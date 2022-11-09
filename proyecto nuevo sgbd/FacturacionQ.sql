use facturacion


select idpro, nombre from Provincias

select nombre, idpro from Provincias

select idart, 2*precio from Articulos

select idfac, linea, precio from Lineas_fac

select Lineas_fac.idfac, linea, precio-(precio*Facturas.descu)+(precio*Facturas.iva) from Lineas_fac, Facturas

select distinct iva from Facturas
select idpro, nombre from Provincias where idpro < 5

select distinct descu from Facturas where idven <= 50

select idart, descrip from Articulos where stock >= 20

select idfac, fecha from Facturas where iva = 16 and idcli = 10

select idfac, fecha from Facturas where (descu= 20 or iva = 16) and idcli = 5

select idfac, linea from Lineas_fac where precio>100

select idven, nombre from Vendedores where idjefe = 125 

select idart, descrip from Articulos where stock > 50

select distinct idcli from Facturas where idfac < 50