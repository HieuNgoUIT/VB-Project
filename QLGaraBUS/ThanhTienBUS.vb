Imports QLGaraDAL
Imports QLGaraDTO
Imports QLGaraGUI
Imports Utility

Public Class thanhtienBus
    Private thanhtienDAL As thanhtienDAL
    Public Sub New()
        thanhtienDAL = New ThanhTienDAL()
    End Sub
    Public Sub New(connectionString As String)
        thanhtienDAL = New ThanhTienDAL(connectionString)
    End Sub

    Public Function insert(thanhtien As ThanhTienDTO) As Result
        Return thanhtienDAL.insert(thanhtien)
    End Function

    Public Function insertForce(thanhtien As ThanhTienDTO) As Result
        Return thanhtienDAL.insertForce(thanhtien)
    End Function


    Public Function selectALL(ByRef listthanhtien As List(Of ThanhTienDTO)) As Result
        Return thanhtienDAL.selectALL(listthanhtien)
    End Function

    Public Function selectALL_Bythanhtien( ByRef listthanhtien As List(Of ThanhTienDTO)) As Result
        Return thanhtienDAL.selectALL_Bythanhtien(thanhtien, listthanhtien)
    End Function
	Public Function delete(thanhtien As ThanhTienDTO) As Result
        Return thanhtienDAL.delete(thanhtien)
    End Function
End Class