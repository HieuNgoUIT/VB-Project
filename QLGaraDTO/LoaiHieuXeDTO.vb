Public Class LoaiHieuXeDTO
    Private iMaLoaiXe As Integer
    Private strTenLoaiXe As String
    Public Sub New()
    End Sub
    Public Sub New(ml As Integer, tl As String)
        iMaLoaiXe = ml
        strTenLoaiXe = tl
    End Sub

    Public Property IMaLoaiXe1 As Integer
        Get
            Return iMaLoaiXe
        End Get
        Set(value As Integer)
            iMaLoaiXe = value
        End Set
    End Property

    Public Property StrTenLoaiXe1 As String
        Get
            Return strTenLoaiXe
        End Get
        Set(value As String)
            strTenLoaiXe = value
        End Set
    End Property
End Class
