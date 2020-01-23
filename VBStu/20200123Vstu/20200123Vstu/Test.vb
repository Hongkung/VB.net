Module Test
    Sub BirthdayGreeing(ByVal person As String)
        Dim Msg As String
        If person <> "" Then
            Msg = "Happy birthday" & person & "!"
        Else
            Msg = "Name not specified"
        End If
        MsgBox(Msg, , "best wishes")
    End Sub
End Module
