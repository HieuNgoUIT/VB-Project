Imports QLGaraDAL
Imports QLGaraDTO
Imports QLGaraGUI
Imports Utility

Public Class TonDauBus
    Private tondauDAL As TonDauDAL
    Public Sub New()
       tondauDAL = New TonDauDAL()
    End Sub
    Public Sub New(connectionString As String)
        tondauDAL = New TonDauDAL(connectionString)
    End Sub

    Public Function insert(tondau As TonDauDTO) As Result
        Return tondauDAL.insert(tondau)
    End Function

    Public Function insertForce(tondau As TonDauDTO) As Result
        Return tondauDAL.insertForce(tondau)
    End Function


    Public Function selectALL(ByRef listtondau As List(Of TonDauDTO)) As Result
        Return tondauDAL.selectALL(listtondau)
    End Function

    Public Function selectALL_Bytondau( ByRef listtondau As List(Of TonDauDTO)) As Result
        Return tondauDAL.selectALL_Bytondau(tondau, listtondau)
    End Function
	Public Function delete(tondau As TonDauDTO) As Result
        Return tondauDAL.delete(tondau)
    End Function
End Class