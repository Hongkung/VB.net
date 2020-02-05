Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateGV1()
    End Sub

    Private Sub dateGV1()

        DataGridView1.ColumnCount = 11
        DataGridView1.Columns(0).Name = "ProName"           '상품명
        DataGridView1.Columns(1).Name = "Price"             '가격
        DataGridView1.Columns(2).Name = "StockCount"        '재고수
        DataGridView1.Columns(3).Name = "PurchaseNum"       '매입수
        DataGridView1.Columns(4).Name = "SalesNum"          '판매수
        DataGridView1.Columns(5).Name = "FinaIinvenCount"   '최종재고수
        DataGridView1.Columns(6).Name = "Remarks"           '비고
        DataGridView1.Columns(7).Name = "ProductCode"       ' 상품
        DataGridView1.Columns(8).Name = "ProMLastUp"        '상품M최종변경일시
        DataGridView1.Columns(9).Name = "LastUpTimeEntry"   '입고최종변경일시
        DataGridView1.Columns(10).Name = "ShippingLastUp"   '출고최종변경일시


    End Sub


End Class
