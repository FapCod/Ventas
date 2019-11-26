use Ventas
INSERT INTO Venta VALUES(123,'22/11/2019',1,'B',13,'B')
select * from venta
create procedure registrarVenta(
@idventa int,
@fecha date, 
@idcliente int, 
@tipodoc char(1),
@monto float,
@estado char(1) )
as
begin
insert into venta values (@idventa, @fecha, @idcliente, @tipodoc,@monto,@estado) 
end 

create procedure registrarDV(
@idproducto char(8),
@idventa int,
@cantidad int,
@costo float)
as
begin 
insert into detalleVenta values(@idproducto,@idventa,@cantidad,@costo)
end
delete from  detalleventa
delete from venta
select * from venta
select * from detalleVenta
