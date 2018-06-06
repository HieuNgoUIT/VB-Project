Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility
Public Class XuatPhieuBus
    Private xuatphieuDAL As XuatPhieuDAL
    Public Sub New()
        xuatphieuDAL = New XuatPhieuDAL()
    End Sub
    Public Sub New(connectionString As String)
        xuatphieuDAL = New XuatPhieuDAL(connectionString)
    End Sub
    Public Function selectAll(ByRef listXe As List(Of TiepNhanXeSuaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return xuatphieuDAL.selectALL(listXe)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return xuatphieuDAL.getNextID(nextID)
    End Function
End Class
