Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tdfk() As String = {"東京", "大阪", "名古屋"}

        For Each ken As String In tdfk
            ListBox1.Items.Add(ken)
        Next

        ListBox1.SelectionMode = SelectionMode.MultiSimple
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = ""
        For Each itm As String In ListBox1.SelectedItems
            str &= itm & " "
        Next
        MsgBox(str)
    End Sub
End Class
