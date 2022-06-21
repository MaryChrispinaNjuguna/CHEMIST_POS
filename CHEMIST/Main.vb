Public Class Main


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        'when btnInvoice is clicked to show Invoice form
        Dim invoice As New Invoice
        invoice.Show()
        Visible = False



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        'when btnOrder is clicked to show Order form
        Dim order As New Order
        order.Show()
        Visible = False


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        'when btnReports is clicked to show Reports form
        Dim reports As New Reports
        reports.Show()
        Visible = False

    End Sub


End Class