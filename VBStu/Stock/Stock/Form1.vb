Imports System.Text.RegularExpressions

Public Class Form1


    Private strErr As String = "Input is Number Only"






    Private strRege As New Regex("\[\D\]", RegexOptions.Compiled)
    Private strEncode As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift-JIS")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateGV1()
        btnSet()
    End Sub

    Private Sub dateGV1()

        ' DataGridView1.ColumnCount = 11
        'DataGridView1.Columns(0).Name = "ProName"           '상품명
        'DataGridView1.Columns(1).Name = "Price"             '가격
        'DataGridView1.Columns(2).Name = "StockCount"        '재고수
        'DataGridView1.Columns(3).Name = "PurchaseNum"       '매입수
        'DataGridView1.Columns(4).Name = "SalesNum"          '판매수
        'DataGridView1.Columns(5).Name = "FinaIinvenCount"   '최종재고수
        'DataGridView1.Columns(6).Name = "Remarks"           '비고
        'DataGridView1.Columns(7).Name = "ProductCode"       ' 상품
        'DataGridView1.Columns(8).Name = "ProMLastUp"        '상품M최종변경일시
        'DataGridView1.Columns(9).Name = "LastUpTimeEntry"   '입고최종변경일시
        'DataGridView1.Columns(10).Name = "ShippingLastUp"   '출고최종변경일시

        Me.MaskedTextBox1.TabIndex = 0



    End Sub
    Private Sub btnSet()
        Me.Button4.Enabled = False 'ADD Btn
        Me.Button3.Enabled = False 'REFRES Btn
        Me.Button2.Enabled = False 'DELETE Btn
    End Sub

    'MaskedTextBox Check , 전각 체크, 정규식 체크 
    Private Sub MaskedTextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MaskedTextBox1.Validating
        Dim strDate As String = Me.MaskedTextBox1.Text
        If Not strDate.Length = 10 Then


            For Each chr As Char In strDate

                If strEncode.GetByteCount(chr) = 2 Or strRege.IsMatch(chr) Then
                    MessageBox.Show(strErr, "StrError", MessageBoxButtons.OK)
                    Exit For

                End If

            Next
        End If



    End Sub
End Class
