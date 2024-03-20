Public Class Class5
    Public Sub Fibonacci()

        Console.Write("enter the size of values to print Fibonacci series : ")
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
