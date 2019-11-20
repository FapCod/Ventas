

create table Venta(
idventa int primary key not null,
fecha date,
idcliente int,
tipodoc char (1),
monto float,
estado char(1)
CONSTRAINT fk_cliente FOREIGN KEY (idcliente) REFERENCES Cliente (idcliente)
)

drop table Venta


------
drop table detalleVenta
create table detalleVenta(
idproducto char(5) ,
idventa int ,
cantidad int,
costo float
CONSTRAINT fk_producto FOREIGN KEY  (idproducto) REFERENCES producto (idproducto),
CONSTRAINT fk_venta FOREIGN KEY  (idventa) REFERENCES Venta (idventa),
primary key (idproducto, idventa)
)