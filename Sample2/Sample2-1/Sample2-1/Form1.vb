Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kazu As String
        kazu = TextBox1.Text
        Button1.Text = kazu & "度です"
    End Sub
End Class
