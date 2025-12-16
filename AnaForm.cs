using OtoServisOtomasyonu.Entities;
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
    public partial class AnaForm : Form
    {
        // Giriş yapan personeli bu değişkende tutacağız, her yerde kullanabiliriz.
        Personel aktifPersonel;
        public AnaForm(Personel personel)
        {
            InitializeComponent();
            aktifPersonel = personel;
        }
        // Aktif olan butonu hafızada tutmak için
        private Button currentButton;

        // Renkleri buraya yazalım ki sonradan değiştirmek kolay olsun
        // Turuncu (Aktif Renk)
        private Color activeColor = Color.FromArgb(230, 126, 34);
        // Menünün kendi rengi (Pasif Renk)
        private Color defaultColor = Color.FromArgb(24, 24, 24);

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    // Önceki butonu eski haline getir
                    DisableButton();

                    // Yeni butonu seç ve rengini değiştir
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = activeColor; // Turuncu olur
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            // Eski butonu standart ayarlarına döndür
            if (currentButton != null)
            {
                currentButton.BackColor = defaultColor; // Menü rengine dön
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            // Üst panele bilgi yazalım
            lblKullaniciBilgi.Text = $"Aktif Kullanıcı: {aktifPersonel.Ad} {aktifPersonel.Soyad} ({aktifPersonel.Pozisyon})";

            // OOP Yetki Kontrolü (Polymorphism/Encapsulation Mantığı):
            // Eğer kişi Müdür DEĞİLSE VE Yönetici DEĞİLSE butonu kapat.
            if (aktifPersonel.Pozisyon != "Müdür" && aktifPersonel.Pozisyon != "Yönetici")
            {
                // Butonu tamamen gizleyelim ki basamasınlar
                if (btnPersonel != null)
                    btnPersonel.Visible = false;
            }
        }

        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Bu komut, gizli açık ne varsa her şeyi kapatıp programı sonlandırır.
                                // Eğer bunu yazmazsan program kapandı sanırsın ama arka planda çalışmaya devam eder.
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); // Butonu boyama metodu
            openChildForm(new MusteriForm());
        }

        private void btnArac_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); // Butonu boyama metodu
            openChildForm(new AracForm());
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); // Butonu boyama metodu
            // ServisForm'u içerik panelinde açar
            openChildForm(new ServisForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Önce global bir değişken tanımla ki açık formu takip edebilelim
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            // Eğer zaten bir form açıksa onu kapat (temizle)
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            // Alt formun ayarlarını yap (Panel içine gömmek için şart)
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Panelin içine ekle
            pnlIcerik.Controls.Add(childForm); // pnlIcerik senin orta panelinin adı
            pnlIcerik.Tag = childForm;

            // Formu göster
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); // Butonu boyama metodu
            // PersonelForm'u içerik panelinde açar
            openChildForm(new PersonelForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close(); // Açık formu kapat
            DisableButton(); // Butonların rengini söndür (Hiçbiri seçili değil)
        }
    }
}
