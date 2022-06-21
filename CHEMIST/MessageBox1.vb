Public Class MessageBox1
    Public Property StringPass As String
    'gets total from Order form



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'when btnCancel is clicked to close form / take back to main form
        Main.Show()
        Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'when btnNext is clicked to open a new Invoice form
        Dim invoice As New Invoice
        invoice.Show()
    End Sub

    Private Sub MessageBox1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Ksh" & StringPass

    End Sub
End Class