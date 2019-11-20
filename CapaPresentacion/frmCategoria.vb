Imports CapaNegocio
Imports CapaEntidad
Public Class frmCategoria

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objneg As New negCategoria
        dgvCategoria.DataSource = objneg.listarActivos()
    End Sub

   
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim objCat As New entCategoria
        Dim objnegc As New negCategoria
        objCat.nomcategoria = txtnombre.Text
        objCat.estado = rbActivo.Checked
        If objnegc.nuevo(objCat) Then
            MsgBox("registro exitoso")
        End If
        Dim objneg As New negCategoria
        dgvCategoria.DataSource = objneg.listarActivos()
    End Sub

    Private Sub dgvCategoria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategoria.CellClick
        Dim i As Integer
        i = dgvCategoria.CurrentRow.Index
        txtnombre.Text = dgvCategoria.Item(1, i).Value()
        rbActivo.Checked = dgvCategoria.Item(2, i).Value()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim objCat As New entCategoria
        Dim objnegc As New negCategoria
        Dim id As Integer
        Dim i As Integer
        i = dgvCategoria.CurrentRow.Index
        id = dgvCategoria.Item(0, i).Value()
        objCat.idcategoria = id
        objCat.nomcategoria = txtnombre.Text
        objCat.estado = rbActivo.Checked
        If objnegc.Editar(objCat) Then
            MsgBox("Actualizacion exitosa")
        End If
        Dim objneg As New negCategoria
        dgvCategoria.DataSource = objneg.listarActivos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub
End Class