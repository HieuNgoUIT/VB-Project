Imports QLGaraBUS
Imports QLGaraDTO
Imports Utility
Imports QLGaraDAL
Public Class TiepNhanXeSuaGUI
    Private xeBus As TiepNhanXeSuaBUS
    Private Sub tiepnhan_Click(sender As Object, e As EventArgs) Handles btTiepNhanXe.Click
        Dim XE As TiepNhanXeSuaDTO
        XE = New TiepNhanXeSuaDTO()

        XE.BienSo1 = tbBienSo.Text
        XE.DiaChi1 = tbDiachi.Text
        XE.DienThoai1 = tbDienThoai.Text
        XE.HieuXe1 = tbHieuXe.Text
        XE.NgayTiepNhan1 = tbNgayTiepNhan.Text
        XE.TenChuXe1 = tbTenChuXe.Text


        '2. Business .....
        xeBus = New TiepNhanXeSuaBUS()

        '3. Insert to DB
        Dim result As Result
        result = xeBus.insert(XE)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm xe thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Thêm xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class