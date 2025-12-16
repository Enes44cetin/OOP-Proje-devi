using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisOtomasyonu.Entities
{
    public abstract class Kisi
    {
        public string ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public virtual string TamAdGetir()
        {
            return $"{Ad} {Soyad}";
        }
    }
}
