Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer

        num1 = Integer.Parse(TextBox1.Text)
        num2 = Integer.Parse(TextBox2.Text)
        num3 = Integer.Parse(TextBox3.Text)

        Label4.Text = "割り勘" & Math.Round(num1 * num2 / num3) & "円"
        Label5.Text = "端数" & num1 * num2 Mod num3 & "円"
    End Sub
End Class
