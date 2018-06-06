Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility
Public Class PhieuThuTienBUS
    Private phieuthutienDAL As PhieuThuTienDAL
    Public Sub New()
        phieuthutienDAL = New PhieuThuTienDAL()
    End Sub
    Public Sub New(connectionString As String)
        phieuthutienDAL = New PhieuThuTienDAL(connectionString)
    End Sub
    Public Function selectAll(ByRef listXe As List(Of TiepNhanXeSuaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phieuthutienDAL.selectALL(listXe)
    End Function
End Class
