Module Module1

    Sub Mycomp()

        Dim x As Integer
        Dim y As Integer
        Dim z As Integer

        Console.Write("整数値を入力してください。")
        x = Integer.Parse(Console.ReadLine())
        Console.Write("整数値を入力してください。")
        y = Integer.Parse(Console.ReadLine())

        If x > y Then
            z = x
        Else
            z = y

        End If

        Console.WriteLine("大きい値は" & z & "です。")

    End Sub
    Sub Main()
        Mycomp()
    End Sub

End Module
