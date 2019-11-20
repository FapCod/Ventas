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

    
   
    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub MosaicoVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoVerticalToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)
    End Sub

    Private Sub MosaicoHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)
    End Sub

    Private Sub CerrarTodasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CerrarTodasToolStripMenuItem1.Click
        For i = 0 To Me.MdiChildren.Count - 1
            Me.MdiChildren(0).Close()
        Next
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        frmVenta.MdiParent = Me
        frmVenta.Show()
    End Sub
End Class