Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility
Public Class QLHieuxe
    Private hieuxeBus As HieuXeBus
    Private Sub HieuXeFilter_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles ThanhTienFilter.SELECTedIndexChanged
    Dim listHieuXe = New List(Of HieuXeDTO)
        Dim result As Result
        result = HieuXeBus.selectAll(HIEUXE)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách hieu xe không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        listHieuXe.DataSource = New BindingSource(listHieuXe, String.Empty)
        listHieuXe.DisplayMember = "HieuXe"
        listHieuXe.ValueMember = "HieuXe"
        Dim myCurrencyManager As CurrencyManager = Me.BindingContext(HieuXe.DataSource)
        myCurrencyManager.Refresh()
        HieuXe.SELECTedIndex = 0
        If (HieuXe.Count > 0) Then
            HieuXe.SELECTedIndex = 0
        End If
	End Sub
End Class