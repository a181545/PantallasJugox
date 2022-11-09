use mitienda

--create table Fabricantes (codigo int primary key identity (1,1), nombre varchar(100) not null)
--create table Articulos (codigo int primary key identity (1,1), nombre varchar(100) not null, precio money not null, fabricante int not null)

--ej1
select nombre from Articulos

--ej2
select nombre, precio from Articulos

--ej3
select nombre from Articulos where precio <= 200

--ej4
select * from Articulos where precio >= 60 and precio <= 120
--select * from Articulos where precio >= 60 and precio <= 120

--ej5
select nombre, (precio)*0.049 as 'precioendolar' from Articulos

--lol
select precio, Fabricantes.codigo from Articulos, Fabricantes
--ej6
select precio, Fabricantes.nombre from Articulos, Fabricantes where precio >= 150

--ej7
insert into Articulos (nombre, precio, fabricante) values ('No Break 480W 800VA', 1000, 3), ('Fuente de Poder 500W', 1200, 4), ('WebCam 720p', 700, 5), ('Monitor Gamer 24.5" 75hz', 4000, 6), ('Celular V20 Smart', 4500, 7)
insert into Fabricantes (nombre) values ('Vorago'), ('bequiet!'), ('Logitech'), ('GameFactor'), ('ZTE')
--ej8
update Articulos set precio = precio - (precio*0.10)
select * from Articulos

--ej9
update Articulos set nombre = 'Impresora Laser' where codigo = 8

--ej10
update Articulos set precio = precio - (precio*0.15) where precio >= 200