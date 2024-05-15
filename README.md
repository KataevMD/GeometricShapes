# GeometricShapes
Данный проект предназначен для ответа на вопрос 2 по выполнению практического задания:

Задание:
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

Вопрос №3: 

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Ответ:

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
('Панкейк'),
('Творожная запеканка'),
('Сэндвич'),
('Помидор'),
('Огурце'),
('Чертезнаетчто'),
('Блинчики с сырной начинкой'),
('Овсяные хлопья'),
('Кукурузные хлопья'),
('Доместос')
;
GO
INSERT INTO Category(Title) VALUES
('Готовая еда'),
('Каши и сухие завтраки'),
('Злаки'),
('Для яичницы и омлета'),
('На завтрак')
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
--Запрос выводящий все пары названий продуктов и категорий, при это если у продукта нет категории он также выводится
--Делается это при помощи LEFT JOIN: В этом случае выбираются все записи первой (левой таблицы), в нашем случае это таблица Продуктов,
--затем с помощью LEFT JOIN добавляются данные из таблицы ProductCategory, это нужно чтобы соединить строки так, чтобы каждый продукт 
--соответствовал своему идентификатору в таблице ProductCategory, даже если у него нет категории
--после LEFT JOIN  для таблицы Category позволяет сопоставить категории с их идентификаторами.
SELECT Product.Title, Category.Title FROM Product 
LEFT JOIN ProductCategory ON Product.ProductID = ProductCategory.ProductID 
LEFT JOIN Category on ProductCategory.CategoryID = Category.CategoryID;

