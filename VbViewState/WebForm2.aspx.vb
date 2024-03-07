Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Value of TextBox1 and TextBox2 is assigned to the ViewState
        ViewState("name") = TextBox1.Text
        ViewState("password") = TextBox2.Text

        ' After clicking on Button, TextBox value will be cleared
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' If ViewState values are not null, assign them to TextBoxes
        If ViewState("name") IsNot Nothing Then
            TextBox1.Text = ViewState("name").ToString()
        End If

        If ViewState("password") IsNot Nothing Then
            TextBox2.Text = ViewState("password").ToString()
        End If
    End Sub

End Class