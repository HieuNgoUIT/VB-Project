Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility

Public Class SoLuotSuaDTO
    Private iSoLuotSua As Integer
    Public Sub New ()
	    Me.iSoLuotSua = 0
    End Sub
	Public Sub New(iSoLuotSua As Integer)
        Me.iSoLuotSua = iSoLuotSua
    End Sub
	
	Public Property iSoLuotSua As Integer
        Get
            Return iSoLuotSua
        End Get
        Set(value As Integer)
            iSoLuotSua = value
        End Set
    End Property
End Class
