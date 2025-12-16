using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisOtomasyonu.Entities
{
    public class ServisIslemi : IKayit
    {
        public string ID { get; set; } // Kayıt ID'si
        public string AracPlaka { get; set; } // Hangi araca işlem yapıldı? (İlişki burada)
        public string YapilanIslemler { get; set; } // Örn: "Yağ değişti, Fren balatası yenilendi"
        public decimal Ucret { get; set; } // İşlem tutarı
        public DateTime Tarih { get; set; } // İşlem tarihi
        public string Durum { get; set; } // "İşlemde", "Tamamlandı", "Parça Bekliyor"
        
        // Interface zorunluluğu olan metot:
        public string OzetBilgiVer()
        {
            return $"{AracPlaka} Plakalı Araç - {Durum} ({Ucret} TL)";
        }
    }
}
