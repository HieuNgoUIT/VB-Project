Imports QLGaraDTO
Imports QLGaraBUS
Imports Utility
Imports System.Data.SqlClient
Public Class PhieuThuTienGUI

    Private lxBus As PhieuThuTienBUS
    Private xe As TiepNhanXeSuaDTO
    Private Sub frmDanhSachLoaiHocSinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lxBus = New PhieuThuTienBUS()
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

        Dim clTenChuXe = New DataGridViewTextBoxColumn()
        clTenChuXe.Name = "TenChuXe1"
        clTenChuXe.HeaderText = "Tên Chủ Xe"
        clTenChuXe.DataPropertyName = "TenChuXe1"
        dgvDanhSachXe.Columns.Add(clTenChuXe)

        Dim clDienThoai = New DataGridViewTextBoxColumn()
        clDienThoai.Name = "DienThoai1"
        clDienThoai.HeaderText = "Số điện thoại"
        clDienThoai.DataPropertyName = "DienThoai1"
        dgvDanhSachXe.Columns.Add(clDienThoai)

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
                tbBienXe.Text = lxe.BienSo1
                tbTenChuXe.Text = lxe.TenChuXe1
                tbSDT.Text = lxe.DienThoai1
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If

    End Sub
End Class