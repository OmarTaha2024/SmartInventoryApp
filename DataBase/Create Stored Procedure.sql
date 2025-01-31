
Go
CREATE PROCEDURE GetLowStockProducts
AS
BEGIN
    SELECT ProductID, ProductName, Stock
    FROM Products
    WHERE Stock < 10;
END;
Go
CREATE PROCEDURE AddNewSale
    @ProductID INT,
    @Quantity INT
AS
BEGIN
    DECLARE @Price DECIMAL(10, 2);

    -- Get product price
    SELECT @Price = Price FROM Products WHERE ProductID = @ProductID;

    -- Insert into Sales
    INSERT INTO Sales (ProductID, Quantity, TotalAmount, SaleDate)
    VALUES (@ProductID, @Quantity, @Price * @Quantity, GETDATE());

    -- Update Product Stock
    UPDATE Products
    SET Stock = Stock - @Quantity
    WHERE ProductID = @ProductID;
END;

Go
CREATE PROCEDURE AddProduct
    @ProductName NVARCHAR(100),
    @Price DECIMAL(10, 2),
    @Stock INT
AS
BEGIN
    INSERT INTO Products (ProductName, Price, Stock, CreatedDate)
    VALUES (@ProductName, @Price, @Stock, GETDATE());
END;
Go
CREATE PROCEDURE UpdateProduct
    @ProductId INT,
    @ProductName NVARCHAR(100),
    @Price DECIMAL(10, 2),
    @Stock INT
AS
BEGIN
    UPDATE Products
    SET ProductName = @ProductName, Price = @Price, Stock = @Stock
    WHERE ProductId = @ProductId;
END;



