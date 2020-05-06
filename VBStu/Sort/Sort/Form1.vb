Imports System.Globalization

Public Class Form1

    Private value As ArrayList
    Private ErrorMsg() As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IndexCount()



    End Sub

    Private Sub IndexCount()

        TextBox1.TabIndex = 0
        TextBox2.TabIndex = 1
        TextBox3.TabIndex = 2
        TextBox4.TabIndex = 3
        TextBox5.TabIndex = 4

        RadioButton1.TabIndex = 6
        RadioButton2.TabIndex = 7
        Button1.TabIndex = 8

    End Sub

    Private Sub BasicsSet()

        RadioButton1.Checked = True


    End Sub

    'Right Area
    Private Sub SetNum(ByVal values As ArrayList, ByVal text As String)
        Dim Ctext As Integer = Nothing

        Try
            Ctext = CInt(text)

            If Ctext <> Nothing Then
                values.Add(Ctext)
            End If

        Catch ex As Exception
            MsgBox("SetNum Error", "ErrorMSG", MessageBoxButtons.OK)
            Exit Sub
        End Try

    End Sub

    'Left Area

    Private Sub SetLeft(ByVal value As ArrayList)

        If RadioButton1.Checked Then
            Rdi1(value)
            Output(value)

        ElseIf RadioButton2.Checked Then
            Rdi2(value)
            Output(value)

        End If

    End Sub

    Private Sub Rdi1(ByRef value As ArrayList)
        Dim temp As Integer

        For index = 0 To value.Count
            For index2 = 0 To 1
                If value(index2) > value(index2 + 1) Then
                    temp = value(index2)
                    value(index2) = value(index2 + 1)
                    value(index2 + 1) = temp
                End If
            Next index2

        Next index


    End Sub

    Private Sub Rdi2(ByRef value As ArrayList)
        Dim temp As Integer

        For index = 0 To value.Count
            For index2 = 0 To 1
                If value(index2) < value(index2 + 1) Then
                    temp = value(index2)
                    value(index2) = value(index2 + 1)
                    value(index2 + 1) = temp
                End If
            Next index2

        Next index


    End Sub

    Private Sub Output(ByVal value As ArrayList)
        Dim count As Integer = value.Count

        If 0 <= count - 1 AndAlso value(0) <> Nothing Then
            TextBox4.Text = value(0)
        End If
        If 1 <= count - 1 AndAlso value(1) <> Nothing Then
            TextBox5.Text = value(1)
        End If
        If 2 <= count - 1 AndAlso value(2) <> Nothing Then
            TextBox6.Text = value(0)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        value = New ArrayList
        SetNum(value, TextBox1.Text)
        SetNum(value, TextBox2.Text)
        SetNum(value, TextBox3.Text)

        SetLeft(value)


    End Sub
End Class
