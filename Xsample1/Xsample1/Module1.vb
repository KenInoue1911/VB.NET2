Module Module1

    Sub Main()
        Dim student1 As Class1 = New Class1()
        Dim student2 As Class1 = New Class1()
        Dim student3 As Class1 = New Class1()

        student1.SetData("鈴木一郎：", 45)
        student2.SetData("山田花子：", 90)
        student3.SetData("田中次郎：", 70)

        Console.WriteLine(student1.disp())
        Console.WriteLine(student2.disp())
        Console.WriteLine(student3.disp())
    End Sub

End Module
