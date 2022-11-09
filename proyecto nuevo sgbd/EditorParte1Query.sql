create procedure InsertarEspPrim
@procesador nvarchar(100),
@placa_madre nvarchar(100),
@graficos nvarchar(100),
@memoria_ram int,
@ventiladores int,
@fuente_poder nvarchar(100)
as
insert into Especif_Principales values (@procesador, @placa_madre, @graficos, @memoria_ram, @ventiladores, @fuente_poder)
go

exec InsertarEspPrim 'Intel core i5 10400f','asus b460m','nvidia gtx 1660 oc',16,4,'bequiet! 500 W 80PLUS Bronze'

select * from Especif_Principales