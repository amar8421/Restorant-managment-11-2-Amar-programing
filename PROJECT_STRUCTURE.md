# Restaurant Management System - Struktura e Projektit

## 📁 Përshkrimi i Folderave

```
RestaurantManagement/
├── RestaurantManagement.sln          # Solution file
├── RestaurantManagement.UI/          # Windows Forms UI (Main Project)
│   ├── Forms/
│   │   ├── LoginForm.cs              # Login form (Admin/Waiter)
│   │   ├── AdminDashboard.cs         # Admin main form
│   │   ├── ProductManagement.cs      # Products CRUD
│   │   ├── PriceManagement.cs        # Prices & taxes
│   │   ├── StaffManagement.cs        # Waiters & staff
│   │   ├── TableManagement.cs        # Tables configuration
│   │   ├── POSForm.cs                # Point of Sale form
│   │   ├── OrderForm.cs              # Order entry
│   │   ├── KitchenDisplayForm.cs     # Kitchen display
│   │   └── InvoiceForm.cs            # Invoice generation
│   ├── Controls/                     # Custom controls
│   ├── Resources/                    # Images, icons
│   └── App.config
│
├── RestaurantManagement.Core/        # Business Logic & Models
│   ├── Models/
│   │   ├── Product.cs
│   │   ├── Category.cs
│   │   ├── Staff.cs
│   │   ├── Table.cs
│   │   ├── Order.cs
│   │   ├── OrderItem.cs
│   │   ├── Invoice.cs
│   │   └── User.cs
│   ├── Services/
│   │   ├── ProductService.cs
│   │   ├── OrderService.cs
│   │   ├── StaffService.cs
│   │   ├── AuthService.cs
│   │   └── InvoiceService.cs
│   └── Enums/
│       ├── OrderStatus.cs
│       └── UserRole.cs
│
├── RestaurantManagement.Data/        # Database Access Layer
│   ├── DatabaseContext.cs
│   ├── Repositories/
│   │   ├── IRepository.cs
│   │   ├── ProductRepository.cs
│   │   ├── OrderRepository.cs
│   │   ├── StaffRepository.cs
│   │   └── InvoiceRepository.cs
│   ├── Migrations/
│   └── Schema.sql
│
└── RestaurantManagement.Utilities/
    ├── BarcodeGenerator.cs           # For barcode printing
    ├── ReportGenerator.cs
    ├── ConfigHelper.cs
    └── ValidationHelper.cs
```

## 🗄️ Database Schema

### Tabela: Users
- UserId (int, PK)
- Username (string, unique)
- Password (varchar, encrypted)
- Role (int, enum: Admin=1, Waiter=2)
- IsActive (bool)

### Tabela: Products
- ProductId (int, PK)
- ProductName (string)
- CategoryId (int, FK)
- Price (decimal)
- Tax (decimal, %)
- IsActive (bool)

### Tabela: Categories
- CategoryId (int, PK)
- CategoryName (string)

### Tabela: Tables
- TableId (int, PK)
- TableNumber (int)
- Capacity (int)
- Status (int, enum: Available=1, Occupied=2, Reserved=3)

### Tabela: Orders
- OrderId (int, PK)
- TableId (int, FK)
- UserId (int, FK)
- OrderDate (datetime)
- Status (int, enum: New=1, InProgress=2, Completed=3, Cancelled=4)
- TotalAmount (decimal)

### Tabela: OrderItems
- OrderItemId (int, PK)
- OrderId (int, FK)
- ProductId (int, FK)
- Quantity (int)
- Price (decimal)
- Status (int, enum: Pending=1, Cooking=2, Ready=3, Served=4)

### Tabela: Invoices
- InvoiceId (int, PK)
- OrderId (int, FK)
- InvoiceNumber (string, unique)
- InvoiceDate (datetime)
- Subtotal (decimal)
- TaxAmount (decimal)
- Total (decimal)
- PaymentMethod (string)

## 🎯 Features

### Admin Panel
- ✅ Dashboard me statistika
- ✅ Gestione produktesh (Add, Edit, Delete)
- ✅ Gestione çmimesh dhe TVSH
- ✅ Gestione kameríerësh
- ✅ Gestione tavolina
- ✅ Raportet shitjesh

### POS/Waiter Module
- ✅ Login me username/password (ose NFC)
- ✅ Shfaqja e tavolina të disponueshme
- ✅ Zgjedhja e produkteve
- ✅ Kalkulimi i çmimit (me TVSH)
- ✅ Shfaqja e faturës
- ✅ Shfaqja e kodit të barres
- ✅ Shtypja e faturës

### Kitchen Display System (KDS)
- ✅ Shfaqja e porosive në kohë reale
- ✅ Filtrim sipas kategorive
- ✅ Ndryshim statusi (Cooking → Ready → Served)
- ✅ Notiftime për porosi të reja

## 📊 Teknologjitë

- **Framework**: .NET Framework 4.7.2+ (Windows Forms)
- **Database**: SQL Server LocalDB
- **Language**: C#
- **UI**: Windows Forms (nativen, lehtë në sistemet e vjetra)
- **Additional**: ZXing.Net (për barcode), Dapper (ORM)
