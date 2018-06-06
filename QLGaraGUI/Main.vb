Public Class Main
    Private Sub TiếpNhậnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiếpNhậnToolStripMenuItem.Click
        Dim frm As TiepNhanXeSuaGUI = New TiepNhanXeSuaGUI()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub XuấtPhiếuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XuấtPhiếuToolStripMenuItem.Click
        Dim frm As XuatPhieuGUI = New XuatPhieuGUI()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PhiếuThuTiềnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuThuTiềnToolStripMenuItem.Click
        Dim frm As PhieuThuTienGUI = New PhieuThuTienGUI()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
