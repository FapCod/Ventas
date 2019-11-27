delete producto  where idproducto=2
delete  venta
delete detalleVenta
select * from venta
select * from detalleVenta
--drop procedure buscardt
--buscamos detalleventa
create procedure buscardt(
@idventa int 
)
as 
begin
SELECT dbo.detalleVenta.idproducto, dbo.producto.nomproducto,  dbo.detalleVenta.cantidad, dbo.detalleVenta.costo, cantidad*costo as subtotal
FROM     dbo.detalleVenta INNER JOIN
                  dbo.producto ON dbo.detalleVenta.idproducto = dbo.producto.idproducto
				  where dbo.detalleVenta.idventa=@idventa
				  end 

---listamos la venta
create procedure listarventa
as 
begin
SELECT dbo.Venta.idventa, dbo.Venta.fecha, dbo.Venta.idcliente, dbo.Venta.tipodoc, dbo.Venta.monto, dbo.Venta.estado, dbo.Cliente.nombre
FROM     dbo.Venta INNER JOIN
                  dbo.Cliente ON dbo.Venta.idcliente = dbo.Cliente.idCliente
				  end 

--drop procedure buscarVentas
create procedure buscarVentas(
@idventa int 
)
as 
begin
SELECT dbo.Venta.idventa, dbo.Venta.fecha, dbo.Venta.idcliente, dbo.Venta.tipodoc, dbo.Venta.monto, dbo.Venta.estado, dbo.Cliente.nombre
FROM     dbo.Venta INNER JOIN
                  dbo.Cliente ON dbo.Venta.idcliente = dbo.Cliente.idCliente
				  where dbo.Venta.idventa=@idventa
				  end 