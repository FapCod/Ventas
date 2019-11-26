Imports CapaNegocio
Imports CapaEntidad
Public Class frmUsuario


    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objneg As New negUsuario
        dgvUsers.DataSource = objneg.listarActivos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim objent As New entUsuario
        objent.idusuario = txtId.Text
        objent.nombres = txtNombre.Text
        objent.clave = txtclave.Text
        objent.tipousuarios = tipoUser.Text
        objent.estado = chcEstado.Checked
        Dim objneg As New negUsuario
        Dim verificar = objneg.nuevo(objent)
        If (verificar) Then
            MsgBox("Usuario agregado")
            dgvUsers.DataSource = objneg.listarActivos()
        End If
    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        Dim i As Integer
        i = dgvUsers.CurrentRow.Index
        txtId.Text = dgvUsers.Item(0, i).Value()
        txtNombre.Text = dgvUsers.Item(1, i).Value()
        txtclave.Text = dgvUsers.Item(2, i).Value()
        tipoUser.Text = dgvUsers.Item(3, i).Value()
        chcEstado.Checked = dgvUsers.Item(4, i).Value()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim objent As New entUsuario
        objent.idusuario = txtId.Text
        objent.nombres = txtNombre.Text
        objent.clave = txtclave.Text
        objent.tipousuarios = tipoUser.Text
        objent.estado = chcEstado.Checked
        Dim objneg As New negUsuario
        Dim verificar = objneg.editar(objent)
        If (verificar) Then
            MsgBox("Usuario Actualizado")
            dgvUsers.DataSource = objneg.listarActivos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim i As Integer
        i = dgvUsers.CurrentRow.Index
        txtId.Text = dgvUsers.Item(0, i).Value()
        Dim objneg As New negUsuario
        Dim verificar = objneg.eliminar(txtId.Text)
        If (verificar) Then
            MsgBox("Usuario Eliminado")
            dgvUsers.DataSource = objneg.listarActivos()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objneg As New negUsuario
        Dim id As String
        id = txtId.Text
        dgvUsers.DataSource = objneg.buscar(id)
    End Sub
End Class