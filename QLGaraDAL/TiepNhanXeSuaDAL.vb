Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility


Public Class TiepNhanXeSuaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function insertXe(xe As TiepNhanXeSuaDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [TIEPNHAN] ([TENCHUXE], [BIENSO], [HIEUXE],[DIACHI],[DIENTHOAI],[NGAYTIEPNHAN],[THANHTIEN])"
        query &= "VALUES (@TENCHUXE, @BIENSO, @HIEUXE,@DIACHI,@DIENTHOAI,@NGAYTIEPNHAN,@THANHTIEN)"

        Using conn As New SqlConnection("Data Source=DESKTOP-M4843TO\SQLEXPRESS;Initial Catalog=VBPROJECT;Integrated Security=True")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TENCHUXE", xe.TenChuXe1)
                    .Parameters.AddWithValue("@BIENSO", xe.BienSo1)
                    .Parameters.AddWithValue("@HIEUXE", xe.HieuXe1)
                    .Parameters.AddWithValue("@DIACHI", xe.DiaChi1)
                    .Parameters.AddWithValue("@DIENTHOAI", xe.DienThoai1)
                    .Parameters.AddWithValue("@NGAYTIEPNHAN", xe.NgayTiepNhan1)
                    .Parameters.AddWithValue("@THANHTIEN", xe.ThanhTien1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
