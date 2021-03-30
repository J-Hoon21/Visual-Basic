<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerLoginPage
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
        Me.lblSystem = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtboxID = New System.Windows.Forms.TextBox()
        Me.lblCustomer_Number = New System.Windows.Forms.Label()
        Me.txtboxCustomer_Number = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnLog_Out = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.txtboxUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.BackColor = System.Drawing.Color.Transparent
        Me.lblSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystem.ForeColor = System.Drawing.Color.White
        Me.lblSystem.Location = New System.Drawing.Point(117, 61)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(411, 29)
        Me.lblSystem.TabIndex = 1
        Me.lblSystem.Text = "CAFETERIA ORDERING SYSTEM"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(164, 144)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(28, 20)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID"
        '
        'txtboxID
        '
        Me.txtboxID.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxID.Location = New System.Drawing.Point(338, 144)
        Me.txtboxID.Name = "txtboxID"
        Me.txtboxID.Size = New System.Drawing.Size(161, 20)
        Me.txtboxID.TabIndex = 4
        Me.txtboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtboxID.UseSystemPasswordChar = True
        '
        'lblCustomer_Number
        '
        Me.lblCustomer_Number.AutoSize = True
        Me.lblCustomer_Number.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomer_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer_Number.ForeColor = System.Drawing.Color.White
        Me.lblCustomer_Number.Location = New System.Drawing.Point(164, 219)
        Me.lblCustomer_Number.Name = "lblCustomer_Number"
        Me.lblCustomer_Number.Size = New System.Drawing.Size(153, 20)
        Me.lblCustomer_Number.TabIndex = 5
        Me.lblCustomer_Number.Text = "Customer Number"
        '
        'txtboxCustomer_Number
        '
        Me.txtboxCustomer_Number.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxCustomer_Number.Location = New System.Drawing.Point(338, 219)
        Me.txtboxCustomer_Number.Name = "txtboxCustomer_Number"
        Me.txtboxCustomer_Number.Size = New System.Drawing.Size(161, 20)
        Me.txtboxCustomer_Number.TabIndex = 6
        Me.txtboxCustomer_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtboxCustomer_Number.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.Window
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(189, 272)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(283, 27)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnLog_Out
        '
        Me.btnLog_Out.BackColor = System.Drawing.SystemColors.Window
        Me.btnLog_Out.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog_Out.Location = New System.Drawing.Point(189, 370)
        Me.btnLog_Out.Name = "btnLog_Out"
        Me.btnLog_Out.Size = New System.Drawing.Size(283, 29)
        Me.btnLog_Out.TabIndex = 8
        Me.btnLog_Out.Text = "Log Out"
        Me.btnLog_Out.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(163, 90)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(321, 29)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "CUSTOMER LOGIN PAGE"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.SystemColors.Window
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(189, 320)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(283, 27)
        Me.btnRegister.TabIndex = 10
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(164, 180)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Name"
        '
        'txtboxName
        '
        Me.txtboxName.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxName.Location = New System.Drawing.Point(338, 180)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(161, 20)
        Me.txtboxName.TabIndex = 12
        Me.txtboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxUser
        '
        Me.txtboxUser.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxUser.Enabled = False
        Me.txtboxUser.Location = New System.Drawing.Point(534, 25)
        Me.txtboxUser.Name = "txtboxUser"
        Me.txtboxUser.Size = New System.Drawing.Size(94, 20)
        Me.txtboxUser.TabIndex = 13
        Me.txtboxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(436, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Staff Incharge:"
        '
        'CustomerLoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cafeteria_Ordering_System.My.Resources.Resources.Coffeeshop_Tips_06
        Me.ClientSize = New System.Drawing.Size(640, 431)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxUser)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnLog_Out)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtboxCustomer_Number)
        Me.Controls.Add(Me.lblCustomer_Number)
        Me.Controls.Add(Me.txtboxID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblSystem)
        Me.Name = "CustomerLoginPage"
        Me.Text = "Customer Login Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSystem As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtboxID As TextBox
    Friend WithEvents lblCustomer_Number As Label
    Friend WithEvents txtboxCustomer_Number As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnLog_Out As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblName As Label
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents txtboxUser As TextBox
    Friend WithEvents Label1 As Label
End Class
