Public Class Class5
    Public Sub Fibonacci()

        Console.WriteLine("enter the size of values")
        Dim size = Console.ReadLine()
        Dim i As Integer = 1
        Dim a As Integer = 1
        Dim b As Integer = 1
        Dim c As Integer

        While i <= size
            Console.WriteLine(a)
            c = a + b
            a = b
            b = c
            i += 1
        End While

    End Sub

End Class
