Imports CapaEntidad
Imports CapaNegocio
Public Class frmInicio

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim objUsu As New negUsuario
        If objUsu.validarUsuario(txtUser.Text, txtPass.Text) = True Then
            Dim frmPrin As New frmPrincipal
            Me.Dispose(False)
            frmPrin.Show()
        Else
            MsgBox("Usuario o contraseña incorrecto")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtUser.Clear()
        txtPass.Clear()
        txtUser.Focus()
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        txtPass.PasswordChar = ""
        btnVer.Visible = False
        btnOcultar.Visible = True
    End Sub

    Private Sub btnOcultar_Click(sender As Object, e As EventArgs) Handles btnOcultar.Click
        txtPass.PasswordChar = "*"
        btnOcultar.Visible = False
        btnVer.Visible = True
    End Sub
End Class