Imports CapaDatos
Imports CapaEntidad
Public Class negCategoria
    Public Function nuevo(objent As entCategoria) As Boolean
        Dim objdat As New datCategoria
        Return objdat.nuevo(objent)
    End Function
    Public Function Editar(objent As entCategoria) As Boolean
        Dim objdat As New datCategoria
        Return objdat.editar(objent)
    End Function
    Public Function listar() As DataTable
        Dim objCat As New datCategoria
        Return objCat.listar()
    End Function
    Public Function listarActivos() As DataTable
        Dim objCat As New datCategoria
        Return objCat.listarActivos()
    End Function
End Class
