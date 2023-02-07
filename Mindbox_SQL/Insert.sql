INSERT INTO Test_mindbox.Product (Title)
VALUES
    ('Product1'),
    ('Product2'),
    ('Product3'),
    ('Product4'),
    ('Product5')
GO

INSERT INTO Test_mindbox.Category (Title)
VALUES
    ('Category1'),
    ('Category2'),
    ('Category3'),
    ('Category4'),
    ('Category5')
GO

INSERT INTO Test_mindbox.ProductCategory (ProductId, CategoryId)
VALUES
    (1, 1),
    (2, 2),
    (3, 3),
    (4, 4),
    (1, 3)