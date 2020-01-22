Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, bmi As Single

        num1 = CType(T1.Text, Single)
        num2 = CType(T2.Text, Single) * 0.01

        bmi = num1 / (num2 * num2)

        T3.Text = bmi
    End Sub

    '형변환을 이용한 간단한 체질량지수 계산기 BMI


End Class