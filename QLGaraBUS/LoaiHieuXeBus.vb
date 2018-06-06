Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility
Public Class LoaiHieuXeBus
    Private lhxDAL As LoaiHieuXeDAL
    Public Sub New()
        lhxDAL = New LoaiHieuXeDAL()
    End Sub
    Public Sub New(connectionString As String)
        lhxDAL = New LoaiHieuXeDAL(connectionString)
    End Sub
    Public Function selectAll(ByRef listLoaiHX As List(Of LoaiHieuXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return lhxDAL.selectALL(listLoaiHX)
    End Function
End Class
