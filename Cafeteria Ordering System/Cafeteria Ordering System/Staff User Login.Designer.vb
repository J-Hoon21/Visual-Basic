<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffUserLogin
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUser_Name = New System.Windows.Forms.Label()
        Me.txtboxUser_Name = New System.Windows.Forms.TextBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblUser_Password = New System.Windows.Forms.Label()
        Me.txtboxUser_Password = New System.Windows.Forms.TextBox()
        Me.btnUser_Register = New System.Windows.Forms.Button()
        Me.btnUser_Login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.BackColor = System.Drawing.Color.Transparent
        Me.lblSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystem.ForeColor = System.Drawing.Color.White
        Me.lblSystem.Location = New System.Drawing.Point(74, 43)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(411, 29)
        Me.lblSystem.TabIndex = 2
        Me.lblSystem.Text = "CAFETERIA ORDERING SYSTEM"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(153, 72)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(245, 29)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "USER LOGIN PAGE"
        '
        'lblUser_Name
        '
        Me.lblUser_Name.AutoSize = True
        Me.lblUser_Name.BackColor = System.Drawing.Color.Transparent
        Me.lblUser_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser_Name.ForeColor = System.Drawing.Color.White
        Me.lblUser_Name.Location = New System.Drawing.Point(131, 155)
        Me.lblUser_Name.Name = "lblUser_Name"
        Me.lblUser_Name.Size = New System.Drawing.Size(98, 20)
        Me.lblUser_Name.TabIndex = 11
        Me.lblUser_Name.Text = "User Name"
        '
        'txtboxUser_Name
        '
        Me.txtboxUser_Name.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxUser_Name.Location = New System.Drawing.Point(257, 157)
        Me.txtboxUser_Name.Name = "txtboxUser_Name"
        Me.txtboxUser_Name.Size = New System.Drawing.Size(161, 20)
        Me.txtboxUser_Name.TabIndex = 12
        Me.txtboxUser_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtboxUser_Name.UseSystemPasswordChar = True
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.Window
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(135, 326)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(283, 29)
        Me.btnQuit.TabIndex = 13
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblUser_Password
        '
        Me.lblUser_Password.AutoSize = True
        Me.lblUser_Password.BackColor = System.Drawing.Color.Transparent
        Me.lblUser_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser_Password.ForeColor = System.Drawing.Color.White
        Me.lblUser_Password.Location = New System.Drawing.Point(131, 206)
        Me.lblUser_Password.Name = "lblUser_Password"
        Me.lblUser_Password.Size = New System.Drawing.Size(129, 20)
        Me.lblUser_Password.TabIndex = 14
        Me.lblUser_Password.Text = "User Password"
        '
        'txtboxUser_Password
        '
        Me.txtboxUser_Password.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxUser_Password.Location = New System.Drawing.Point(257, 206)
        Me.txtboxUser_Password.Name = "txtboxUser_Password"
        Me.txtboxUser_Password.Size = New System.Drawing.Size(161, 20)
        Me.txtboxUser_Password.TabIndex = 15
        Me.txtboxUser_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtboxUser_Password.UseSystemPasswordChar = True
        '
        'btnUser_Register
        '
        Me.btnUser_Register.BackColor = System.Drawing.SystemColors.Window
        Me.btnUser_Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser_Register.Location = New System.Drawing.Point(135, 285)
        Me.btnUser_Register.Name = "btnUser_Register"
        Me.btnUser_Register.Size = New System.Drawing.Size(283, 29)
        Me.btnUser_Register.TabIndex = 16
        Me.btnUser_Register.Text = "Register As New User"
        Me.btnUser_Register.UseVisualStyleBackColor = False
        '
        'btnUser_Login
        '
        Me.btnUser_Login.BackColor = System.Drawing.SystemColors.Window
        Me.btnUser_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser_Login.Location = New System.Drawing.Point(135, 242)
        Me.btnUser_Login.Name = "btnUser_Login"
        Me.btnUser_Login.Size = New System.Drawing.Size(283, 29)
        Me.btnUser_Login.TabIndex = 17
        Me.btnUser_Login.Text = "Login"
        Me.btnUser_Login.UseVisualStyleBackColor = False
        '
        'StaffUserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cafeteria_Ordering_System.My.Resources.Resources.hashtag_coffee_shop_seating
        Me.ClientSize = New System.Drawing.Size(549, 367)
        Me.Controls.Add(Me.btnUser_Login)
        Me.Controls.Add(Me.btnUser_Register)
        Me.Controls.Add(Me.txtboxUser_Password)
        Me.Controls.Add(Me.lblUser_Password)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.txtboxUser_Name)
        Me.Controls.Add(Me.lblUser_Name)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSystem)
        Me.Name = "StaffUserLogin"
        Me.Text = "Staff User Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSystem As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUser_Name As Label
    Friend WithEvents txtboxUser_Name As TextBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblUser_Password As Label
    Friend WithEvents txtboxUser_Password As TextBox
    Friend WithEvents btnUser_Register As Button
    Friend WithEvents btnUser_Login As Button
End Class
