Imports QLGaraDAL
Imports QLGaraDTO
Imports QLGaraGUI
Imports Utility

Public Class TiLeBus
    Private tileDAL As TiLeDAL
    Public Sub New()
        tileDAL = New TiLeDAL()
    End Sub
    Public Sub New(connectionString As String)
        tileDAL = New TiLeDAL(connectionString)
    End Sub

    Public Function insert(tile As TiLeDTO) As Result
        Return tileDAL.insert(tile)
    End Function

    Public Function insertForce(tile As TiLeDTO) As Result
        Return tileDAL.insertForce(tile)
    End Function


    Public Function selectALL(ByRef listtile As List(Of TiLeDTO)) As Result
        Return tileDAL.selectALL(listtile)
    End Function

    Public Function selectALL_Bytile( ByRef listtile As List(Of TiLeDTO)) As Result
        Return tileDAL.selectALL_Bytile(tile, listtile)
    End Function
	Public Function delete(tile As TiLeDTO) As Result
        Return tileDAL.delete(tile)
    End Function
End Class