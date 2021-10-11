Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox3.Enabled = True
        Else
            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer
        Dim tax As Integer

        If CheckBox1.Checked = True Then
            num1 = Integer.Parse(TextBox1.Text)
            num2 = Integer.Parse(TextBox2.Text)
            num3 = Integer.Parse(TextBox3.Text)

            tax = num2 / 100 * num1 + num1
            Label4.Text = tax * (1 - num3 / 100) & "円"

        Else
            num1 = Integer.Parse(TextBox1.Text)
            num2 = Integer.Parse(TextBox2.Text)

            tax = num2 / 100 * num1 + num1
            Label4.Text = tax & "円"
        End If


    End Sub
End Class
