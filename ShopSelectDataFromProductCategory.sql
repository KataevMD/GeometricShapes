USE [master]
GO
CREATE DATABASE [Shops]
GO
USE [Shops]
GO
CREATE TABLE [Product](
[ProductID] int PRIMARY KEY IDENTITY(1,1),
[Title] nvarchar(50) NOT NULL
);

CREATE TABLE [Category](
[CategoryID] int PRIMARY KEY IDENTITY(1,1),
[Title] nvarchar(50) NOT NULL
);

CREATE TABLE [ProductCategory](
[CategoryID] int,
[ProductID] int,
FOREIGN KEY (ProductID) REFERENCES Product(ProductID),
FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID),
PRIMARY KEY (ProductID, CategoryID)
);
GO
USE [Shops]
GO
INSERT INTO [Product] (Title) VALUES
('�������'),
('��������� ���������'),
('�������'),
('�������'),
('������'),
('�������������'),
('�������� � ������ ��������'),
('������� ������'),
('���������� ������'),
('��������')
;
GO
INSERT INTO Category(Title) VALUES
('������� ���'),
('���� � ����� ��������'),
('�����'),
('��� ������� � ������'),
('�� �������')
;
GO
INSERT INTO ProductCategory ([CategoryID], ProductID) VALUES
(1, 1),
(1, 2),
(2, 8),
(2, 9),
(3, 8),
(3, 9),
(4, 4),
(5, 1),
(5, 2),
(5, 4)
;
GO
--������ ��������� ��� ���� �������� ��������� � ���������, ��� ��� ���� � �������� ��� ��������� �� ����� ���������
--�������� ��� ��� ������ LEFT JOIN: � ���� ������ ���������� ��� ������ ������ (����� �������), � ����� ������ ��� ������� ���������,
--����� � ������� LEFT JOIN ����������� ������ �� ������� ProductCategory, ��� ����� ����� ��������� ������ ���, ����� ������ ������� 
--�������������� ������ �������������� � ������� ProductCategory, ���� ���� � ���� ��� ���������
--����� LEFT JOIN  ��� ������� Category ��������� ����������� ��������� � �� ����������������.
SELECT Product.Title, Category.Title FROM Product 
LEFT JOIN ProductCategory ON Product.ProductID = ProductCategory.ProductID 
LEFT JOIN Category on ProductCategory.CategoryID = Category.CategoryID;

