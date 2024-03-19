Public Class Week
    Public Sub Day()
        Console.Write("Please enter Day No : ")
        Dim day As Integer = Console.ReadLine()
        Select Case day
            Case 1
                Console.WriteLine(day & " is Sunday")
            Case 2
                Console.WriteLine(day & " is Monday")
            Case 3
                Console.WriteLine(day & " is Tuesday")
            Case 4
                Console.WriteLine(day & "is Wednesday")
            Case 5
                Console.WriteLine(day & " is Thursday")
            Case 6
                Console.WriteLine(day & " is Friday")
            Case 7
                Console.WriteLine(day & " is Saturday")
            Case Else
                Console.WriteLine("Please enter values between 1-7 ")
        End Select

        Console.WriteLine()
    End Sub

End Class
