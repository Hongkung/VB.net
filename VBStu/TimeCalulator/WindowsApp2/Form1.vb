Public Class Form1

    Private TodayTime As Integer '22 ~ 24시 사이의 시간
    Private TomorrowTime As Integer '0~ 5시 사이의 시간
    Private Time As Integer '플레이 타임
    Private StartTime As Integer '시작시간
    Private EndTime As Integer '끝나는 시간

    Private Const Time_24 As Integer = 1440
    Private Const Time_StartLine As Integer = 1320
    Private Const Time_EndLine As Integer = 300

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        StartTime = CInt(TextBox1.Text.Trim)
        EndTime = CInt(TextBox2.Text.Trim)

        Calculator(StartTime, EndTime)

        Label1.Text = TodayTime
        Label2.Text = TomorrowTime
        Label3.Text = Time
    End Sub



    Private Sub Calculator(ByVal st As Integer, ByVal et As Integer)

        Dim stmin As Integer = st
        Dim enmin As Integer = et

        ConvertMin(stmin)
        ConvertMin(enmin)

        SetTime(stmin, enmin)
        SetTodayTime(stmin, enmin)
        SetTomorrowTime(stmin, enmin)

    End Sub

    Private Sub SetTime(ByVal smin As Integer, ByVal emin As Integer)
        '총시간 계산
        Try
            If emin < smin Then
                'endtime이 24 시간을 넘어 다음날이 될 경우
                Time = emin + Time_24
                Time = Time - smin
            Else
                Time = emin - smin
            End If

        Catch ex As Exception
            MsgBox("Error : SetTime")
            Time = 0
            Exit Sub
        End Try

    End Sub

    Private Sub SetTodayTime(ByVal smin As Integer, ByVal emin As Integer)
        Try
            'endtime이 0 or smin 보다 작으면 24시로 고정
            If emin = 0 Or emin < smin Then
                emin = Time_24
            End If

            If smin < Time_StartLine Then
                'starttime이 22시보다 작으면 22시로 고정
                smin = Time_StartLine
            End If
            '위의 조건에 들어가지 않으면 22시~24시 안쪽의 시간대이므로 그냥 빼기

            TodayTime = emin - smin

            If TodayTime < 0 Then
                TodayTime = 0
            End If

        Catch ex As Exception
            MsgBox("Error : SetTodayTime")
            TodayTime = 0
            Exit Sub
        End Try

    End Sub

    Private Sub SetTomorrowTime(ByVal smin As Integer, ByVal emin As Integer)
        Try
            If emin > Time_EndLine Then
                'emin이 5시 보다 크면 5시로 고정
                emin = Time_EndLine
            End If
            If emin < smin Then
                ' smin이 emin보다 크면 24시로 고정
                smin = 0
            End If

            TomorrowTime = emin - smin

            If TomorrowTime < 0 Then
                TomorrowTime = 0
            End If

        Catch ex As Exception
            MsgBox("Error : SetTomorrowTime")
            TomorrowTime = 0
            Exit Sub
        End Try

    End Sub

    Private Sub ConvertMin(ByRef time As Integer)

        If time <> 0 Then

            If time < 100 Then
                time = time Mod 100
            Else
                time = ((time \ 100) * 60) + time Mod 100
            End If

        End If

    End Sub
End Class
