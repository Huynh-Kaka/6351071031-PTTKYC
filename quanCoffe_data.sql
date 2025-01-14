			-- Bảng Accounts
CREATE TABLE Accounts (
    AccountID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(256) NOT NULL,
    Role INT NOT NULL CHECK (Role IN (1, 2)) -- Thêm kiểm tra giá trị cho Role
);


-- Bảng Customer (Khách hàng)
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY,
    FullName VARCHAR(100),
    Phone VARCHAR(15),
);
INSERT INTO Customers (FullName, Phone)
VALUES 
    ('Nguyen Thi Lan', '0901234567'),
    ('Tran Minh Tu', '0987654321'),
    ('Le Hoang Nam', '0912345678'),
    ('Pham Thanh Son', '0934567890'),
    ('Vu Thi Bao Ngoc', '0976543210'),
    ('Hoang Minh Tuan', '0909876543'),
    ('Nguyen Quang Hieu', '0912345679'),
    ('Nguyen Thi Mai', '0987654322');



-- Bảng Category (Danh mục)
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY,
    CategoryName VARCHAR(100) NOT NULL
);

DROP TABLE Categories;
-- Bảng Product (Sản phẩm)

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY,
    ProductName VARCHAR(100) NOT NULL,
    CategoryID INT NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
   
    Image VARCHAR(255),
	FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

ALTER TABLE Products
DROP COLUMN Description;




CREATE TABLE Tables (
    TableID INT PRIMARY KEY IDENTITY(1,1),
    TableName VARCHAR(50) NOT NULL, -- Tên hoặc số hiệu của bàn
    Capacity INT,                    -- Sức chứa của bàn (số ghế)
	Status BIT NOT NULL DEFAULT 1, -- 0: đã đặt, 1: trống 
);
-- Bảng Order (Đơn hàng)
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY,
    CustomerID INT NOT NULL,
	AccountID INT NOT NULL,
	TableID INT NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
	FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
	FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID),
	FOREIGN KEY (TableID) REFERENCES Tables(TableID)
);

-- Bảng OrderDetail (Chi tiết đơn hàng)
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL DEFAULT 1,
	FOREIGN KEY (OrderID) REFERENCES Orders(OrderID) ON DELETE CASCADE,
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

CREATE TABLE Invoices (
    InvoiceID INT PRIMARY KEY IDENTITY,
    OrderID INT NOT NULL,
    InvoiceDate DATETIME DEFAULT GETDATE(),
    PaymentMethod BIT NOT NULL DEFAULT 1, -- 0: chuyển khoản , 1: tiền mặt  
    TotalAmount DECIMAL(10, 2) NOT NULL, -- Tổng số tiền trên hóa đơn
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID) -- Liên kết với đơn hàng
);

CREATE TABLE InvoiceDetails (
    InvoiceDetailID INT PRIMARY KEY IDENTITY,
    InvoiceID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL DEFAULT 1,
    UnitPrice DECIMAL(10, 2) NOT NULL, -- Giá mỗi sản phẩm tại thời điểm thanh toán
    TotalPrice AS (Quantity * UnitPrice) PERSISTED, -- Tổng giá trị cho mỗi sản phẩm trong hóa đơn
    FOREIGN KEY (InvoiceID) REFERENCES Invoices(InvoiceID) ON DELETE CASCADE, -- Tự động xóa chi tiết nếu hóa đơn bị xóa
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
DBCC CHECKIDENT ('Employees', RESEED, 0);
-- Bảng Employee (Nhân viên)

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY,
	AccountID INT NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    Position VARCHAR(50),
	DateOfJoining DATE NOT NULL,               -- Ngày vào làm
	 Status NVARCHAR(20) DEFAULT 'Đang làm',    -- Trạng thái
	Salary DECIMAL(18, 2),                     -- Lương
	CreatedAt DATETIME DEFAULT GETDATE(),      -- Ngày tạo
    UpdatedAt DATETIME DEFAULT GETDATE() 
	FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID)
);

