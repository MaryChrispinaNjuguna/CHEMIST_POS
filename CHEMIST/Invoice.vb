Imports MySql.Data.MySqlClient

Public Class Invoice
    'declaring variables
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim total As Integer = 0
    Dim drug As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'when btnSave is clicked to insert data to database

        For i As Integer = 0 To dgvInvoice.Rows.Count - 2 Step +1

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=Njuguna2;database=chemist"
            Dim READER, READER1 As MySqlDataReader
            Try
                MysqlConn.Open()

                total = total + dgvInvoice.Rows(i).Cells(5).Value.ToString()
                lblTotal.Text = total

                Dim Query, Query1 As String

                Query = "insert into Invoice (InvoiceLine,InvoiceNo,Date,DrugIdF,Quantity,Total) VALUES
                ('" & dgvInvoice.Rows(i).Cells(0).Value.ToString() & "','" & lblInvoiceNo1.Text & "','" & lblDate.Text & "','" & dgvInvoice.Rows(i).Cells(1).Value.ToString() & "','" & dgvInvoice.Rows(i).Cells(3).Value.ToString() & "','" & dgvInvoice.Rows(i).Cells(5).Value.ToString() & "')"

                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader
                READER.Close()
                Query1 = "UPDATE drugstock SET Quantity=Quantity-'" & dgvInvoice.Rows(i).Cells(3).Value.ToString() & "'  WHERE (DrugID='" & drug & "')"
                COMMAND = New MySqlCommand(Query1, MysqlConn)
                READER1 = COMMAND.ExecuteReader
                READER1.Close()

                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Next
        MessageBox.Show("Data Inserted")

        Dim MsgBox As New MessageBox1
        MsgBox.StringPass = total
        MsgBox.Show()

        Visible = False



    End Sub

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get current date
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
        'create the ComboBox column in DataGridView
        Dim combo As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn
        combo.HeaderText = "Drug id"
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=Njuguna2;database=chemist"
        Dim READER, Reader1 As MySqlDataReader
        'get data from database and store it in combobox
        Try
            MysqlConn.Open()
            Dim Query, Query1 As String
            Query = "SELECT * FROM drugstock"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim drugid = READER.GetString("DrugId")
                combo.Items.Add(drugid)
            End While
            READER.Close()

            'autoincrement invoice no
            Query1 = "SELECT * FROM invoice ORDER BY InvoiceNo DESC LIMIT 1"
            COMMAND = New MySqlCommand(Query1, MysqlConn)
            Reader1 = COMMAND.ExecuteReader
            While Reader1.Read
                Dim num = Reader1.GetString("InvoiceNo")
                lblInvoiceNo1.Text = num + 1
            End While
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try



        dgvInvoice.Columns.Insert(1, combo)


    End Sub



    Private Sub DataGridView1_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvInvoice.EditingControlShowing
        'sub procedure to dectect change in Datagridview
        If dgvInvoice.CurrentCell.ColumnIndex = 1 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)

            AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
        End If
    End Sub

    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'used to select selecteditem in combobox
        For i As Integer = 0 To dgvInvoice.Rows.Count - 2
            Dim result As String = CType(sender, ComboBox).SelectedItem.ToString()

            drug = result
        Next
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=Njuguna2;database=chemist"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM drugstock WHERE (DrugID='" & drug & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim row = dgvInvoice.Rows.Count - 2
            'to get values from db with specefic  drug id to datagridview cells
            While READER.Read
                Dim drugname = READER.GetString("DrugName")
                Dim price = READER.GetString("S_Price")
                dgvInvoice.Rows(row).Cells(2).Value = drugname
                dgvInvoice.Rows(row).Cells(4).Value = price
            End While
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'when btnCancel is clicked to close form / take back to main form
        Main.Show()
        Visible = False
    End Sub
End Class