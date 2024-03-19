Imports System.Linq.Expressions

Public Class Year
    Public Sub Days()
        Console.Write("Please enter Month No : ")
        Dim month As Integer = Console.ReadLine()

        Select Case month
            Case 1, 3, 5, 7, 8, 10, 12
                Console.WriteLine("This month contain 31 days")

            Case 4, 6, 9, 11
                Console.WriteLine("This month contain 30 days")
            Case 2
                Console.WriteLine("February contain 28 days")
            Case Else
                Console.WriteLine("Please enter valid values ")
        End Select

        Console.WriteLine()

    End Sub

End Class


'Public Class Year
'    Public Sub Days()
'        Console.Write("Please enter Month No : ")
'        Dim month As Integer = Console.ReadLine()

'        Select Case month
'            Case 1, 3, 5, 7, 8, 10, 12
'                Console.WriteLine("January contain 31 days")
'            Case 2
'                Console.WriteLine("February contain 28 days")
'            Case 3
'                Console.WriteLine("March contain 31 days")
'            Case 4
'                Console.WriteLine("April contain 31 days")
'            Case 5
'                Console.WriteLine("May contain 31 days")
'            Case 6
'                Console.WriteLine("June contain 31 days")
'            Case 7
'                Console.WriteLine("July contain 31 days")
'            Case 8
'                Console.WriteLine("August contain 30 days")
'            Case 9
'                Console.WriteLine("september contain 31 days")
'            Case 10
'                Console.WriteLine("October contain 31 days")
'            Case 11
'                Console.WriteLine("November contain 31 days")
'            Case 12
'                Console.WriteLine("December contain 28 days")
'            Case Else
'                Console.WriteLine("Please enter values between 1-12 ")
'        End Select
'    End Sub

'End Class
