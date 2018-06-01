
Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility
Public Class TonCuoi
'class nay la nhap xuat gia tri tu csdl
    Private toncuoiBUS As TonCuoiBUS

    Private Sub toncuoi_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles TonCuoi.SELECTedIndexChanged
    Dim result As Result
        result = toncuoiBus.insert(toncuoiDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			
        Else
            MessageBox.Show("Thêm không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Try
    Dim toncuoi = CType(toncuoi.SELECTedItem, TonCuoiDTO)

            Dim listTonCuoi = New List(Of TonCuoiDTO)
            Dim Result = TonCuoiBus.selectALL_ByTonCuoi(THONGKE.TONCUOI, listTonCuoi)
            If (Result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(Result.SystemMessage)
                Return
            End If

            TonCuoi.DataSource = New BindingSource(listTonCuoi, String.Empty)
            TonCuoi.DisplayMember = "TonCuoi"
            TonCuoi.ValueMember = "TonCuoi"
            Dim myCurrencyManager As CurrencyManager = Me.BindingContext(TonCuoi.DataSource)
            myCurrencyManager.Refresh()
            If (listTonCuoi.Count > 0) Then
                TonCuoi.SELECTedIndex = 0
            End If
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
End Class