GO
CREATE TABLE Voucher (
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(), -- Mã định danh của voucher
    MaVoucher NVARCHAR(50) NOT NULL UNIQUE,         -- Mã voucher
    LoaiGiamGia CHAR(1) NOT NULL CHECK (LoaiGiamGia IN ('P', 'F')), -- Loại giảm giá: 'P' - phần trăm, 'F' - số tiền cố định
    GiaTriGiam DECIMAL(10, 2) NOT NULL,             -- Giá trị giảm (phần trăm hoặc số tiền)
    NgayBatDau DATE NOT NULL,                       -- Ngày bắt đầu áp dụng voucher
    NgayHetHan DATE NOT NULL,                       -- Ngày hết hạn voucher
    SoLanToiDaSuDung INT NOT NULL,                  -- Số lần tối đa có thể sử dụng
    SoLanDaSuDung INT DEFAULT 0,                    -- Số lần đã sử dụng
    GiaTriDonHangToiThieu DECIMAL(10, 2),           -- Giá trị đơn hàng tối thiểu để áp dụng voucher
    TrangThai BIT DEFAULT 1                         -- Trạng thái: 1 - hoạt động, 0 - không hoạt động
);

INSERT INTO Accounts (Username, Password, Role )
VALUES
    (N'admin1', N'aaa123', 1),
    (N'admin2', N'bbb123',1),
    (N'user1', N'userpass1',2),
    (N'user2', N'userpass2',2),
    (N'user3', N'userpass3',2);

select *
from Accounts

DROP TABLE Employees;

DELETE FROM Employees;
-- Insert employees with Vietnamese names and limited positions
-- Insert employees using existing account IDs


INSERT INTO Employees (AccountID, FullName, Position)
VALUES 
    (1, 'Admin User One', 'Manager'),
    (2, 'Admin User Two', 'Assistant Manager'),
    (3, 'Regular User One', 'Server'),
    (4, 'Regular User Two', 'Server'),
    (5, 'Regular User Three', 'Bartender');

	-- Thêm dữ liệu vào bảng Employees
INSERT INTO Employees (AccountID, FullName, Position, DateOfJoining, Status, Salary, CreatedAt, UpdatedAt)
VALUES
(1, 'Nguyen Van A', 'Department Head', '2020-01-15', 'Active', 30000000, GETDATE(), GETDATE()),
(2, 'Tran Thi B', 'Deputy Head', '2021-05-20', 'Active', 25000000, GETDATE(), GETDATE()),
(3, 'Le Van C', 'Staff', '2022-03-01', 'Active', 15000000, GETDATE(), GETDATE()),
(4, 'Hoang Thi D', 'Staff', '2023-01-10', 'Active', 12000000, GETDATE(), GETDATE()),
(5, 'Dinh van huynh', 'Staff', '2023-01-10', 'Active', 12000000, GETDATE(), GETDATE());




INSERT INTO Categories (CategoryName)
VALUES
('Desserts'),
('Coffee'),
('Soft Drinks');


-- Thêm dữ liệu vào bảng Products cho "Desserts"
INSERT INTO Products (ProductName, CategoryID, Price, Description, Image)
VALUES
('Chocolate Cake', 1, 50000, 'Rich chocolate cake with ganache topping', 'chocolate_cake.jpg'),
('Strawberry Cheesecake', 1, 60000, 'Creamy cheesecake with fresh strawberries', 'strawberry_cheesecake.jpg'),
('Lemon Tart', 1, 45000, 'Tart and sweet lemon filling in a buttery crust', 'lemon_tart.jpg'),
('Brownie', 1, 30000, 'Classic fudgy brownie with nuts', 'brownie.jpg'),
('Apple Pie', 1, 55000, 'Warm apple pie with cinnamon and flaky crust', 'apple_pie.jpg');

-- Thêm dữ liệu vào bảng Products cho "Coffee"
INSERT INTO Products (ProductName, CategoryID, Price, Description, Image)
VALUES
('Espresso', 2, 20000, 'Strong black coffee served in small shots', 'espresso.jpg'),
('Cappuccino', 2, 25000, 'Creamy coffee with steamed milk and foam', 'cappuccino.jpg'),
('Latte', 2, 27000, 'Smooth coffee with steamed milk and a touch of foam', 'latte.jpg'),
('Americano', 2, 18000, 'Espresso diluted with hot water', 'americano.jpg'),
('Macchiato', 2, 22000, 'Espresso marked with a splash of milk', 'macchiato.jpg');

