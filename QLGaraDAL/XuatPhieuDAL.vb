Imports QLGaraDTO
Imports Utility
Imports System.Data.SqlClient
Imports System.Configuration
Public Class XuatPhieuDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL(ByRef listXe As List(Of TiepNhanXeSuaDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [BIENSO], [NGAYTIEPNHAN]"
        query &= " FROM [TIEPNHAN]"


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
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New TiepNhanXeSuaDTO(reader("BIENSO"), reader("NGAYTIEPNHAN")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [thutuphieu] "
        query &= "FROM [PhieuXe] "
        query &= "ORDER BY [thutuphieu] DESC "

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
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("thutuphieu")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của phiếu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
