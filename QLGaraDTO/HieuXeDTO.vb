
Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility

Public Class HieuXeDTO
    Private strHieuXe As String
    Public Sub New ()
	    Me.strHieuXe=String.Empty
    End Sub
	Public Sub New(strHieuXe As String)
        Me.strHieuXe = strHieuXe
    End Sub
	
	Public Property strHieuXe As String
        Get
            Return strHieuXe
        End Get
        Set(value As String)
            strHieuXe = value
        End Set
    End Property
End Class
