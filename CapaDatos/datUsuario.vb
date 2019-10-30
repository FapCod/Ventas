Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datUsuario
    Public Function Validar(usu As String, cla As String) As Boolean
        Try
            Dim objdat As New CapaDatos.datConexion
            Dim cmd As SqlCommand
            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select estado from usuario where idusuario = @usu and clave  = @cla"
            cmd.Parameters.AddWithValue("@usu", usu)
            cmd.Parameters.AddWithValue("@cla", cla)
            objdat.Conectar("", "", True) 'Autenticacion de windows
            cmd.Connection = objdat.cnn
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox("error ex" + ex.Message)
        End Try
        Return False
    End Function
End Class
