Public Class PaymentSystem
    ' All Form 4 textbox, masked textbox and list box has been enabled FALSE through properties
    Private Sub Btn_Final_Calculate_Click(sender As Object, e As EventArgs) Handles btnFinal_Calculate.Click
        txtboxTotal_Amount.Text = MenuList.txtboxTotal_Payable_Amount.Text
        Dim receive As Double
        Dim sum As Decimal
        Dim amount() As String = {"0.10", "0.20", "0.50", "1.00", "5.00", "10.00", "20.00", "50.00"}
        receive = (amount(0) * cbo1.Text) + (amount(1) * cbo2.Text) + (amount(2) * cbo3.Text) + (amount(3) * cbo4.Text) + (amount(4) * cbo5.Text) + (amount(5) * cbo6.Text) + (amount(6) * cbo7.Text) + (amount(7) * cbo8.Text)
        sum = txtboxTotal_Amount.Text
        If receive < sum Then
            MsgBox("Not Enough Cash, Stranger")
            btnProceed.Enabled = False
        Else btnFinal_Confirm.Enabled = True
        End If
        txtboxReceive_Amount.Text = "RM" & Format(receive, "0.00")
        txtboxTotal_Change.Text = "RM" & Format(receive - sum, "0.00")
    End Sub

    Private Sub BtnFinal_Confirm_Click(sender As Object, e As EventArgs) Handles btnFinal_Confirm.Click
        Dim ans As String
        ans = MsgBox("(All Action Will Be Irreversible Once You Select This Button)
        Are You Sure You Want To Proceed With Your Orders?", vbYesNo)
        If ans = vbYes Then
            btnProceed.Enabled = True
            btnFinal_Calculate.Enabled = False
            btnFinal_Confirm.Enabled = False
            btnBack.Enabled = False
            cbo1.Enabled = False
            cbo2.Enabled = False
            cbo3.Enabled = False
            cbo4.Enabled = False
            cbo5.Enabled = False
            cbo6.Enabled = False
            cbo7.Enabled = False
            cbo8.Enabled = False
        End If
    End Sub

    Private Sub BtnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim Connection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Cafeteria Ordering System Database.accdb")
        Dim Command As New OleDb.OleDbCommand("INSERT INTO Order_Payment (Customer_ID , Order_Date , Order_Time , Sandwitch , Cranberry_B , Blueberry_B , Chocolate_B , Bourbon_B , French_Toast , German_Stollen , Green_T , Black_T , Americano, Cappuccino , Macchiato , Espresso , Espresso_Macchiato , Total_Price , Total_Payment , Staff_Incharge) VALUES (@txtboxID.Text,@mtxtboxDate.Text,@mtxtboxTime.Text,@Form3.txtSandwitch.Text,@Form3.txtCranberry_B.Text,@Form3.txtBlueberry_B.Text,@Form3.txtChocolate_Banana_B.Text,@Form3.txtBourbon_Banana_B.Text,@Form3.txtFrench_Toast.Text,@Form3.txtGerman_Stollen.Text,@Form3.txtGreen_T.Text,@Form3.txtBlack_T.Text,@Form3.txtAmericano.Text,@Form3.txtCappuccino.Text,@Form3.txtMacchiato.Text,@Form3.txtEspresso.Text,@Form3.txtEspresso_Macchiato.Text,@Form3.txtboxSubtotal.Text,@txtboxTotal_Amount.Text,@txtboxUser.Text)", Connection)
        Command.Parameters.Add("@Customer_ID", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxID.Text
        Command.Parameters.Add("@Order_Date", oleDbType:=OleDb.OleDbType.VarChar).Value = mtxtboxDate.Text
        Command.Parameters.Add("@Order_Time", oleDbType:=OleDb.OleDbType.VarChar).Value = mtxtboxTime.Text
        Command.Parameters.Add("@Sandwitch", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtSandwitch.Text
        Command.Parameters.Add("@Cranberry_B", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtCranberry_B.Text
        Command.Parameters.Add("@Blueberry_B", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtBlueberry_B.Text
        Command.Parameters.Add("@Chocolate_B", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtChocolate_Banana_B.Text
        Command.Parameters.Add("@Bourbon_B", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtBourbon_Banana_B.Text
        Command.Parameters.Add("@French_Toast", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtFrench_Toast.Text
        Command.Parameters.Add("@German_Stollen", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtMexicanCoffeeBread.Text
        Command.Parameters.Add("@Green_T", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtGreen_T.Text
        Command.Parameters.Add("@Black_T", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtBlack_T.Text
        Command.Parameters.Add("@Americano", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtAmericano.Text
        Command.Parameters.Add("@Cappuccino", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtCappuccino.Text
        Command.Parameters.Add("@Macchiato", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtMacchiato.Text
        Command.Parameters.Add("@Espresso", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtEspresso.Text
        Command.Parameters.Add("@Espresso_Macchiato", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtEspresso_Macchiato.Text
        Command.Parameters.Add("@Total_Price", oleDbType:=OleDb.OleDbType.VarChar).Value = MenuList.txtboxSubtotal.Text
        Command.Parameters.Add("@Total_Payment", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxTotal_Amount.Text
        Command.Parameters.Add("@Staff_Incharge", oleDbType:=OleDb.OleDbType.VarChar).Value = txtboxUser.Text
        Dim adapter As New OleDb.OleDbDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        Connection.Open()
        If txtboxTotal_Amount.Text >= 41 And (MenuList.txtSandwitch.Text + MenuList.txtCranberry_B.Text + MenuList.txtBlueberry_B.Text + MenuList.txtChocolate_Banana_B.Text + MenuList.txtBourbon_Banana_B.Text + MenuList.txtFrench_Toast.Text + MenuList.txtMexicanCoffeeBread.Text) >= 5 And (MenuList.txtGreen_T.Text + MenuList.txtBlack_T.Text + MenuList.txtAmericano.Text + MenuList.txtCappuccino.Text + MenuList.txtMacchiato.Text + +MenuList.txtEspresso.Text + MenuList.txtEspresso_Macchiato.Text) >= 2 Then
            MsgBox("Congratulations You Have Fulfill Hidden Criteria")
            MsgBox("You Have 45 Seconds To Choose 1 Item only
        (If You Select Reject Button, You Are Consider Letting Go FREE Chance)")
            HiddenMenu.Show()
            HiddenMenu.txtboxID.Text = txtboxID.Text
            HiddenMenu.txtboxName.Text = txtboxName.Text
            HiddenMenu.mtxtboxDate.Text = Date.Now.ToString("dd/MM/yyyy")
            HiddenMenu.mtxtboxTime.Text = Date.Now.ToString("hh:mm:ss tt")
            HiddenMenu.txtboxUser.Text = txtboxUser.Text
            HiddenMenu.lblTime.Text = 45
            HiddenMenu.Timer1.Start()
            HiddenMenu.Timer1.Interval = 1000
            Me.Hide()
        Else
            MsgBox("Thank You, Please Come Again")
            CustomerLoginPage.Show()
            Me.Hide()
        End If
        btnFinal_Calculate.Enabled = True
        btnBack.Enabled = True
        cbo1.Enabled = True
        cbo2.Enabled = True
        cbo3.Enabled = True
        cbo4.Enabled = True
        cbo5.Enabled = True
        cbo6.Enabled = True
        cbo7.Enabled = True
        cbo8.Enabled = True
        txtboxID.Clear()
        txtboxName.Clear()
        mtxtboxDate.Clear()
        mtxtboxTime.Clear()
        txtboxUser.Clear()
        MenuList.txtboxID.Clear()
        MenuList.txtboxName.Clear()
        txtboxTotal_Amount.Clear()
        txtboxReceive_Amount.Clear()
        txtboxTotal_Change.Clear()
        listbox1.Items.Clear()
        listbox2.Items.Clear()
        cbo1.Text = 0
        cbo2.Text = 0
        cbo3.Text = 0
        cbo4.Text = 0
        cbo5.Text = 0
        cbo6.Text = 0
        cbo7.Text = 0
        cbo8.Text = 0
        MenuList.listbox1.Items.Clear()
        MenuList.listbox2.Items.Clear()
        MenuList.listbox3.Items.Clear()
        MenuList.txtboxSubtotal.Clear()
        MenuList.txtboxTaxes.Clear()
        MenuList.txtboxTotal_Payable_Amount.Clear()
        MenuList.txtSandwitch.Text = 0
        MenuList.txtCranberry_B.Text = 0
        MenuList.txtBlueberry_B.Text = 0
        MenuList.txtChocolate_Banana_B.Text = 0
        MenuList.txtBourbon_Banana_B.Text = 0
        MenuList.txtFrench_Toast.Text = 0
        MenuList.txtMexicanCoffeeBread.Text = 0
        MenuList.txtGreen_T.Text = 0
        MenuList.txtBlack_T.Text = 0
        MenuList.txtAmericano.Text = 0
        MenuList.txtCappuccino.Text = 0
        MenuList.txtMacchiato.Text = 0
        MenuList.txtEspresso.Text = 0
        MenuList.txtEspresso_Macchiato.Text = 0
        CustomerLoginPage.txtboxID.Clear()
        CustomerLoginPage.txtboxName.Clear()
        CustomerLoginPage.txtboxCustomer_Number.Clear()
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        btnFinal_Confirm.Enabled = False
        txtboxID.Clear()
        txtboxName.Clear()
        txtboxUser.Clear()
        mtxtboxDate.Clear()
        mtxtboxTime.Clear()
        txtboxTotal_Amount.Clear()
        txtboxReceive_Amount.Clear()
        txtboxTotal_Change.Clear()
        listbox1.Items.Clear()
        listbox2.Items.Clear()
        cbo1.Text = 0
        cbo2.Text = 0
        cbo3.Text = 0
        cbo4.Text = 0
        cbo5.Text = 0
        cbo6.Text = 0
        cbo7.Text = 0
        cbo8.Text = 0
        MenuList.Show()
        Me.Hide()
    End Sub
End Class