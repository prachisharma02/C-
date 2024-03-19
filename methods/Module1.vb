Module Module1

    Sub Main()


        Dim a As Integer
        a = 21
        If a Mod 2 = 0 Then
            Console.WriteLine("a is even")
        Else
            Console.WriteLine(" a is odd")

        End If



        Dim value As String
        value = "hello hi myself prachi"

        Dim reversedValue As String = ""
        For i = Len(value) To 1 Step -1
            reversedValue &= Mid(value, i, 1)
        Next i
        Console.WriteLine(reversedValue)





        Dim value2 As String = "hello hi myself prachi"

        Dim reversedWords2 As String = ""
        Dim words() As String = value.Split(" ") ' Split the string into an array of words

        For Each word As String In words
            Dim reversedWord2 As String = ""
            For i = Len(word) To 1 Step -1 ' Reverse each word individually
                reversedWord2 &= Mid(word, i, 1)
            Next i
            reversedWords2 &= reversedWord2 & " " ' Append reversed word to the result string
        Next

        ' Remove extra space at the end
        reversedWords2 = reversedWords2.Trim()

        Console.WriteLine(reversedWords2) '





        'Dim value3 As String = "hello hi myself prachi"

        'Dim words3() As String = value.Split(" ")

        'Dim reversedWords3() As String
        'Dim j As Integer = reversedWords3.Length - 1

        'For i As Integer = 0 To words.Length - 1
        '    reversedWords3(j) = words(i)
        '    j -= 1
        'Next i

        'Dim finalString As String = String.Join(" ", reversedWords3)  ' Join the reversed words back with spaces

        'Console.WriteLine(finalString)  ' Output: prachi myself hi hello





        Console.ReadLine()
    End Sub












End Module
