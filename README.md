# **MyFinancialCrm** 💰

Bu proje, **kişisel veya küçük işletmeler için finans yönetimi** sağlayan bir **Windows Forms (C#) uygulamasıdır**.
Kullanıcı, **banka işlemleri**, **harcamalar**, **faturalar** ve **kategori yönetimi** yapabilir.

---

## **📂 Proje Yapısı**

| Dosya / Klasör            | Açıklama                                            |
| ------------------------- | --------------------------------------------------- |
| **App.config**            | Veritabanı bağlantı ayarlarını içerir.              |
| **Properties/**           | Proje özellikleri ve Assembly bilgileri.            |
| **FrmBankProcesses.cs**   | Banka işlemlerini gösteren formun kod dosyası.      |
| **FrmBanks.cs**           | Banka hesaplarının listelendiği form.               |
| **FrmBills.cs**           | Faturaların yönetildiği form.                       |
| **FrmCategories.cs**      | Harcama kategorilerini yönetmek için form.          |
| **FrmDashboard.cs**       | Ana kontrol paneli (Dashboard).                     |
| **FrmSpending.cs**        | Harcamaların listelendiği ve eklendiği form.        |
| **Designer.cs Dosyaları** | Formların tasarım dosyaları (otomatik oluşturulur). |
| **.resx Dosyaları**       | Formların yerelleştirme ve kaynak dosyaları.        |

---

## **⚙️ Kullanılan Teknolojiler**

* **C# / .NET Framework**
* **Windows Forms**
* **Entity Framework (Code First)**
* **SQL Server / LocalDB**

---

## **🚀 Çalıştırma Adımları**

1. Projeyi klonla:

   ```bash
   git clone https://github.com/emrah-Tpc/MyFinancialCrm.git
   ```
2. Visual Studio ile aç
3. **App.config** içindeki veritabanı bağlantı ayarını kendi SQL Server’ına göre güncelle
4. **Build** → **Run**

---

## **📌 Özellikler**

* Banka hesaplarını listeleme ve yönetme
* Harcama ekleme, silme ve görüntüleme
* Fatura yönetimi
* Kategori bazlı harcama analizi
* Dashboard üzerinden genel finansal görünüm




