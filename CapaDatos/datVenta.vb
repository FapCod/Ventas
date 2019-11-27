Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datVenta
    Public Function nuevaVenta(objent As entVenta) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "registrarVenta"
            cmd.Parameters.AddWithValue("@idventa", objent.idventa)
            cmd.Parameters.AddWithValue("@fecha", objent.fecha)
            cmd.Parameters.AddWithValue("@idcliente", objent.idcliente)
            cmd.Parameters.AddWithValue("@tipodoc", objent.tipodoc)
            cmd.Parameters.AddWithValue("@monto", objent.monto)
            cmd.Parameters.AddWithValue("@estado", objent.estado)
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

    Public Function listar() As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "listarventa"
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
    Public Function listardgv(id As Integer) As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "buscardt"
        cmd.Parameters.AddWithValue("@idventa", id)
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
    Public Function buscar(id As Integer) As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "buscarVentas"
        cmd.Parameters.AddWithValue("@idventa", id)
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
