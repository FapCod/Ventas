Imports CapaNegocio
Public Class frmProducto


    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objCat As New negCategoria
        cmbCategoria.DataSource = objCat.listarActivos()
        cmbCategoria.DisplayMember = "nomcategoria"
        cmbCategoria.ValueMember = "idcategoria"
    End Sub
End Class