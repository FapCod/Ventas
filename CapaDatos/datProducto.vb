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
    Public Function editar(objent As entProducto) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update producto set nomproducto=@nom, precioventa=@prev,stock=@stock,presentacion=@pres,estado=@est,idcategoria=@cat where idproducto=@id;"
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
    Public Function eliminar(id As String) As Boolean
        Try
            Dim objdao As New datConexion
            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete producto  where idproducto=@id"
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
    Public Function listar() As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT dbo.categoria.nomcategoria, dbo.producto.nomproducto AS Nombre, dbo.producto.precioventa AS PrecioV, dbo.producto.idproducto AS id, dbo.producto.stock, dbo.producto.presentacion, dbo.producto.estado FROM dbo.categoria INNER JOIN dbo.producto ON dbo.categoria.idcategoria = dbo.producto.idcategoria"
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
    Public Function buscar(id As String) As DataTable
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT dbo.categoria.nomcategoria, dbo.producto.nomproducto AS Nombre, dbo.producto.precioventa AS PrecioV, dbo.producto.idproducto AS id, dbo.producto.stock, dbo.producto.presentacion, dbo.producto.estado FROM dbo.categoria INNER JOIN dbo.producto ON dbo.categoria.idcategoria = dbo.producto.idcategoria where idproducto=@id"
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
    Public Function mostrar() As DataTable 'para combobox
        Dim objdat As New datConexion
        Dim dt As DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT idproducto, nomproducto from producto where estado=1"
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

    Public Function cargar(id As String) As entProducto 'para combobox
        Dim objdat As New datConexion
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Dim objent As New entProducto
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT precioventa, stock from producto where idproducto=@id"
        cmd.Parameters.AddWithValue("@id", id)
        objdat.Conectar("", "", True)
        cmd.Connection = objdat.cnn
        dr = cmd.ExecuteReader()
        dr.Read()
        objent.precioventa = dr.Item(0)
        objent.stock = dr.Item(1)
        Return objent
    End Function


End Class
