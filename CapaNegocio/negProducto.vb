Imports CapaDatos
Imports CapaEntidad

Public Class negProducto
    Public Function nuevo(objent As entProducto) As Boolean
        Dim objdat As New datProducto
        Return objdat.nuevo(objent)
    End Function
    Public Function listarActivos() As DataTable
        Dim objpro As New datProducto
        Return objpro.listar()
    End Function
End Class
