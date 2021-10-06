Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        name = TextBox1.Text
        Label2.Text = name & "さん、こんにちは"
    End Sub
End Class
