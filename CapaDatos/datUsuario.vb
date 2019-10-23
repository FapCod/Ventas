Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datUsuario
    Public Function Validar(usu As String, cla As String) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT estado FROM usuario WHERE idusuario=@usu AND clave=@cla"
            cmd.Parameters.AddWithValue("@usu", usu)
            cmd.Parameters.AddWithValue("@cla", cla)
            'objdao.BaseDatos = "Ejemplo"
            'objdao.Servidor = "FAPCOD\SQLEXPRESS"
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox("error ex")
        End Try
        Return False
    End Function
End Class
