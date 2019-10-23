Imports CapaDatos
Public Class negCategoria
    Public Function listar() As DataTable
        Dim objCat As New datCategoria
        Return objCat.listar()
    End Function
    Public Function listarActivos() As DataTable
        Dim objCat As New datCategoria
        Return objCat.listarActivos()
    End Function
End Class
