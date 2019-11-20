Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datCliente
    Public Function buscar(nom As String) As DataTable 'para datagriew
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT idCliente,nombre from cliente where nombre like+'%'+ @nom+'%'"
        cmd.Parameters.AddWithValue("@nom", nom)
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
