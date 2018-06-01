Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports QLGaraBUS
Imports QLGaraGUI
Imports Utility

Public Class DoanhSoDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(hieuxe As HieuXeDTO) As Result

        Dim f = False
        Dim result = select_Check(HIEUXE, f)
        If (result.FlagResult = False) Then
            Return result
        End If
        If (f = True) Then 'Hieu Xe existed on DB
            Return Me.update(HIEUXE)
        End If

        Dim query As String = String.Empty
        query &= "INSERT INTO THONGKE ( HIEUXE,THANG,TONGDOANHTHU,SOLUOTSUA,THANHTIEN,TILE,VATTUPHUTUNG,TONDAU,PHATSINH,TONCUOI)"
        query &= "VALUES (@HIEUXE,@THANG,@TONGDOANHTHU,@SOLUOTSUA,@THANHTIEN,@TILE,@VATTUPHUTUNG,@TONDAU,@PHATSINH,@TONCUOI)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@HIEUXE", THONGKE.HIEUXE)
                    .Parameters.AddWithValue("@THANG", THONGKE.THANG)
                    .Parameters.AddWithValue("@TONGDOANHTHU", THONGKE.TONGDOANHTHU)
                    .Parameters.AddWithValue("@SOLUOTSUA", THONGKE.SOLUOTSUA)
                    .Parameters.AddWithValue("@THANHTIEN", THONGKE.THANHTIEN)
                    .Parameters.AddWithValue("@TILE", THONGKE.TILE)
                    .Parameters.AddWithValue("@VATTUPHUTUNG", THONGKE.VATTUPHUTUNG)
					.Parameters.AddWithValue("@VATTUPHUTUNG", THONGKE.VATTUPHUTUNG)
                    .Parameters.AddWithValue("@TONDAU", THONGKE.TONDAU)
                    .Parameters.AddWithValue("@PHATSINH", THONGKE.PHATSINH)
					.Parameters.AddWithValue("@TONCUOI", THONGKE.TONCUOI)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm  không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
