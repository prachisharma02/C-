Public Class Class10
    Public Sub Pattern()
        Console.WriteLine("enter the size")
        Dim size = Console.ReadLine()

        Dim i As Integer = 1
        While i <= size
            Dim j As Integer = 1
            While j <= i
                Console.Write("*")
                j += 1
            End While
            Dim k As Integer = 1
            While k <= (size - i) * 2
                Console.Write(" ")
                k += 1
            End While
            Dim l As Integer = 1
            While l <= i
                Console.Write("*")
                l += 1
            End While
            i += 1
            Console.WriteLine()
        End While

        i = size - 1
        While i >= 1
            Dim j As Integer = 1
                While j <= i
                    Console.Write("*")
                    j += 1
                End While
                Dim k As Integer = 1
                While k <= (size - i) * 2
                    Console.Write(" ")
                    k += 1
                End While
                Dim l As Integer = 1
                While l <= i
                    Console.Write("*")
                    l += 1
            End While
            Console.WriteLine()
            i -= 1


        End While




    End Sub

End Class
