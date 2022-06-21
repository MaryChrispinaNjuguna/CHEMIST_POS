Imports MySql.Data.MySqlClient

Public Class Order
    'declaring variables

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim total As Integer = 0
    Dim drug As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'when btnSave is clicked to insert data to database

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=Njuguna2;database=chemist"
        Dim READER, READER1 As MySqlDataReader
        Try
            MysqlConn.Open()
            For i As Integer = 0 To dgvOrder.Rows.Count - 2 Step +1

                total = total + dgvOrder.Rows(i).Cells(5).Value.ToString()
                lblTotal.Text = total

                Dim Query, Query1 As String

                Query = "insert into orders (OrderNo,OrderLine,Date,DrugIdF,Quantity,Total) VALUES
                ('" & lblOrderNo.Text & "','" & dgvOrder.Rows(i).Cells(0).Value.ToString() & "','" & lblDate.Text & "','" & dgvOrder.Rows(i).Cells(1).Value.ToString() & "','" & dgvOrder.Rows(i).Cells(3).Value.ToString() & "','" & dgvOrder.Rows(i).Cells(5).Value.ToString() & "')"

                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader
                READER.Close()

                Query1 = "UPDATE drugstock SET Quantity=Quantity+'" & dgvOrder.Rows(i).Cells(3).Value.ToString() & "'  WHERE (DrugID='" & drug & "')"
                COMMAND = New MySqlCommand(Query1, MysqlConn)
                READER1 = COMMAND.ExecuteReader
                READER1.Close()

            Next
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        MessageBox.Show("Data Saved")
        Dim MsgBox1 As New MessageBox2
        MsgBox1.StringPass = total
        MsgBox1.Show()

        Visible = False



    End Sub

    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'when btnSave is clicked to insert data to database

        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
        Dim combo As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn
        combo.HeaderText = "Drug id"
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=Njuguna2;database=chemist"
        Dim READER, Reader1 As MySqlDataReader
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
            'autoincrement order no

            Query1 = "SELECT * FROM orders ORDER BY OrderNo DESC LIMIT 1"

            READER.Close()

            COMMAND = New MySqlCommand(Query1, MysqlConn)
            Reader1 = COMMAND.ExecuteReader
            While Reader1.Read
                Dim num = Reader1.GetString("OrderNo")
                lblOrderNo.Text = num + 1
            End While
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try



        dgvOrder.Columns.Insert(1, combo)


    End Sub
    Private Sub DataGridView1_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvOrder.EditingControlShowing
        'sub procedure to dectect change in Datagridview

        If dgvOrder.CurrentCell.ColumnIndex = 1 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)

            AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
        End If
    End Sub

    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'used to select selecteditem in combobox

        Dim result As String = CType(sender, ComboBox).SelectedItem.ToString()
        drug = result
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=Njuguna2;database=chemist"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM drugstock WHERE (DrugID='" & drug & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim row = dgvOrder.Rows.Count - 2
            'to get values from db with specefic  drug id to datagridview cells

            While READER.Read
                Dim drugname = READER.GetString("DrugName")
                Dim price = READER.GetString("B_Price")
                dgvOrder.Rows(row).Cells(2).Value = drugname
                dgvOrder.Rows(row).Cells(4).Value = price
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