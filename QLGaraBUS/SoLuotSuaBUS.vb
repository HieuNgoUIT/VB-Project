Imports QLGaraDAL
Imports QLGaraDTO
Imports QLGaraGUI
Imports Utility

Public Class SoLuotSuaBus
    Private SoLuotSuaDAL As SoLuotSuaDAL
    Public Sub New()
        SoLuotSuaDAL = New SoLuotSuaDAL()
    End Sub
    Public Sub New(connectionString As String)
        SoLuotSuaDAL = New SoLuotSuaDAL(connectionString)
    End Sub

    Public Function insert(soluotsua As SoLuotSuaDTO) As Result
        Return SoLuotSuaDAL.insert(soluotsua)
    End Function

    Public Function insertForce(soluotsua As SoLuotSuaDTO) As Result
        Return SoLuotSuaDAL.insertForce(soluotsua)
    End Function


    Public Function selectALL(ByRef listsoluotsua As List(Of SoLuotSuaDTO)) As Result
        Return SoLuotSuaDAL.selectALL(listsoluotsua)
    End Function

    Public Function selectALL_Bysoluotsua( ByRef listsoluotsua As List(Of SoLuotSuaDTO)) As Result
        Return SoLuotSuaDAL.selectALL_Bysoluotsua(soluotsua, listsoluotsua)
    End Function
	Public Function delete(soluotsua As SoLuotSuaDTO) As Result
        Return SoLuotSuaDAL.delete(soluotsua)
    End Function
End Class