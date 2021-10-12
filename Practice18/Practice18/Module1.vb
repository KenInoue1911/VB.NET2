Module Module1
    Sub Mycomp()
        Dim str As String = "★"
        Console.Write(str)


    End Sub
    Sub Main()
        Dim num As Integer
        Dim count As Integer

        Console.Write("表示回数を入力してください。")
        num = Integer.Parse(Console.ReadLine())
        Do
            Mycomp()
            count = count + 1
        Loop While num > count
        Console.WriteLine()

    End Sub

End Module
