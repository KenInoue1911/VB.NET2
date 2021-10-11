Module Module1

    Sub Main()
        Dim Fire As Integer

        Console.Write("火力を選んで下さい(1～3)")
        Fire = Integer.Parse(Console.ReadLine())

        If Fire = 1 Then
            Console.WriteLine("弱火にしました")
        ElseIf Fire = 2 Then
            Console.WriteLine("中火にしました")
        ElseIf Fire = 3 Then
            Console.WriteLine("強火にしました")
        End If
    End Sub

End Module
