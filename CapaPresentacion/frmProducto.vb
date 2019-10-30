Imports CapaNegocio
Imports CapaEntidad

Public Class frmProducto


    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objCat As New negCategoria
        cmbCategoria.DataSource = objCat.listarActivos()
        cmbCategoria.DisplayMember = "nomcategoria"
        cmbCategoria.ValueMember = "idcategoria"
        Dim objneg As New negProducto
        dgvProducto.DataSource = objneg.listarActivos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim objProEnt As New entProducto
        Dim objProNeg As New negProducto
        objProEnt.idproducto = txtId.Text
        objProEnt.nomproducto = txtNombre.Text
        objProEnt.precioventa = numPrecioVenta.Value
        objProEnt.stock = nmStock.Value
        objProEnt.presentacion = txtPresentacion.Text
        If rbActivo.Checked = True Then
            objProEnt.estado = rbActivo.Checked
        ElseIf rbInactivo.Checked = True Then
            objProEnt.estado = rbInactivo.Checked
        End If
        objProEnt.objCategoria.idcategoria = cmbCategoria.SelectedValue
        If objProNeg.nuevo(objProEnt) Then
            MsgBox("Registro Exitoso")
        Else : MsgBox("Error")
        End If


    End Sub

    
End Class