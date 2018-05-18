Public Class Main
    Private Sub TiếpNhậnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiếpNhậnToolStripMenuItem.Click
        Dim frm As TiepNhanXeSuaGUI = New TiepNhanXeSuaGUI()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
