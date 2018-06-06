Imports QLGaraDTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Configuration
Public Class NguyenLieuDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL(ByRef listnl As List(Of NguyenLieuDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [VATTU], [DONGIA]"
        query &= " FROM [NGUYENLIEU]"


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
                        listnl.Clear()
                        While reader.Read()
                            listnl.Add(New NguyenLieuDTO(reader("VATTU"), reader("DONGIA")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả nguyên liệu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class