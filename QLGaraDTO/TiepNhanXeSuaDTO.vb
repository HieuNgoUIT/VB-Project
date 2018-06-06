Public Class TiepNhanXeSuaDTO

    Private BienSo As String
    Private DienThoai As String
    Private HieuXe As String
    Private TenChuXe As String
    Private NgayTiepNhan As String
    Private DiaChi As String
    Private ThanhTien As Integer
    Public Sub New()
    End Sub
    Public Sub New(bienso As String, dienthoai As String, hieuxe As String, tenchuxe As String, ngaytiepnhan As String, diachi As String)
        Me.BienSo = bienso
        Me.DienThoai = dienthoai
        Me.HieuXe = hieuxe
        Me.TenChuXe = tenchuxe
        Me.DiaChi = diachi
        Me.NgayTiepNhan = ngaytiepnhan
    End Sub
    Public Sub New(bienso As String, ngaytiepnhan As String)
        Me.BienSo = bienso
        Me.NgayTiepNhan = ngaytiepnhan
    End Sub
    Public Sub New(bienso As String, tenchuxe As String, dienthoai As String)
        Me.BienSo = bienso
        Me.TenChuXe = tenchuxe
        Me.DienThoai = dienthoai
    End Sub
    Public Property BienSo1 As String
        Get
            Return BienSo
        End Get
        Set(value As String)
            BienSo = value
        End Set
    End Property

    Public Property DienThoai1 As String
        Get
            Return DienThoai
        End Get
        Set(value As String)
            DienThoai = value
        End Set
    End Property

    Public Property HieuXe1 As String
        Get
            Return HieuXe
        End Get
        Set(value As String)
            HieuXe = value
        End Set
    End Property

    Public Property TenChuXe1 As String
        Get
            Return TenChuXe
        End Get
        Set(value As String)
            TenChuXe = value
        End Set
    End Property

    Public Property NgayTiepNhan1 As String
        Get
            Return NgayTiepNhan
        End Get
        Set(value As String)
            NgayTiepNhan = value
        End Set
    End Property

    Public Property DiaChi1 As String
        Get
            Return DiaChi
        End Get
        Set(value As String)
            DiaChi = value
        End Set
    End Property

    Public Property ThanhTien1 As Integer
        Get
            Return ThanhTien
        End Get
        Set(value As Integer)
            ThanhTien = value
        End Set
    End Property
End Class
