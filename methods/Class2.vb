Public Class Age

    Public Sub Eligible()
        Console.Write("Please enter your Age:")
        Dim age As Integer = Console.ReadLine()
        If age <= 13 And age > 0 Then
            Console.WriteLine("You are a child")
        ElseIf age > 13 And age <= 19 Then
            Console.WriteLine("You are a teenager")
        ElseIf age >= 20 Then
            Console.WriteLine("You are an adult")
        End If

        Console.WriteLine()
    End Sub
End Class
