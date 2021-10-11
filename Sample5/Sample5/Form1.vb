Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For cnt As Integer = 1950 To 2000
            ComboBox1.Items.Add(cnt)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = ComboBox1.SelectedIndex
        MsgBox(ComboBox1.Text)
    End Sub
End Class
