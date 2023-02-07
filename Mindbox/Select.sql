SELECT p.Title as ProductName, c.Title as CategoryName FROM Test_mindbox.Product as p
    LEFT JOIN Test_mindbox.ProductCategory as pc ON pc.ProductId = p.Id
    LEFT JOIN Test_mindbox.Category as c ON c.Id = pc.CategoryId