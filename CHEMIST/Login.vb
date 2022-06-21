Imports MySql.Data.MySqlClient
Public Class Login
    'declaring variables
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'validating login credentials from db
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=Njuguna2;database=chemist"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT username,password FROM users WHERE (username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            READER = COMMAND.ExecuteReader
            Dim count As Integer
            While READER.Read
                count = 0
                count = count + 1

            End While

            If count = 1 Then
                Visible = False
                MessageBox.Show("Login Successful")
                Main.Show()

            Else
                MessageBox.Show("Invalid username or password")
                txtPassword.Text = ""
                txtUsername.Text = ""



            End If


            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try






    End Sub




    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        'hide/show password
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False

        Else
            txtPassword.UseSystemPasswordChar = False

        End If
    End Sub



End Class
