using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisOtomasyonu.Entities
{
    internal class Arac
    {
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string SahipID { get; set; }

        private int _yil;
        public int Yil
        {
            get { return _yil; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year + 1)
                {
                    // Hata fırlatmak yerine varsayılan bir değer atayabiliriz veya hata verebiliriz.
                    // Şimdilik hatayı önleyip günümüz yılını atayalım.
                    _yil = DateTime.Now.Year;
                }
                else
                {
                    _yil = value;
                }
            }

        }
        public override string ToString()
        {
            return $"{Plaka} - {Marka} {Model}";
        }
    }
}
