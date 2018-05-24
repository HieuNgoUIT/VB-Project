
Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility

Public Class TiLeDTO
    Private strTiLe As String
    Public Sub New ()
	    Me.strTiLe=String.Empty
    End Sub
	Public Sub New(strTiLe As String)
        Me.strTiLe = strTiLe
    End Sub
	
	Public Property strTiLe As String
        Get
            Return strTiLe
        End Get
        Set(value As String)
            strTiLe = value
        End Set
    End Property
End Class
