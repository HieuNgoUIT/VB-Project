Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility

Public Class VatTuPhuTungDTO
    Private strVatTuPhuTung As String
    Public Sub New ()
	    Me.strVatTuPhuTung=String.Empty
    End Sub
	Public Sub New(strVatTuPhuTung As String)
        Me.strVatTuPhuTung = strVatTuPhuTung
    End Sub
	
	Public Property strVatTuPhuTung As String
        Get
            Return strVatTuPhuTung
        End Get
        Set(value As String)
            strVatTuPhuTung = value
        End Set
    End Property
End Class
