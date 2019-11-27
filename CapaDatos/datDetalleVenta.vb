Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datDetalleVenta
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
