Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility
Public Class TiepNhanXeSuaBUS
    Private xeDAL As TiepNhanXeSuaDAL
    Public Sub New()
        xeDAL = New TiepNhanXeSuaDAL()
    End Sub
    Public Sub New(connectionString As String)
        xeDAL = New TiepNhanXeSuaDAL(connectionString)
    End Sub
    Public Function insert(xe As TiepNhanXeSuaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return xeDAL.insertXe(xe)
    End Function
End Class
