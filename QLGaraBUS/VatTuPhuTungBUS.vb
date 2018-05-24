Imports QLGaraDAL
Imports QLGaraDTO
Imports QLGaraGUI
Imports Utility

Public Class VatTuPhuTungBus
    Private vattuphutungDAL As VatTuPhuTungDAL
    Public Sub New()
        vattuphutungDAL = New VatTuPhuTungDAL()
    End Sub
    Public Sub New(connectionString As String)
        vattuphutungDAL = New VatTuPhuTungDAL(connectionString)
    End Sub

    Public Function insert(vattuphutung As VatTuPhuTungDTO) As Result
        Return vattuphutungDAL.insert(vattuphutung)
    End Function

    Public Function insertForce(vattuphutung As VatTuPhuTungDTO) As Result
        Return vattuphutungDAL.insertForce(vattuphutung)
    End Function


    Public Function selectALL(ByRef listvattuphutung As List(Of VatTuPhuTungDTO)) As Result
        Return vattuphutungDAL.selectALL(listvattuphutung)
    End Function

    Public Function selectALL_Byvattuphutung( ByRef listvattuphutung As List(Of VatTuPhuTungDTO)) As Result
        Return vattuphutungDAL.selectALL_Byvattuphutung(vattuphutung, listvattuphutung)
    End Function
	Public Function delete(vattuphutung As VatTuPhuTungDTO) As Result
        Return vattuphutungDAL.delete(vattuphutung)
    End Function
End Class