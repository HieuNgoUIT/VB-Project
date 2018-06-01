Imports QLGaraDAL
Imports QLGaraDTO
Imports QLGaraGUI
Imports Utility

Public Class HieuXeBus
    Private hieuxeDAL As HieuXeDAL
    Public Sub New()
        hieuxeDAL = New HieuXeDAL()
    End Sub
    Public Sub New(connectionString As String)
        hieuxeDAL = New HieuXeDAL(connectionString)
    End Sub

    Public Function insert(hieuxe As HieuXeDTO) As Result
        Return hieuxeDAL.insert(hieuxe)
    End Function

    Public Function insertForce(hieuxe As HieuXeDTO) As Result
        Return hieuxeDAL.insertForce(hieuxe)
    End Function


    Public Function selectALL(ByRef listHieuXe As List(Of HieuXeDTO)) As Result
        Return hieuxeDAL.selectALL(listhieuxe)
    End Function

    Public Function selectALL_ByHieuXe( ByRef listHieuXe As List(Of HieuXeDTO)) As Result
        Return hieuxeDAL.selectALL_ByHieuXe(HIEUXE, listhieuxe)
    End Function
	Public Function delete(hieuxe As HieuXeDTO) As Result
        Return hieuxeDAL.delete(hieuxe)
    End Function
End Class