Imports System.Text.RegularExpressions

Public Class Form1


    Private startY As Integer = 2010
    Private endY As Integer = 1910
    Private dateFormat As String = "{0}/{1}"
    Private brithdRe As String = "{0}/{1}"

    Private nameRe As String = Nothing
    Private heightRe As String = Nothing
    Private weightRe As String = Nothing

    Private Bmi As Decimal = 0.0
    Private Aw As Decimal = 0.0
    Dim caW As Decimal = 0.0


    Private errMsg As ArrayList
    Private errMsgFomat As String = "Please type your {0}."

    Private rgx As New Regex("[0-9]")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetYear()
        SetTabIndex()
        SetGender()
    End Sub

#Region "setForm"
    '기본적으로 남자에 체크
    Private Sub SetGender()
        r_m.Checked = True

    End Sub

    Private Sub SetTabIndex()

        t_Name.TabIndex = 0
        cb_Y.TabIndex = 1
        cb_md.TabIndex = 2
        r_m.TabIndex = 3
        r_w.TabIndex = 4
        tb_hei.TabIndex = 5
        tb_wei.TabIndex = 6
        Button2.TabIndex = 7
        Button1.TabIndex = 8

    End Sub

    '2010~1910 내림차순정렬
    Private Sub SetYear()
        cb_Y.Items.Add("")

        For index = startY To endY Step -1

            cb_Y.Items.Add(index)

        Next index


    End Sub

    '선택 년도의 1월 1일부터 12월 말까지 출력
    Private Sub SetDate()
        Dim nowY As String = Nothing
        Dim month As Integer = 0
        Dim day As Integer = 0

        nowY = cb_Y.SelectedItem
        cb_md.Items.Add("")
        For index = 1 To 12
            month = index
            day = DateTime.DaysInMonth(nowY, month)

            For index2 = 1 To day

                cb_md.Items.Add(String.Format(dateFormat, month, index2))

            Next index2
        Next index


    End Sub
#End Region


    Private Sub ErrChk()
        errMsg = New ArrayList
        If nameRe = Nothing Then errMsg.Add(String.Format(errMsgFomat, "Name"))
        If heightRe = Nothing Then errMsg.Add(String.Format(errMsgFomat, "height"))
        If heightRe = Nothing Then errMsg.Add(String.Format(errMsgFomat, "weight"))

        If cb_Y.Text = "" Then errMsg.Add(String.Format(errMsgFomat, "Year"))
        If cb_md.Text = "" Then errMsg.Add(String.Format(errMsgFomat, "MonthDay"))



    End Sub

    Private Sub SetInput()

        nameRe = t_Name.Text.Trim
        heightRe = tb_hei.Text.Trim
        weightRe = tb_wei.Text.Trim

    End Sub

    Private Sub SetResult()
        Dim nowY As String = cb_Y.SelectedItem
        Dim nowMD As String = cb_md.SelectedItem

        l_Name.Text = nameRe

        l_brith.Text = String.Format(brithdRe, nowY, nowMD)

        If r_m.Checked Then
            l_G.Text = r_m.Text
        Else
            l_G.Text = r_w.Text
        End If

        l_hei.Text = heightRe
        l_wei.Text = weightRe

        calBMI()
        calAW()
        l_aw.Text = Math.Round(Aw, 2)
        l_caW.Text = Math.Round(caW, 2)
        l_bmi.Text = Bmi
    End Sub

    Private Sub calBMI()
        Bmi = 0.0
        Dim hi As Decimal = CType(heightRe, Decimal)
        Dim wi As Decimal = CType(weightRe, Decimal)

        Bmi = (hi * hi) Mod wi
    End Sub

    Private Sub calAW()
        Dim heiM As Decimal = 0.0

        heiM = CType(heightRe, Decimal) / 100
        Aw = heiM * heiM * Bmi

        caW = Bmi - Aw

    End Sub

#Region "Button"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String = Nothing
        SetInput()
        ErrChk()

        If errMsg.Count <> 0 Then

            For Each str2 As String In errMsg
                str += str2 & Environment.NewLine
            Next

            MessageBox.Show(str, "ErrMsg", MessageBoxButtons.OK, MessageBoxIcon.Error)
            errMsg.Clear()
            Exit Sub
        End If
        SetResult()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SetClear()
    End Sub

#End Region

    Private Sub SetClear()

        t_Name.Text = ""
        cb_md.SelectedIndex = 0
        cb_Y.SelectedIndex = 0
        r_m.Checked = True
        r_w.Checked = False
        tb_hei.Text = ""
        tb_wei.Text = ""
        l_Name.Text = ""
        l_brith.Text = ""
        l_G.Text = ""
        l_hei.Text = ""
        l_bmi.Text = ""
        l_aw.Text = ""
        l_caW.Text = ""
        l_wei.Text = ""
    End Sub
    Private Sub cb_Y_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Y.SelectedIndexChanged
        If cb_Y.Text <> "" Then
            SetDate()
        End If
    End Sub


    Private Sub t_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_Name.KeyPress

        If rgx.IsMatch(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
