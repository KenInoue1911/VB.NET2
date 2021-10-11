Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox3.Enabled = True
        Else
            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            Dim num1 As Integer
            Dim num2 As Integer
            Dim num3 As Integer
            Dim tax As Integer

            num1 = Integer.Parse(TextBox1.Text)
            num2 = Integer.Parse(TextBox2.Text)
            num3 = Integer.Parse(TextBox3.Text)

            If RadioButton1.Checked = True Then
                tax = num2 / 100 * num1 + num1
                Label4.Text = tax * (1 - num3 / 100)
            Else
                Label4.Text = num1 * (1 - num3 / 100)
            End If

        Else
            Dim num1 As Integer
            Dim num2 As Integer
            Dim tax As Integer

            num1 = Integer.Parse(TextBox1.Text)
            num2 = Integer.Parse(TextBox2.Text)

            If RadioButton1.Checked = True Then
                tax = num2 / 100 * num1 + num1
                Label4.Text = tax
            Else
                Label4.Text = num1
            End If

        End If
    End Sub

End Class
