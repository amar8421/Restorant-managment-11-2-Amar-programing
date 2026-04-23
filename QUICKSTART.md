# 🚀 Quick Start for Developers

Get the Restaurant Management System running in **5 minutes**!

## ⚡ Express Setup

### Step 1: Prerequisites Check (1 min)
Ensure you have installed:
- ✅ Visual Studio 2019+ or VS Code
- ✅ Windows 7+
- ✅ SQL Server 2019 Express or LocalDB

```bash
# Verify .NET Framework
dir "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework"
```

### Step 2: Clone & Open (1 min)
```bash
git clone <repository-url>
cd Restorant-managment-11-2-Amar-programing
```

Open in Visual Studio: `RestaurantManagement.sln`

### Step 3: Setup Database (2 min)

#### Option A: Using SQL Server Management Studio
1. Open **SQL Server Management Studio**
2. Connect to: `(localdb)\mssqllocaldb`
3. New Query
4. Copy-paste from `Database/Schema.sql`
5. Execute (F5)

#### Option B: Using Command Line
```cmd
sqlcmd -S (localdb)\mssqllocaldb -U sa -P "" -i Database\Schema.sql
```

### Step 4: Build & Run (1 min)
```
Ctrl+Shift+B    (Build Solution)
F5              (Start Debugging)
```

## 🎮 Testing the Application

### Login Credentials
```
Username: admin
Password: admin123
```

### What to Try
1. **Admin Panel**: Click "Produktet" to see product grid
2. **Add Data**: Use admin panel to add products/tables
3. **POS Mode**: Create new admin user with Waiter role
4. **Kitchen**: Create new admin user with Kitchen role
5. **Logout**: Test logout functionality

## 🔧 Configuring Connection String

If database is not found, update in `App.config`:

```xml
<connectionStrings>
    <add name="DefaultConnection" 
         connectionString="Server=(localdb)\mssqllocaldb;Database=RestaurantDB;Trusted_Connection=true;" />
</connectionStrings>
```

## 🐛 Common Quick Fixes

### Issue: "Cannot connect to database"
```cmd
# Start LocalDB
sqllocaldb start mssqllocaldb

# Or verify status
sqllocaldb info mssqllocaldb
```

### Issue: "LoginForm won't compile"
```
- Clean Solution (Build → Clean)
- Restore NuGet (Tools → NuGet → Restore)
- Rebuild All
```

### Issue: "Database doesn't exist"
```
- Re-run the Schema.sql script
- Check correct database name in connection string
- Verify you're connecting to correct server instance
```

## 📁 File Locations

| File | Path |
|------|------|
| Solution | `RestaurantManagement.sln` |
| UI Layer | `src/RestaurantManagement.UI/` |
| Business | `src/RestaurantManagement.Core/` |
| Database | `src/RestaurantManagement.Data/` |
| Utilities | `src/RestaurantManagement.Utilities/` |
| Schema | `Database/Schema.sql` |
| Config | `src/RestaurantManagement.UI/App.config` |

## 🎯 Next Development Steps

### Immediate (1-2 hours)
- [ ] Add Edit/Delete functionality in ProductManagementForm
- [ ] Implement table selection in POSForm
- [ ] Add order calculation logic

### Short-term (1 day)
- [ ] Complete POS order entry
- [ ] Implement Kitchen order display
- [ ] Add invoice generation

### Medium-term (1-2 weeks)
- [ ] Real-time order synchronization
- [ ] Barcode printer integration
- [ ] Payment processing
- [ ] Reports & analytics

## 📚 Documentation Navigation

| Document | Purpose |
|----------|---------|
| README.md | General overview & features |
| SETUP_GUIDE.md | Installation instructions |
| TECHNICAL_DOCS.md | Architecture & design |
| PROJECT_STRUCTURE.md | Component layout |

## 🎓 Learning Resources

### Windows Forms
- Microsoft Docs: https://docs.microsoft.com/windows-forms
- Tutorial: https://www.tutorialspoint.com/winforms

### C# & OOP
- Microsoft Docs: https://docs.microsoft.com/dotnet/csharp
- Patterns: https://refactoring.guru/design-patterns/csharp

### SQL Server
- Getting Started: https://docs.microsoft.com/sql/

## 🆘 Need Help?

1. **Check the docs** - 90% of questions answered
2. **Read code comments** - Well-documented
3. **Debug in VS** - Set breakpoints, step through
4. **Google the error** - Stack Overflow is your friend

## 🎉 You're Ready!

You now have a fully functional Restaurant Management System ready for:
- Development and customization
- Testing and QA
- Deployment to production

**Next: Open `RestaurantManagement.sln` and start coding!** 🚀