-- Thêm dữ liệu vào bảng Products cho "Soft Drinks"
INSERT INTO Products (ProductName, CategoryID, Price, Description, Image)
VALUES
('Cola', 3, 15000,'Classic cola soda with a refreshing taste', 'cola.jpg'),
('Lemonade', 3, 13000, 'Sweet and tangy homemade lemonade', 'lemonade.jpg'),
('Orange Juice', 3, 17000, 'Freshly squeezed orange juice', 'orange_juice.jpg'),
('Ice Tea', 3, 14000, 'Iced tea with a hint of mint', 'ice_tea.jpg'),
('Sprite', 3, 16000, 'Sparkling lemon-lime soda', 'sprite.jpg');



-- Thêm dữ liệu vào bảng Products cho "Cakes"
INSERT INTO Products (ProductName, CategoryID, Price, Image)
VALUES
('Chocolate Cake', 1, 50000, 'chocolate_cake.jpg'),
('Strawberry Cheesecake', 1, 60000, 'strawberry_cheesecake.jpg'),
('Lemon Tart', 1, 45000, 'lemon_tart.jpg'),
('Brownie', 1, 30000, 'brownie.jpg'),
('Apple Pie', 1, 55000, 'apple_pie.jpg');

-- Thêm dữ liệu vào bảng Products cho "Coffee"
INSERT INTO Products (ProductName, CategoryID, Price, Image)
VALUES
('Espresso', 2, 20000, 'espresso.jpg'),
('Cappuccino', 2, 25000, 'cappuccino.jpg'),
('Latte', 2, 27000, 'latte.jpg'),
('Americano', 2, 18000, 'americano.jpg'),
('Macchiato', 2, 22000, 'macchiato.jpg');

-- Thêm dữ liệu vào bảng Products cho "Soft Drinks"
INSERT INTO Products (ProductName, CategoryID, Price, Image)
VALUES
('Cola', 3, 15000, 'cola.jpg'),
('Lemonade', 3, 13000, 'lemonade.jpg'),
('Orange Juice', 3, 17000, 'orange_juice.jpg'),
('Ice Tea', 3, 14000, 'ice_tea.jpg'),
('Sprite', 3, 16000, 'sprite.jpg');


DELETE FROM Products;

ALTER TABLE Products
DROP COLUMN Quantity;

-- Bước 1: Xóa ràng buộc mặc định
ALTER TABLE Products DROP CONSTRAINT DF__Products__Quanti__778AC167;

-- Bước 2: Xóa cột Quantity
ALTER TABLE Products DROP COLUMN Quantity;

DBCC CHECKIDENT ('Products', RESEED, 0);

INSERT INTO Categories (CategoryName)
VALUES
('Desserts'),
('Coffee'),
('Soft Drinks');


INSERT INTO Products (ProductName, CategoryID, Price, Image)
VALUES
('Chocolate Cake', 1, 50000, 'Rich chocolate cake with ganache topping', 'chocolate_cake.jpg'),
('Strawberry Cheesecake', 1, 60000, 'Creamy cheesecake with fresh strawberries', 'strawberry_cheesecake.jpg'),
('Lemon Tart', 1, 45000, 'Tart and sweet lemon filling in a buttery crust', 'lemon_tart.jpg'),
('Brownie', 1, 30000, 'Classic fudgy brownie with nuts', 'brownie.jpg'),
('Apple Pie', 1, 55000, 'Warm apple pie with cinnamon and flaky crust', 'apple_pie.jpg');

-- Thêm dữ liệu vào bảng Products cho "Coffee"
INSERT INTO Products (ProductName, CategoryID, Price, Image)
VALUES
('Espresso', 2, 20000, 'Strong black coffee served in small shots', 'espresso.jpg'),
('Cappuccino', 2, 25000, 'Creamy coffee with steamed milk and foam', 'cappuccino.jpg'),
('Latte', 2, 27000, 'Smooth coffee with steamed milk and a touch of foam', 'latte.jpg'),
('Americano', 2, 18000, 'Espresso diluted with hot water', 'americano.jpg'),
('Macchiato', 2, 22000, 'Espresso marked with a splash of milk', 'macchiato.jpg');


