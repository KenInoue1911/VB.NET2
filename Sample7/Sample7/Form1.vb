Public Class Form1
    Private Sub SetColor(bcolor As Color, fcolor As Color)
        TextBox1.BackColor = bcolor
        TextBox1.ForeColor = fcolor
        ComboBox1.BackColor = bcolor
        ComboBox1.ForeColor = fcolor
        ListBox1.BackColor = bcolor
        ListBox1.ForeColor = fcolor
        Me.BackColor = bcolor
        Me.ForeColor = fcolor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SetColor(Button1.BackColor, Button1.ForeColor)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SetColor(Button2.BackColor, Button2.ForeColor)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SetColor(Button3.BackColor, Button3.ForeColor)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SetColor(Button4.BackColor, Button4.ForeColor)
    End Sub
End Class
