# Technical Documentation

## Architecture Overview

### Layered Architecture

```
┌─────────────────────────────────┐
│   UI Layer (Windows Forms)       │ RestaurantManagement.UI
│   - LoginForm                    │
│   - AdminDashboard              │
│   - POSForm                      │
│   - KitchenDisplayForm           │
└──────────────┬────────────────────┘
               │
┌──────────────▼────────────────────┐
│   Core Layer (Business Logic)    │ RestaurantManagement.Core
│   - Models                        │
│   - Services                      │
│   - Enums                         │
└──────────────┬────────────────────┘
               │
┌──────────────▼────────────────────┐
│   Data Layer (Database Access)   │ RestaurantManagement.Data
│   - DatabaseContext              │
│   - Repositories                 │
│   - Connections                  │
└──────────────┬────────────────────┘
               │
┌──────────────▼────────────────────┐
│   Utilities Layer                │ RestaurantManagement.Utilities
│   - Helpers                       │
│   - BarcodeGenerator             │
│   - Validators                    │
└──────────────────────────────────┘
```

## Database Design

### Entities

1. **Users** - Përfaqëson përdoruesit (Admin, Waiter, Kitchen)
2. **Products** - Artikujt në menynë
3. **Categories** - Klasifikimi i produkteve
4. **Tables** - Tavolina në restorant
5. **Orders** - Porositë
6. **OrderItems** - Artikujt në porosite
7. **Invoices** - Faturat ndaj klientit
8. **AuditLog** - Logging i veprimeve

### Relationships

```
Users ──────────────────┐
                        │
Orders ─────────────────┼────→ Tables
        │               │
        │               │
        └───────────────┘
           │
        OrderItems
           │
           └────────────→ Products
                         │
                         └─→ Categories

Invoices ──────────────→ Orders
```

## Service Architecture

### AuthService
- `Login(username, password)` - Authenticate user
- `LoginWithNFC(nfcId)` - NFC authentication
- `Register(user)` - Create new user
- `ChangePassword(userId, oldPassword, newPassword)`

### ProductService
- `GetAllProducts()` - Fetch all products
- `GetProduct(productId)`
- `AddProduct(product)`
- `UpdateProduct(product)`
- `DeleteProduct(productId)`

### OrderService
- `GetAllOrders()`
- `GetOrder(orderId)`
- `CreateOrder(order)`
- `UpdateOrder(order)`
- `CancelOrder(orderId)`

## Data Access Pattern

Using lightweight ADO.NET with manual SQL queries (no ORM):

```csharp
public class ProductRepository : IRepository<Product>
{
    private DatabaseContext _context;
    
    public Product GetById(int id)
    {
        var parameters = new SqlParameter[] 
        { 
            new SqlParameter("@ProductId", id) 
        };
        var dataTable = _context.ExecuteQuery(
            "SELECT * FROM Products WHERE ProductId = @ProductId", 
            parameters
        );
        // Map DataRow to Product
    }
}
```

## Configuration

### App.config
```xml
<configuration>
    <connectionStrings>
        <add name="DefaultConnection" 
             connectionString="Server=...;Database=RestaurantDB;..." />
    </connectionStrings>
    <appSettings>
        <add key="AppName" value="..." />
        <add key="CompanyName" value="..." />
        <add key="Version" value="..." />
    </appSettings>
</configuration>
```

## Performance Considerations

1. **Connection Pooling** - Automatic via .NET Framework
2. **Query Optimization** - Indexed queries on frequently accessed tables
3. **Caching** - Local cache for categories and products
4. **Async Operations** - For long-running database queries

## Security Measures

1. **Input Validation** - All inputs validated before database operations
2. **SQL Injection Prevention** - Parameterized queries
3. **Authentication** - Username/password + optional NFC
4. **Authorization** - Role-based access control
5. **Audit Trail** - All changes logged to AuditLog table

## Testing

### Unit Tests
- Service layer logic
- Validation rules
- Business calculations

### Integration Tests
- Database operations
- Form interactions
- Real-time updates

## Deployment

### Development Environment
1. Local SQL Server Express
2. Visual Studio debugger
3. Auto-reload on changes

### Production Environment
1. SQL Server 2019+ on server
2. Client installations with LocalDB
3. Network connectivity for sync

## Common Issues & Solutions

| Issue | Solution |
|-------|----------|
| Slow startup | Clear LocalDB cache, rebuild indexes |
| Network sync lag | Reduce refresh rate, optimize queries |
| Memory leaks | Dispose properly, use `using` statements |
| Print failures | Check printer drivers, test connectivity |

## Future Improvements

1. Entity Framework migration
2. MVVM pattern for UI
3. WebAPI backend for sync
4. Azure cloud database
5. Mobile app (UWP/Xamarin)
6. Real-time notifications (SignalR)
7. Advanced analytics
8. Multi-language support

---

**For questions, contact: dev@restaurant.local**