Module Module1

    Sub Main()

        For cnt As Integer = 10 To 0 Step -1
            Console.WriteLine(cnt)
            If cnt = 0 Then
                Console.WriteLine("Finish!")
            End If
        Next
    End Sub

End Module
