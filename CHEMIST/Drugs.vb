Imports MySql.Data.MySqlClient
Public Class Drugs
    'Declaring variables
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand


    Private Sub Drugs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get current date

        lblDate1.Text = Date.Now.ToString("dd-MM-yyyy")
        'get data from database

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
"server=localhost;userid=root;password=Njuguna2;database=chemist"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select DrugId,DrugName,Quantity,B_Price,S_Price from drugstock"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dgvDrugs.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Visible = False
        Reports.Show()


    End Sub
End Class