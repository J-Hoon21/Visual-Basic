Public Class StaffUserLogin
    Private Sub ButtonUser_Login_Click(sender As Object, e As EventArgs) Handles btnUser_Login.Click
        Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Cafeteria Ordering System Database.accdb")
        Dim Command As New OleDb.OleDbCommand("SELECT * FROM StaffUser_Info WHERE User_Name = @txtboxUser_Name.Text AND User_Password = @txtboxUser_Password.Text", Connection)
        Command.Parameters.Add("@Customer_ID", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxUser_Name.Text
        Command.Parameters.Add("@Customer_Name", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxUser_Password.Text
        Dim adapter As New OleDb.OleDbDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Connection.Open()
        If table.Rows.Count() <= 0 Then
            MsgBox("Access Denied")
        Else MsgBox("Access Granted")
            CustomerLoginPage.txtboxUser.Text = txtboxUser_Name.Text
            CustomerLoginPage.Show()
            Me.Hide()
        End If
        Connection.Close()
    End Sub

    Private Sub BtnUser_Register_Click(sender As Object, e As EventArgs) Handles btnUser_Register.Click
        Dim randomnumber As New Random
        Dim number As Integer
        randomnumber = New Random
        number = randomnumber.Next(1, 1000)
        If IsNumeric(txtboxUser_Name.Text) Then
            MsgBox("Numeric Data Is Not Accepted From User Name")
        ElseIf txtboxUser_Name.Text = "" Then
            MsgBox("Please Fill In User Name")
        ElseIf txtboxUser_Password.Text = ("AntidisestablishmentarianismPathfinderPeebee") Then
            MsgBox("Your Password Is " & (number) & ",Please Remember")
            txtboxUser_Password.Text = (number)
            Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Cafeteria Ordering System Database.accdb")
            Dim Command As New OleDb.OleDbCommand("INSERT INTO StaffUser_Info VALUES ( @txtboxUser_Name.Text,@txtboxUser_Password.Text)", Connection)
            Command.Parameters.Add("@Customer_ID", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxUser_Name.Text
            Command.Parameters.Add("@Customer_ID", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxUser_Password.Text
            Dim adapter As New OleDb.OleDbDataAdapter(Command)
            Dim table As New DataTable()
            adapter.Fill(table)
            Connection.Open()
            Connection.Close()
            txtboxUser_Name.Clear()
            txtboxUser_Password.Clear()
        Else MsgBox("Please Do Not Register Without Permission")
        End If
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        txtboxUser_Name.Clear()
        txtboxUser_Password.Clear()
        Me.Close()
    End Sub
End Class