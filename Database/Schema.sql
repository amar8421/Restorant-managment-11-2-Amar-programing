-- =====================================================
-- RESTAURANT MANAGEMENT SYSTEM - DATABASE SCHEMA
-- =====================================================

-- =====================================================
-- USERS TABLE (Admin dhe Kameriert)
-- =====================================================
CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    FirstName NVARCHAR(100),
    LastName NVARCHAR(100),
    Email NVARCHAR(100),
    PhoneNumber NVARCHAR(20),
    Role INT NOT NULL,  -- 1=Admin, 2=Waiter, 3=Kitchen
    Status INT DEFAULT 1,  -- 1=Active, 0=Inactive
    CreatedDate DATETIME DEFAULT GETDATE(),
    LastLogin DATETIME,
    NFCID NVARCHAR(100) UNIQUE  -- Per NFC/RFID chips
);

-- =====================================================
-- CATEGORIES TABLE
-- =====================================================
CREATE TABLE Categories (
    CategoryId INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500),
    DisplayOrder INT DEFAULT 0,
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE()
);

-- =====================================================
-- PRODUCTS TABLE (Artikujt)
-- =====================================================
CREATE TABLE Products (
    ProductId INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(150) NOT NULL,
    CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories(CategoryId),
    Description NVARCHAR(500),
    Price DECIMAL(10, 2) NOT NULL,
    TaxPercentage DECIMAL(5, 2) DEFAULT 0,  -- TVSH percentage
    Quantity INT DEFAULT 0,
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE(),
    ModifiedDate DATETIME
);

-- =====================================================
-- TABLES TABLE (Tavolinat)
-- =====================================================
CREATE TABLE Tables (
    TableId INT PRIMARY KEY IDENTITY(1,1),
    TableNumber INT NOT NULL UNIQUE,
    Capacity INT NOT NULL,
    Status INT DEFAULT 1,  -- 1=Available, 2=Occupied, 3=Reserved
    Location NVARCHAR(100),
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE()
);

-- =====================================================
-- ORDERS TABLE (Porosite)
-- =====================================================
CREATE TABLE Orders (
    OrderId INT PRIMARY KEY IDENTITY(1,1),
    OrderNumber NVARCHAR(50) NOT NULL UNIQUE,
    TableId INT NOT NULL FOREIGN KEY REFERENCES Tables(TableId),
    WaiterId INT NOT NULL FOREIGN KEY REFERENCES Users(UserId),
    OrderDate DATETIME DEFAULT GETDATE(),
    CompletedDate DATETIME,
    Status INT DEFAULT 1,  -- 1=New, 2=InProgress, 3=Ready, 4=Completed, 5=Cancelled
    Notes NVARCHAR(500),
    SubTotal DECIMAL(10, 2),
    TaxAmount DECIMAL(10, 2),
    Total DECIMAL(10, 2)
);

-- =====================================================
-- ORDER ITEMS TABLE (Artikujt ne porosite)
-- =====================================================
CREATE TABLE OrderItems (
    OrderItemId INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT NOT NULL FOREIGN KEY REFERENCES Orders(OrderId),
    ProductId INT NOT NULL FOREIGN KEY REFERENCES Products(ProductId),
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2) NOT NULL,
    TaxPercentage DECIMAL(5, 2),
    LineTotal DECIMAL(10, 2),
    Status INT DEFAULT 1,  -- 1=Pending, 2=Cooking, 3=Ready, 4=Served
    Notes NVARCHAR(300),
    CreatedDate DATETIME DEFAULT GETDATE()
);

-- =====================================================
-- INVOICES TABLE (Faturat)
-- =====================================================
CREATE TABLE Invoices (
    InvoiceId INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT NOT NULL UNIQUE FOREIGN KEY REFERENCES Orders(OrderId),
    InvoiceNumber NVARCHAR(50) NOT NULL UNIQUE,
    InvoiceDate DATETIME DEFAULT GETDATE(),
    SubTotal DECIMAL(10, 2),
    TaxAmount DECIMAL(10, 2),
    Total DECIMAL(10, 2),
    PaymentMethod NVARCHAR(50),  -- Cash, Card, etc.
    PaymentStatus INT DEFAULT 1,  -- 1=Pending, 2=Paid, 3=Partially Paid
    Notes NVARCHAR(500),
    BarcodeData NVARCHAR(MAX)
);

-- =====================================================
-- AUDIT LOG TABLE
-- =====================================================
CREATE TABLE AuditLog (
    LogId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT FOREIGN KEY REFERENCES Users(UserId),
    Action NVARCHAR(100),
    TableName NVARCHAR(50),
    RecordId INT,
    OldValue NVARCHAR(MAX),
    NewValue NVARCHAR(MAX),
    Timestamp DATETIME DEFAULT GETDATE()
);

-- =====================================================
-- INDEXES
-- =====================================================
CREATE INDEX IX_Orders_TableId ON Orders(TableId);
CREATE INDEX IX_Orders_WaiterId ON Orders(WaiterId);
CREATE INDEX IX_Orders_OrderDate ON Orders(OrderDate);
CREATE INDEX IX_OrderItems_OrderId ON OrderItems(OrderId);
CREATE INDEX IX_OrderItems_ProductId ON OrderItems(ProductId);
CREATE INDEX IX_Products_CategoryId ON Products(CategoryId);
CREATE INDEX IX_Invoices_OrderId ON Invoices(OrderId);
CREATE INDEX IX_Invoices_InvoiceDate ON Invoices(InvoiceDate);

-- =====================================================
-- SAMPLE DATA
-- =====================================================

-- Insert Admin User
INSERT INTO Users (Username, Password, FirstName, LastName, Role, Status)
VALUES ('admin', 'admin123', 'Admin', 'User', 1, 1);

-- Insert Sample Categories
INSERT INTO Categories (CategoryName, DisplayOrder) VALUES
('Meshkatjellesa', 1),
('Peshk', 2),
('Salata', 3),
('Pasta', 4),
('Pijet', 5),
('Desertet', 6);

-- Insert Sample Products
INSERT INTO Products (ProductName, CategoryId, Price, TaxPercentage) VALUES
('Mish Viçi', 1, 8.50, 18),
('Mish Pule', 1, 7.00, 18),
('Mish Derri', 1, 6.50, 18),
('Trout', 2, 9.00, 18),
('Salata Greke', 3, 4.50, 18),
('Spageti', 4, 5.50, 18),
('Coca Cola', 5, 1.50, 18),
('Kafe', 5, 1.00, 18),
('Chocolate Cake', 6, 3.50, 18);

-- Insert Sample Tables
INSERT INTO Tables (TableNumber, Capacity, Status) VALUES
(1, 2, 1),
(2, 2, 1),
(3, 4, 1),
(4, 4, 1),
(5, 6, 1),
(6, 6, 1);
