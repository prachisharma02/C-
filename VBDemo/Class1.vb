Public Class Class1

    Public Sub Even()
        Console.WriteLine("Even values upto 20")
        For i = 1 To 20
            If i Mod 2 = 0 Then
                Console.Write(i & " ")

            End If
        Next
        Console.WriteLine()

    End Sub

End Class
