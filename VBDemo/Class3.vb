Public Class Class3

    Public Sub Sum()

        Console.WriteLine("enter the size of array")
        Dim size = Console.ReadLine()
        Console.WriteLine("Enter array values to find their sum")
        Dim val As Integer
        Dim intvalues(size) As Integer
        For val = 1 To size
            Dim values = Convert.ToInt32(Console.ReadLine())
            intvalues(val) = values
        Next

        Dim i As Integer
        Dim sum As Integer = 0
        For Each i In intvalues
            sum += i
        Next
        Console.WriteLine("and their sum is : " & sum)

        Console.ReadLine()

    End Sub

End Class
