using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisOtomasyonu.Entities
{
    public interface IKayit
    {
        string ID { get; set; }       // Her kaydın bir ID'si olmalı
        string OzetBilgiVer();        // Her kayıt kendini özetleyen bir metin döndürmeli
    }
}
