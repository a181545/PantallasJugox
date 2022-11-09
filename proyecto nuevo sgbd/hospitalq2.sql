--Insertar datos en la table Dept
INSERT INTO Dept(Dept_No,DNombre,Loc) VALUES(10,'CONTABILIDAD','ELCHE')
INSERT INTO Dept(Dept_No,DNombre,Loc) VALUES(20,'INVESTIGACIÓN','MADRID')
INSERT INTO Dept(Dept_No,DNombre,Loc) VALUES(30,'VENTAS','BARCELONA')
INSERT INTO Dept(Dept_No,DNombre,Loc) VALUES(40,'PRODUCCIÓN','SALAMANCA')
--Insertar datos en la tabla Emp
INSERT INTO Emp( Emp_No, Apellido, Oficio, Dir, Fecha_Alt, Salario, Comision, Dept_No)
VALUES
(7566,'JIMENEZ','DIRECTOR',7839,'1981-04-02 00:00:00',386750,0,20),
(7654,'MARTIN','VENDEDOR',7698,'1981-09-28 00:00:00',182000,182000,30),
(7698,'NEGRO','DIRECTOR',7839,'1981-05-01 00:00:00',370500,0,30),
(7782,'CEREZO','DIRECTOR',7839,'1981-06-09 00:00:00',318500,0,10),
(7788,'NINO','ANALISTA',7566,'1987-03-30 00:00:00',390000,0,20),
(7839,'REY','PRESIDENTE',0,'1981-11-17 00:00:00',650000,0,10),
(7844,'TOVAR','VENDEDOR',7698,'1981-09-08 00:00:00',195000,0,30),
(7876,'ALONSO','EMPLEADO',7788,'1987-05-03 00:00:00',143000,0,20),
(7900,'JIMENO','EMPLEADO',7698,'1981-12-03 00:00:00',123500,0,30),
(7902,'FERNANDEZ','ANALISTA',7566,'1981-12-03',390000,0,20),
(7934,'MUÑOZ','EMPLEADO',7782,'1982-06-23 00:00:00',169000,0,10),
(7119,'SERRA','DIRECTOR',7839,'1983-11-19 00:00:00',225000,39000,20),
(7322,'GARCIA','EMPLEADO',7119,'1982-10-12 00:00:00',129000,0,20)
--Insertar datos en la tabla Hospital
INSERT INTO Hospital(Hospital_Cod,Nombre,Direccion,Telefono, Num_Cama)
VALUES(19,'Provincial','O Donell 50','964-4256',502)
INSERT INTO Hospital(Hospital_Cod,Nombre,Direccion,Telefono, Num_Cama)
VALUES(18,'General','Atocha s/n','595-3111',987)
INSERT INTO Hospital(Hospital_Cod,Nombre,Direccion,Telefono, Num_Cama) VALUES(22,'La
Paz','Castellana 1000','923-5411',412)
INSERT INTO Hospital(Hospital_Cod,Nombre,Direccion,Telefono, Num_Cama) VALUES(45,'San
Carlos','Ciudad Universitaria','597-1500',845)
--Insertar datos en la tabla Doctor
INSERT INTO Doctor(Hospital_Cod,Doctor_No,Apellido,Especialidad) VALUES(22,386,'Cabeza
D.','Psiquiatría')
INSERT INTO Doctor(Hospital_Cod,Doctor_No,Apellido,Especialidad) VALUES(22,398,'Best
D.','Urología')
INSERT INTO Doctor(Hospital_Cod,Doctor_No,Apellido,Especialidad) VALUES(19,435,'López
A.','Cardiología')
INSERT INTO Doctor(Hospital_Cod,Doctor_No,Apellido,Especialidad) VALUES(22,453,'Galo
D.','Pediatría')
INSERT INTO Doctor(Hospital_Cod,Doctor_No,Apellido,Especialidad) VALUES(45,522,'Adams
C.','Neurología')
INSERT INTO Doctor(Hospital_Cod,Doctor_No,Apellido,Especialidad) VALUES(18,585,'Miller
G.','Ginecología')
INSERT INTO Doctor(Hospital_Cod,Doctor_No,Apellido,Especialidad) VALUES(45,607,'Chuki
P.','Pediatría')
INSERT INTO Doctor(Hospital_Cod,Doctor_No,Apellido,Especialidad) VALUES(18,982,'Cajal
R.','Cardiología')