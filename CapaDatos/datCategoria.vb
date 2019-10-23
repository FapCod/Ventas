Imports System.Data.SqlClient
Public Class datCategoria
    Public Function listar() As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM categoria"
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
    Public Function listarActivos() As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT idcategoria,nomcategoria FROM categoria WHERE estado=1"
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
