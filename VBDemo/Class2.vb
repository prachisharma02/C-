Public Class Class2
    Public Sub Factorial()
        Console.Write("Input value to find Factorial : ")
        Dim value = Console.ReadLine

        Dim i As Integer = 1
        Dim fact As Integer = 1
        While i < value
            fact *= i + 1
            i += 1
        End While
        Console.WriteLine(value & "  factorial is " & fact)

    End Sub

End Class
