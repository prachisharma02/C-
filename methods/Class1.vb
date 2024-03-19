Public Class Exam
    Public Sub ExamScore()
        Console.Write("Please enter Exam Score:")
        Dim score As Integer = Console.ReadLine()
        If score >= 90 And score <= 100 Then
            Console.WriteLine("Grade Is A")
        ElseIf score >= 80 And score <= 89 Then
            Console.WriteLine("Grade Is B")
        ElseIf score >= 70 And score <= 79 Then
            Console.WriteLine("Grade Is C")
        ElseIf score >= 60 And score <= 69 Then
            Console.WriteLine("Grade Is D")
        ElseIf score < 60 And score > 0 Then
            Console.WriteLine("Grade Is F")
        End If

        Console.WriteLine()


    End Sub


End Class
