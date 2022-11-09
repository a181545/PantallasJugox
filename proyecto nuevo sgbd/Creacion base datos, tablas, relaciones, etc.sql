create database Mantenimiento_PC_UNE
go

use Mantenimiento_PC_UNE
go

--tablas
create table Aula(
id_aula int not null primary key identity (1,1),
aula nchar (15) not null
)
go

create table Equipos(
id_equipo int not null primary key identity(1,1),
equipo nchar(12) not null,
especificaciones nvarchar(255) not null,
condiciones nvarchar(15) not null,
id_aula int not null
constraint fk_Aula_Equipos foreign key (id_aula) references Aula(id_aula)
)
go

create table Reportes(
num_reporte int not null primary key identity(1,1),
detalles nvarchar(255) not null,
id_equipo int not null
constraint fk_Equipos_Reportes foreign key (id_equipo) references Equipos(id_equipo)
)
go


insert into Aula values ('Aula 5.1'), ('Aula 5.2'), ('Aula 5.3'), ('Aula 5.4'), ('Aula Mac')
go

select * from Aula
go

insert into Equipos values ('academ500','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',1), ('academ501','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',1),
('academ502','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',1), ('academ503','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',1),
('academ514','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',2), ('academ515','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',2),
('academ516','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',2), ('academ517','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',2),
('academ528','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',3), ('academ529','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',3),
('academ530','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',3), ('academ531','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',3),
('academ542','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',4), ('academ543','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',4),
('academ544','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',4), ('academ545','Intel Core i5 3400, 8 GB ram, 500 GB HDD','Buena',4),
('mac21','Intel Core i5 7000, 8 GB ram, 500 GB SSD','Buena',5), ('mac22','Intel Core i5 7000, 8 GB ram, 500 GB SSD','Buena',5)
go

select * from Equipos
go

insert into Reportes values ('Poco almacenamiento disponible', 'En proceso', 1), ('Poco almacenamiento disponible', 'Terminado',10), ('Poco almacenamiento disponible', 'En proceso',18)
go

select * from Reportes
go