Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGaraDTO
Imports Utility
Public Class LoaiHieuXeDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL(ByRef listLoaiHX As List(Of LoaiHieuXeDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [mahieuxe], [tenhieuxe]"
        query &= " FROM [dbMaHieuXe]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listLoaiHX.Clear()
                        While reader.Read()
                            listLoaiHX.Add(New LoaiHieuXeDTO(reader("mahieuxe"), reader("tenhieuxe")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại hiệu xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
