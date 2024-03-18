



Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim num1 As Double = txtNum1.Text
        Dim num2 As Double = txtNum2.Text

        Dim sum As Integer
        sum = num1 + num2
        TextBox3.Text = sum
        If Double.IsNaN(num1) Or Double.IsNaN(num2) Then
            ' Handle invalid input (e.g., show an error message)
            Response.Write("Please enter valid numbers.")
        Else
            Dim result As Double = num1 + num2
            ' Do something with the result (e.g., display it on a label)
        End If
    End Sub
    Protected Sub Subtract_Click(sender As Object, e As EventArgs) Handles Subtract.Click 'id dete hain
        Dim num1 As Double = txtNum1.Text
        Dim num2 As Double = txtNum2.Text
        Dim Subtract As Integer
        Subtract = num1 - num2
        TextBox3.Text = Subtract
        If Double.IsNaN(num1) Or Double.IsNaN(num2) Then
            ' Handle invalid input (e.g., show an error message)
            Response.Write("Please enter valid numbers.")
        Else
            Dim result As Double = num1 - num2
            ' Do something with the result (e.g., display it on a label)
        End If
    End Sub
    Protected Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click
        Dim num1 As Double = txtNum1.Text
        Dim num2 As Double = txtNum2.Text
        Dim mul As Integer
        mul = num1 * num2
        TextBox3.Text = mul
        If Double.IsNaN(num1) Or Double.IsNaN(num2) Then
            ' Handle invalid input (e.g., show an error message)
            Response.Write("Please enter valid numbers.")
        Else
            Dim result As Double = num1 * num2
            ' Do something with the result (e.g., display it on a label)
        End If
    End Sub
    Protected Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide.Click
        Dim num1 As Double = txtNum1.Text
        Dim num2 As Double = txtNum2.Text
        Dim div As Integer
        div = num1 / num2
        TextBox3.Text = div
        If Double.IsNaN(num1) Or Double.IsNaN(num2) Then
            ' Handle invalid input (e.g., show an error message)
            Response.Write("Please enter valid numbers.")
        Else
            Dim result As Double = num1 / num2
            ' Do something with the result (e.g., display it on a label)
        End If
    End Sub
    Protected Sub Modulus_Click(sender As Object, e As EventArgs) Handles Modulus.Click
        Dim num1 As Double = txtNum1.Text
        Dim num2 As Double = txtNum2.Text
        Dim modl As Integer
        modl = num1 Mod num2
        TextBox3.Text = modl
        If Double.IsNaN(num1) Or Double.IsNaN(num2) Then
            ' Handle invalid input (e.g., show an error message)
            Response.Write("Please enter valid numbers.")
        Else
            Dim result As Double = num1 Mod num2
            ' Do something with the result (e.g., display it on a label)
        End If
    End Sub


End Class