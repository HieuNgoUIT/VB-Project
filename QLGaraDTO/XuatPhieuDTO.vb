Public Class XuatPhieuDTO
    Private strBienso As String
    Private strNgayTiepNhan As String

    Public Sub New()
    End Sub
    Public Sub New(bs As Integer, ntn As String)
        StrBienso1 = bs
        StrNgayTiepNhan1 = ntn
    End Sub

    Public Property StrBienso1 As String
        Get
            Return strBienso
        End Get
        Set(value As String)
            strBienso = value
        End Set
    End Property

    Public Property StrNgayTiepNhan1 As String
        Get
            Return strNgayTiepNhan
        End Get
        Set(value As String)
            strNgayTiepNhan = value
        End Set
    End Property
End Class
