Public Class Class9
    Public Sub Pattern()

        Console.Write("enter the size : ")
        Dim size = Console.ReadLine()

        Dim i As Integer = 1
        Do While i <= size

            Dim j As Integer = 1
            Do While j <= i
                Console.Write("*")
                j += 1
            Loop

            Dim k As Integer = 1
            Do While k <= (size - i) * 2
                Console.Write(" ")
                k += 1
            Loop

            Dim l As Integer = 1
            Do While l <= i
                Console.Write("*")
                l += 1
            Loop
            Console.WriteLine()
            i += 1
        Loop

        i = size - 1
        Do While i >= 1
            Dim j As Integer = 1
            Do While j <= i
                Console.Write("*")
                j += 1
            Loop

            Dim k As Integer = 1
            Do While k <= (size - i) * 2
                Console.Write(" ")
                k += 1
            Loop

            Dim l As Integer = 1
            Do While l <= i
                Console.Write("*")
                l += 1
            Loop

            Console.WriteLine()
            i -= 1
        Loop

        Console.ReadLine()




    End Sub
End Class
