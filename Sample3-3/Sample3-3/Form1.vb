Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim tax As Integer

        num1 = Integer.Parse(TextBox1.Text)
        num2 = Integer.Parse(TextBox2.Text)

        tax = num2 / 100 * num1

        Label3.Text = num1 + tax
    End Sub
End Class
