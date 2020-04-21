<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_hei = New System.Windows.Forms.TextBox()
        Me.tb_wei = New System.Windows.Forms.TextBox()
        Me.r_m = New System.Windows.Forms.RadioButton()
        Me.r_w = New System.Windows.Forms.RadioButton()
        Me.t_Name = New System.Windows.Forms.TextBox()
        Me.cb_Y = New System.Windows.Forms.ComboBox()
        Me.cb_md = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.l_Name = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.l_brith = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.l_G = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.l_hei = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.l_bmi = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.l_aw = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.l_wei = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.l_caW = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(52, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BirthDay"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Height"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 12)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Weight"
        '
        'tb_hei
        '
        Me.tb_hei.Location = New System.Drawing.Point(77, 171)
        Me.tb_hei.Name = "tb_hei"
        Me.tb_hei.Size = New System.Drawing.Size(100, 21)
        Me.tb_hei.TabIndex = 1
        '
        'tb_wei
        '
        Me.tb_wei.Location = New System.Drawing.Point(77, 207)
        Me.tb_wei.Name = "tb_wei"
        Me.tb_wei.Size = New System.Drawing.Size(100, 21)
        Me.tb_wei.TabIndex = 1
        '
        'r_m
        '
        Me.r_m.AutoSize = True
        Me.r_m.Location = New System.Drawing.Point(77, 136)
        Me.r_m.Name = "r_m"
        Me.r_m.Size = New System.Drawing.Size(48, 16)
        Me.r_m.TabIndex = 2
        Me.r_m.TabStop = True
        Me.r_m.Text = "Man"
        Me.r_m.UseVisualStyleBackColor = True
        '
        'r_w
        '
        Me.r_w.AutoSize = True
        Me.r_w.Location = New System.Drawing.Point(179, 136)
        Me.r_w.Name = "r_w"
        Me.r_w.Size = New System.Drawing.Size(65, 16)
        Me.r_w.TabIndex = 2
        Me.r_w.TabStop = True
        Me.r_w.Text = "Woman"
        Me.r_w.UseVisualStyleBackColor = True
        '
        't_Name
        '
        Me.t_Name.Location = New System.Drawing.Point(78, 63)
        Me.t_Name.MaxLength = 15
        Me.t_Name.Name = "t_Name"
        Me.t_Name.Size = New System.Drawing.Size(100, 21)
        Me.t_Name.TabIndex = 0
        '
        'cb_Y
        '
        Me.cb_Y.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Y.FormattingEnabled = True
        Me.cb_Y.Location = New System.Drawing.Point(79, 100)
        Me.cb_Y.Name = "cb_Y"
        Me.cb_Y.Size = New System.Drawing.Size(61, 20)
        Me.cb_Y.TabIndex = 1
        '
        'cb_md
        '
        Me.cb_md.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_md.FormattingEnabled = True
        Me.cb_md.Location = New System.Drawing.Point(180, 100)
        Me.cb_md.Name = "cb_md"
        Me.cb_md.Size = New System.Drawing.Size(67, 20)
        Me.cb_md.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(193, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 12)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "cm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(193, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 12)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "kg"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(62, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(144, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Practice"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(290, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 12)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ExResult"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(306, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 12)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "-Name"
        '
        'l_Name
        '
        Me.l_Name.AutoSize = True
        Me.l_Name.Location = New System.Drawing.Point(306, 100)
        Me.l_Name.Name = "l_Name"
        Me.l_Name.Size = New System.Drawing.Size(42, 12)
        Me.l_Name.TabIndex = 8
        Me.l_Name.Text = "Label9"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(306, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 12)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "-BirthDay"
        '
        'l_brith
        '
        Me.l_brith.AutoSize = True
        Me.l_brith.Location = New System.Drawing.Point(306, 161)
        Me.l_brith.Name = "l_brith"
        Me.l_brith.Size = New System.Drawing.Size(42, 12)
        Me.l_brith.TabIndex = 8
        Me.l_brith.Text = "Label9"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(306, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 12)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "-Genger"
        '
        'l_G
        '
        Me.l_G.AutoSize = True
        Me.l_G.Location = New System.Drawing.Point(306, 236)
        Me.l_G.Name = "l_G"
        Me.l_G.Size = New System.Drawing.Size(42, 12)
        Me.l_G.TabIndex = 8
        Me.l_G.Text = "Label9"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(475, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 12)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "-Height"
        '
        'l_hei
        '
        Me.l_hei.AutoSize = True
        Me.l_hei.Location = New System.Drawing.Point(475, 100)
        Me.l_hei.Name = "l_hei"
        Me.l_hei.Size = New System.Drawing.Size(42, 12)
        Me.l_hei.TabIndex = 8
        Me.l_hei.Text = "Label9"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(475, 136)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 12)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "-BMI"
        '
        'l_bmi
        '
        Me.l_bmi.AutoSize = True
        Me.l_bmi.Location = New System.Drawing.Point(475, 161)
        Me.l_bmi.Name = "l_bmi"
        Me.l_bmi.Size = New System.Drawing.Size(42, 12)
        Me.l_bmi.TabIndex = 8
        Me.l_bmi.Text = "Label9"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(475, 207)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 12)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "-AverageWeighi"
        '
        'l_aw
        '
        Me.l_aw.AutoSize = True
        Me.l_aw.Location = New System.Drawing.Point(475, 236)
        Me.l_aw.Name = "l_aw"
        Me.l_aw.Size = New System.Drawing.Size(42, 12)
        Me.l_aw.TabIndex = 8
        Me.l_aw.Text = "Label9"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(650, 67)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 12)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "-Weighi"
        '
        'l_wei
        '
        Me.l_wei.AutoSize = True
        Me.l_wei.Location = New System.Drawing.Point(650, 100)
        Me.l_wei.Name = "l_wei"
        Me.l_wei.Size = New System.Drawing.Size(42, 12)
        Me.l_wei.TabIndex = 8
        Me.l_wei.Text = "Label9"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(475, 275)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 12)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "-CuW - AvW"
        '
        'l_caW
        '
        Me.l_caW.AutoSize = True
        Me.l_caW.Location = New System.Drawing.Point(475, 304)
        Me.l_caW.Name = "l_caW"
        Me.l_caW.Size = New System.Drawing.Size(11, 12)
        Me.l_caW.TabIndex = 8
        Me.l_caW.Text = "-"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(142, 104)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 12)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "Year"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 347)
        Me.Controls.Add(Me.l_caW)
        Me.Controls.Add(Me.l_aw)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.l_G)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.l_bmi)
        Me.Controls.Add(Me.l_brith)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.l_wei)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.l_hei)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.l_Name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cb_md)
        Me.Controls.Add(Me.cb_Y)
        Me.Controls.Add(Me.r_w)
        Me.Controls.Add(Me.r_m)
        Me.Controls.Add(Me.tb_wei)
        Me.Controls.Add(Me.t_Name)
        Me.Controls.Add(Me.tb_hei)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_hei As TextBox
    Friend WithEvents tb_wei As TextBox
    Friend WithEvents r_m As RadioButton
    Friend WithEvents r_w As RadioButton
    Friend WithEvents t_Name As TextBox
    Friend WithEvents cb_Y As ComboBox
    Friend WithEvents cb_md As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents l_Name As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents l_brith As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents l_G As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents l_hei As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents l_bmi As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents l_aw As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents l_wei As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents l_caW As Label
    Friend WithEvents Label25 As Label
End Class
