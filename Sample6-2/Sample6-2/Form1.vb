Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim office() As String = {"Excel", "Word", "PowerPoint", "Access"}
        For Each Ken As String In office
            ListBox1.Items.Add(Ken)
        Next
        ListBox1.SelectionMode = SelectionMode.MultiSimple
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnt As Integer = ListBox1.SelectedItems.Count
        Label2.Text = 5000 * cnt & "円"
    End Sub
End Class
