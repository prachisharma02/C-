Public MustInherit Class Class9
    Public Shared SharedVariable As Integer

    Public Const FinalVariable As String = "This is a final variable."

    Public MustOverride Sub AbstractMethod()

    Public Shared Sub SharedMethod()
        Console.WriteLine("This is a shared method.")
    End Sub

    Public Sub NonAbstractMethod()
        Console.WriteLine("This is a non-abstract method.")
    End Sub
End Class

Public Class MyDerivedClass
    Inherits Class9

    Public Overrides Sub AbstractMethod()
        Console.WriteLine("This is an implementation of the abstract method.")
    End Sub
End Class


