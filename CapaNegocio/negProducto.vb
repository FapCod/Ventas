Imports CapaDatos
Imports CapaEntidad

Public Class negProducto
    Public Function nuevo(objent As entProducto) As Boolean
        Dim objdat As New datProducto
        Return objdat.nuevo(objent)
    End Function
End Class
