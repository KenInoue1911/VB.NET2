Module Module1

    Sub Main()
        Dim score() As Integer = {1, 2, 3, 4, 5}
        For Each num As Integer In score
            Console.WriteLine("得点は" & num & "点です")
        Next
    End Sub

End Module
