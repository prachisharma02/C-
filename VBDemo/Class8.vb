Public Class Class8
    Shared SharedVariable As Integer

    Dim InstanceVariable As Integer

    Shared Sub New()
        SharedVariable = 10
    End Sub

    Public Sub New()
        InstanceVariable = 20
    End Sub

    Public Sub New(ByVal initialValue As Integer)
        InstanceVariable = initialValue

    End Sub

    Public Sub DisplayVariables()
        Console.WriteLine("Shared Variable: " & SharedVariable)
        Console.WriteLine("Instance Variable: " & InstanceVariable)
    End Sub
    Public Sub Add()
        Dim sum As Integer
        sum += InstanceVariable + SharedVariable
        Console.WriteLine("the sum of instance and shared variable is : " & sum)



    End Sub
End Class


