Public Class Class8
    Public Sub Pattern()
        Console.Write("Enter the size: ")
        Dim size As Integer = Console.ReadLine()
        ' Adjust the size of the pattern as needed
        For i As Integer = 1 To size
            For j As Integer = 1 To i
                Console.Write("*")
            Next
            For k As Integer = 1 To (size - i) * 2
                Console.Write(" ")
            Next
            For l As Integer = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        For i As Integer = size - 1 To 1 Step -1
            For j As Integer = 1 To i
                Console.Write("*")
            Next
            For k As Integer = 1 To (size - i) * 2
                Console.Write(" ")
            Next
            For l As Integer = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub

End Class
