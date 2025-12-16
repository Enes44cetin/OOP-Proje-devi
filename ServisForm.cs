using Newtonsoft.Json;
using OtoServisOtomasyonu.Entities;
using OtoServisOtomasyonu.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoServisOtomasyonu
{
    public partial class ServisForm : Form
    {
        string secilenServisID = "";
        public ServisForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ServisForm_Load(object sender, EventArgs e)
        {
            ArayuzYardimcisi.StyleDataGridView(dgvServisler);
            PlakalariGetir();    // ComboBox dolsun
            ServisleriListele(); // Grid dolsun
        }
        private async void PlakalariGetir()
        {
            FirebaseHelper db = new FirebaseHelper();
            var response = await db.client.GetAsync("Araclar");

            if (response.Body != "null")
            {
                var dict = JsonConvert.DeserializeObject<Dictionary<string, Arac>>(response.Body);

                cmbPlakalar.Items.Clear(); // Önce temizle

                // Sadece plakaları döngüyle ekle
                foreach (var arac in dict.Values)
                {
                    cmbPlakalar.Items.Add(arac.Plaka);
                }

                // İlk sıradakini seçili yap (Kullanıcı boş görmesin)
                if (cmbPlakalar.Items.Count > 0)
                    cmbPlakalar.SelectedIndex = 0;
            }
        }

        private async void ServisleriListele()
        {
            FirebaseHelper db = new FirebaseHelper();
            var response = await db.client.GetAsync("ServisIslemleri");

            if (response.Body != "null")
            {
                var dict = JsonConvert.DeserializeObject<Dictionary<string, ServisIslemi>>(response.Body);
                var servisListesi = dict.Values.OrderByDescending(x => x.Tarih).ToList();

                // Grid'i doldur
                dgvServisler.DataSource = servisListesi;
                dgvServisler.Columns["ID"].Visible = false;

                // --- İSTATİSTİKLERİ HESAPLA ---

                // 1. Sayılar
                int toplam = servisListesi.Count;
                int islemde = servisListesi.Count(x => x.Durum == "İşlemde");
                int parcaBekleyen = servisListesi.Count(x => x.Durum == "Parça Bekliyor");
                decimal ciro = servisListesi.Sum(x => x.Ucret);

                // 2. Tasarıma Yazdır
                lblToplamArac.Text = toplam.ToString();
                lblIslemdekiler.Text = islemde.ToString();
                lblParcaBekleyen.Text = parcaBekleyen.ToString();

                // "C0" formatı para birimi yazar ve kuruşları yuvarlar (₺50.000 gibi)
                // Eğer kuruş istiyorsan "C2" yap.
                lblToplamKazanc.Text = ciro.ToString("C0");
            }
            else
            {
                dgvServisler.DataSource = null;
                // Veri yoksa sıfırla
                lblToplamArac.Text = "0";
                lblIslemdekiler.Text = "0";
                lblParcaBekleyen.Text = "0";
                lblToplamKazanc.Text = "0 ₺";
            }   
        }

        private async void btnServisAc_Click_1(object sender, EventArgs e)
        {
            // 1. Kontroller
            if (cmbPlakalar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir araç seçin!");
                return;
            }
            if (string.IsNullOrEmpty(txtIslem.Text))
            {
                MessageBox.Show("Yapılan işlemleri yazmalısınız!");
                return;
            }

            FirebaseHelper db = new FirebaseHelper();

            // 2. Yeni Servis Nesnesi
            ServisIslemi yeniServis = new ServisIslemi
            {
                ID = Guid.NewGuid().ToString(),
                AracPlaka = cmbPlakalar.SelectedItem.ToString(),
                YapilanIslemler = txtIslem.Text,
                Ucret = numUcret.Value,
                Durum = cmbDurum.SelectedItem.ToString(), // İşlemde, Tamamlandı vs.
                Tarih = DateTime.Now // Şu anki zaman
            };

            // 3. Veritabanına Kayıt
            // ServisIslemleri/KARMASIK_ID yoluna kaydediyoruz
            await db.client.SetAsync("ServisIslemleri/" + yeniServis.ID, yeniServis);

            MessageBox.Show("Servis kaydı başarıyla açıldı!");

            // 4. Temizlik
            txtIslem.Clear();
            numUcret.Value = 0;
            ServisleriListele(); // Listeyi güncelle
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnServisGuncelle_Click(object sender, EventArgs e)
        {
            // 1. Seçim kontrolü
            if (string.IsNullOrEmpty(secilenServisID))
            {
                MessageBox.Show("Lütfen listeden güncellenecek işlemi seçiniz.");
                return;
            }

            FirebaseHelper db = new FirebaseHelper();

            // 2. Güncel Nesneyi Oluştur (ID AYNI KALMALI!)
            ServisIslemi guncelServis = new ServisIslemi
            {
                ID = secilenServisID, // <-- En önemli kısım burası, eski ID'yi kullanıyoruz
                AracPlaka = cmbPlakalar.SelectedItem.ToString(),
                YapilanIslemler = txtIslem.Text,
                Ucret = numUcret.Value,
                Durum = cmbDurum.SelectedItem.ToString(),
                Tarih = DateTime.Now // Güncelleme tarihini yeni tarih yapıyoruz
            };

            // 3. Firebase üzerine yaz (SetAsync aynı ID varsa günceller)
            var response = await db.client.SetAsync("ServisIslemleri/" + secilenServisID, guncelServis);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Servis kaydı güncellendi!");
                FormuTemizle(); // Kutuları boşalt
                ServisleriListele(); // Listeyi yenile
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız oldu.");
            }
        }

        private async void btnServisSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secilenServisID))
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.");
                return;
            }

            // --- INTERFACE KULLANIMI BAŞLIYOR ---
            // Mevcut verilerden geçici bir nesne oluşturup interface metodunu çağırıyoruz.
            // Bu, Polymorphism (Çok Biçimlilik) örneğidir.

            IKayit silinecekKayit = new ServisIslemi
            {
                AracPlaka = cmbPlakalar.SelectedItem.ToString(),
                Durum = cmbDurum.SelectedItem.ToString(),
                Ucret = numUcret.Value
            };

            // silinecekKayit.OzetBilgiVer() diyerek Interface'in gücünü kullanıyoruz.
            string mesaj = silinecekKayit.OzetBilgiVer() + "\nBu kaydı silmek istediğinize emin misiniz?";
            // -------------------------------------

            DialogResult onay = MessageBox.Show(mesaj, "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {
                // ... (Silme kodların aynen kalacak) ...
                FirebaseHelper db = new FirebaseHelper();
                var response = await db.client.DeleteAsync("ServisIslemleri/" + secilenServisID);
                // ...
                MessageBox.Show("Kayıt silindi.");
                FormuTemizle();
                ServisleriListele();
            }
        }
        private void FormuTemizle()
        {
            secilenServisID = ""; // Hafızayı temizle ki yanlışlıkla eski ID'yi güncellemeyelim
            txtIslem.Clear();
            numUcret.Value = 0;
            cmbPlakalar.SelectedIndex = -1; // Seçimi kaldır
            cmbDurum.SelectedIndex = 0; // Varsayılan duruma dön
        }

        private void dgvServisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Başlığa (header) tıklanırsa işlem yapma, patlar yoksa
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvServisler.Rows[e.RowIndex];

                // 1. ID'yi hafızaya alıyoruz (Bu değişkeni en tepeye eklemediysen hata verir, aşağıda hatırlattım)
                secilenServisID = row.Cells["ID"].Value.ToString();

                // 2. Kutuları dolduruyoruz
                // ComboBox seçimleri
                cmbPlakalar.SelectedItem = row.Cells["AracPlaka"].Value?.ToString();
                cmbDurum.SelectedItem = row.Cells["Durum"].Value?.ToString();

                // Metin kutuları
                txtIslem.Text = row.Cells["YapilanIslemler"].Value?.ToString();

                // Ücret (Sayısal olduğu için çeviriyoruz)
                if (row.Cells["Ucret"].Value != null)
                {
                    numUcret.Value = Convert.ToDecimal(row.Cells["Ucret"].Value);
                }
            }
        }
    }
}
