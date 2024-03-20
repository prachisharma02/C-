Public Class Class4

    Public Sub Vowels()

        Console.Write("enter the String : ")
        Dim value = Console.ReadLine()
        Dim i As Integer = 1
        Dim count As Integer
        For i = 0 To value.Length - 1
            If (value(i) = "a" Or value(i) = "e" Or value(i) = "i" Or value(i) = "o" Or value(i) = "u") Then
                count += 1
            End If
        Next

        Console.WriteLine("Total vowels in string is " & count)

        Console.WriteLine()

    End Sub


End Class
