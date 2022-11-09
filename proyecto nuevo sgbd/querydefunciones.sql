use tareaJOIN
go

SELECT AVG(UnitPrice) AS AvgPrice FROM Products

SELECT MAX(UnitPrice) AS MaxPrice FROM Products

SELECT MIN(UnitPrice) AS MaxPrice FROM Products

SELECT COUNT(ProductName) AS TotalProducts FROM Products

SELECT SUM(UnitsInStock) AS ProductsInStock FROM Products

SELECT SUM(UnitPrice*Quantity) AS TotalAmount FROM [Order Details]

SELECT MAX(UnitsInStock) AS MaximoStock FROM Products 
SELECT MIN(UnitsInStock) AS MinimoStock FROM Products 

SELECT COUNT(Quantity) AS Sells FROM [Order Details] WHERE ProductID = 1

--9 Obtener la cantidad de órdenes generadas y el monto total vendido de un empleado específico.
SELECT SUM(UnitPrice*Quantity) AS TotalAmount FROM [Order Details]
SELECT COUNT(Orders.OrderID) AS SellsGen FROM [Orders] WHERE EmployeeID = 1


--10 Obtener las órdenes generadas para un año específico.
SELECT COUNT(Orders.OrderID) AS SellsGen FROM [Orders] WHERE OrderDate BETWEEN '2022-01-01 00:00:00.000' AND  '2022-12-31 00:00:00.000'