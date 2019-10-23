Imports CapaEntidad
Imports System.Data.SqlClient
Public Class datProducto
    Public Function nuevo(objent As entProducto) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO producto VALUES(@id,@nom,@prev,@stock,@pres,@est,@cat)"
            cmd.Parameters.AddWithValue("@id", objent.idproducto)
            cmd.Parameters.AddWithValue("@nom", objent.nomproducto)
            cmd.Parameters.AddWithValue("@prev", objent.precioventa)
            cmd.Parameters.AddWithValue("@stock", objent.stock)
            cmd.Parameters.AddWithValue("@pres", objent.presentacion)
            cmd.Parameters.AddWithValue("@est", objent.estado)
            cmd.Parameters.AddWithValue("@cat", objent.objCategoria.idcategoria)
            objdao.Conectar("", "", True)
            cmd.Connection = objdao.cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("error ex")
        End Try

        Return False
    End Function

End Class
