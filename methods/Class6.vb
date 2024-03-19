Public Class Checks
    Public Sub Evenodd()
        Console.Write("Please enter the no to check even and odd :")
        Dim a As Integer = Console.ReadLine()
        If a Mod 2 = 0 Then
            If a < 0 Then
                Console.WriteLine("Even odd cant be checked in negetive values ")
            Else
                Console.WriteLine(" number is evem")
            End If
        Else
            If a < 0 Then
                Console.WriteLine("Even odd cant be checked in negetive values ")
            Else
                Console.WriteLine(" number is odd")
            End If

        End If

        Console.WriteLine()



    End Sub
End Class
