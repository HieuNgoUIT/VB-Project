Imports QLGaraDAL
Imports QLGaraDTO
Imports QLGaraGUI
Imports Utility

Public Class PhatSinhBus
    Private phatsinhDAL As PhatSinhDAL
    Public Sub New()
        phatsinhDAL = New PhatSinhDAL()
    End Sub
    Public Sub New(connectionString As String)
        phatsinhDAL = New PhatSinhDAL(connectionString)
    End Sub

    Public Function insert(phatsinh As PhatSinhDTO) As Result
        Return phatsinhDAL.insert(phatsinh)
    End Function

    Public Function insertForce(phatsinh As PhatSinhDTO) As Result
        Return phatsinhDAL.insertForce(phatsinh)
    End Function


    Public Function selectALL(ByRef listphatsinh As List(Of PhatSinhDTO)) As Result
        Return phatsinhDAL.selectALL(listphatsinh)
    End Function

    Public Function selectALL_Byphatsinh( ByRef listphatsinh As List(Of PhatSinhDTO)) As Result
        Return phatsinhDAL.selectALL_Byphatsinh(phatsinh, listphatsinh)
    End Function
	Public Function delete(phatsinh As PhatSinhDTO) As Result
        Return phatsinhDAL.delete(phatsinh)
    End Function
End Class