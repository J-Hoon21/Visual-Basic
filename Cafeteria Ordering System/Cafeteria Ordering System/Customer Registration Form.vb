Public Class CustomerRegistrationForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If IsNumeric(txtboxCustomer_Name.Text) = True Or IsNumeric(cboGender.SelectedItem) = True Or IsNumeric(txtboxCity.Text) Or IsNumeric(txtboxState.Text) = True Or IsNumeric(txtboxCountry.Text) = True Or IsNumeric(txtboxEmail.Text) = True Then
            MsgBox("Numeric Data Are Only Accepted From Customer ID, Birth Date , Phone Number and Address Street")
        ElseIf txtboxCustomer_Name.Text = "" Or txtboxCustomer_ID.Text = "" Or cboGender.Text = "" Or mtxtboxBirth_Date.Text = "  -  -    " Or mtxtboxPhone_Number.Text = "   -        " Or txtboxAddressStreet.Text = "" Or txtboxCity.Text = "" Or txtboxState.Text = "" Or txtboxCountry.Text = "" Or txtboxEmail.Text = "" Then
            MsgBox("Please Fill In All Data")
        ElseIf Not cboGender.Text = "Male" And Not cboGender.Text = "Female" Then
            MsgBox("Invalid Gender")
        Else
            MsgBox("Registeration Successful, Please Login in Customer Login Page")
            Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Cafeteria Ordering System Database.accdb")
            Dim Command As New OleDb.OleDbCommand("INSERT INTO Customer_Info (Customer_ID , Customer_Name , Gender , Birth_Date , Phone_Number , Address_Street , City , State , Country , Email,  Customer_Number) VALUES (@txtboxCustomer_ID.Text,@txtboxCustomer_Name.Text,@cboGender.SelectedItem,@mtxtboxBirth_Date.Text,@mtxtboxPhone_Number.Text,@txtAddressStreet.Text,@txtboxCity.Text,@txtboxState.Text,@txtboxCountry.Text,@txtboxEmail.Text,@btnCustomer_Number.Text)", Connection)
            Command.Parameters.Add("@Customer_ID", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxCustomer_ID.Text
            Command.Parameters.Add("@Customer_Name", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxCustomer_Name.Text
            Command.Parameters.Add("@Gender", oleDbType:=OleDb.OleDbType.VarChar).Value = cboGender.SelectedItem
            Command.Parameters.Add("@Birth_Date", oleDbType:=OleDb.OleDbType.VarChar).Value = mtxtboxBirth_Date.Text
            Command.Parameters.Add("@Phone_Number", oleDbType:=OleDb.OleDbType.VarChar).Value = mtxtboxPhone_Number.Text
            Command.Parameters.Add("@Address_Street", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxAddressStreet.Text
            Command.Parameters.Add("@City", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxCity.Text
            Command.Parameters.Add("@State", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxState.Text
            Command.Parameters.Add("@Country", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxCountry.Text
            Command.Parameters.Add("@Email", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxEmail.Text
            Command.Parameters.Add("@Customer_Number", oleDbType:=OleDb.OleDbType.VarChar).Value = btnCustomer_Number.Text
            Dim adapter As New OleDb.OleDbDataAdapter(Command)
            Dim table As New DataTable()
            adapter.Fill(table)
            Connection.Open()
            CustomerLoginPage.Show()
            Me.Hide()
            txtboxCustomer_Name.Clear()
            txtboxCustomer_ID.Clear()
            cboGender.ResetText()
            mtxtboxBirth_Date.Clear()
            mtxtboxPhone_Number.Clear()
            txtboxAddressStreet.Clear()
            txtboxCity.Clear()
            txtboxState.Clear()
            txtboxCountry.Clear()
            txtboxEmail.Clear()
            btnCustomer_Number.Text = "Customer Number"
            Connection.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MsgBox("The Data Has Been Discarded")
        txtboxCustomer_Name.Clear()
        txtboxCustomer_ID.Clear()
        cboGender.ResetText()
        mtxtboxBirth_Date.Clear()
        mtxtboxPhone_Number.Clear()
        txtboxAddressStreet.Clear()
        txtboxCity.Clear()
        txtboxState.Clear()
        txtboxCountry.Clear()
        txtboxEmail.Clear()
        btnCustomer_Number.Text = "Customer Number"
        CustomerLoginPage.Show()
        Me.Hide()
    End Sub

    Private Sub BtnNumber_Click(sender As Object, e As EventArgs) Handles btnCustomer_Number.Click
        Dim randomnumber As New Random
        Dim number As Integer
        randomnumber = New Random
        number = randomnumber.Next(1, 1000)
        btnCustomer_Number.Text = number
        MsgBox("Your Customer Number Is " & (btnCustomer_Number.Text) & ", Please Remember")
        btnCustomer_Number.Enabled = False
        btnSubmit.Enabled = True
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Cafeteria Ordering System Database.accdb")
        Dim Command As New OleDb.OleDbCommand("DELETE FROM Customer_Info  where Customer_Number =@txtboxCustomer_ID.Text AND Customer_Name = @txtboxCustomer_Name.Text", Connection)
        Command.Parameters.Add("@Customer_Number", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxCustomer_ID.Text
        Command.Parameters.Add("@Customer_Name", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxCustomer_Name.Text
        Dim adapter As New OleDb.OleDbDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Connection.Open()
        If table.Rows.Count() <= 0 Then
            MsgBox("Record Unabled Delete")
        Else MsgBox("Record Successfully Delete")
        End If
        Connection.Close()
    End Sub
End Class