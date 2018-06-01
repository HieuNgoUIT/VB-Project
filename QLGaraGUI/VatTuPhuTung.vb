Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility
Public Class VatTuPhuTung
'class nay la nhap xuat gia tri tu csdl
    Private vattuphutungBUS As VatTuPhuTungBUS

    Private Sub vattuphutung_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles VatTuPhuTung.SELECTedIndexChanged
    Dim result As Result
        result = vattuphutungBus.insert(vattuphutungDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			
        Else
            MessageBox.Show("Thêm không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Try
    Dim vattuphutung = CType(vattuphutung.SELECTedItem,VatTuPhuTungDTO)

            Dim listVatTuPhuTung = New List(Of VatTuPhuTungDTO)
            Dim Result = VatTuPhuTungBus.selectALL_ByVatTuPhuTung(THONGKE.VATTUPHUTUNG, listVatTuPhuTung)
            If (Result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(Result.SystemMessage)
                Return
            End If

            VatTuPhuTung.DataSource = New BindingSource(listvatTuPhuTung, String.Empty)
            VatTuPhuTung.DisplayMember = "VatTuPhuTung"
            VatTuPhuTung.ValueMember = "VatTuPhuTung"
            Dim myCurrencyManager As CurrencyManager = Me.BindingContext(VatTuPhuTung.DataSource)
            myCurrencyManager.Refresh()
            If (listVatTuPhuTung.Count > 0) Then
                 VatTuPhuTung.SELECTedIndex = 0
            End If
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
End Class