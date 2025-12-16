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
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }
        FirebaseHelper db = new FirebaseHelper();

        string secilenPersonelID = "";

        private async void PersonelForm_Load(object sender, EventArgs e)
        {
            ArayuzYardimcisi.StyleDataGridView(dgvPersoneller);
            // 1. ComboBox içini temizleyip seçenekleri ekleyelim
            cmbPozisyon.Items.Clear();
            cmbPozisyon.Items.Add("Müdür");
            cmbPozisyon.Items.Add("Yönetici"); 
            cmbPozisyon.Items.Add("Usta");
            cmbPozisyon.Items.Add("Sekreter");

            // İPUCU: Kullanıcı buraya kafasına göre bir şey yazamasın, sadece listeden seçsin:
            cmbPozisyon.DropDownStyle = ComboBoxStyle.DropDownList;
            await PersonelleriListele();
        }

        // Listeleme Metodu (DRY Prensibi - Tekrar eden kodu ayırdık)
        private async System.Threading.Tasks.Task PersonelleriListele()
        {
            try
            {
                var response = await db.client.GetAsync("Personeller");
                if (response.Body != "null")
                {
                    var data = JsonConvert.DeserializeObject<Dictionary<string, Personel>>(response.Body);

                    // Dictionary'i Listeye çevirip Grid'e basıyoruz
                    var list = data.Values.ToList();
                    dgvPersoneller.DataSource = list;

                    // Grid ayarları (İstemediğimiz kolonları gizleyelim)
                    if (dgvPersoneller.Columns["ID"] != null) dgvPersoneller.Columns["ID"].Visible = false;
                }
                else
                {
                    dgvPersoneller.DataSource = null; // Veri yoksa temizle
                }
            }
            catch
            {
                // Hata olursa sessiz kal veya logla
            }
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı, şifre ve pozisyon zorunludur!");
                return;
            }

            Personel p = new Personel
            {
                ID = Guid.NewGuid().ToString(),
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTel.Text,
                //Mail = txtMail.Text,
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text,
                Pozisyon = cmbPozisyon.Text, // ComboBox'tan seçilen
                Maas = numericMaas.Value
            };

            
            // Eğer Helper'da yoksa direkt buraya da yazabilirsin:
            var response = await db.client.SetAsync("Personeller/" + p.ID, p);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Personel Eklendi");
                await PersonelleriListele(); // Listeyi yenile
            }
        }

        // Grid'den birine tıklayınca bilgileri kutulara doldur
        private void dgvPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Başlığa tıklanırsa hata vermesin diye kontrol
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPersoneller.Rows[e.RowIndex];

                // 1. Seçilen kişinin ID'sini global değişkene alıyoruz
                // (Grid'de ID kolonu gizli olsa bile değeri ordadır)
                secilenPersonelID = row.Cells["ID"].Value.ToString();

                // 2. Kutuları dolduruyoruz
                txtAd.Text = row.Cells["Ad"].Value?.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value?.ToString();
                txtTel.Text = row.Cells["Telefon"].Value?.ToString();
                //txtMail.Text = row.Cells["Email"].Value?.ToString();
                txtKullaniciAdi.Text = row.Cells["KullaniciAdi"].Value?.ToString();
                txtSifre.Text = row.Cells["Sifre"].Value?.ToString();
                cmbPozisyon.Text = row.Cells["Pozisyon"].Value?.ToString();

                // Maaş sayısal olduğu için dönüşüm gerekebilir
                if (row.Cells["Maas"].Value != null)
                {
                    numericMaas.Value = Convert.ToDecimal(row.Cells["Maas"].Value);
                }
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            // 1. Bir kişi seçilmiş mi kontrol et
            if (string.IsNullOrEmpty(secilenPersonelID))
            {
                MessageBox.Show("Lütfen listeden güncellenecek personeli seçiniz.");
                return;
            }

            // 2. Yeni bilgileri nesneye doldur (ID değişmemeli!)
            Personel guncelPersonel = new Personel
            {
                ID = secilenPersonelID, // <-- DİKKAT: Eski ID'yi kullanıyoruz
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTel.Text,
                //Mail = txtMail.Text,
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text,
                Pozisyon = cmbPozisyon.Text,
                Maas = numericMaas.Value
            };

            // 3. Firebase'e gönder (Eski verinin üzerine yazar)
            // UpdateAsync de kullanılabilir ama SetAsync tüm nesneyi yenilediği için daha pratiktir.
            var response = await db.client.SetAsync("Personeller/" + secilenPersonelID, guncelPersonel);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Personel bilgileri güncellendi.");
                FormuTemizle(); // Kutuları boşaltalım
                await PersonelleriListele(); // Listeyi yenileyelim
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız.");
            }
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            // 1. Seçim kontrolü
            if (string.IsNullOrEmpty(secilenPersonelID))
            {
                MessageBox.Show("Lütfen silinecek personeli seçiniz.");
                return;
            }

            // 2. Kullanıcıya soralım
            DialogResult onay = MessageBox.Show(txtAd.Text + " adlı personeli silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {
                // 3. Firebase'den sil
                var response = await db.client.DeleteAsync("Personeller/" + secilenPersonelID);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Personel silindi.");
                    FormuTemizle();
                    await PersonelleriListele();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız.");
                }
            }
        }
        private void FormuTemizle()
        {
            secilenPersonelID = ""; // Hafızayı sıfırla
            txtAd.Clear();
            txtSoyad.Clear();
            txtTel.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            numericMaas.Value = 0;
            cmbPozisyon.SelectedIndex = -1; // Seçimi kaldır
        }
    }
}
