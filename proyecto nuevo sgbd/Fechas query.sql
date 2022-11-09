create procedure NuevaFecha
@nfecha date
as
insert into fechas values (@nfecha)
go

exec NuevaFecha '2022-02-02'

select * from fechas