Imports CapaDatos
Imports CapaEntidad

Public Class negProducto
    Public Function nuevo(objent As entProducto) As Boolean
        Dim objdat As New datProducto
        Return objdat.nuevo(objent)
    End Function
    Public Function editar(objent As entProducto) As Boolean
        Dim objdat As New datProducto
        Return objdat.editar(objent)
    End Function
    Public Function eliminar(id As String) As Boolean
        Dim objdat As New datProducto
        Return objdat.eliminar(id)
    End Function
    Public Function buscar(id As String) As DataTable
        Dim objpro As New datProducto
        Return objpro.buscar(id)
    End Function
    Public Function listarActivos() As DataTable
        Dim objpro As New datProducto
        Return objpro.listar()
    End Function

    Public Function mostrar() As DataTable
        Dim objpro As New datProducto
        Return objpro.mostrar()
    End Function

    Public Function cargar(id As String) As entProducto
        Dim objPro As New datProducto
        Return objPro.cargar(id)
    End Function
End Class
