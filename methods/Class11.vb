Public Class Class11
    Public Sub Pattern()
        Console.WriteLine("Enter the size")
        Dim size As Integer = Integer.Parse(Console.ReadLine())

        ' Initialize a 2D array (matrix) to store the pattern
        Dim matrix(size * 2 - 1, size * 2 - 1) As Char

        ' Populate the matrix
        For i As Integer = 0 To size * 2 - 2
            For j As Integer = 0 To size * 2 - 2
                If j < size - i - 1 OrElse j > size + i - 1 Then
                    matrix(i, j) = " "c ' Fill with spaces
                Else
                    matrix(i, j) = "*"c ' Fill with stars
                End If
            Next
        Next

        ' Print the matrix
        For i As Integer = 0 To size * 2 - 2
            For j As Integer = 0 To size * 2 - 2
                Console.Write(matrix(i, j))
            Next
            Console.WriteLine()
        Next
    End Sub
End Class
