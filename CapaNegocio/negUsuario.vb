Imports CapaDatos
Imports CapaEntidad
Public Class negUsuario
    Public Function nuevo(objent As entUsuario) As Boolean
        Dim objUsu As New datUsuario
        If objent.clave.Length = 8 Then
            Return objUsu.nuevo(objent)
        End If
        Return False
    End Function
    Public Function editar(objent As entUsuario) As Boolean
        Dim objUsu As New datUsuario
        If objent.clave.Length = 8 Then
            Return objUsu.editar(objent)
        End If
        Return False
    End Function
    Public Function eliminar(id As String) As Boolean
        Dim objUsu As New datUsuario
        Return objUsu.eliminar(id)
        Return False
    End Function
    Public Function buscar(id As String) As DataTable
        Dim objUsu As New datUsuario
        Return objUsu.buscar(id)
    End Function
    Public Function validarUsuario(usu As String, cla As String) As Boolean
        Dim objUsu As New datUsuario
        If cla.Length = 8 Then
            Return objUsu.Validar(usu, cla)
        End If
        Return False
    End Function
    Public Function listarActivos() As DataTable
        Dim objCat As New datUsuario
        Return objCat.listarActivos()
    End Function
End Class
