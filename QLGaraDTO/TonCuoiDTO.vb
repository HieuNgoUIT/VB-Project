Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility

Public Class TonCuoiDTO
    Private strTonCuoi As String
    Public Sub New ()
	    Me.strTonCuoi=String.Empty
    End Sub
	Public Sub New(strTonCuoi As String)
        Me.strTonCuoi = strTonCuoi
    End Sub
	
	Public Property strTonCuoi As String
        Get
            Return strTonCuoi
        End Get
        Set(value As String)
            strTonCuoi = value
        End Set
    End Property
End Class
