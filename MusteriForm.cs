using FireSharp.Response;
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
    public partial class MusteriForm : Form
    {
        string secilenMusteriId = null;
        public MusteriForm()
        {
            InitializeComponent();
        }

        private async void MusterileriListele()
        {
            FirebaseHelper db = new FirebaseHelper();

            // Verileri çek
            FirebaseResponse response = await db.client.GetAsync("Musteriler");

            // Eğer veri yoksa (null dönerse) işlemi durdur
            if (response.Body == "null")
            {
                dgvMusteriler.DataSource = null;
                return;
            }

            // Gelen JSON verisini Dictionary'e çevir
            // Anahtar: ID (String), Değer: Musteri Nesnesi
            var dict = JsonConvert.DeserializeObject<Dictionary<string, Musteri>>(response.Body);

            // Dictionary'i Listeye çevirip Grid'e bağla
            // .Values.ToList() diyerek sadece Müşteri nesnelerini alıyoruz
            dgvMusteriler.DataSource = dict.Values.ToList();

            // İstenmeyen kolonları (sütunları) gizleyelim (İsteğe bağlı)
            // dgvMusteriler.Columns["ID"].Visible = false; // ID'yi kullanıcı görmese de olur
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            ArayuzYardimcisi.StyleDataGridView(dgvMusteriler);
            MusterileriListele();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            // 1. Basit validasyon (Boş alan kontrolü)
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtTel.Text))
            {
                MessageBox.Show("Ad ve Telefon alanları zorunludur!");
                return;
            }

            FirebaseHelper db = new FirebaseHelper();

            // 2. Yeni Müşteri Nesnesi Oluşturma
            Musteri yeniMusteri = new Musteri
            {
                ID = Guid.NewGuid().ToString(), // Eşsiz bir kimlik numarası üretir
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTel.Text,
                Email = txtMail.Text,
                Adres = txtAdres.Text
            };

            // 3. Firebase'e Gönderme (Musteriler/GUID_ID altına kaydeder)
            // SetAsync kullanıyoruz ki üzerine yazsın (Update mantığına da uyar)
            await db.client.SetAsync("Musteriler/" + yeniMusteri.ID, yeniMusteri);

            MessageBox.Show("Müşteri Başarıyla Eklendi!");

            // 4. Temizlik ve Yenileme
            Temizle(); 
            MusterileriListele(); // Listeyi güncelle ki yeni geleni görelim
        }

        // Formu temizlemek için yardımcı metot
        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTel.Clear();
            txtMail.Clear();
            txtAdres.Clear();
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Başlığa (Header) tıklarsa hata vermesin diye kontrol
            if (e.RowIndex >= 0)
            {
                // Seçilen satırı al
                DataGridViewRow row = dgvMusteriler.Rows[e.RowIndex];

                // 1. ID'yi hafızaya al (En önemli kısım!)
                secilenMusteriId = row.Cells["ID"].Value.ToString();

                // 2. Kutucukları doldur
                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtTel.Text = row.Cells["Telefon"].Value.ToString();
                txtMail.Text = row.Cells["Email"].Value.ToString();
                txtAdres.Text = row.Cells["Adres"].Value.ToString();
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenMusteriId == null)
            {
                MessageBox.Show("Lütfen listeden güncellenecek bir müşteri seçin!");
                return;
            }

            FirebaseHelper db = new FirebaseHelper();

            // ID hariç diğer bilgileri Textboxlardan alıyoruz
            // ID'yi seçilen ID olarak koruyoruz (Değişmez)
            Musteri guncelMusteri = new Musteri
            {
                ID = secilenMusteriId,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTel.Text,
                Email = txtMail.Text,
                Adres = txtAdres.Text
            };

            // Firebase'de ilgili ID'nin olduğu yere yeni veriyi yapıştırıyoruz.
            await db.client.UpdateAsync("Musteriler/" + secilenMusteriId, guncelMusteri);

            MessageBox.Show("Müşteri Bilgileri Güncellendi!");

            Temizle(); // Kutuları boşalt
            secilenMusteriId = null; // Seçimi sıfırla
            MusterileriListele(); // Listeyi yenile
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenMusteriId == null)
            {
                MessageBox.Show("Lütfen silinecek bir müşteri seçin!");
                return;
            }

            // Kullanıcıya soralım: Emin misin?
            DialogResult onay = MessageBox.Show(txtAd.Text + " isimli müşteriyi silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {
                FirebaseHelper db = new FirebaseHelper();

                // Silme komutu
                await db.client.DeleteAsync("Musteriler/" + secilenMusteriId);

                MessageBox.Show("Müşteri Silindi.");

                Temizle();
                secilenMusteriId = null;
                MusterileriListele();
            }
        }
        
    }

}
