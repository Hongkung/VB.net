Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim totalcost, salesPrice As Single
        salesPrice = 500
        totalcost = salesPrice + totaltax(salesPrice)

        laltax.Text = totalcost


    End Sub
End Class
