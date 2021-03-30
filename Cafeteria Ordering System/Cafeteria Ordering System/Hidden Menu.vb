Public Class HiddenMenu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lblTime.Text >= 31 Then
            lblTime.ForeColor = Color.Green
            lblTime.Text = Val(lblTime.Text) - 1
        ElseIf lblTime.Text >= 21 Then
            lblTime.ForeColor = Color.Yellow
            lblTime.Text = Val(lblTime.Text) - 1
        ElseIf lblTime.Text >= 1 Then
            lblTime.ForeColor = Color.Red
            lblTime.Text = Val(lblTime.Text) - 1
        ElseIf lblTime.Text = 0 Then
            Timer1.Enabled = False
            MsgBox("Times Up")
            txtboxID.Clear()
            txtboxName.Clear()
            mtxtboxDate.Clear()
            mtxtboxTime.Clear()
            txtboxUser.Clear()
            CustomerLoginPage.txtboxID.Clear()
            CustomerLoginPage.txtboxName.Clear()
            CustomerLoginPage.txtboxCustomer_Number.Clear()
            CustomerLoginPage.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BtTSL_Click(sender As Object, e As EventArgs) Handles btnTSL.Click
        MsgBox("You Have Choosen The Shepard Loaf")
        Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Cafeteria Ordering System Database.accdb")
        Dim Command As New OleDb.OleDbCommand("INSERT INTO HiddenMenu_Info (Customer_ID , Item_Select , Claim_Date) VALUES (@txtboxID.Text,@btnTSL.Text,@mtxtboxDate.Text)", Connection)
        Command.Parameters.Add("@Customer_ID", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxID.Text
        Command.Parameters.Add("@Item_Select", oleDbType:=OleDb.OleDbType.VarChar).Value = btnTSL.Text
        Command.Parameters.Add("@Claim_Date", oleDbType:=OleDb.OleDbType.VarChar).Value = mtxtboxDate.Text
        Dim adapter As New OleDb.OleDbDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Connection.Open()
        Timer1.Enabled = False
        txtboxID.Clear()
        txtboxName.Clear()
        mtxtboxDate.Clear()
        mtxtboxTime.Clear()
        txtboxUser.Clear()
        CustomerLoginPage.Show()
        Me.Hide()
        Connection.Close()
    End Sub

    Private Sub BtnHR_AS_Click(sender As Object, e As EventArgs) Handles btnHR_AS.Click
        MsgBox("You Have Choosen Harrods Roquefort and Almond-Sourdough Bread")
        Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Cafeteria Ordering System Database.accdb")
        Dim Command As New OleDb.OleDbCommand("INSERT INTO HiddenMenu_Info (Customer_ID , Item_Select , Claim_Date) VALUES (@txtboxID.Text,@btnHR_AS.Text,@mtxtboxDate.Text)", Connection)
        Command.Parameters.Add("@Customer_ID", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxID.Text
        Command.Parameters.Add("@Item_Select", oleDbType:=OleDb.OleDbType.VarChar).Value = btnHR_AS.Text
        Command.Parameters.Add("@Claim_Date", oleDbType:=OleDb.OleDbType.VarChar).Value = mtxtboxDate.Text
        Dim adapter As New OleDb.OleDbDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Connection.Open()
        Timer1.Enabled = False
        txtboxID.Clear()
        txtboxName.Clear()
        mtxtboxDate.Clear()
        mtxtboxTime.Clear()
        txtboxUser.Clear()
        CustomerLoginPage.Show()
        Me.Hide()
        Connection.Close()
    End Sub

    Private Sub BtnMiche_Click(sender As Object, e As EventArgs) Handles btnMT.Click
        MsgBox("You Have Choosen Matcha Tea")
        Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Cafeteria Ordering System Database.accdb")
        Dim Command As New OleDb.OleDbCommand("INSERT INTO HiddenMenu_Info (Customer_ID , Item_Select , Claim_Date) VALUES (@txtboxID.Text,@btnMT.Text,@mtxtboxDate.Text)", Connection)
        Command.Parameters.Add("@Customer_ID", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxID.Text
        Command.Parameters.Add("@Item_Select", oleDbType:=OleDb.OleDbType.VarChar).Value = btnMT.Text
        Command.Parameters.Add("@Claim_Date", oleDbType:=OleDb.OleDbType.VarChar).Value = mtxtboxDate.Text
        Dim adapter As New OleDb.OleDbDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Connection.Open()
        Timer1.Enabled = False
        txtboxID.Clear()
        txtboxName.Clear()
        mtxtboxDate.Clear()
        mtxtboxTime.Clear()
        txtboxUser.Clear()
        CustomerLoginPage.Show()
        Me.Hide()
        Connection.Close()
    End Sub

    Private Sub BtnBP_Click(sender As Object, e As EventArgs) Handles btnBP.Click
        MsgBox("You Have Choosen Butterfly Pea")
        Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Cafeteria Ordering System Database.accdb")
        Dim Command As New OleDb.OleDbCommand("INSERT INTO HiddenMenu_Info (Customer_ID , Item_Select , Claim_Date) VALUES (@txtboxID.Text,@btnBP.Text,@mtxtboxDate.Text)", Connection)
        Command.Parameters.Add("@Customer_ID", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxID.Text
        Command.Parameters.Add("@Item_Select", oleDbType:=OleDb.OleDbType.VarChar).Value = btnBP.Text
        Command.Parameters.Add("@Claim_Date", oleDbType:=OleDb.OleDbType.VarChar).Value = mtxtboxDate.Text
        Dim adapter As New OleDb.OleDbDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Connection.Open()
        Timer1.Enabled = False
        txtboxID.Clear()
        txtboxName.Clear()
        mtxtboxDate.Clear()
        mtxtboxTime.Clear()
        txtboxUser.Clear()
        CustomerLoginPage.Show()
        Me.Hide()
        Connection.Close()
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        MsgBox("Thank You, Please Come Again")
        Timer1.Enabled = False
        txtboxID.Clear()
        txtboxName.Clear()
        mtxtboxDate.Clear()
        mtxtboxTime.Clear()
        txtboxUser.Clear()
        CustomerLoginPage.Show()
        Me.Hide()
    End Sub
End Class