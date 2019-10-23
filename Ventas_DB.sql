create database Ventas
use Ventas
create table usuario(
idusuario varchar (15) Primary Key not null,
nomusuario varchar(50),
clave char(8) ,
tipo varchar (20), 
estado bit 
)
INSERT INTO usuario VALUES('Fra123','Frank','12345678','Administrador',1)
INSERT INTO usuario VALUES('Fra1234','Frank','12345678','Administrador',0)
INSERT INTO usuario VALUES('Fra12345','Frank1','12345678','Administrador',0)
select * from usuario
SELECT estado FROM usuario WHERE nomusuario='Frank' AND clave=12345678
create table categoria (
idcategoria int IDENTITY (1,1) primary key not null, 
nomcategoria varchar (30),
estado bit 
)
INSERT INTO categoria VALUES('Abarrotes',1)
INSERT INTO categoria VALUES('Utilez de Oficina',1)
INSERT INTO categoria VALUES('Materiales de Limpieza',1)
INSERT INTO categoria VALUES('Lacteos',0)
Select * from categoria

create table producto (
idproducto char(5) primary key not null, 
nomproducto varchar (30),
precioventa float,
stock int ,
presentacion varchar (50), 
estado bit ,
idcategoria int
CONSTRAINT fk_categoria FOREIGN KEY (idcategoria) REFERENCES categoria (idcategoria)
)

INSERT INTO producto VALUES('Pro123','Escoba',12.3,12,'Pequeña',1)