-- Thêm dữ liệu vào bảng Products cho "Soft Drinks"
INSERT INTO Products (ProductName, CategoryID, Price, Image)
VALUES
('Cola', 3, 15000,'Classic cola soda with a refreshing taste', 'cola.jpg'),
('Lemonade', 3, 13000, 'Sweet and tangy homemade lemonade', 'lemonade.jpg'),
('Orange Juice', 3, 17000, 'Freshly squeezed orange juice', 'orange_juice.jpg'),
('Ice Tea', 3, 14000, 'Iced tea with a hint of mint', 'ice_tea.jpg'),
('Sprite', 3, 16000, 'Sparkling lemon-lime soda', 'sprite.jpg');


-- Thêm 10 bàn vào bảng Tables, tất cả đều trống
INSERT INTO Tables (TableName, Capacity, Status)
VALUES
('Bàn 1', 4, 1),  -- Bàn 1, Sức chứa 4, Trống
('Bàn 2', 2, 1),  -- Bàn 2, Sức chứa 2, Trống
('Bàn 3', 6, 1),  -- Bàn 3, Sức chứa 6, Trống
('Bàn 4', 4, 1),  -- Bàn 4, Sức chứa 4, Trống
('Bàn 5', 8, 1),  -- Bàn 5, Sức chứa 8, Trống
('Bàn 6', 4, 1),  -- Bàn 6, Sức chứa 4, Trống
('Bàn 7', 10, 1), -- Bàn 7, Sức chứa 10, Trống
('Bàn 8', 2, 1),  -- Bàn 8, Sức chứa 2, Trống
('Bàn 9', 6, 1),  -- Bàn 9, Sức chứa 6, Trống
('Bàn 10', 4, 1); -- Bàn 10, Sức chứa 4, Trống

Go


DELETE FROM Orders


DELETE FROM OrderDetails
DELETE FROM Invoices
DELETE FROM InvoiceDetails

DBCC CHECKIDENT ('Orders', RESEED, 0);
DBCC CHECKIDENT ('OrderDetails', RESEED, 0);
DBCC CHECKIDENT ('Invoices', RESEED, 0);
DBCC CHECKIDENT ('InvoiceDetails', RESEED, 0);




INSERT INTO Orders (CustomerID, AccountID, TableID, OrderDate)
VALUES 
    (1, '3', 1, GETDATE()), -- Đơn hàng cho Bàn 1, tài khoản user1
    (2, '3', 2, GETDATE());

	INSERT INTO OrderDetails (OrderID, ProductID, Quantity)
VALUES 
    (1, 2, 10), -- Bàn 1, sản phẩm bàn 2, số lượng 10
    (1, 3, 10), -- Bàn 1, sản phẩm bàn 3, số lượng 10
    (1, 4, 10); -- Bàn 1, sản phẩm bàn 4, số lượng 10

-- Chèn chi tiết đơn hàng cho Bàn 2 (OrderID = 2)
INSERT INTO OrderDetails (OrderID, ProductID, Quantity)
VALUES 
    (2, 2, 10), -- Bàn 2, sản phẩm bàn 2, số lượng 10
    (2, 3, 10), -- Bàn 2, sản phẩm bàn 3, số lượng 10
    (2, 4, 10);

-- Thêm dữ liệu vào bảng Orders (Đơn hàng)
INSERT INTO Orders (CustomerID, AccountID, TableID, OrderDate)
VALUES
(1, 2, 3, '2025-01-11 08:30:00'),
(2, 3, 2, '2025-01-11 09:00:00'),
(3, 2, 1, '2025-01-11 10:00:00'),
(4, 2, 4, '2025-01-11 11:00:00'),
(5, 3, 5, '2025-01-11 12:30:00'),
(6, 1, 2, '2025-01-11 13:00:00'),
(7, 2, 3, '2025-01-11 14:15:00'),
(8, 1, 4, '2025-01-11 15:00:00');


