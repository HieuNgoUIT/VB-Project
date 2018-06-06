Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility
Public Class NguyenLieuBUS
    Private nguyenlieuDAL As NguyenLieuDAL
    Public Sub New()
        nguyenlieuDAL = New NguyenLieuDAL()
    End Sub
    Public Sub New(connectionString As String)
        nguyenlieuDAL = New NguyenLieuDAL(connectionString)
    End Sub
    Public Function selectAll(ByRef listXe As List(Of NguyenLieuDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nguyenlieuDAL.selectALL(listXe)
    End Function
End Class
