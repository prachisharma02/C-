Public Class Class6

    Public Sub Patterns()
        Console.WriteLine("enter the size ")
        Dim size = Console.ReadLine()
        Console.WriteLine()

        Console.WriteLine("------------------Square------------------")


        Dim i As Integer
        For i = 1 To size
            Dim j As Integer
            For j = 1 To size
                Console.Write("* ")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()

        Console.WriteLine("------------------Triangle------------------")

        For i = 1 To size
            Dim k As Integer
            For k = 1 To size - i
                Console.Write(" ")
            Next
            Dim j As Integer
            For j = 1 To i
                Console.Write("* ")
            Next
            Console.WriteLine()
        Next
    End Sub

End Class
