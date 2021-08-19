


select * from [order details]

select
	OrderId, UnitPrice * Quantity PrecioTotal
FROM [order details]

-- Suma agrupado por lo que defina en "group by"
select orderid, SUM(UnitPrice * Quantity) Total from [order details]
group by orderid

-- Count: cuenta cuantas veces aparece un valor

select orderid, COUNT(orderid) Cantidad From [Order details] group by orderid

select count(orderid) from [order details]

select SUM(UnitPrice * Quantity) Total from [order details]

select productid, SUM(UnitPrice * Quantity) Total from [order details] group by productid

select productid, AVG(UnitPrice * Quantity) Promedio FROM [order details] group by productid

select Count(UnitPrice), UnitPrice from [order details] group by UnitPrice

select SUM(Discount) from [Order Details] group by orderid

select top 1 productid, MAX(Quantity) Total from [order details] group by productid order by Total DESC

select top 1 productid, MIN(Quantity) Total from [order details] group by productid order by Total DESC


select * from products

select top 1 productname,max(unitprice) Total from products group by productid,productname ORDER BY Total DESC



select orderid, SUM(Discount) Descuento from [Order Details] group by orderid having SUM(Discount) > 0


CREATE TABLE [MisOrdenes] (
	OrderID int IDENTITY PRIMARY KEY,
	ProductID int FOREIGN KEY REFERENCES Products(ProductID)
)

INSERT INTO MisOrdenes (ProductID) VALUES (1)

select * from products

select 
	OrderId,
	P.ProductId,
	P.ProductName,
	D.UnitPrice
from [order details] D
INNER JOIN Products P ON D.ProductID = P.ProductID

select
	O.OrderId,
	O.CustomerID,
	E.EmployeeID,
	E.LastName
FROM Orders O
LEFT JOIN Employees E ON O.EmployeeID = E.EmployeeID

select
	O.OrderId,
	O.CustomerID,
	E.EmployeeID,
	E.LastName
FROM Orders O
RIGHT JOIN Employees E ON O.EmployeeID = E.EmployeeID

select
	O.OrderId,
	O.CustomerID,
	E.EmployeeID,
	E.LastName
FROM Orders O
full JOIN Employees E ON O.EmployeeID = E.EmployeeID

Select * From Orders
Select * From Employees

