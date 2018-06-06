Public Class NguyenLieuDTO
    Private vattu As String
    Private dongia As Integer
    Public Sub New(vt As String, dg As Integer)
        vattu = vt
        dongia = dg
    End Sub

    Public Property Vattu1 As String
        Get
            Return vattu
        End Get
        Set(value As String)
            vattu = value
        End Set
    End Property

    Public Property Dongia1 As Integer
        Get
            Return dongia
        End Get
        Set(value As Integer)
            dongia = value
        End Set
    End Property
End Class
