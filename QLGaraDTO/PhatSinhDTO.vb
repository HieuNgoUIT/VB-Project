Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility

Public Class PhatSinhDTO
    Private strPhatSinh As String
    Public Sub New ()
	    Me.strPhatSinh=String.Empty
    End Sub
	Public Sub New(strPhatSinh As String)
        Me.strPhatSinh = strPhatSinh
    End Sub
	
	Public Property strPhatSinh As String
        Get
            Return strPhatSinh
        End Get
        Set(value As String)
            strPhatSinh = value
        End Set
    End Property
End Class
