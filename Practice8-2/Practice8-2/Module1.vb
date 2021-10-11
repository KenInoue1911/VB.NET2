Module Module1

    Sub Main()
        Dim cnt As Integer = 1
        If cnt <= 3 Then
            Console.WriteLine(cnt)
            cnt = cnt + 1
        End If

        Dim cnt2 As Integer = 1
        Do While cnt2 <= 3
            Console.WriteLine(cnt2)
            cnt2 = cnt2 + 1
        Loop

        Dim password As String = "ABCD"
        Dim input As String

        Do
            Console.WriteLine("パスワードを入力してください")
            input = Console.ReadLine()
        Loop While input <> password
    End Sub

End Module
