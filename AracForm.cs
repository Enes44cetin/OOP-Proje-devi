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
    public partial class AracForm : Form
    {
        // Silme işlemi için seçilen plakayı burada tutacağız
        string secilenPlaka = null;
        public AracForm()
        {
            InitializeComponent();
        }

        private void AracForm_Load(object sender, EventArgs e)
        {
            ArayuzYardimcisi.StyleDataGridView(dgvAraclar);
            MusterileriGetirComboyaDoldur();
            AraclariListele(); 
        }
        private async void MusterileriGetirComboyaDoldur()
        {
            FirebaseHelper db = new FirebaseHelper();
            var response = await db.client.GetAsync("Musteriler");

            if (response.Body != "null")
            {
                var dict = JsonConvert.DeserializeObject<Dictionary<string, Musteri>>(response.Body);

                // Dictionary değerlerini listeye çevirip ComboBox'a kaynak olarak veriyoruz.
                // Musteri.cs içinde ToString() metodunu ezdiğimiz için isimler düzgün görünecek.
                cmbMusteri.DataSource = dict.Values.ToList();
            }
        }

        private async void btnAracEkle_Click(object sender, EventArgs e)
        {
            // 1. Kontroller
            if (cmbMusteri.SelectedItem == null)
            {
                MessageBox.Show("Lütfen araç sahibini seçiniz!");
                return;
            }
            if (string.IsNullOrEmpty(txtPlaka.Text))
            {
                MessageBox.Show("Plaka girmelisiniz!");
                return;
            }

            // 2. ComboBox'tan Seçilen Müşteri Nesnesini Al
            // (cmbMusteri.SelectedItem aslında bir 'Musteri' nesnesidir, cast ediyoruz)
            Musteri secilenMusteri = (Musteri)cmbMusteri.SelectedItem;

            // 3. Araç Nesnesini Oluştur
            Arac yeniArac = new Arac
            {
                Plaka = txtPlaka.Text.ToUpper(), // Plaka büyük harf olsun
                Marka = txtMarka.Text,
                Model = txtModel.Text,
                Yil = (int)numYil.Value,

                // KRİTİK NOKTA: İlişkiyi burada kuruyoruz.
                SahipID = secilenMusteri.ID
            };

            FirebaseHelper db = new FirebaseHelper();

            // 4. Kaydet (Plakayı anahtar olarak kullanabiliriz çünkü benzersizdir)
            await db.client.SetAsync("Araclar/" + yeniArac.Plaka, yeniArac);

            MessageBox.Show($"{yeniArac.Plaka} plakalı araç, {secilenMusteri.Ad} adına kaydedildi.");

            AraclariListele(); // Listeyi güncelle
        }
        private async void AraclariListele()
        {
            FirebaseHelper db = new FirebaseHelper();
            var response = await db.client.GetAsync("Araclar");

            if (response.Body != "null")
            {
                var dict = JsonConvert.DeserializeObject<Dictionary<string, Arac>>(response.Body);
                dgvAraclar.DataSource = dict.Values.ToList();

                
            }
            else
            {
                dgvAraclar.DataSource = null; // Veri yoksa tabloyu boşalt
            }
        }

        private void dgvAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Başlığa tıklanmadıysa
            {
                DataGridViewRow row = dgvAraclar.Rows[e.RowIndex];

                // 1. Silme işlemi için Plakayı hafızaya al
                secilenPlaka = row.Cells["Plaka"].Value.ToString();

                // 2. Kutucukları doldur (Kullanıcı neyi sildiğini görsün)
                txtPlaka.Text = secilenPlaka;
                txtMarka.Text = row.Cells["Marka"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                // Yıl sayısal olduğu için çeviriyoruz
                numYil.Value = Convert.ToDecimal(row.Cells["Yil"].Value);

                // Not: ComboBox'taki müşteriyi seçtirmek biraz daha karmaşık olabilir, 
                // şimdilik sadece araç bilgilerini doldursak yeterli.
            }
        }

        private async void btnAracSil_Click(object sender, EventArgs e)
        {
            // 1. Seçim Kontrolü
            if (secilenPlaka == null)
            {
                MessageBox.Show("Lütfen listeden silinecek aracı seçiniz!");
                return;
            }

            // 2. Onay İsteme
            DialogResult onay = MessageBox.Show($"{secilenPlaka} plakalı aracı silmek istediğinize emin misiniz?", "Araç Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {
                FirebaseHelper db = new FirebaseHelper();

                // 3. Firebase'den Silme (Yolumuz: Araclar/34ABC12)
                await db.client.DeleteAsync("Araclar/" + secilenPlaka);

                MessageBox.Show("Araç kaydı silindi.");

                // 4. Temizlik
                txtPlaka.Clear();
                txtMarka.Clear();
                txtModel.Clear();
                secilenPlaka = null; // Seçimi sıfırla

                AraclariListele(); // Listeyi yenile ki silinen araç gitsin
            }
        }
        
    }
}
