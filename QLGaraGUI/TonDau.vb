Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility
Public Class VatTuPhuTung
'class nay la nhap xuat gia tri tu csdl
    Private tondauBUS As TonDauBUS

    Private Sub tondau_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles tondau.SELECTedIndexChanged
    Dim result As Result
        result = tondauBus.insert(vattuphutungDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			
        Else
            MessageBox.Show("Thêm không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Try
    Dim  = CType(tondau.SELECTedItem, TonDauDTO)

            Dim listTonDau = New List(Of TonDauDTO)
            Dim Result = TonDauBus.selectALL_ByTonDau(THONGKE.TONDAU, listTonDau)
            If (Result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(Result.SystemMessage)
                Return
            End If

            TonDau.DataSource = New BindingSource(listTonDau, String.Empty)
            TonDau.DisplayMember = "TonDau"
            TonDau.ValueMember = "TonDau"
            Dim myCurrencyManager As CurrencyManager = Me.BindingContext(TonDau.DataSource)
            myCurrencyManager.Refresh()
            If (listTonDau.Count > 0) Then
                 TonDau.SELECTedIndex = 0
            End If
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
End Class