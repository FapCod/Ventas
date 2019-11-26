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
            Dim objneg As New negProducto
            dgvProducto.DataSource = objneg.listarActivos()
        Else : MsgBox("Error")
        End If


    End Sub

    
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim objProEnt As New entProducto
        Dim objProNeg As New negProducto
        Dim i As Integer
        i = dgvProducto.CurrentRow.Index
        txtId.Text = dgvProducto.Item(3, i).Value()
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

        If objProNeg.editar(objProEnt) Then
            MsgBox("Editado Exitoso")
            Dim objneg As New negProducto
            dgvProducto.DataSource = objneg.listarActivos()
        Else : MsgBox("Error")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'tengo error en eliminar
        Dim id As Integer
        Dim i As Integer
        i = dgvProducto.CurrentRow.Index
        id = dgvProducto.Item(3, i).Value()
        Dim objneg As New negProducto
        Dim verificar = objneg.eliminar(id)
        If (verificar) Then
            MsgBox("ELIMINACION EXITOSA")
            dgvProducto.DataSource = objneg.listarActivos()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objneg As New negProducto
        Dim id As String
        id = txtId.Text
        dgvProducto.DataSource = objneg.buscar(id)
    End Sub

    Private Sub dgvProducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducto.CellClick
        Dim i As Integer
        i = dgvProducto.CurrentRow.Index
        txtId.Text = dgvProducto.Item(3, i).Value()
        txtNombre.Text = dgvProducto.Item(1, i).Value()
        numPrecioVenta.Value = dgvProducto.Item(2, i).Value()
        nmStock.Value = dgvProducto.Item(4, i).Value()
        txtPresentacion.Text = dgvProducto.Item(5, i).Value()
        rbActivo.Checked = dgvProducto.Item(6, i).Value()
        cmbCategoria.Text = dgvProducto.Item(0, i).Value()
    End Sub
End Class