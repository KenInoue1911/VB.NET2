Public Class Class1
    Dim name As String
    Dim score As Integer

    Sub SetData(tmpName As String, tmpScore As Integer)

        name = tmpName
        score = tmpScore

    End Sub

    Function disp() As String
        Return "名前：" & name & "点数：" & score
    End Function
End Class
