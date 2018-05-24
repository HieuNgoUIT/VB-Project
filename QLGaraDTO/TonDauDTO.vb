Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility

Public Class TonDauDTO
    Private strTonDau As String
    Public Sub New ()
	    Me.strTonDau=String.Empty
    End Sub
	Public Sub New(strTonDau As String)
        Me.strTonDau = strTonDau
    End Sub
	
	Public Property strTonDau As String
        Get
            Return strTonDau
        End Get
        Set(value As String)
            strTonDau = value
        End Set
    End Property
End Class
