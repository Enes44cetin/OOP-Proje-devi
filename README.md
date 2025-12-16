# 🚗 Oto Servis Otomasyonu (Auto Service Automation)

Bu proje, **Nesne Yönelimli Programlama (OOP)** dersi kapsamında geliştirilmiş, bulut tabanlı bir **Oto Servis Yönetim Sistemidir**. 

Araç servis süreçlerini, müşteri kayıtlarını ve mali durum analizlerini dijital ortamda yönetmeyi sağlar. Veritabanı olarak **Google Firebase Realtime Database** kullanılmıştır.

---

##  Özellikler

### 1. Müşteri Yönetimi
* Yeni müşteri ekleme, silme ve bilgilerini güncelleme.
* Müşterileri veritabanından **Asenkron (Async)** olarak listeleme.
* Seçili müşteriye ait geçmiş işlemleri görüntüleme.

### 2. Servis & Araç Takibi
* Araç kabul işlemleri ve arıza kaydı oluşturma.
* **Durum Yönetimi:** Araçların durumunu *("Parça Bekliyor", "İşlemde", "Tamamlandı")* olarak değiştirme.
* Servis ücreti ve yapılan işlem detaylarını kayıt altına alma.

### 3. İstatistik & Raporlama (Dashboard)
* Toplam Araç Sayısı
* İşlemdeki Araçlar
* Parça Bekleyen Araçlar
* **Toplam Ciro (Kazanç)** hesaplaması.
* Anlık güncellenen modern arayüz.

---

## 🛠 Kullanılan Teknolojiler ve Mimari

* **Dil:** C# (Windows Forms)
* **Veritabanı:** Google Firebase Realtime Database (NoSQL)
* **Kütüphaneler:** * `FireSharp` (Firebase bağlantısı için)
    * `Newtonsoft.Json` (JSON verileri nesneye çevirmek için)

### 🏗 Uygulanan OOP Prensipleri

Proje geliştirilirken temiz kod ve SOLID prensiplerine dikkat edilmiştir:

1.  **Kapsülleme (Encapsulation):** Entity sınıflarında (`Musteri`, `Personel`) veriler `Property` olarak tanımlanmış, dış erişim kontrol altına alınmıştır.
2.  **Miras Alma (Inheritance):** `Personel` ve `Musteri` sınıfları, ortak özelliklerini barındıran **`Kisi`** sınıfından türetilmiştir.
3.  **Çok Biçimlilik (Polymorphism) & Interface:** * `IKayit` arayüzü (Interface) oluşturulmuştur.
    * Farklı sınıflar (`ServisIslemi`, `Personel`) bu arayüzü implemente ederek `OzetBilgiVer()` metodunu kendi yapılarına göre farklı şekillerde çalıştırmaktadır.

---

## 💻 Kurulum ve Çalıştırma

1.  Projeyi bilgisayarınıza indirin veya klonlayın:
    ```bash
    git clone [https://github.com/KULLANICI_ADINIZ/OtoServisOtomasyonu.git](https://github.com/KULLANICI_ADINIZ/OtoServisOtomasyonu.git)
    ```
2.  **Visual Studio** ile `OtoServisOtomasyonu.sln` dosyasını açın.
3.  **NuGet Paketlerini Yükleyin:**
    * Solution Explorer'da projeye sağ tıklayın -> **Manage NuGet Packages**.
    * `FireSharp` ve `Newtonsoft.Json` paketlerinin yüklü olduğundan emin olun (Restore işlemi yapın).
4.  Projeyi derleyin ve **Start** tuşuna basarak çalıştırın.

---

## 👤 Geliştirici

**Ad Soyad:** Enes Çetin  
**Ders:** Nesne Yönelimli Programlama  

---
