--1 Listado de las órdenes y el nombre del cliente
select OrderID, OrderDate, ShipCity, ShipCountry, ContactName from Orders INNER JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID

select OrderID, OrderDate, ShipCity, ShipCountry, ContactName from Orders LEFT JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID

select OrderID, OrderDate, ShipCity, ShipCountry, ContactName from Orders RIGHT JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID

select OrderID, OrderDate, ShipCity, ShipCountry, ContactName from Orders FULL JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID

--2 Listado de las órdenes y el nombre del empleado que las generó
select OrderID, OrderDate, ShipCity, ShipCountry, FirstName, LastName from Orders INNER JOIN Employees 
ON Orders.EmployeeID = Employees.EmployeeID

select OrderID, OrderDate, ShipCity, ShipCountry, FirstName, LastName from Orders LEFT JOIN Employees 
ON Orders.EmployeeID = Employees.EmployeeID

select OrderID, OrderDate, ShipCity, ShipCountry, FirstName, LastName from Orders RIGHT JOIN Employees 
ON Orders.EmployeeID = Employees.EmployeeID

select OrderID, OrderDate, ShipCity, ShipCountry, FirstName, LastName from Orders FULL JOIN Employees 
ON Orders.EmployeeID = Employees.EmployeeID

--3 Listado de las órdenes y los nombres del cliente y del empleado que las género
select OrderID, OrderDate, ShipCity, ShipCountry, ContactName, FirstName, LastName from Orders INNER JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID INNER JOIN Employees 
ON Orders.EmployeeID = Employees.EmployeeID

select OrderID, OrderDate, ShipCity, ShipCountry, ContactName, FirstName, LastName from Orders LEFT JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID LEFT JOIN Employees 
ON Orders.EmployeeID = Employees.EmployeeID

select OrderID, OrderDate, ShipCity, ShipCountry, ContactName, FirstName, LastName from Orders RIGHT JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID RIGHT JOIN Employees 
ON Orders.EmployeeID = Employees.EmployeeID

select OrderID, OrderDate, ShipCity, ShipCountry, ContactName, FirstName, LastName from Orders FULL JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID FULL JOIN Employees 
ON Orders.EmployeeID = Employees.EmployeeID

--4 Listado de los productos y su categoría
select ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, CategoryName from Products INNER JOIN Categories 
ON Products.CategoryID = Categories.CategoryID

select ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, CategoryName from Products LEFT JOIN Categories 
ON Products.CategoryID = Categories.CategoryID

select ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, CategoryName from Products RIGHT JOIN Categories 
ON Products.CategoryID = Categories.CategoryID

select ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, CategoryName from Products FULL JOIN Categories 
ON Products.CategoryID = Categories.CategoryID

--5 El detalle de una orden específica, incluyendo el nombre del producto
select OrderID, Quantity, Discount, ProductName from [Order Details] INNER JOIN Products 
ON [Order Details].ProductID = Products.ProductID

select OrderID, Quantity, Discount, ProductName from [Order Details] LEFT JOIN Products 
ON [Order Details].ProductID = Products.ProductID

select OrderID, Quantity, Discount, ProductName from [Order Details] RIGHT JOIN Products 
ON [Order Details].ProductID = Products.ProductID

select OrderID, Quantity, Discount, ProductName from [Order Details] FULL JOIN Products 
ON [Order Details].ProductID = Products.ProductID

--6 Listado de órdenes y las compañías de envío
select OrderID, OrderDate, ShipCity, ShipCountry, CompanyName from Orders INNER JOIN Shippers 
ON Orders.ShipID = Shippers.ShipperID

select OrderID, OrderDate, ShipCity, ShipCountry, CompanyName from Orders LEFT JOIN Shippers 
ON Orders.ShipID = Shippers.ShipperID

select OrderID, OrderDate, ShipCity, ShipCountry, CompanyName from Orders RIGHT JOIN Shippers 
ON Orders.ShipID = Shippers.ShipperID

select OrderID, OrderDate, ShipCity, ShipCountry, CompanyName from Orders FULL JOIN Shippers 
ON Orders.ShipID = Shippers.ShipperID

--7 Incluir en el ejercicio anterior el nombre del empleado que género la orden y el cliente
select OrderID, OrderDate, ShipCity, ShipCountry, ContactName from Orders INNER JOIN Shippers 
ON Orders.ShipID = Shippers.ShipperID INNER JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID INNER JOIN Employees 
ON Orders.EmployeeID = Employees.EmployeeID

select OrderID, OrderDate, ShipCity, ShipCountry, ContactName from Orders LEFT JOIN Shippers 
ON Orders.ShipID = Shippers.ShipperID LEFT JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID LEFT JOIN Employees 
ON Orders.EmployeeID = Employees.EmployeeID

select OrderID, OrderDate, ShipCity, ShipCountry, ContactName from Orders RIGHT JOIN Shippers 
ON Orders.ShipID = Shippers.ShipperID RIGHT JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID RIGHT JOIN Employees 
ON Orders.EmployeeID = Employees.EmployeeID

select OrderID, OrderDate, ShipCity, ShipCountry, ContactName from Orders FULL JOIN Shippers 
ON Orders.ShipID = Shippers.ShipperID FULL JOIN Customers 
ON Orders.CustomerID = Customers.CustomerID FULL JOIN Employees 
ON Orders.EmployeeID = Employees.EmployeeID

--8 Listado de productos y el proveedor
select ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, CompanyName, ContactName from Products INNER JOIN Suppliers 
ON Products.SupplierID = Suppliers.SupplierID

select ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, CompanyName, ContactName from Products LEFT JOIN Suppliers 
ON Products.SupplierID = Suppliers.SupplierID

select ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, CompanyName, ContactName from Products RIGHT JOIN Suppliers 
ON Products.SupplierID = Suppliers.SupplierID

select ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, CompanyName, ContactName from Products FULL JOIN Suppliers 
ON Products.SupplierID = Suppliers.SupplierID