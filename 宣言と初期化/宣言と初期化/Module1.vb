Module Module1

    Sub Main()
        Dim score() As Integer = {1, 2, 3, 4, 5}
        Console.WriteLine("生徒番号1:得点" & score(0))
        Console.WriteLine("生徒番号2:得点" & score(1))
        Console.WriteLine("生徒番号3:得点" & score(2))
        Console.WriteLine("生徒番号4:得点" & score(3))
        Console.WriteLine("生徒番号5:得点" & score(4))

        For cnt As Integer = 0 To 4
            Console.WriteLine("生徒番号" & (cnt + 1) & "得点は" & score(cnt) & "点です")
        Next
    End Sub

End Module
