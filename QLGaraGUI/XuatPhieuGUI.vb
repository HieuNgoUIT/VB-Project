Imports System.Configuration
Imports QLGaraDTO
Imports QLGaraBUS
Imports Utility
Imports System.Data.SqlClient

Public Class XuatPhieuGUI
    Private xeBus As TiepNhanXeSuaBUS
    Private lxBus As XuatPhieuBus
    Private xe As TiepNhanXeSuaDTO
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

    Private Sub tbTienCong_TextChanged(sender As Object, e As EventArgs) Handles tbTienCong.TextChanged
        tbThanhTien.Text = tbSoLuong.Text * tbDonGia.Text + tbTienCong.Text

    End Sub

    Private Sub tbSoLuong_TextChanged(sender As Object, e As EventArgs) Handles tbSoLuong.TextChanged
        'tbThanhTien.Text = tbSoLuong.Text * tbDonGia.Text + tbTienCong.Text
    End Sub

    Private Sub tbDonGia_TextChanged(sender As Object, e As EventArgs) Handles tbDonGia.TextChanged
        '  tbThanhTien.Text = tbSoLuong.Text * tbDonGia.Text + tbTienCong.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = String.Empty
        query &= " UPDATE [TIEPNHAN] SET"
        query &= " [THANHTIEN] = '{0}' "
        query &= " WHERE "
        query &= " [BIENSO] = '{1}' "
        query = String.Format(query, tbThanhTien.Text, txBienXe.Text)

        Using conn As New SqlConnection("Data Source=DESKTOP-M4843TO\SQLEXPRESS;Initial Catalog=VBPROJECT;Integrated Security=True")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                    MessageBox.Show("thêm thành tiền thành công")
                Catch ex As Exception
                    conn.Close()

                    ' Return New Result(False, "Thêm Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
    End Sub
End Class