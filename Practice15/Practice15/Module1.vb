Module Module1

    Sub Main()
        Dim score(2) As Integer
        Dim amount As Integer
        Dim avarage As Integer

        For cnt As Integer = 0 To 2
            Console.Write("第" & cnt + 1 & "科目の結果を入力してください。")
            score(cnt) = Console.ReadLine()
        Next

        For cnt As Integer = 0 To 2
            Console.WriteLine("第" & cnt + 1 & "科目：" & score(cnt) & "点")
        Next

        amount = score(0) + score(1) + score(2)
        avarage = amount / 3

        Console.WriteLine("合計点は" & amount & "点です")
        Console.WriteLine("平均点は" & avarage & "点です")

    End Sub

End Module
