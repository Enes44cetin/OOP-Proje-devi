using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisOtomasyonu.Entities
{
    public class Personel : Kisi , IKayit
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Pozisyon { get; set; }
        public decimal Maas { get; set; }

        // Interface'den gelen zorunlu metodu (kontratı) dolduruyoruz
        public string OzetBilgiVer()
        {
            return $"{Ad} {Soyad} - {Pozisyon}";
        }

    }
}
