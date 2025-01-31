
GO
CREATE VIEW ProductStockView AS
SELECT 
    ProductID, 
    ProductName, 
    Stock, 
    Price 
FROM Products;


Go
CREATE VIEW SalesReportView AS
SELECT 
    s.SaleID, 
    p.ProductName, 
    s.Quantity, 
    s.TotalAmount, 
    s.SaleDate
FROM Sales s
JOIN Products p ON s.ProductID = p.ProductID;
