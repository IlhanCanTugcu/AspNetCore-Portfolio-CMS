# 🚀 ASP.NET Core 8.0 - Dinamik Portfolyo ve Admin Paneli

Bu proje, **ASP.NET Core 8.0** teknolojisi ve **N-Katmanlı Mimari (N-Tier Architecture)** prensipleri kullanılarak geliştirilmiş, uçtan uca (Full-Stack) dinamik bir web uygulamasıdır.

Proje, kişisel bir portfolyo sitesi olmanın ötesinde, içeriklerin kod yazmaya gerek kalmadan yönetilebildiği kapsamlı bir **CMS (İçerik Yönetim Sistemi)** niteliğindedir.

---

## 🏗️ Mimari ve Kullanılan Teknolojiler

Bu projede **Spaghetti Code** yapısından kaçınılmış, sürdürülebilir, test edilebilir ve geliştirilebilir bir yapı kurulmuştur.

### ⚙️ Backend (Arka Uç)
* **Platform:** .NET 8.0 (Long Term Support)
* **Dil:** C# 12.0
* **Web Çatısı:** ASP.NET Core MVC
* **Veritabanı:** MSSQL Server
* **ORM:** Entity Framework Core (Code First Yaklaşımı)
* **Mimari:** N-Tier Architecture (Entity, DataAccess, Business, UI Layers)
* **Tasarım Desenleri:** Generic Repository Pattern & Dependency Injection

### 🎨 Frontend (Ön Yüz)
* **Motor:** Razor View Engine
* **Diller:** HTML5, CSS3, JavaScript
* **Framework:** Bootstrap 5
* **Admin Teması:** Corona Admin Template (Koyu Mod)

---

## 🌟 Öne Çıkan Özellikler

### 🖥️ Kullanıcı Arayüzü (Vitrin)
* **Dinamik İçerik Yönetimi:** Hakkımda, Yetenekler, Hizmetler ve Deneyimler gibi tüm alanlar veritabanından dinamik olarak çekilir.
* **ViewComponent Mimarisi:** Sayfa parçaları (Header, Navbar, SkillList, ExperienceList vb.) modüler "Widget" yapısında tasarlanmıştır. Bu sayede yüksek performans ve kod tekrarı önlenmiştir.
* **İletişim Formu:** Ziyaretçiler site üzerinden mesaj gönderebilir, mesajlar tarih ve saat bilgisiyle veritabanına kaydedilir.

### ⚙️ Yönetim Paneli (Admin Dashboard)
* **Dashboard İstatistikleri:** Toplam yetenek sayısı, okunmamış mesajlar, tamamlanan projeler ve **staj bitimine kalan gün sayacı** gibi canlı veriler.
* **Canlı Döviz Kurları:** JSON ve XML API entegrasyonu ile anlık kur fiyatlarının çekilmesi.
* **CRUD İşlemleri:**
    * **Yetenekler (Skills):** Başlık ve yüzdelik oran (Progress Bar) yönetimi.
    * **Deneyimler (Experience):** Şirket adı, tarih, açıklama ve **görsel yükleme (Image Upload)** işlemleri.
    * **Öne Çıkanlar (Feature):** Site başlığı ve kapak görseli yönetimi.
* **Mesaj Kutusu:** Gelen mesajların listelenmesi, okunma durumunun (Okundu/Okunmadı) değiştirilmesi ve silinmesi.
* **Dinamik Sidebar:** Bulunulan sayfaya göre sol menüdeki ilgili sekmenin otomatik olarak aktif (Active Class) olması.

---
```text
## 📂 Proje Klasör Yapısı (N-Katmanlı)


Core_Proje
├── BusinessLayer       # İş Kuralları, Validasyonlar ve Manager Sınıfları
├── DataAccessLayer     # Veritabanı Bağlantısı (Context), Migrations ve Repository Kodları
├── EntityLayer         # Veritabanı Tablo Karşılıkları (Concrete Sınıflar - POCO)
└── Core_Proje (UI)     # Kullanıcı Arayüzü (Controllers, Views, ViewComponents, wwwroot)
```
---

## 🚀 Kurulum ve Çalıştırma

Projeyi yerel makinenizde çalıştırmak için şu adımları izleyin:

1.  **Projeyi Klonlayın:**
    ```bash
    git clone [https://github.com/IlhanCanTugcu/Core_Proje.git](https://github.com/IlhanCanTugcu/Core_Proje.git)
    ```
2.  **Veritabanı Ayarı:**
    `DataAccessLayer/Concrete/Context.cs` dosyasını açın. OnConfiguring metodu içindeki Server bilgisini kendi SQL Server adınıza göre düzenleyin.
3.  **Veritabanını Oluşturun (Migration):**
    Visual Studio'da **Package Manager Console**'u açın ve şu komutu çalıştırın:
    ```bash
    update-database
    ```
4.  **Projeyi Çalıştırın:**
    Visual Studio üzerinden `Ctrl + F5` yaparak projeyi ayağa kaldırın.

---

## 📸 Ekran Görüntüleri

Projenin çalışan haline ait görüntüler aşağıdadır:

| Vitrin (Ana Sayfa) | Admin Dashboard (Koyu Tema) |
| :---: | :---: |
| ![Vitrin](screenshots/vitrin.png) | ![Dashboard](screenshots/dashboard.png) |

| Yetenek ve Deneyimler (Vitrin) | Deneyim Yönetimi (Admin CRUD) |
| :---: | :---: |
| ![CRUD](screenshots/yetenek-deneyim.png) | ![API](screenshots/deneyim-listesi.png) |

| İletişim Formu (Vitrin) | Gelen Mesajlar (Admin) |
| :---: | :---: |
| ![CRUD](screenshots/iletisim.png) | ![API](screenshots/mesaj-listesi.png) |

| Yetenek Yönetimi (Admin CRUD) |
| :---: | :---: |
| ![CRUD](screenshots/yetenek.png) |

---

## 👨‍💻 Geliştirici

**İlhan Can Tuğcu** *Bilgisayar Mühendisliği Öğrencisi*

Bu proje, **BTÜ-İMEP (İşletmede Mesleki Eğitim Programı)** kapsamında, kurumsal yazılım geliştirme standartlarını öğrenmek ve uygulamak amacıyla geliştirilmiştir.

* [LinkedIn Profilim](http://linkedin.com/in/ilhan-can-tu%C4%9Fcu)
* [GitHub Profilim](https://github.com/IlhanCanTugcu)

---
*© 2025 İlhan Can Tuğcu - Tüm Hakları Saklıdır.*