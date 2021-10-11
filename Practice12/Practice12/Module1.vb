Module Module1

    Sub Main()
        Dim num As Integer
        Dim cnt As Integer = 1

        Console.Write("数字を入力してください")
        num = Console.ReadLine()

        Do
            Console.Write("△")
            cnt = cnt + 1

        Loop While num >= cnt
        Console.WriteLine()

    End Sub

End Module
