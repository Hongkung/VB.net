Imports System.Math

Public Class Form1

    Dim x, y As String

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Visible = False

        'Rnd() 0~1사이의 수를 랜덤으로 출력한다. 
        Label1.Text = CStr(Int(Rnd() * 10))
        Label2.Text = CStr(Int(Rnd() * 10))
        Label3.Text = CStr(Int(Rnd() * 10))
        spins += 1

        spcoun.Text = hitRate(wins, spins)
        If Label1.Text = "7" Or Label2.Text = "7" Or Label3.Text = "7" Then
            Button2.Visible = True
            Beep()
            'wins는 모듈에서 선언한 공용변수
            wins = wins + 1
            idlwins.text = "winds: " & wins

        End If


    End Sub

End Class
