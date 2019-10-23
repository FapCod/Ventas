Imports CapaNegocio
Public Class frmCategoria

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objneg As New negCategoria
        dgvCategoria.DataSource = objneg.listarActivos()
    End Sub

   
End Class