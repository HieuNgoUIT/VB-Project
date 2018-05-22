Imports System.Configuration
Imports QLGaraDTO
Imports QLGaraBUS
Imports Utility
Public Class XuatPhieuGUI
    Private lxBus As XuatPhieuBus
    Private Sub frmDanhSachLoaiHocSinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lxBus = New XuatPhieuBus()
        ' Load LoaiHocSinh list
        loadListXe()

    End Sub
    Private Sub loadListXe()
        ' Load LoaiHocSinh list
        Dim listXe = New List(Of TiepNhanXeSuaDTO)
        Dim result As Result
        result = lxBus.selectAll(listXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachXe.Columns.Clear()
        dgvDanhSachXe.DataSource = Nothing

        dgvDanhSachXe.AutoGenerateColumns = False
        dgvDanhSachXe.AllowUserToAddRows = False
        dgvDanhSachXe.DataSource = listXe

        Dim clBienSo = New DataGridViewTextBoxColumn()
        clBienSo.Name = "BienSo1"
        clBienSo.HeaderText = "Biển xe"
        clBienSo.DataPropertyName = "BienSo1"
        dgvDanhSachXe.Columns.Add(clBienSo)

        Dim clNgay = New DataGridViewTextBoxColumn()
        clNgay.Name = "NgayTiepNhan1"
        clNgay.HeaderText = "Ngày Tiếp Nhận"
        clNgay.DataPropertyName = "NgayTiepNhan1"
        dgvDanhSachXe.Columns.Add(clNgay)

    End Sub
    Private Sub dgvDanhSachXe_SELECTionChanged(sender As Object, e As EventArgs) Handles dgvDanhSachXe.SelectionChanged

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachXe.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachXe.RowCount) Then
            Try
                Dim lxe = CType(dgvDanhSachXe.Rows(currentRowIndex).DataBoundItem, TiepNhanXeSuaDTO)
                txBienXe.Text = lxe.BienSo1
                tbNgayTiepNhan.Text = lxe.NgayTiepNhan1
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class