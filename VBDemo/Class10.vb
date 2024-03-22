
' First interface
Public Interface IFirstInterface
    Sub MustOverride Method()
End Interface

    ' Second interface
    Public Interface ISecondInterface
        Sub Method()
    End Interface

' Class implementing both interfaces
Public Class MyClass10
    Implements IFirstInterface, ISecondInterface

    Public Sub Method() Implements IFirstInterface.Method
        Dim a As Integer
        Console.WriteLine("Method from ISecondInterface")
    End Sub

    ' Implementation of Method for the second interface
    Public Sub Method() Implements ISecondInterface.Method
        Console.WriteLine("Method from ISecondInterface")
    End Sub
End Class


