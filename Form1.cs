using Newtonsoft.Json;
using OtoServisOtomasyonu.Entities;
using OtoServisOtomasyonu.Helpers;

namespace OtoServisOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            FirebaseHelper db = new FirebaseHelper();

            // 1. Önce veritabanýnda Personel var mý bakalým? (Gereksiz yere sürekli eklemesin)
            var kontrol = await db.client.GetAsync("Personeller");

            // Eðer "Personeller" düðümü boþsa veya null ise Admin'i ekle
            if (kontrol.Body == "null")
            {
                Personel admin = new Personel
                {
                    ID = Guid.NewGuid().ToString(),
                    Ad = "Yönetici",
                    Soyad = "Admin",
                    Telefon = "5550000000",
                    KullaniciAdi = "admin",
                    Sifre = "1234", // Gerçek hayatta þifrelenmeli (MD5/SHA) ama okul projesi için düz metin kalsýn
                    Pozisyon = "Müdür",
                    Maas = 50000
                };

                // SetAsync kullanýyoruz. ID'si ile kaydediyoruz ki sonra bulmasý kolay olsun.
                // Yolumuz: Personeller/KarmasikID/...
                await db.client.SetAsync("Personeller/" + admin.ID, admin);
                MessageBox.Show("Ýlk Admin Kullanýcýsý Oluþturuldu!");
            }
        }

        private async void btnGiris_Click(object sender, EventArgs e)
        {
            // 1. Boþ alan kontrolü
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen kullanýcý adý ve þifre giriniz.");
                return;
            }

            FirebaseHelper db = new FirebaseHelper();

            // Butonu pasif yapalým ki art arda basamasýnlar
            btnGiris.Enabled = false;
            btnGiris.Text = "Kontrol Ediliyor...";

            try
            {
                // 2. Tüm personelleri çekiyoruz
                var response = await db.client.GetAsync("Personeller");

                if (response.Body == "null")
                {
                    MessageBox.Show("Sistemde hiç personel yok!");
                    btnGiris.Enabled = true;
                    return;
                }

                // 3. Gelen veriyi çözümlüyoruz 
                // Firebase bize veriyi þu formatta verir: { "ID1": {UserObj}, "ID2": {UserObj} }
                // Bu yüzden Dictionary kullanýyoruz.
                var personeller = JsonConvert.DeserializeObject<Dictionary<string, Personel>>(response.Body);

                // 4. Döngüyle eþleþen kullanýcý var mý bakýyoruz
                bool girisBasarili = false;
                Personel girisYapanPersonel = null;

                foreach (var item in personeller)
                {
                    // item.Value bizim Personel nesnemizdir
                    if (item.Value.KullaniciAdi == txtKullaniciAdi.Text && item.Value.Sifre == txtSifre.Text)
                    {
                        girisBasarili = true;
                        girisYapanPersonel = item.Value;
                        break; // Bulduk, döngüden çýk
                    }
                }

                if (girisBasarili)
                {
                    MessageBox.Show($"Hoþgeldin {girisYapanPersonel.Ad} {girisYapanPersonel.Soyad} ({girisYapanPersonel.Pozisyon})");

                    
                    AnaForm ana = new AnaForm(girisYapanPersonel);
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalý Kullanýcý Adý veya Þifre!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message);
            }
            finally
            {
                // Ýþlem bitince butonu eski haline getir
                btnGiris.Enabled = true;
                btnGiris.Text = "Giriþ Yap";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Gereksiz kýsým
        // Mouse ile sürükleme için gerekli deðiþkenler
        bool move;
        int mouse_x;
        int mouse_y;

        // Formun "MouseDown" olayýna (Properties -> Events (Þimþek ikonu)) çift týkla ve bunu yaz:
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        // Formun "MouseUp" olayýna çift týkla:
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        // Formun "MouseMove" olayýna çift týkla:
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        #endregion
    }
}
