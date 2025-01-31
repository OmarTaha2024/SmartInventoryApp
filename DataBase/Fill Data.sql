INSERT INTO Products (ProductName, Price, Stock)
VALUES 
    ('Laptop - Dell Inspiron 15', 800.00, 50),
    ('Desktop - HP Pavilion 590', 600.00, 30),
    ('Monitor - Samsung 24" LED', 150.00, 75),
    ('Keyboard - Logitech Wireless', 20.00, 120),
    ('Mouse - HP Wired Optical', 10.00, 200),
    ('Printer - Canon PIXMA G3010', 180.00, 40),
    ('External HDD - WD 1TB', 60.00, 90),
    ('RAM - Corsair DDR4 8GB', 40.00, 100),
    ('Motherboard - ASUS Prime B550', 150.00, 20),
    ('Graphics Card - NVIDIA GTX 3060', 400.00, 10);


	INSERT INTO Suppliers (SupplierName, ContactNumber, Address)
VALUES 
    ('Tech Distributors Ltd.', '+123456789', '123 Tech Park, Silicon City'),
    ('Global Computers Supply', '+987654321', '56 IT Street, New York'),
    ('Hardware Hub', '+112233445', '99 Hardware Road, London'),
    ('Gadget Wholesale', '+665544332', '10 Electronics Lane, Dubai'),
    ('Pro Supplies Co.', '+778899001', '500 Supplies Ave, San Francisco');



	INSERT INTO Purchases (ProductID, SupplierID, Quantity, TotalCost)
VALUES 
    (1, 1, 20, 16000.00),
    (2, 2, 10, 6000.00),
    (3, 3, 25, 3750.00),
    (4, 4, 50, 1000.00),
    (5, 5, 100, 1000.00),
    (6, 1, 15, 2700.00),
    (7, 2, 40, 2400.00),
    (8, 3, 30, 1200.00),
    (9, 4, 10, 1500.00),
    (10, 5, 5, 2000.00);


	INSERT INTO Sales (ProductID, Quantity, TotalAmount)
VALUES 
    (1, 5, 4000.00),
    (2, 3, 1800.00),
    (3, 10, 1500.00),
    (4, 15, 300.00),
    (5, 25, 250.00),
    (6, 7, 1260.00),
    (7, 8, 480.00),
    (8, 10, 400.00),
    (9, 2, 300.00),
    (10, 1, 400.00);
