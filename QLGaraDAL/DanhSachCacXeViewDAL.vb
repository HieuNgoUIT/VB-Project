Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility

Public Class BienSoDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

   
    
    Public Function insert(ds As DanhSachDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO TIEPNHAN (BIENSO, HIEUXE, TENCHUXE,DIACHI,DIENTHOAI,NGAYTIEPNHAN)"
        query &= "VALUES (@BIENSO, @HIEUXE, @TENCHUXE,@DIACHI,@DIENTHOAI,@NGAYTIEPNHAN)"

      
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@BIENSO", hk.BienSo)
                    .Parameters.AddWithValue("@HIEUXE", hk.HieuXe)
                    .Parameters.AddWithValue("@TENCHUXE", hk.TenChuXe)
                    .Parameters.AddWithValue("@DIACHI", hk.DiaChi)
					.Parameters.AddWithValue("@DIENTHOAI", hk.DienThoai)
                    .Parameters.AddWithValue("@NGAYTIEPNHAN", hk.NgayTiepNhan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    

    Public Function delete(maLoai As Integer) As Result

        Dim query As String = String.Empty     
		query &= " DELETE FROM TIEPNHAN "
        query &= " WHERE "
        query &= " BIENSO = @BIENSO "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@BIENSO", maLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa  không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
