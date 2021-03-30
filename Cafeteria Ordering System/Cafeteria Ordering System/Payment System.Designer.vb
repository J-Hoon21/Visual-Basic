<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTen_sen = New System.Windows.Forms.Label()
        Me.lblFifty_ringgit = New System.Windows.Forms.Label()
        Me.lblTwenty_ringgit = New System.Windows.Forms.Label()
        Me.lblTen_ringgit = New System.Windows.Forms.Label()
        Me.lblTwenty_sen = New System.Windows.Forms.Label()
        Me.lblFifty_sen = New System.Windows.Forms.Label()
        Me.lblOne_ringgit = New System.Windows.Forms.Label()
        Me.lblFive_ringgit = New System.Windows.Forms.Label()
        Me.txtboxReceive_Amount = New System.Windows.Forms.TextBox()
        Me.txtboxTotal_Change = New System.Windows.Forms.TextBox()
        Me.txtboxTotal_Amount = New System.Windows.Forms.TextBox()
        Me.lblTotal_Change = New System.Windows.Forms.Label()
        Me.lblReceive_Amount = New System.Windows.Forms.Label()
        Me.lblTotal_Amount = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFinal_Calculate = New System.Windows.Forms.Button()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.picbox1 = New System.Windows.Forms.PictureBox()
        Me.cbo1 = New System.Windows.Forms.ComboBox()
        Me.cbo2 = New System.Windows.Forms.ComboBox()
        Me.cbo3 = New System.Windows.Forms.ComboBox()
        Me.cbo4 = New System.Windows.Forms.ComboBox()
        Me.cbo5 = New System.Windows.Forms.ComboBox()
        Me.cbo6 = New System.Windows.Forms.ComboBox()
        Me.cbo7 = New System.Windows.Forms.ComboBox()
        Me.cbo8 = New System.Windows.Forms.ComboBox()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.txtboxID = New System.Windows.Forms.TextBox()
        Me.mtxtboxTime = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtboxDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtboxUser = New System.Windows.Forms.TextBox()
        Me.btnFinal_Confirm = New System.Windows.Forms.Button()
        Me.listbox1 = New System.Windows.Forms.ListBox()
        Me.listbox2 = New System.Windows.Forms.ListBox()
        CType(Me.picbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(98, 110)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(236, 29)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "PAYMENT SYSTEM"
        '
        'lblTen_sen
        '
        Me.lblTen_sen.AutoSize = True
        Me.lblTen_sen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTen_sen.ForeColor = System.Drawing.Color.Gold
        Me.lblTen_sen.Location = New System.Drawing.Point(102, 159)
        Me.lblTen_sen.Name = "lblTen_sen"
        Me.lblTen_sen.Size = New System.Drawing.Size(53, 16)
        Me.lblTen_sen.TabIndex = 33
        Me.lblTen_sen.Text = "RM0.10"
        '
        'lblFifty_ringgit
        '
        Me.lblFifty_ringgit.AutoSize = True
        Me.lblFifty_ringgit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFifty_ringgit.ForeColor = System.Drawing.Color.Gold
        Me.lblFifty_ringgit.Location = New System.Drawing.Point(102, 418)
        Me.lblFifty_ringgit.Name = "lblFifty_ringgit"
        Me.lblFifty_ringgit.Size = New System.Drawing.Size(60, 16)
        Me.lblFifty_ringgit.TabIndex = 35
        Me.lblFifty_ringgit.Text = "RM50.00"
        '
        'lblTwenty_ringgit
        '
        Me.lblTwenty_ringgit.AutoSize = True
        Me.lblTwenty_ringgit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwenty_ringgit.ForeColor = System.Drawing.Color.Gold
        Me.lblTwenty_ringgit.Location = New System.Drawing.Point(102, 379)
        Me.lblTwenty_ringgit.Name = "lblTwenty_ringgit"
        Me.lblTwenty_ringgit.Size = New System.Drawing.Size(60, 16)
        Me.lblTwenty_ringgit.TabIndex = 36
        Me.lblTwenty_ringgit.Text = "RM20.00"
        '
        'lblTen_ringgit
        '
        Me.lblTen_ringgit.AutoSize = True
        Me.lblTen_ringgit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTen_ringgit.ForeColor = System.Drawing.Color.Gold
        Me.lblTen_ringgit.Location = New System.Drawing.Point(102, 344)
        Me.lblTen_ringgit.Name = "lblTen_ringgit"
        Me.lblTen_ringgit.Size = New System.Drawing.Size(60, 16)
        Me.lblTen_ringgit.TabIndex = 37
        Me.lblTen_ringgit.Text = "RM10.00"
        '
        'lblTwenty_sen
        '
        Me.lblTwenty_sen.AutoSize = True
        Me.lblTwenty_sen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwenty_sen.ForeColor = System.Drawing.Color.Gold
        Me.lblTwenty_sen.Location = New System.Drawing.Point(102, 195)
        Me.lblTwenty_sen.Name = "lblTwenty_sen"
        Me.lblTwenty_sen.Size = New System.Drawing.Size(53, 16)
        Me.lblTwenty_sen.TabIndex = 38
        Me.lblTwenty_sen.Text = "RM0.20"
        '
        'lblFifty_sen
        '
        Me.lblFifty_sen.AutoSize = True
        Me.lblFifty_sen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFifty_sen.ForeColor = System.Drawing.Color.Gold
        Me.lblFifty_sen.Location = New System.Drawing.Point(102, 232)
        Me.lblFifty_sen.Name = "lblFifty_sen"
        Me.lblFifty_sen.Size = New System.Drawing.Size(53, 16)
        Me.lblFifty_sen.TabIndex = 39
        Me.lblFifty_sen.Text = "RM0.50"
        '
        'lblOne_ringgit
        '
        Me.lblOne_ringgit.AutoSize = True
        Me.lblOne_ringgit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOne_ringgit.ForeColor = System.Drawing.Color.Gold
        Me.lblOne_ringgit.Location = New System.Drawing.Point(102, 269)
        Me.lblOne_ringgit.Name = "lblOne_ringgit"
        Me.lblOne_ringgit.Size = New System.Drawing.Size(53, 16)
        Me.lblOne_ringgit.TabIndex = 40
        Me.lblOne_ringgit.Text = "RM1.00"
        '
        'lblFive_ringgit
        '
        Me.lblFive_ringgit.AutoSize = True
        Me.lblFive_ringgit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFive_ringgit.ForeColor = System.Drawing.Color.Gold
        Me.lblFive_ringgit.Location = New System.Drawing.Point(102, 306)
        Me.lblFive_ringgit.Name = "lblFive_ringgit"
        Me.lblFive_ringgit.Size = New System.Drawing.Size(53, 16)
        Me.lblFive_ringgit.TabIndex = 41
        Me.lblFive_ringgit.Text = "RM5.00"
        '
        'txtboxReceive_Amount
        '
        Me.txtboxReceive_Amount.Enabled = False
        Me.txtboxReceive_Amount.Location = New System.Drawing.Point(224, 501)
        Me.txtboxReceive_Amount.Name = "txtboxReceive_Amount"
        Me.txtboxReceive_Amount.Size = New System.Drawing.Size(100, 20)
        Me.txtboxReceive_Amount.TabIndex = 129
        Me.txtboxReceive_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxTotal_Change
        '
        Me.txtboxTotal_Change.Enabled = False
        Me.txtboxTotal_Change.Location = New System.Drawing.Point(224, 535)
        Me.txtboxTotal_Change.Name = "txtboxTotal_Change"
        Me.txtboxTotal_Change.Size = New System.Drawing.Size(100, 20)
        Me.txtboxTotal_Change.TabIndex = 128
        Me.txtboxTotal_Change.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxTotal_Amount
        '
        Me.txtboxTotal_Amount.Enabled = False
        Me.txtboxTotal_Amount.Location = New System.Drawing.Point(224, 468)
        Me.txtboxTotal_Amount.Name = "txtboxTotal_Amount"
        Me.txtboxTotal_Amount.Size = New System.Drawing.Size(100, 20)
        Me.txtboxTotal_Amount.TabIndex = 127
        Me.txtboxTotal_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal_Change
        '
        Me.lblTotal_Change.AutoSize = True
        Me.lblTotal_Change.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal_Change.ForeColor = System.Drawing.Color.Gold
        Me.lblTotal_Change.Location = New System.Drawing.Point(80, 539)
        Me.lblTotal_Change.Name = "lblTotal_Change"
        Me.lblTotal_Change.Size = New System.Drawing.Size(112, 16)
        Me.lblTotal_Change.TabIndex = 126
        Me.lblTotal_Change.Text = "TOTAL CHANGE"
        '
        'lblReceive_Amount
        '
        Me.lblReceive_Amount.AutoSize = True
        Me.lblReceive_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceive_Amount.ForeColor = System.Drawing.Color.Gold
        Me.lblReceive_Amount.Location = New System.Drawing.Point(80, 502)
        Me.lblReceive_Amount.Name = "lblReceive_Amount"
        Me.lblReceive_Amount.Size = New System.Drawing.Size(128, 16)
        Me.lblReceive_Amount.TabIndex = 125
        Me.lblReceive_Amount.Text = "RECEIVE AMOUNT"
        '
        'lblTotal_Amount
        '
        Me.lblTotal_Amount.AutoSize = True
        Me.lblTotal_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal_Amount.ForeColor = System.Drawing.Color.Gold
        Me.lblTotal_Amount.Location = New System.Drawing.Point(80, 468)
        Me.lblTotal_Amount.Name = "lblTotal_Amount"
        Me.lblTotal_Amount.Size = New System.Drawing.Size(114, 16)
        Me.lblTotal_Amount.TabIndex = 124
        Me.lblTotal_Amount.Text = "TOTAL AMOUNT"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(80, 588)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 132
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnFinal_Calculate
        '
        Me.btnFinal_Calculate.Location = New System.Drawing.Point(238, 588)
        Me.btnFinal_Calculate.Name = "btnFinal_Calculate"
        Me.btnFinal_Calculate.Size = New System.Drawing.Size(75, 23)
        Me.btnFinal_Calculate.TabIndex = 131
        Me.btnFinal_Calculate.Text = "Calculate"
        Me.btnFinal_Calculate.UseVisualStyleBackColor = True
        '
        'btnProceed
        '
        Me.btnProceed.Location = New System.Drawing.Point(393, 588)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(75, 23)
        Me.btnProceed.TabIndex = 133
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'picbox1
        '
        Me.picbox1.Image = Global.Cafeteria_Ordering_System.My.Resources.Resources._210_2108274_angle_monochrome_photography_money_money_clipart_black_and
        Me.picbox1.Location = New System.Drawing.Point(103, 30)
        Me.picbox1.Name = "picbox1"
        Me.picbox1.Size = New System.Drawing.Size(221, 109)
        Me.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox1.TabIndex = 130
        Me.picbox1.TabStop = False
        '
        'cbo1
        '
        Me.cbo1.FormattingEnabled = True
        Me.cbo1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbo1.Location = New System.Drawing.Point(203, 158)
        Me.cbo1.Name = "cbo1"
        Me.cbo1.Size = New System.Drawing.Size(121, 21)
        Me.cbo1.TabIndex = 136
        Me.cbo1.Text = "0"
        '
        'cbo2
        '
        Me.cbo2.FormattingEnabled = True
        Me.cbo2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbo2.Location = New System.Drawing.Point(203, 195)
        Me.cbo2.Name = "cbo2"
        Me.cbo2.Size = New System.Drawing.Size(121, 21)
        Me.cbo2.TabIndex = 137
        Me.cbo2.Text = "0"
        '
        'cbo3
        '
        Me.cbo3.FormattingEnabled = True
        Me.cbo3.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbo3.Location = New System.Drawing.Point(203, 232)
        Me.cbo3.Name = "cbo3"
        Me.cbo3.Size = New System.Drawing.Size(121, 21)
        Me.cbo3.TabIndex = 138
        Me.cbo3.Text = "0"
        '
        'cbo4
        '
        Me.cbo4.FormattingEnabled = True
        Me.cbo4.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbo4.Location = New System.Drawing.Point(203, 269)
        Me.cbo4.Name = "cbo4"
        Me.cbo4.Size = New System.Drawing.Size(121, 21)
        Me.cbo4.TabIndex = 139
        Me.cbo4.Text = "0"
        '
        'cbo5
        '
        Me.cbo5.FormattingEnabled = True
        Me.cbo5.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbo5.Location = New System.Drawing.Point(203, 306)
        Me.cbo5.Name = "cbo5"
        Me.cbo5.Size = New System.Drawing.Size(121, 21)
        Me.cbo5.TabIndex = 140
        Me.cbo5.Text = "0"
        '
        'cbo6
        '
        Me.cbo6.FormattingEnabled = True
        Me.cbo6.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbo6.Location = New System.Drawing.Point(203, 344)
        Me.cbo6.Name = "cbo6"
        Me.cbo6.Size = New System.Drawing.Size(121, 21)
        Me.cbo6.TabIndex = 141
        Me.cbo6.Text = "0"
        '
        'cbo7
        '
        Me.cbo7.FormattingEnabled = True
        Me.cbo7.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbo7.Location = New System.Drawing.Point(203, 379)
        Me.cbo7.Name = "cbo7"
        Me.cbo7.Size = New System.Drawing.Size(121, 21)
        Me.cbo7.TabIndex = 142
        Me.cbo7.Text = "0"
        '
        'cbo8
        '
        Me.cbo8.FormattingEnabled = True
        Me.cbo8.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbo8.Location = New System.Drawing.Point(203, 418)
        Me.cbo8.Name = "cbo8"
        Me.cbo8.Size = New System.Drawing.Size(121, 21)
        Me.cbo8.TabIndex = 143
        Me.cbo8.Text = "0"
        '
        'txtboxName
        '
        Me.txtboxName.Enabled = False
        Me.txtboxName.Location = New System.Drawing.Point(368, 38)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(100, 20)
        Me.txtboxName.TabIndex = 146
        Me.txtboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxID
        '
        Me.txtboxID.Enabled = False
        Me.txtboxID.Location = New System.Drawing.Point(368, 12)
        Me.txtboxID.Name = "txtboxID"
        Me.txtboxID.Size = New System.Drawing.Size(100, 20)
        Me.txtboxID.TabIndex = 145
        Me.txtboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtxtboxTime
        '
        Me.mtxtboxTime.Enabled = False
        Me.mtxtboxTime.Location = New System.Drawing.Point(368, 90)
        Me.mtxtboxTime.Mask = "90:00"
        Me.mtxtboxTime.Name = "mtxtboxTime"
        Me.mtxtboxTime.Size = New System.Drawing.Size(100, 20)
        Me.mtxtboxTime.TabIndex = 148
        Me.mtxtboxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtxtboxTime.ValidatingType = GetType(Date)
        '
        'mtxtboxDate
        '
        Me.mtxtboxDate.Enabled = False
        Me.mtxtboxDate.Location = New System.Drawing.Point(368, 64)
        Me.mtxtboxDate.Mask = "00/00/0000"
        Me.mtxtboxDate.Name = "mtxtboxDate"
        Me.mtxtboxDate.Size = New System.Drawing.Size(100, 20)
        Me.mtxtboxDate.TabIndex = 147
        Me.mtxtboxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtxtboxDate.ValidatingType = GetType(Date)
        '
        'txtboxUser
        '
        Me.txtboxUser.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxUser.Enabled = False
        Me.txtboxUser.Location = New System.Drawing.Point(368, 119)
        Me.txtboxUser.Name = "txtboxUser"
        Me.txtboxUser.Size = New System.Drawing.Size(100, 20)
        Me.txtboxUser.TabIndex = 149
        Me.txtboxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFinal_Confirm
        '
        Me.btnFinal_Confirm.Location = New System.Drawing.Point(393, 536)
        Me.btnFinal_Confirm.Name = "btnFinal_Confirm"
        Me.btnFinal_Confirm.Size = New System.Drawing.Size(75, 23)
        Me.btnFinal_Confirm.TabIndex = 150
        Me.btnFinal_Confirm.Text = "Confirm"
        Me.btnFinal_Confirm.UseVisualStyleBackColor = True
        '
        'listbox1
        '
        Me.listbox1.Enabled = False
        Me.listbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbox1.FormattingEnabled = True
        Me.listbox1.Location = New System.Drawing.Point(364, 195)
        Me.listbox1.Name = "listbox1"
        Me.listbox1.Size = New System.Drawing.Size(116, 212)
        Me.listbox1.TabIndex = 151
        '
        'listbox2
        '
        Me.listbox2.Enabled = False
        Me.listbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listbox2.FormattingEnabled = True
        Me.listbox2.Location = New System.Drawing.Point(479, 195)
        Me.listbox2.Name = "listbox2"
        Me.listbox2.Size = New System.Drawing.Size(34, 212)
        Me.listbox2.TabIndex = 152
        '
        'PaymentSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(519, 636)
        Me.ControlBox = False
        Me.Controls.Add(Me.listbox2)
        Me.Controls.Add(Me.listbox1)
        Me.Controls.Add(Me.btnFinal_Confirm)
        Me.Controls.Add(Me.txtboxUser)
        Me.Controls.Add(Me.mtxtboxTime)
        Me.Controls.Add(Me.mtxtboxDate)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.txtboxID)
        Me.Controls.Add(Me.cbo8)
        Me.Controls.Add(Me.cbo7)
        Me.Controls.Add(Me.cbo6)
        Me.Controls.Add(Me.cbo5)
        Me.Controls.Add(Me.cbo4)
        Me.Controls.Add(Me.cbo3)
        Me.Controls.Add(Me.cbo2)
        Me.Controls.Add(Me.cbo1)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnFinal_Calculate)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picbox1)
        Me.Controls.Add(Me.txtboxReceive_Amount)
        Me.Controls.Add(Me.txtboxTotal_Change)
        Me.Controls.Add(Me.txtboxTotal_Amount)
        Me.Controls.Add(Me.lblTotal_Change)
        Me.Controls.Add(Me.lblReceive_Amount)
        Me.Controls.Add(Me.lblTotal_Amount)
        Me.Controls.Add(Me.lblFive_ringgit)
        Me.Controls.Add(Me.lblOne_ringgit)
        Me.Controls.Add(Me.lblFifty_sen)
        Me.Controls.Add(Me.lblTwenty_sen)
        Me.Controls.Add(Me.lblTen_ringgit)
        Me.Controls.Add(Me.lblTwenty_ringgit)
        Me.Controls.Add(Me.lblFifty_ringgit)
        Me.Controls.Add(Me.lblTen_sen)
        Me.Name = "PaymentSystem"
        Me.Text = "PAYMENT SYSTEM"
        CType(Me.picbox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTen_sen As Label
    Friend WithEvents lblFifty_ringgit As Label
    Friend WithEvents lblTwenty_ringgit As Label
    Friend WithEvents lblTen_ringgit As Label
    Friend WithEvents lblTwenty_sen As Label
    Friend WithEvents lblFifty_sen As Label
    Friend WithEvents lblOne_ringgit As Label
    Friend WithEvents lblFive_ringgit As Label
    Friend WithEvents txtboxReceive_Amount As TextBox
    Friend WithEvents txtboxTotal_Change As TextBox
    Friend WithEvents txtboxTotal_Amount As TextBox
    Friend WithEvents lblTotal_Change As Label
    Friend WithEvents lblReceive_Amount As Label
    Friend WithEvents lblTotal_Amount As Label
    Friend WithEvents picbox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnFinal_Calculate As Button
    Friend WithEvents btnProceed As Button
    Friend WithEvents cbo1 As ComboBox
    Friend WithEvents cbo2 As ComboBox
    Friend WithEvents cbo3 As ComboBox
    Friend WithEvents cbo4 As ComboBox
    Friend WithEvents cbo5 As ComboBox
    Friend WithEvents cbo6 As ComboBox
    Friend WithEvents cbo7 As ComboBox
    Friend WithEvents cbo8 As ComboBox
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents txtboxID As TextBox
    Friend WithEvents mtxtboxTime As MaskedTextBox
    Friend WithEvents mtxtboxDate As MaskedTextBox
    Friend WithEvents txtboxUser As TextBox
    Friend WithEvents btnFinal_Confirm As Button
    Friend WithEvents listbox1 As ListBox
    Friend WithEvents listbox2 As ListBox
End Class
