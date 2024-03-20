Public Class Class7
    Public Sub Longest()

        Console.Write("enter the size of Array to find Longest String : ")
        Dim size = Console.ReadLine()
        Console.WriteLine("Enter array values ")
        Dim val As Integer
        Dim strvalues(size - 1) As String
        For val = 0 To size - 1
            Dim values = Console.ReadLine()
            strvalues(val) = values
        Next
        Dim maxlength As Integer = 0
        Dim correct As String = ""
        For Each i In strvalues

            Dim length As Integer = i.Length
            If (length > maxlength) Then
                maxlength = length
                correct = i
            End If

        Next
        Console.WriteLine("longest string is " & correct)

    End Sub

End Class
