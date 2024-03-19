Public Class Leapyear
    Public Sub Leap()
        Console.Write("Please enter year : ")
        Dim year As Integer = Console.ReadLine()
        If year Mod 4 = 0 Then
            If year Mod 100 <> 0 Or year Mod 400 = 0 Then 'Years like 1900, 2100, 2200, etc., are divisible by 100 but not by 400, so they are not leap years, despite being divisible by 4.
                Console.WriteLine(year & " is a leap year.")
            Else                                                      '2016 is divisble by 4 but not by 100
                Console.WriteLine(year & " is not a leap year.")
            End If
        Else
            Console.WriteLine(year & " is not a leap year.")
        End If

        Console.WriteLine()

    End Sub

End Class
