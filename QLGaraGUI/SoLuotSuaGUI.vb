Imports QLGaraBUS
Imports QLGaraDTO
Imports QLGaraDAL
Imports Utility
Public Class SoLuotSua
'class nay la nhap xuat gia tri tu csdl
    Private soluotsuaBUS As SoLuotSuaBUS

    Private Sub SoLuotSua_SELECTedIndexChanged(sender As Object, e As EventArgs) Handles SoLuotSua.SELECTedIndexChanged
    Dim result As Result
        result = soluotsuaBus.insert(soluotsuaDTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
			
        Else
            MessageBox.Show("Thêm không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Try
    Dim soluotsua = CType(soluotsua.SELECTedItem, SoLuotSuaDTO)

            Dim listSoLuotSua = New List(Of SoLuotSuaDTO)
            Dim Result = SoLuotSuaBus.selectALL_BySoLuotSua(THONGKE.SOLUOTSUA, listSoLuotSua)
            If (Result.FlagResult = False) Then
                MessageBox.Show("Lấy danh sách không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(Result.SystemMessage)
                Return
            End If

            SoLuotSua.DataSource = New BindingSource(listSoLuotSua, String.Empty)
            SoLuotSua.DisplayMember = "SoLuotSua"
            SoLuotSua.ValueMember = "SoLuotSua"
            Dim myCurrencyManager As CurrencyManager = Me.BindingContext(SoLuotSua.DataSource)
            myCurrencyManager.Refresh()
            If (listSoLuotSua.Count > 0) Then
                 SoLuotSua.SELECTedIndex = 0
            End If
        Catch ex As Exception
            System.Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
End Class