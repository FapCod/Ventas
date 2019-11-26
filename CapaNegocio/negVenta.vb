Imports CapaDatos
Imports CapaEntidad
Public Class negVenta
    Public Function nuevaVenta(objent As entVenta) As Boolean
        Dim objdat As New datVenta
        Return objdat.nuevaVenta(objent)
    End Function
    Public Function detalleVenta(objent As entDetalleVenta) As Boolean
        Dim objdat As New datVenta
        Return objdat.detalleVenta(objent)
    End Function
End Class
