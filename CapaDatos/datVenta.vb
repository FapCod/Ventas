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

    Public Function detalleVenta(objent As entDetalleVenta) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "registrarDV"
            cmd.Parameters.AddWithValue("@idproducto", objent.idproducto)
            cmd.Parameters.AddWithValue("@idventa", objent.idventa)
            cmd.Parameters.AddWithValue("@cantidad", objent.cantidad)
            cmd.Parameters.AddWithValue("@costo", objent.costo)
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
End Class
