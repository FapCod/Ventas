Imports CapaDatos
Public Class negUsuario
    Public Function validarUsuario(usu As String, cla As String) As Boolean
        Dim objUsu As New datUsuario
        If cla.Length = 8 Then
            Return objUsu.Validar(usu, cla)
        End If
        Return False
    End Function

End Class
