Public Class frmPrincipal

   
    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        'Dim ventana As New frmUsuario
        'ventana.MdiParent = Me
        'ventana.Show()
        frmUsuario.MdiParent = Me
        frmUsuario.Show()

    End Sub

    Private Sub frmPrincipal_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    
    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        frmCategoria.MdiParent = Me
        frmCategoria.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        frmProducto.MdiParent = Me
        frmProducto.Show()
    End Sub
End Class