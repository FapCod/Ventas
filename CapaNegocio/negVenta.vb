Imports CapaDatos
Imports CapaEntidad
Public Class negVenta
    Public Function nuevaVenta(objent As entVenta) As Boolean
        'Dim validar As Boolean = False
        Dim objdat As New datVenta
        'Dim objdatdv As New datDetalleVenta
        'Dim objentdv As New entDetalleVenta
        Dim validar = objdat.nuevaVenta(objent)
        'If (validar) Then
        '    'MsgBox("ingresa al neg")
        '    For a = 0 To objent.detallev.Count - 1
        '        objentdv.idproducto = objent.detallev.Item(a).idproducto
        '        objentdv.idventa = objent.detallev.Item(a).idventa
        '        objentdv.cantidad = objent.detallev.Item(a).cantidad
        '        objentdv.costo = objent.detallev.Item(a).costo
        '        MsgBox(objentdv.idproducto)
        '        validar = objdatdv.detalleVenta(objentdv)
        '    Next
        'Else
        '    MsgBox("Error en ingreso de venta")

        'End If
        Return validar
    End Function
    Public Function detalleVenta(objent As entDetalleVenta) As Boolean
        Dim objdat As New datDetalleVenta
        Return objdat.detalleVenta(objent)
    End Function
    Public Function listar() As DataTable
        Dim objdat As New datVenta
        Return objdat.listar()
    End Function
    Public Function listardgv(id As Integer) As DataTable
        Dim objdat As New datVenta
        Return objdat.listardgv(id)
    End Function
    Public Function buscar(id As Integer) As DataTable
        Dim objdat As New datVenta
        Return objdat.buscar(id)
    End Function
End Class
