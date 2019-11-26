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
    Public Function listarActivos() As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM usuario WHERE estado=1"
        objdat.Conectar("", "", True)
        cmd.Connection = objdat.cnn
        If cmd.ExecuteNonQuery Then
            dt = New DataTable
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Else
            Return Nothing
        End If

    End Function
    Public Function nuevo(objent As entUsuario) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO usuario VALUES(@id,@nom,@clave,@tipo,@est)"
            cmd.Parameters.AddWithValue("@id", objent.idusuario)
            cmd.Parameters.AddWithValue("@nom", objent.nombres)
            cmd.Parameters.AddWithValue("@clave", objent.clave)
            cmd.Parameters.AddWithValue("@tipo", objent.tipousuarios)
            cmd.Parameters.AddWithValue("@est", objent.estado)
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("error ex" + ex.Message)
        End Try

        Return False
    End Function
    Public Function editar(objent As entUsuario) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update usuario set nomusuario=@nom, clave=@clave,tipo=@tip,estado=@est where idusuario=@id;"
            cmd.Parameters.AddWithValue("@nom", objent.nombres)
            cmd.Parameters.AddWithValue("@clave", objent.clave)
            cmd.Parameters.AddWithValue("@tip", objent.tipousuarios)
            cmd.Parameters.AddWithValue("@est", objent.estado)
            cmd.Parameters.AddWithValue("@id", objent.idusuario)

            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("error ex" + ex.Message)
        End Try

        Return False
    End Function
    Public Function eliminar(id As String) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete usuario  where idusuario=@id"
            cmd.Parameters.AddWithValue("@id", id)
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("error ex" + ex.Message)
        End Try

        Return False
    End Function
    Public Function buscar(id As String) As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * from usuario where idusuario=@id"
        cmd.Parameters.AddWithValue("@id", id)
        objdat.Conectar("", "", True)
        cmd.Connection = objdat.cnn
        If cmd.ExecuteNonQuery Then
            dt = New DataTable
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Else
            Return Nothing
        End If

    End Function
End Class
