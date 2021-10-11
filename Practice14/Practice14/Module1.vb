Module Module1

    Sub Main()
        Dim cnt As Integer
        Dim cash As Integer
        Dim amount As Integer
        Do
            Console.Write("1預金、2引出、３照会、4終了")
            cnt = Integer.Parse(Console.ReadLine())

            Select Case (cnt)
                Case 1
                    Console.WriteLine("金額を入力してください。")
                    cash = Integer.Parse(Console.ReadLine())
                    amount = amount + cash
                    If amount >= 100000 Then
                        Console.WriteLine("100000円を超えています。")
                        amount = amount - cash
                    End If

                Case 2
                    Console.WriteLine("金額を入力してください。")
                    cash = Integer.Parse(Console.ReadLine())
                    If cash >= amount Then
                        Console.WriteLine("0円未満です。")
                    Else
                        amount = amount - cash
                    End If

                Case 3
                    Console.WriteLine("現在の金額は" & amount & "円です")

                Case 4
                    Console.WriteLine("終わり")
            End Select
        Loop While cnt <= 3


    End Sub

End Module
