# Sistemi i Menaxhimit të Restorantit (Restaurant Management System)

## 📋 Përshkrimi i Projektit

Ky është një aplikacion **Windows Forms** në **C#** për menaxhimin e plotë të restorantit. Sistemi përfshin:

- **Admin Panel** - Menaxhimi i produkteve, kamerierëve, tavolina, dhe raporteve
- **POS System (Point of Sale)** - Për karerierat me porosi dhe faturim
- **Kitchen Display System (KDS)** - Për kuzhinarët në kohë reale
- **Autentifikimi** - Support për login me username/password ose NFC/RFID
- **Database** - SQL Server LocalDB

## 🎯 Karakteristikat

### Admin Panel
- ✅ Menaxhimi i artikujve/produkteve
- ✅ Vendosja e çmimeve dhe TVSH
- ✅ Menaxhimi i kamerierëve
- ✅ Konfigurimi i tavolina
- ✅ Raportet e shitjeve

### Sistem Kamarieri (POS)
- ✅ Zgjedhja e tavolina
- ✅ Shtimi i artikujve në porosi
- ✅ Kalkulimi automatik me TVSH
- ✅ Shtypja e faturës dhe barcode
- ✅ Mundësia e NFC login

### Sistemi i Kuzhines (KDS)
- ✅ Shfaqja në kohë reale e porosive të reja
- ✅ Statusimi i porosive (Duke u përpunuar → E gatshme)
- ✅ Notifikime për porosi të reja
- ✅ Prioritizimi i porosive

## 🔧 Teknologjitë e Përdorura

- **Framework**: .NET Framework 4.7.2
- **UI**: Windows Forms (Lehtë për sistemet e vjetra)
- **Database**: SQL Server LocalDB
- **Language**: C#
- **Barcode**: ZXing.Net
- **Architecture**: N-Tier (UI, Core, Data, Utilities)

## 📁 Struktura e Projektit

```
RestaurantManagement/
├── src/
│   ├── RestaurantManagement.UI/          # Windows Forms UI
│   ├── RestaurantManagement.Core/        # Business Logic & Models
│   ├── RestaurantManagement.Data/        # Database Layer
│   └── RestaurantManagement.Utilities/   # Helpers
├── Database/
│   └── Schema.sql                        # Database Schema
└── RestaurantManagement.sln
```

## 🚀 Setup dhe Instalimi

### Parakuisimet
- Visual Studio 2019+ ose VS Code me C# extensions
- SQL Server 2019+ ose SQL Server Express
- .NET Framework 4.7.2+

### Hapat e Setup

#### 1. Klonohja e Projektit
```bash
git clone <repository-url>
cd Restorant-managment-11-2-Amar-programing
```

#### 2. Hapja në Visual Studio
```
File → Open → RestaurantManagement.sln
```

#### 3. Setup i Bazës
1. Hapni SQL Server Management Studio
2. Connect në (localdb)\mssqllocaldb
3. Right-click → New Query
4. Copy-paste content nga `Database/Schema.sql`
5. Execute (F5)

#### 4. Konfigurimi i Connection String
Ndrysho në `src/RestaurantManagement.UI/App.config`:
```xml
<connectionStrings>
    <add name="DefaultConnection" 
         connectionString="Server=(localdb)\mssqllocaldb;Database=RestaurantDB;Trusted_Connection=true;" />
</connectionStrings>
```

#### 5. Build dhe Run
```
Build → Build Solution (Ctrl+Shift+B)
Debug → Start Debugging (F5)
```

## 🔑 Kredenciale Default

| Username | Password | Role |
|----------|----------|------|
| admin | admin123 | Admin |

## 📱 Përdorimi i Sistemit

### Admin Panel
1. Hyni me admin credentials
2. Zgjidh "Produktet" për të shtuar artikujt
3. Zgjidh "Personali" për të regjistruar kamerierët
4. Zgjidh "Tavolina" për të konfiguruar tavolina

### POS (Kamarieri)
1. Hyni me kredencialet e kamerierit
2. Zgjidh tavolinën
3. Zgjedh artikujt
4. Shtyp faturën
5. Barcode gjenerohet automatikisht

### Kitchen Display
1. Hyni si kuzhinar
2. Porosi shfaqen në kohë reale
3. Marko "Fillo Gatimin" për të nisur
4. Marko "E Gatshme!" kur përfundoji

## 🗄️ Database Schema

### Tabela: Users
- Përdorues (Admin, Kamarieri, Kuzhinari)
- Login credentials
- Support NFC/RFID

### Tabela: Products
- Emri i produktit
- Çmimi
- TVSH
- Kategoria

### Tabela: Orders
- Porosi e plotë
- Tavolina dhe Kamarieri
- Statusi i porosise
- Zëra i porosise

### Tabela: Invoices
- Fatura (PDF/Print ready)
- Barcode
- Të dhënat e pagesës

## 🔐 Siguria

- Fjalëkalime të ruajtura (plain text - rekomendohet encryption në prod)
- NFC/RFID authentication option
- Role-based access control
- Audit logging

## 🌐 Deployment

### Lokal
1. Install .NET Framework 4.7.2
2. Setup SQL Server Express
3. Run installer

### Rrjetor
- Database server: Qendror
- POS + Kitchen: Kompjutera të ndryshëm
- Real-time sync përmes database

## 📝 Roadmap

- [ ] Mobile app (UWP)
- [ ] Cloud sync
- [ ] Advanced reports
- [ ] Multi-language
- [ ] E-menu
- [ ] Delivery tracking
- [ ] Payment gateway integration

## 🔧 Troubleshooting

### Problem: Database connection failed
**Zgjidhje**: Kontrolloni nëse SQL Server është running
```bash
services.msc → Search "SQL Server" → Start service
```

### Problem: DLL reference errors
**Zgjidhje**: Restore NuGet packages
```
Tools → NuGet Package Manager → Restore Packages
```

## 📞 Support

- 📧 amar@programmingteam.local
- 💬 GitHub Issues
- 📞 +1-XXX-XXX-XXXX

## 📄 Licensa

MIT License - Shih LICENSE file

## 👨‍💻 Autori

Amar Programming Team © 2024

---

**Këta hapat ju duhet të ndjekni për të filluar aplikacionin!**
