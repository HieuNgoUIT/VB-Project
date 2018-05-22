Imports QLGaraDAL
Imports QLGaraDTO
Imports Utility

Public Class DanhSachCacXeViewBus
    Private xeDAL As XeDAL
    Public Sub New()
        xeDAL = New XeDAL()
    End Sub
    Public Sub New(connectionString As String)
        XeDAL = New XeDAL(connectionString)
    End Sub
    

    Public Function insert(ds As DanhSachCacXeViewDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return DanhSachCacXeViewDAL.insert(hk)
    End Function
   
    Public Function delete(ds As DanhSachCacXeViewDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return DanhSachCacXeViewDAL.delete(maLoai)
    End Function
    
