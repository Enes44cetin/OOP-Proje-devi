using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisOtomasyonu.Helpers
{
    public class FirebaseHelper
    {
        // IFirebaseClient arayüzü, veritabanı işlemlerini (Ekle, Sil, Güncelle) yapacak nesnedir.
        public IFirebaseClient client;

        // Firebase Ayarları
        private IFirebaseConfig config = new FirebaseConfig
        {
            
            AuthSecret = "6wrUaTmkcVnsirLj4gZFABi4IJhZHVNY5GdBpjcW",
            BasePath = "https://otoservisproje-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        public FirebaseHelper()
        {
            // Bağlantıyı kuruyoruz
            client = new FireSharp.FirebaseClient(config);

            // Bağlantı başarılı mı kontrolü (Opsiyonel ama iyi olur)
            if (client == null)
            {
                throw new System.Exception("Firebase bağlantısı kurulamadı! İnternetini veya API anahtarlarını kontrol et.");
            }
        }
    }
}
