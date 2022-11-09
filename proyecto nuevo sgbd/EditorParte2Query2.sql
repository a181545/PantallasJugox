create procedure MaximoIDPrueba as
select max(id_Especif_Prin) as ep, max(id_Almacenamiento) as al, max(id_Cond_Ext) as ce, max(id_conclusiones) as con from Especificaciones_Principales, Almacenamiento, Condiciones_externas, Conclusiones
go

exec MaximoIDPrueba
go

create procedure InsertarEquiposIDsPrueba 
@equipo nchar(12),
@idEspecifPrinF int,
@idCondExtF int,
@idAlmacenamiento int,
@idConclusiones int
as
insert into Equipos values (@equipo, @idEspecifPrinF, @idCondExtF, @idAlmacenamiento, @idConclusiones)
go

select * from Equipos
go


create procedure MostrarEspecificacionesPrincipales
as
select procesador as Procesador, placa_madre as [Placa Madre], graficos as Gráficos, memoria_ram as [Memoria RAM Total], 
n_ventiladores as [Nº de Ventiladores], tipo_fuente_poder as [Tipo de Fuente de Poder], potencia_fuente_poder as [Potencia FP (W)],
tipo_fuente_alimentacion as [Tipo de la Fuente de Alimentación], potencia_fuente_alimentacion as [Potencia FA (W)] from Especificaciones_Principales
