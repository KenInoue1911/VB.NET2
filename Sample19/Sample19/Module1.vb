Module Module1

    Sub Main()
        Dim rtn As String
        rtn = Left("ABCD", 4)
        Console.WriteLine(rtn)

        Dim str2 As String = "ABCDEF"
        Dim num As Integer = 4

        Console.WriteLine(Left("ABCDEF", 4))
        Console.WriteLine(Left(str2, num))
        Console.WriteLine(Left("ABC" & "DEF", 2 * 2))
        Console.WriteLine(Left(str2, 2 * 2))

    End Sub

End Module
