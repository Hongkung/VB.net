Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, add, minus, multi, div As Single
        'CType의사용, 명시적 형변환
        num1 = CType(Me.tb1.Text, Single)
        num2 = CType(Me.tb2.Text, Single)

        add = num1 + num2
        minus = num1 - num2
        multi = num1 * num2
        div = num1 / num2


        '수치형 데이터를 문자열로 변환
        '.ToString()은 Single타입의 메서드 .ToString()을 사용한것.
        Me.TextBox1.Text = add.ToString()

        'toString의 경우 그냥 .ToString()<<이런 식으로 쓰자
        Me.TextBox2.Text = minus.ToString

        'CStr은 형변환 함수로서 Convert to String
        Me.TextBox3.Text = CStr(multi)


        Me.TextBox4.Text = div




    End Sub


End Class
