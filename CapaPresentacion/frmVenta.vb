Imports CapaNegocio
Imports CapaEntidad
Public Class frmVenta
    Dim objneg As New negProducto
    Dim objent As New entProducto
    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objnegProducto As New negProducto
        cmbProducto.DataSource = objnegProducto.mostrar()
        cmbProducto.DisplayMember = "nomproducto"
        cmbProducto.ValueMember = "idproducto"
    End Sub


    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged
        objent = objneg.cargar(Me.cmbProducto.SelectedValue(0))
        txtPrecio.Text = objent.precioventa
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cantidad As Integer
        cantidad = Val(txtCantidad.Text)
        If cantidad <= objent.stock Then
            MsgBox("se pudo agregar")

        Else
            MsgBox("no  pudo agregar")
        End If
    End Sub
End Class