-- Thêm dữ liệu vào bảng OrderDetails (Chi tiết đơn hàng)
INSERT INTO OrderDetails (OrderID, ProductID, Quantity)
VALUES
(1, 1, 2),  -- Đơn hàng 1: Sản phẩm ID 1 (Chocolate Cake), số lượng 2
(1, 2, 1),  -- Đơn hàng 1: Sản phẩm ID 2 (Strawberry Cheesecake), số lượng 1
(2, 3, 3),  -- Đơn hàng 2: Sản phẩm ID 3 (Lemon Tart), số lượng 3
(3, 4, 5),  -- Đơn hàng 3: Sản phẩm ID 4 (Brownie), số lượng 5
(4, 5, 2),  -- Đơn hàng 4: Sản phẩm ID 5 (Apple Pie), số lượng 2
(5, 6, 4),  -- Đơn hàng 5: Sản phẩm ID 6 (Espresso), số lượng 4
(6, 7, 3),  -- Đơn hàng 6: Sản phẩm ID 7 (Cappuccino), số lượng 3
(7, 8, 2),  -- Đơn hàng 7: Sản phẩm ID 8 (Latte), số lượng 2
(8, 9, 1),  -- Đơn hàng 8: Sản phẩm ID 9 (Americano), số lượng 1
(8, 10, 2); -- Đơn hàng 8: Sản phẩm ID 10 (Macchiato), số lượng 2

-- Thêm dữ liệu vào bảng Invoices (Hóa đơn)
INSERT INTO Invoices (OrderID, InvoiceDate, PaymentMethod, TotalAmount)
VALUES
(1, '2025-01-11 08:35:00', 1, 200000),  -- Hóa đơn 1: Đơn hàng 1, Thanh toán tiền mặt
(2, '2025-01-11 09:05:00', 0, 150000),  -- Hóa đơn 2: Đơn hàng 2, Thanh toán chuyển khoản
(3, '2025-01-11 10:10:00', 1, 300000),  -- Hóa đơn 3: Đơn hàng 3, Thanh toán tiền mặt
(4, '2025-01-11 11:05:00', 1, 250000),  -- Hóa đơn 4: Đơn hàng 4, Thanh toán tiền mặt
(5, '2025-01-11 12:35:00', 0, 400000),  -- Hóa đơn 5: Đơn hàng 5, Thanh toán chuyển khoản
(6, '2025-01-11 13:10:00', 1, 350000),  -- Hóa đơn 6: Đơn hàng 6, Thanh toán tiền mặt
(7, '2025-01-11 14:30:00', 0, 450000),  -- Hóa đơn 7: Đơn hàng 7, Thanh toán chuyển khoản
(8, '2025-01-11 15:15:00', 1, 500000);  -- Hóa đơn 8: Đơn hàng 8, Thanh toán tiền mặt

-- Thêm dữ liệu vào bảng InvoiceDetails (Chi tiết hóa đơn)
INSERT INTO InvoiceDetails (InvoiceID, ProductID, Quantity, UnitPrice)
VALUES
(1, 1, 2, 50000),  -- Hóa đơn 1: Sản phẩm ID 1 (Chocolate Cake), số lượng 2, giá mỗi sản phẩm 50000
(1, 2, 1, 60000),  -- Hóa đơn 1: Sản phẩm ID 2 (Strawberry Cheesecake), số lượng 1, giá mỗi sản phẩm 60000
(2, 3, 3, 45000),  -- Hóa đơn 2: Sản phẩm ID 3 (Lemon Tart), số lượng 3, giá mỗi sản phẩm 45000
(3, 4, 5, 30000),  -- Hóa đơn 3: Sản phẩm ID 4 (Brownie), số lượng 5, giá mỗi sản phẩm 30000
(4, 5, 2, 55000),  -- Hóa đơn 4: Sản phẩm ID 5 (Apple Pie), số lượng 2, giá mỗi sản phẩm 55000
(5, 6, 4, 20000),  -- Hóa đơn 5: Sản phẩm ID 6 (Espresso), số lượng 4, giá mỗi sản phẩm 20000
(6, 7, 3, 25000),  -- Hóa đơn 6: Sản phẩm ID 7 (Cappuccino), số lượng 3, giá mỗi sản phẩm 25000
(7, 8, 2, 27000),  -- Hóa đơn 7: Sản phẩm ID 8 (Latte), số lượng 2, giá mỗi sản phẩm 27000
(8, 9, 1, 18000),  -- Hóa đơn 8: Sản phẩm ID 9 (Americano), số lượng 1, giá mỗi sản phẩm 18000
(8, 10, 2, 22000); -- Hóa đơn 8: Sản phẩm ID 10 (Macchiato), số lượng 2, giá mỗi sản phẩm 22000





