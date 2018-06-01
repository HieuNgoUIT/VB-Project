Imports QLGaraDAL
Imports QLGaraDTO
Imports QLGaraGUI
Imports Utility

Public Class TonCuoiBus
    Private toncuoiDAL As TonCuoiDAL
    Public Sub New()
        toncuoiDAL = New TonCuoiDAL()
    End Sub
    Public Sub New(connectionString As String)
        toncuoiDAL = New TonCuoiDAL(connectionString)
    End Sub

    Public Function insert(toncuoi As TonCuoiDTO) As Result
        Return toncuoiDAL.insert(toncuoi)
    End Function

    Public Function insertForce(toncuoi As TonCuoiDTO) As Result
        Return toncuoiDAL.insertForce(toncuoi)
    End Function


    Public Function selectALL(ByRef listtoncuoi As List(Of TonCuoiDTO)) As Result
        Return toncuoiDAL.selectALL(listtoncuoi)
    End Function

    Public Function selectALL_Bytoncuoi( ByRef listtoncuoi As List(Of TonCuoiDTO)) As Result
        Return toncuoiDAL.selectALL_Bytoncuoi(toncuoi, listtoncuoi)
    End Function
	Public Function delete(toncuoi As TonCuoiDTO) As Result
        Return toncuoiDAL.delete(toncuoi)
    End Function
End Class