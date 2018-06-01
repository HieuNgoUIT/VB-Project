Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility
Public Class TonCuoi
'class nay la nhap xuat gia tri tu csdl
    Private phatsinhBUS As PhatSinhBUS

    Private Sub phatsinh_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles PhatSinh.SELECTedIndexChanged
    Dim result As Result
        result = phatsinhBus.insert(phatsinhDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			
        Else
            MessageBox.Show("Thêm không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Try
    Dim phatsinh = CType(phatsinh.SELECTedItem, PhatSinhDTO)

            Dim listPhatSinh = New List(Of PhatSinhDTO)
            Dim Result = PhatSinhBus.selectALL_ByPhatSinh(THONGKE.PHATSINH, listPhatSinh)
            If (Result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(Result.SystemMessage)
                Return
            End If

            PhatSinh.DataSource = New BindingSource(listPhatSinh, String.Empty)
            PhatSinh.DisplayMember = "PhatSinh"
            PhatSinh.ValueMember = "PhatSinh"
            Dim myCurrencyManager As CurrencyManager = Me.BindingContext(PhatSinh.DataSource)
            myCurrencyManager.Refresh()
            If (listPhatSinh.Count > 0) Then
                PhatSinh.SELECTedIndex = 0
            End If
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
End Class