INSERT INTO Tables (TableName, Capacity, Status)
VALUES
('Bàn 1', 4, 1),  -- Bàn 1, Sức chứa 4, Trống
('Bàn 2', 2, 1),  -- Bàn 2, Sức chứa 2, Trống
('Bàn 3', 6, 1),  -- Bàn 3, Sức chứa 6, Trống
('Bàn 4', 4, 1),  -- Bàn 4, Sức chứa 4, Trống
('Bàn 5', 8, 1),  -- Bàn 5, Sức chứa 8, Trống
('Bàn 6', 4, 1),  -- Bàn 6, Sức chứa 4, Trống
('Bàn 7', 10, 1), -- Bàn 7, Sức chứa 10, Trống
('Bàn 8', 2, 1),  -- Bàn 8, Sức chứa 2, Trống
('Bàn 9', 6, 1),  -- Bàn 9, Sức chứa 6, Trống
('Bàn 10', 4, 1); -- Bàn 10, Sức chứa 4, Trống
go

UPDATE Tables
SET Status = 1 -- 1 đại diện cho "Trống"
WHERE TableID IN (1,2,3,4,5,6,7,8,9,10,11,12,13,14);

DELETE FROM Tables
WHERE TableID >= 14;
INSERT INTO Tables (TableName, Capacity, Status)
VALUES
('Bàn 11', 4, 1),  -- Bàn 11, Sức chứa 4, Trống
('Bàn 12', 2, 1),  -- Bàn 12, Sức chứa 2, Trống
('Bàn 13', 6, 1),  -- Bàn 13, Sức chứa 6, Trống
('Bàn 14', 4, 1),  -- Bàn 14, Sức chứa 4, Trống
('Bàn 15', 8, 1),  -- Bàn 15, Sức chứa 8, Trống
('Bàn 16', 4, 1),  -- Bàn 16, Sức chứa 4, Trống
('Bàn 17', 10, 1), -- Bàn 17, Sức chứa 10, Trống
('Bàn 18', 2, 1),  -- Bàn 18, Sức chứa 2, Trống
('Bàn 19', 6, 1),  -- Bàn 19, Sức chứa 6, Trống
('Bàn 20', 4, 1),  -- Bàn 20, Sức chứa 4, Trống
('Bàn 21', 4, 1),  -- Bàn 21, Sức chứa 4, Trống
('Bàn 22', 2, 1),  -- Bàn 22, Sức chứa 2, Trống
('Bàn 23', 6, 1),  -- Bàn 23, Sức chứa 6, Trống
('Bàn 24', 4, 1),  -- Bàn 24, Sức chứa 4, Trống
('Bàn 25', 8, 1),  -- Bàn 25, Sức chứa 8, Trống
('Bàn 26', 4, 1),  -- Bàn 26, Sức chứa 4, Trống
('Bàn 27', 10, 1), -- Bàn 27, Sức chứa 10, Trống
('Bàn 28', 2, 1),  -- Bàn 28, Sức chứa 2, Trống
('Bàn 29', 6, 1),  -- Bàn 29, Sức chứa 6, Trống
('Bàn 30', 4, 1),  -- Bàn 30, Sức chứa 4, Trống
('Bàn 31', 4, 1),  -- Bàn 31, Sức chứa 4, Trống
('Bàn 32', 2, 1),  -- Bàn 32, Sức chứa 2, Trống
('Bàn 33', 6, 1),  -- Bàn 33, Sức chứa 6, Trống
('Bàn 34', 4, 1),  -- Bàn 34, Sức chứa 4, Trống
('Bàn 35', 8, 1);  -- Bàn 35, Sức chứa 8, Trống

ALTER TABLE Orders
DROP CONSTRAINT FK_Orders_Customers; 

DROP TABLE Customers;