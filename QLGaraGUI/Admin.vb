Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
           Form2.Show() //form trong 5.1 5.2
       Else
           MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid")
       End If
   End Sub
End Class
