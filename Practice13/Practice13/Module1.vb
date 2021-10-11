Module Module1

    Sub Main()
        Dim num As Integer
        Dim cash As Integer

        Do
            Console.Write("金額を入力してください。")
            num = Console.ReadLine()
            cash = cash + num
            Console.WriteLine("合計金額は" & cash & "円です。")

        Loop While cash < 1000

        Console.WriteLine("合計金額が1000円以上になったので終了します。")


    End Sub

End Module
