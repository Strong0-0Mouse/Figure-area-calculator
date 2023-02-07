CREATE SCHEMA Test_mindbox
GO

CREATE TABLE Test_mindbox.Product
(
    Id INT PRIMARY KEY IDENTITY,
    Title nvarchar(30)
)
GO

CREATE TABLE Test_mindbox.Category
(
    Id INT PRIMARY KEY IDENTITY,
    Title nvarchar(30)
)
GO

CREATE TABLE Test_mindbox.ProductCategory
(
    Id INT PRIMARY KEY IDENTITY,
    ProductId INT REFERENCES Test_mindbox.Product(Id) ON DELETE CASCADE,
    CategoryId INT REFERENCES Test_mindbox.Category(Id) ON DELETE CASCADE
)