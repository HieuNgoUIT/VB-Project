﻿Imports QLGaraBUS
Imports QLGaraDTO
Imports Utility
Imports QLGaraDAL
Public Class TiepNhanXeSuaGUI
    Private xeBus As TiepNhanXeSuaBUS
    Private lhxBus As LoaiHieuXeBus

    Private Sub tiepnhan_Click(sender As Object, e As EventArgs) Handles btTiepNhanXe.Click
        Dim XE As TiepNhanXeSuaDTO
        XE = New TiepNhanXeSuaDTO()

        XE.BienSo1 = tbBienSo.Text
        XE.DiaChi1 = tbDiachi.Text
        XE.DienThoai1 = tbDienThoai.Text
        XE.HieuXe1 = cbHieuXe.Text
        XE.NgayTiepNhan1 = dtpNgayTiepNhan.Value
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

    Private Sub frmTiepNhanXeGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lhxBus = New LoaiHieuXeBus()

        ' Load LoaiHocSinh list
        Dim listLoaiHieuXe = New List(Of LoaiHieuXeDTO)
        Dim result As Result
        result = lhxBus.selectAll(listLoaiHieuXe)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hiệu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbHieuXe.DataSource = New BindingSource(listLoaiHieuXe, String.Empty)
        cbHieuXe.DisplayMember = "strTenLoaiXe1"
        cbHieuXe.ValueMember = "strTenLoaiXe1"


        'check so xe trong ngay
        Dim xemax As Integer
        xemax = 1



    End Sub
End Class