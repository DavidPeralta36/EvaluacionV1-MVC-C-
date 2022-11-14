use master

create database Proyecto

use Proyecto

CREATE TABLE Roles (
IdRol INT PRIMARY KEY NOT NULL,
NombreRol VARCHAR(40) NOT NULL
)
/*
drop table Roles
drop table Trabajadores
drop table Reportes*/

insert Roles  values (1, 'Jefe de centro de Computo');
insert Roles  values (2, 'Jefe del 햞ea Verificada');

select * from Roles


CREATE TABLE Reportes (
IdReporte INT PRIMARY KEY NOT NULL,
Equipo VARCHAR(40) NOT NULL,
AccionRealizar VARCHAR(40) NOT NULL,
Atencion VARCHAR(40) NOT NULL,
)

insert Reportes  values (1, 'Pc', 'Formateo', 'Interna');
insert Reportes  values (2, 'Switch', 'Configuracion', 'Interna');
insert Reportes  values (3, 'Cableado', 'Enterrarlos', 'Externa');
insert Reportes  values (4, 'Router', 'Mantenimiento', 'Externo');

select * from Reportes


CREATE TABLE Trabajadores (
IdTrabajador INT PRIMARY KEY NOT NULL,
Nombre VARCHAR(40) NOT NULL,
Apaterno VARCHAR(40) NOT NULL,
Amaterno VARCHAR(40) NOT NULL,
Rol VARCHAR(40) NOT NULL,
)



insert Trabajadores  values (1, 'Juan Luis', 'Mendez', 'Perez','Jefe del 햞ea Verificada');
insert Trabajadores  values (2, 'Ana Laura', 'Rodrigues', 'Fernandez','Jefe del 햞ea Verificada');
insert Trabajadores  values (3, 'Daniel Jose', 'Hernandez', 'Mendoza','Jefe del 햞ea Verificada');
insert Trabajadores  values (4, 'Viridiano del jesus', 'de la sagrada congregacion', 'De jesus Mendez Martines', 'Jefe de centro de Computo');


select * from Trabajadores