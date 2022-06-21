Public Class Reports
    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        'when btnStock is Clicked to open Stock form
        Dim drugs As New Drugs
        drugs.Show()
        Visible = False

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        'when btnSales is Clicked to open Sales form
        Dim sales As New Sales
        sales.Show()
        Visible = False
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        'when btnOrders is Clicked to open OrederSummary form

        Dim order As New OrderSummary
        order.Show()
        Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Visible = False
    End Sub
End Class