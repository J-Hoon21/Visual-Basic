<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerRegistrationForm
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblAddressStreet = New System.Windows.Forms.Label()
        Me.lblPhone_Number = New System.Windows.Forms.Label()
        Me.txtboxCustomer_Name = New System.Windows.Forms.TextBox()
        Me.txtboxCustomer_ID = New System.Windows.Forms.TextBox()
        Me.lbl_Gender = New System.Windows.Forms.Label()
        Me.lblCustomer_ID = New System.Windows.Forms.Label()
        Me.lblCustomer_Name = New System.Windows.Forms.Label()
        Me.btnCustomer_Number = New System.Windows.Forms.Button()
        Me.txtboxAddressStreet = New System.Windows.Forms.TextBox()
        Me.txtboxCity = New System.Windows.Forms.TextBox()
        Me.txtboxState = New System.Windows.Forms.TextBox()
        Me.txtboxCountry = New System.Windows.Forms.TextBox()
        Me.txtboxEmail = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblBirth_Day = New System.Windows.Forms.Label()
        Me.mtxtboxBirth_Date = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtboxPhone_Number = New System.Windows.Forms.MaskedTextBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(89, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(440, 29)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "CUSTOMER REGISTRATION FORM"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Window
        Me.btnCancel.Location = New System.Drawing.Point(115, 340)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.Window
        Me.btnSubmit.Location = New System.Drawing.Point(450, 340)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 23
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblAddressStreet
        '
        Me.lblAddressStreet.AutoSize = True
        Me.lblAddressStreet.BackColor = System.Drawing.Color.Transparent
        Me.lblAddressStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressStreet.ForeColor = System.Drawing.Color.White
        Me.lblAddressStreet.Location = New System.Drawing.Point(337, 83)
        Me.lblAddressStreet.Name = "lblAddressStreet"
        Me.lblAddressStreet.Size = New System.Drawing.Size(130, 20)
        Me.lblAddressStreet.TabIndex = 21
        Me.lblAddressStreet.Text = "Address Street"
        '
        'lblPhone_Number
        '
        Me.lblPhone_Number.AutoSize = True
        Me.lblPhone_Number.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone_Number.ForeColor = System.Drawing.Color.White
        Me.lblPhone_Number.Location = New System.Drawing.Point(17, 261)
        Me.lblPhone_Number.Name = "lblPhone_Number"
        Me.lblPhone_Number.Size = New System.Drawing.Size(127, 20)
        Me.lblPhone_Number.TabIndex = 19
        Me.lblPhone_Number.Text = "Phone Number"
        '
        'txtboxCustomer_Name
        '
        Me.txtboxCustomer_Name.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxCustomer_Name.Location = New System.Drawing.Point(167, 83)
        Me.txtboxCustomer_Name.Name = "txtboxCustomer_Name"
        Me.txtboxCustomer_Name.Size = New System.Drawing.Size(151, 20)
        Me.txtboxCustomer_Name.TabIndex = 18
        Me.txtboxCustomer_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxCustomer_ID
        '
        Me.txtboxCustomer_ID.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxCustomer_ID.Location = New System.Drawing.Point(167, 131)
        Me.txtboxCustomer_ID.Name = "txtboxCustomer_ID"
        Me.txtboxCustomer_ID.Size = New System.Drawing.Size(124, 20)
        Me.txtboxCustomer_ID.TabIndex = 17
        Me.txtboxCustomer_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Gender
        '
        Me.lbl_Gender.AutoSize = True
        Me.lbl_Gender.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Gender.ForeColor = System.Drawing.Color.White
        Me.lbl_Gender.Location = New System.Drawing.Point(20, 177)
        Me.lbl_Gender.Name = "lbl_Gender"
        Me.lbl_Gender.Size = New System.Drawing.Size(69, 20)
        Me.lbl_Gender.TabIndex = 14
        Me.lbl_Gender.Text = "Gender"
        '
        'lblCustomer_ID
        '
        Me.lblCustomer_ID.AutoSize = True
        Me.lblCustomer_ID.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomer_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer_ID.ForeColor = System.Drawing.Color.White
        Me.lblCustomer_ID.Location = New System.Drawing.Point(20, 131)
        Me.lblCustomer_ID.Name = "lblCustomer_ID"
        Me.lblCustomer_ID.Size = New System.Drawing.Size(110, 20)
        Me.lblCustomer_ID.TabIndex = 25
        Me.lblCustomer_ID.Text = "Customer ID"
        '
        'lblCustomer_Name
        '
        Me.lblCustomer_Name.AutoSize = True
        Me.lblCustomer_Name.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomer_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer_Name.ForeColor = System.Drawing.Color.White
        Me.lblCustomer_Name.Location = New System.Drawing.Point(20, 83)
        Me.lblCustomer_Name.Name = "lblCustomer_Name"
        Me.lblCustomer_Name.Size = New System.Drawing.Size(137, 20)
        Me.lblCustomer_Name.TabIndex = 26
        Me.lblCustomer_Name.Text = "Customer Name"
        '
        'btnCustomer_Number
        '
        Me.btnCustomer_Number.BackColor = System.Drawing.SystemColors.Window
        Me.btnCustomer_Number.Location = New System.Drawing.Point(256, 340)
        Me.btnCustomer_Number.Name = "btnCustomer_Number"
        Me.btnCustomer_Number.Size = New System.Drawing.Size(134, 23)
        Me.btnCustomer_Number.TabIndex = 27
        Me.btnCustomer_Number.Text = "Customer Number"
        Me.btnCustomer_Number.UseVisualStyleBackColor = False
        '
        'txtboxAddressStreet
        '
        Me.txtboxAddressStreet.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxAddressStreet.Location = New System.Drawing.Point(482, 83)
        Me.txtboxAddressStreet.Name = "txtboxAddressStreet"
        Me.txtboxAddressStreet.Size = New System.Drawing.Size(124, 20)
        Me.txtboxAddressStreet.TabIndex = 29
        Me.txtboxAddressStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxCity
        '
        Me.txtboxCity.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxCity.Location = New System.Drawing.Point(482, 131)
        Me.txtboxCity.Name = "txtboxCity"
        Me.txtboxCity.Size = New System.Drawing.Size(124, 20)
        Me.txtboxCity.TabIndex = 30
        Me.txtboxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxState
        '
        Me.txtboxState.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxState.Location = New System.Drawing.Point(482, 176)
        Me.txtboxState.Name = "txtboxState"
        Me.txtboxState.Size = New System.Drawing.Size(124, 20)
        Me.txtboxState.TabIndex = 31
        Me.txtboxState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxCountry
        '
        Me.txtboxCountry.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxCountry.Location = New System.Drawing.Point(482, 219)
        Me.txtboxCountry.Name = "txtboxCountry"
        Me.txtboxCountry.Size = New System.Drawing.Size(124, 20)
        Me.txtboxCountry.TabIndex = 32
        Me.txtboxCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxEmail
        '
        Me.txtboxEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxEmail.Location = New System.Drawing.Point(482, 262)
        Me.txtboxEmail.Name = "txtboxEmail"
        Me.txtboxEmail.Size = New System.Drawing.Size(124, 20)
        Me.txtboxEmail.TabIndex = 33
        Me.txtboxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.BackColor = System.Drawing.Color.Transparent
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.Color.White
        Me.lblCity.Location = New System.Drawing.Point(337, 131)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(39, 20)
        Me.lblCity.TabIndex = 34
        Me.lblCity.Text = "City"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.BackColor = System.Drawing.Color.Transparent
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.White
        Me.lblState.Location = New System.Drawing.Point(337, 174)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(53, 20)
        Me.lblState.TabIndex = 35
        Me.lblState.Text = "State"
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.BackColor = System.Drawing.Color.Transparent
        Me.lblCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.ForeColor = System.Drawing.Color.White
        Me.lblCountry.Location = New System.Drawing.Point(337, 219)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(71, 20)
        Me.lblCountry.TabIndex = 36
        Me.lblCountry.Text = "Country"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(337, 259)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(53, 20)
        Me.lblEmail.TabIndex = 37
        Me.lblEmail.Text = "Email"
        '
        'lblBirth_Day
        '
        Me.lblBirth_Day.AutoSize = True
        Me.lblBirth_Day.BackColor = System.Drawing.Color.Transparent
        Me.lblBirth_Day.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirth_Day.ForeColor = System.Drawing.Color.White
        Me.lblBirth_Day.Location = New System.Drawing.Point(20, 219)
        Me.lblBirth_Day.Name = "lblBirth_Day"
        Me.lblBirth_Day.Size = New System.Drawing.Size(91, 20)
        Me.lblBirth_Day.TabIndex = 38
        Me.lblBirth_Day.Text = "Birth Date"
        '
        'mtxtboxBirth_Date
        '
        Me.mtxtboxBirth_Date.Location = New System.Drawing.Point(167, 219)
        Me.mtxtboxBirth_Date.Mask = "00/00/0000"
        Me.mtxtboxBirth_Date.Name = "mtxtboxBirth_Date"
        Me.mtxtboxBirth_Date.Size = New System.Drawing.Size(124, 20)
        Me.mtxtboxBirth_Date.TabIndex = 39
        Me.mtxtboxBirth_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtxtboxBirth_Date.ValidatingType = GetType(Date)
        '
        'mtxtboxPhone_Number
        '
        Me.mtxtboxPhone_Number.Location = New System.Drawing.Point(167, 261)
        Me.mtxtboxPhone_Number.Mask = "000-000 0000"
        Me.mtxtboxPhone_Number.Name = "mtxtboxPhone_Number"
        Me.mtxtboxPhone_Number.Size = New System.Drawing.Size(124, 20)
        Me.mtxtboxPhone_Number.TabIndex = 40
        Me.mtxtboxPhone_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(167, 173)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(124, 21)
        Me.cboGender.TabIndex = 41
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Window
        Me.btnDelete.Location = New System.Drawing.Point(256, 369)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(134, 23)
        Me.btnDelete.TabIndex = 42
        Me.btnDelete.Text = "Delete Existing Data"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'CustomerRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cafeteria_Ordering_System.My.Resources.Resources.Coffeeshop_Tips_06
        Me.ClientSize = New System.Drawing.Size(640, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.mtxtboxPhone_Number)
        Me.Controls.Add(Me.mtxtboxBirth_Date)
        Me.Controls.Add(Me.lblBirth_Day)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtboxEmail)
        Me.Controls.Add(Me.txtboxCountry)
        Me.Controls.Add(Me.txtboxState)
        Me.Controls.Add(Me.txtboxCity)
        Me.Controls.Add(Me.txtboxAddressStreet)
        Me.Controls.Add(Me.btnCustomer_Number)
        Me.Controls.Add(Me.lblCustomer_Name)
        Me.Controls.Add(Me.lblCustomer_ID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblAddressStreet)
        Me.Controls.Add(Me.lblPhone_Number)
        Me.Controls.Add(Me.txtboxCustomer_Name)
        Me.Controls.Add(Me.txtboxCustomer_ID)
        Me.Controls.Add(Me.lbl_Gender)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "CustomerRegistrationForm"
        Me.Text = "Customer Registration Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblAddressStreet As Label
    Friend WithEvents lblPhone_Number As Label
    Friend WithEvents txtboxCustomer_Name As TextBox
    Friend WithEvents txtboxCustomer_ID As TextBox
    Friend WithEvents lbl_Gender As Label
    Friend WithEvents lblCustomer_ID As Label
    Friend WithEvents lblCustomer_Name As Label
    Friend WithEvents btnCustomer_Number As Button
    Friend WithEvents txtboxAddressStreet As TextBox
    Friend WithEvents txtboxCity As TextBox
    Friend WithEvents txtboxState As TextBox
    Friend WithEvents txtboxCountry As TextBox
    Friend WithEvents txtboxEmail As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblBirth_Day As Label
    Friend WithEvents mtxtboxBirth_Date As MaskedTextBox
    Friend WithEvents mtxtboxPhone_Number As MaskedTextBox
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents btnDelete As Button
End Class
