Public Class CustomerLoginPage
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Cafeteria Ordering System Database.accdb")
        Dim Command As New OleDb.OleDbCommand("SELECT * FROM Customer_Info WHERE Customer_ID = @txtID.Text AND Customer_Name = @txtName.Text AND Customer_Number = @txtCustomer_Number.Text", Connection)
        Command.Parameters.Add("@Customer_ID", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxID.Text
        Command.Parameters.Add("@Customer_Name", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxName.Text
        Command.Parameters.Add("@Customer_Number", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxCustomer_Number.Text
        Dim adapter As New OleDb.OleDbDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Connection.Open()
        If table.Rows.Count() <= 0 Then
            MsgBox("Incorrect Data, Please Retry")
            MsgBox("Please Make Registration If You Did Not Register")
        Else MsgBox("Login Successful, Welcome Back " & (txtboxName.Text) & "")
            MenuList.btn_Confirm.Enabled = False
            MenuList.txtboxName.Text = txtboxName.Text
            MenuList.txtboxID.Text = txtboxID.Text
            MenuList.txtboxUser.Text = txtboxUser.Text
            MenuList.mtxtboxDate.Text = Date.Now.ToString("dd/MM/yyyy")
            MenuList.mtxtboxTime.Text = Date.Now.ToString("hh:mm:ss tt")
            MenuList.Show()
            Me.Hide()
        End If
        Connection.Close()
    End Sub

    Private Sub ButtonLog_Out_Click(sender As Object, e As EventArgs) Handles btnLog_Out.Click
        Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Cafeteria Ordering System Database.accdb")
        Dim Command As New OleDb.OleDbCommand("SELECT * FROM StaffUser_Info WHERE User_Name = @txtboxName.Text AND User_Password = @txtboxID.Text", Connection)
        Command.Parameters.Add("@User_Name", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxName.Text
        Command.Parameters.Add("@User_Password", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxID.Text
        Dim adapter As New OleDb.OleDbDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Connection.Open()
        If table.Rows.Count() <= 0 Then
            MsgBox("Log Out Unuccessful")
        Else MsgBox("Log Out Successful")
            txtboxID.Clear()
            txtboxName.Clear()
            txtboxCustomer_Number.Clear()
            txtboxUser.Clear()
            StaffUserLogin.txtboxUser_Name.Clear()
            StaffUserLogin.txtboxUser_Password.Clear()
            StaffUserLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        txtboxID.Clear()
        txtboxName.Clear()
        txtboxCustomer_Number.Clear()
        CustomerRegistrationForm.btnCustomer_Number.Enabled = True
        CustomerRegistrationForm.btnSubmit.Enabled = False
        CustomerRegistrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub CustomerLoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
