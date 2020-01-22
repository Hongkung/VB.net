Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer

        x = MsgBox("3개 버튼 1개 클릭", vbYesNoCancel + vbQuestion, "두번째")

        Select Case x
            Case 6 'msgBOX함수가 반환하는 정수결과
                MessageBox.Show("yes")
            Case 7
                MessageBox.Show("no")
            Case 2
                MessageBox.Show("cancle")

        End Select
    End Sub
End Class
