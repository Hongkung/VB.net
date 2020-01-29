Public Class Form1

    'dataGridView Test


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setName()

        'cell 선택시 해당셀이 속한 row전체가 선택된다. 
        'When selecting a cell, the entire row to which the cell belongs is selected.
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DataGridView1.ColumnCount = 2
        DataGridView1.Columns(0).Name = "name"
        DataGridView1.Columns(1).Name = "Address"



    End Sub

    'add btn
    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click



        If name_tb.Text = "" AndAlso address_tb.Text = "" Then
            MsgBox("date input !", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim row As String() = New String() {name_tb.Text, address_tb.Text}

        DataGridView1.Rows.Add(row)


        name_tb.Text = ""
        address_tb.Text = ""

    End Sub



    'update btn
    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        DataGridView1.SelectedRows(0).Cells(0).Value = name_tb.Text
        DataGridView1.SelectedRows(0).Cells(1).Value = address_tb.Text

    End Sub

    'delete btn
    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click

        If DataGridView1.SelectedRows(0).Cells(0).Value = Nothing Then
            Return
        End If

        Dim msgResult As MsgBoxResult = MsgBox("삭제하시겠습니까?", MsgBoxStyle.YesNo)

        If msgResult = MsgBoxResult.Yes Then
            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)

            name_tb.Text = ""
            address_tb.Text = ""

        End If
    End Sub

    'name set
    Private Sub setName()
        Label1.Text = "Name"
        Label2.Text = "Address"

        add_btn.Text = "add"
        update_btn.Text = "update"
        delete_btn.Text = "delete"

    End Sub

    'cell 클릭시 발생 이벤트 
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        'DataGridViewCellEventArgs < 셀,행조작과 관련된 이벤트에 대한 데이터 제공
        If (e.RowIndex > -1) And Not (DataGridView1.SelectedRows(0).Cells(0).Value = Nothing) Then

            name_tb.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString

            address_tb.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
        Else
            name_tb.Text = ""
            address_tb.Text = ""

        End If



    End Sub


End Class
