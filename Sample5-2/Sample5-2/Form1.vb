Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("+")
        ComboBox1.Items.Add("-")
        ComboBox1.Items.Add("X")
        ComboBox1.Items.Add("/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer

        num1 = Integer.Parse(TextBox1.Text)
        num2 = Integer.Parse(TextBox2.Text)

        Select Case ComboBox1.SelectedIndex
            Case 0
                Label1.Text = num1 + num2
            Case 1
                Label1.Text = num1 - num2
            Case 2
                Label1.Text = num1 * num2
            Case 3
                Label1.Text = num1 / num2
        End Select

    End Sub

End Class
