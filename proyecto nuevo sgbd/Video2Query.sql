use Video2

--insert into Alumno(nombre, apellidos) values ('Hugo', 'Ned'),('Emilio', 'De León')

--insert into Carrera(matricula, carrera) values (1, 'ISCE'), (2, 'ISCE')

--select * from Alumno

--select * from Carrera

create table Alumno (
	matricula int identity primary key,
	nombre varchar(50) not null,
	apellidos varchar(50) not null)

create table Carrera(
	idcarrera int identity primary key,
	matricula int not null,
	constraint fk_mat_alca foreign key (matricula) references Alumno(matricula),
	carrera varchar(50) not null)