
Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility

Public Class ThanhTienDTO
    Private strThanhTien As String
    Public Sub New ()
	    Me.strThanhTien=String.Empty
    End Sub
	Public Sub New(strThanhTien As String)
        Me.strThanhTien = strThanhTien
    End Sub
	
	Public Property strThanhTien As String
        Get
            Return strThanhTien
        End Get
        Set(value As String)
            strThanhTien = value
        End Set
    End Property
End Class
