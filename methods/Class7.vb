Public Class Reversestring

    Public Sub Revstr()
        Console.WriteLine()
        Dim value As String
        value = "hello hi myself prachi"

        Console.WriteLine("original string is :  " & value)


        Dim reversedValue As String = ""
        For i = Len(value) To 1 Step -1
            reversedValue &= Mid(value, i, 1)
        Next i
        Console.WriteLine("Reversing the whole string : " & reversedValue)

        Console.WriteLine()

    End Sub

    Public Sub Revwords()
        Dim value2 As String = "hello hi myself prachi"

        Dim reversedWords2 As String = ""
        Dim words() As String = value2.Split(" ") ' Split the string into an array of words

        For Each word As String In words
            Dim reversedWord2 As String = ""
            For i = Len(word) To 1 Step -1 ' Reverse each word individually
                reversedWord2 &= Mid(word, i, 1)
            Next i
            reversedWords2 &= reversedWord2 & " " ' Append reversed word to the result string
        Next

        ' Remove extra space at the end
        reversedWords2 = reversedWords2.Trim()

        Console.WriteLine("reversing only words : " & reversedWords2)

        Console.WriteLine()


    End Sub

End Class
