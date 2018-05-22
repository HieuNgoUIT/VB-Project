Public Class CacXeViewDTO
    Private strBienSo As String
    Private strHieuXe As String
    Private strChuXe As String
    Private strTienNo As String
    Public Sub New()
        Me.strBienSo = String.Empty
        Me.strHieuXe = String.Empty
        Me.strChuXe = String.Empty
        me.strTienNo=String.Empty
    End Sub

    Public Property BienSo() As String
        Get
            Return strBienSo
        End Get
        Set(ByVal Value As String)
            strBienSo = Value
        End Set
    End Property

    

    Public Property HieuXe As String
        Get
            Return strHieuXe
        End Get
        Set(value As String)
            strHieuXe = value
        End Set
    End Property
    

    Public Property ChuXe As String
        Get
            Return strChuXe
        End Get
        Set(value As String)
            strChuXe = value
        End Set
    End Property
	Public Property TienNo As String
        Get
            Return strTienNo
        End Get
        Set(value As String)
            strTienNo = value
        End Set
    End Property
  
  
    Public Function createCacXeViewDTO() As CacXeViewDTO
        Dim d = New CacXeViewDTO()
        d.NgayCapNhat = DateTime.Now
        d.NgayNhap = DateTime.Now
        d.UserIdCapNhat = "admin"
        d.UserIdNhap = "admin"
        Return d
    End Function

End Class
