Public Class Form1
    Dim person As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        person = TextBox1.Text

        BirthdayGreeing(person)

    End Sub
End Class
