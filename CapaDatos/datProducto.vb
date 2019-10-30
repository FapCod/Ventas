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
            MsgBox("error ex" + ex.Message)
        End Try

        Return False
    End Function
    Public Function listar() As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT dbo.categoria.nomcategoria, dbo.producto.nomproducto AS Expr1, dbo.producto.precioventa AS Expr2, dbo.producto.idproducto AS Expr3, dbo.producto.stock, dbo.producto.presentacion, dbo.producto.estado FROM dbo.categoria INNER JOIN dbo.producto ON dbo.categoria.idcategoria = dbo.producto.idcategoria"
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
