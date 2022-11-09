use Tienda

insert into Venta values(1, 1, 501)
select * from Venta

--ej1
select nombre from Clientes where ciudad ='Tampico'

--ej2 Obtener descripción, precio y nombre del cliente que compro cada producto
select descripcion, precio, nombre from Producto, Clientes

--ej3
select Clientes.nombre, Venta.idventa, Venta.cantidad from Clientes, Venta where Clientes.ncliente = Venta.ncliente and Venta.cantidad>500

--ej4 Obtener nombre del cliente, descripción de producto y cantidad de todas las ventas
select nombre, descripcion, cantidad from Clientes, Producto, Venta

--ej5
select nombre from Clientes where (select count(distinct codproducto) from Venta where Clientes.ncliente = Venta.ncliente) = (select count(*) from Producto)

--ej6
select idventa from Venta where (select cantidad from Venta where idventa = 18) > (select cantidad from Venta)

--ej7 Obtener los mismos datos que en el ejercicio 4, más el precio total a pagar por cada idventa
select idventa, nombre, descripcion, cantidad, (precio)*cantidad as 'Total a pagar' from Clientes, Producto, Venta

--ej8
select codproducto, Clientes.ciudad from Producto, Clientes where ciudad = 'Tampico' and ciudad = 'Cd. Madero'

--ej9
select ciudad from Clientes, Venta where cantidad >=1000

--ej10
select distinct(Clientes.nombre) from Venta,Clientes where Venta.ncliente = Clientes.ncliente

--tabla ciudad
--create table Ciudad (idciudad int primary key identity (1,1), ciudad varchar(50) not null)

select * from Ciudad

insert into Ciudad values ('Altamira')
--tabla ciudad
