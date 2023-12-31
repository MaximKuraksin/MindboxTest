# Тестовое задание Mindbox
## Задание 1
> Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
> - Юнит-тесты
> - Легкость добавления других фигур
> - Вычисление площади фигуры без знания типа фигуры в compile-time
> - Проверку на то, является ли треугольник прямоугольным

Для выполнения данного задания было создано решение SimpleGeometry. Данное решение содержит:
- Проект SimpleGeometry - библиотека с необходимым функционалом
- Проект SimpleGeometry.Tests - Unit-тесты

## Задание 2
> В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – > Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Представим, что продукты и категории представлены следующими таблицами:
- Products (Id, Name)
- Categories (Id, Name)
- Products_Categories (ProductId, CategoryId)

### Запросы на создание таблиц в БД MS SQL Server
~~~sql
CREATE TABLE Products (
    Id int NOT NULL PRIMARY KEY,
    Name varchar(255) NOT NULL,
);

CREATE TABLE Categories (
    Id int NOT NULL PRIMARY KEY,
    Name varchar(255) NOT NULL,
);

CREATE TABLE ProductsCategories (
    ProductId int NOT NULL FOREIGN KEY REFERENCES Products(Id),
    CategoryId int NOT NULL FOREIGN KEY REFERENCES Categories(Id),
    CONSTRAINT PK_ProductsCategories PRIMARY KEY (ProductId, CategoryId)
);
~~~

### Запросы на вставку записей в таблицы
~~~sql
INSERT INTO Products
           (Id
           ,Name)
     VALUES
          (1, 'Продукт 1'),
          (2, 'Продукт 2'),
          (3, 'Продукт 3'),
          (4, 'Продукт 4')


INSERT INTO Categories
           (Id
           ,Name)
     VALUES
          (1, 'Категория 1'),
          (2, 'Категория 2'),
          (3, 'Категория 3')

INSERT INTO ProductsCategories
           (ProductId
           ,CategoryId)
     VALUES
          (1, 1),
          (1, 2),
          (2, 1),
          (2, 3),
          (3, 2)
~~~
### Запрос на выборку данных 1
~~~sql
SELECT p.Name AS Product, c.Name AS Category FROM Products AS p
LEFT JOIN ProductsCategories AS pc ON p.Id = pc.ProductId
LEFT JOIN Categories AS c ON c.Id = pc.CategoryId
~~~

### Запрос на выборку данных 2 (вывод всех категорий через запятую для каждого продукта)
~~~sql
SELECT p.Name AS Product, STRING_AGG(c.Name, ', ') AS Categories FROM Products AS p 
LEFT JOIN ProductsCategories AS pc ON p.Id = pc.ProductId 
LEFT JOIN Categories AS c ON c.Id = pc.CategoryId GROUP BY p.Name
~~~
