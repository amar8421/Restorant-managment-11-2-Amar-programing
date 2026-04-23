# Setup Guide për Klientët

## 🎯 Udhëzuesit për Instalimin e Aplikacionit në Kompjuterin e Klientit

Ky dokument shpjegon se si të instaloni **Sistemin e Menaxhimit të Restorantit** në përdoruesin përfundimtar kompjuter.

## 📋 Prakeruisimet

Këto aplikacione duhet të jenë instaluar më parë:
1. **Windows 7 **ose më në zgjuarshëm
2. **.NET Framework 4.7.2** ose më i ri
3. **SQL Server Express 2019** ose më i ri
4. **Printer** (për shtypjen e faturave)

## 📥 Hapat e Instalimit

### Hap 1: Download i Fajllave
1. Download folder-in `RestaurantManagement` nga server
2. Copy në `C:\Program Files\RestaurantManagement\`

### Hap 2: Install SQL Server Express
1. Download **SQL Server Express 2019** nga microsoft.com
2. Run installer
3. Zgjedh **Express** edition
4. Zgjedh **LocalDB** gjatë konfigurimit
5. Provo koneksionin

### Hap 3: Create Database
1. Download **SQL Server Management Studio** (SSMS)
2. Connect në `(localdb)\mssqllocaldb`
3. Right-click → New Query
4. Kudo copy-paste skedën nga `Database\Schema.sql`
5. Execute (F5 ose Ctrl+E)

### Hap 4: Configure Connection String
1. Hap folder `C:\Program Files\RestaurantManagement\`
2. Hap file `RestaurantManagement.UI.exe.config`
3. Ndrysho këtë rresht:
```xml
<add name="DefaultConnection" connectionString="Server=(localdb)\mssqllocaldb;Database=RestaurantDB;Trusted_Connection=true;" />
```
4. Save file

### Hap 5: Test Aplikacionit
1. Double-click `RestaurantManagement.UI.exe`
2. Hyni me credentials:
   - **Username**: admin
   - **Password**: admin123
3. Nëse hapet aplikacioni, instalimi u arrit me sukses!

## ⚙️ Konfigurimi i Sistemit

### Vendosja e Emrit të Restorantit
1. Hap `RestaurantManagement.UI.exe.config`
2. Ndrysho këtë vijë:
```xml
<add key="CompanyName" value="Emri i Restorantit" />
```

### Konfigurimi i Printerit
1. Go to Settings → Printers
2. Set Default Printer
3. Aplikacioni do të përdorë printer default

### NFC/RFID Setup (Opsional)
1. Blejnë NFC reader device
2. Connect USB te kompjuter
3. Install driver software
4. Në Admin Panel → Personali → Edit Waiter → Add NFC ID

## 🖨️ Konfigurimi i Shtypjes

### Për Faturën
1. Admin Panel → Settings
2. Configure invoice format
3. Test print një faturë

### Për Barkodin
1. Sistemi gjeneron barcode automatikisht
2. Kontrolloni që printer mbështet barcode
3. Test print barcode

## 🔑 Menaxhimi i Përdoruesve

### Shtim i Administratorit
1. Hyni si Admin
2. Go to → Personali
3. Click "Shto"
4. Plotëso të dhënat
5. Role: Admin
6. Click "Ruaj"

### Shtim i Kamerierit
1. Admin Panel → Personali
2. Click "Shto"
3. Plotëso:
   - Emri
   - Mbiemri
   - Username
   - Password
4. Role: Waiter
5. Click "Ruaj"

### Shtim i Kuzhinarit
1. Admin Panel → Personali
2. Click "Shto"
3. Plotëso kredencialet
4. Role: Kitchen
5. Click "Ruaj"

## 📋 Vendosja e Tavolina

1. Admin Panel → Tavolina
2. Click "Shto"
3. Plotëso:
   - Tabela Nr: 1
   - Kapaciteti: 4
   - Vendndodhja: Salla e Madhe
4. Click "Ruaj"
5. Përsërit për të gjitha tavolina

## 🍽️ Vendosja e Produkteve

1. Admin Panel → Produktet
2. Click "Shto"
3. Plotëso:
   - Emri: p.sh. "Mish Viçi"
   - Kategoria: Meshkatjellesa
   - Çmimi: 8.50
   - TVSH: 18%
4. Click "Ruaj"
5. Përsërit për të gjitha artikujt

## 🔄 Backup të Dhënave

### Backup Ditor
1. Open SQL Server Management Studio
2. Right-click Database → Tasks → Backup
3. Save në folder të sigurisë

### Restore nga Backup
1. Right-click Database → Restore Database
2. Zgjidh backup file
3. Klik "OK"

## 🆘 Troubleshooting

### Problemi: "Cannot connect to database"
**Zgjidhje**:
1. Kontrolloni që SQL Server është running
2. Open `services.msc`
3. Kërkoni "SQL Server Express"
4. Right-click → Start

### Problemi: "Login shëtosje mendimesh"
**Zgjidhje**:
1. Kontrolloni kredencialet
2. Sigurohuni se kätyri i përdoruesit është "Active"
3. Kontrolloni rolin

### Problemi: "Printer shuar"
**Zgjidhje**:
1. Go to Settings → Printers
2. Kontrolloni që printer është online
3. Rifaq config file

### Problemi: "NFC nuk punon"
**Zgjidhje**:
1. Kontrolloni driver-in
2. Restartoni kompjuterin
3. Test NFC reader separately

## 📞 Support

Për probleme, kontaktoni:
- **Email**: support@restaurant.local
- **Phone**: +XXX-XXX-XXXX
- **Hours**: 9:00 AM - 6:00 PM

## 📝 Checklist Instalimi

- [ ] .NET Framework 4.7.2 instaluar
- [ ] SQL Server Express instaluar
- [ ] Database hapur
- [ ] Connection string konfiguruar
- [ ] Aplikacioni testohet
- [ ] Printerit linku
- [ ] Përdoruesit regjistruar
- [ ] Tavolina konfiguruar
- [ ] Produktet vendosur
- [ ] Admin testohet
- [ ] POS testohet
- [ ] Kitchen display testohet

---

**Pasi plotësohen të gjitha hapat, sistemi është gati për përdorim!**