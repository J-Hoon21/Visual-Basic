<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HiddenMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtboxUser = New System.Windows.Forms.TextBox()
        Me.mtxtboxTime = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtboxDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.txtboxID = New System.Windows.Forms.TextBox()
        Me.btnTSL = New System.Windows.Forms.Button()
        Me.btnHR_AS = New System.Windows.Forms.Button()
        Me.btnBP = New System.Windows.Forms.Button()
        Me.btnMT = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pbox4 = New System.Windows.Forms.PictureBox()
        Me.pbox3 = New System.Windows.Forms.PictureBox()
        Me.pbox2 = New System.Windows.Forms.PictureBox()
        Me.pbox1 = New System.Windows.Forms.PictureBox()
        Me.btnReject = New System.Windows.Forms.Button()
        CType(Me.pbox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(662, 277)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(106, 73)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "45"
        '
        'txtboxUser
        '
        Me.txtboxUser.BackColor = System.Drawing.SystemColors.Window
        Me.txtboxUser.Enabled = False
        Me.txtboxUser.Location = New System.Drawing.Point(438, 32)
        Me.txtboxUser.Name = "txtboxUser"
        Me.txtboxUser.Size = New System.Drawing.Size(100, 20)
        Me.txtboxUser.TabIndex = 154
        Me.txtboxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtxtboxTime
        '
        Me.mtxtboxTime.Enabled = False
        Me.mtxtboxTime.Location = New System.Drawing.Point(332, 32)
        Me.mtxtboxTime.Mask = "90:00"
        Me.mtxtboxTime.Name = "mtxtboxTime"
        Me.mtxtboxTime.Size = New System.Drawing.Size(100, 20)
        Me.mtxtboxTime.TabIndex = 153
        Me.mtxtboxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtxtboxTime.ValidatingType = GetType(Date)
        '
        'mtxtboxDate
        '
        Me.mtxtboxDate.Enabled = False
        Me.mtxtboxDate.Location = New System.Drawing.Point(226, 32)
        Me.mtxtboxDate.Mask = "00/00/0000"
        Me.mtxtboxDate.Name = "mtxtboxDate"
        Me.mtxtboxDate.Size = New System.Drawing.Size(100, 20)
        Me.mtxtboxDate.TabIndex = 152
        Me.mtxtboxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtxtboxDate.ValidatingType = GetType(Date)
        '
        'txtboxName
        '
        Me.txtboxName.Enabled = False
        Me.txtboxName.Location = New System.Drawing.Point(120, 32)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(100, 20)
        Me.txtboxName.TabIndex = 151
        Me.txtboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxID
        '
        Me.txtboxID.Enabled = False
        Me.txtboxID.Location = New System.Drawing.Point(14, 32)
        Me.txtboxID.Name = "txtboxID"
        Me.txtboxID.Size = New System.Drawing.Size(100, 20)
        Me.txtboxID.TabIndex = 150
        Me.txtboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTSL
        '
        Me.btnTSL.Location = New System.Drawing.Point(12, 254)
        Me.btnTSL.Name = "btnTSL"
        Me.btnTSL.Size = New System.Drawing.Size(247, 30)
        Me.btnTSL.TabIndex = 159
        Me.btnTSL.Text = "The Shepard Loaf"
        Me.btnTSL.UseVisualStyleBackColor = True
        '
        'btnHR_AS
        '
        Me.btnHR_AS.Location = New System.Drawing.Point(291, 254)
        Me.btnHR_AS.Name = "btnHR_AS"
        Me.btnHR_AS.Size = New System.Drawing.Size(245, 30)
        Me.btnHR_AS.TabIndex = 160
        Me.btnHR_AS.Text = "Harrods Roquefort and Almond-Sourdough Bread"
        Me.btnHR_AS.UseVisualStyleBackColor = True
        '
        'btnBP
        '
        Me.btnBP.Location = New System.Drawing.Point(291, 496)
        Me.btnBP.Name = "btnBP"
        Me.btnBP.Size = New System.Drawing.Size(247, 30)
        Me.btnBP.TabIndex = 161
        Me.btnBP.Text = "Butterfly Pea"
        Me.btnBP.UseVisualStyleBackColor = True
        '
        'btnMT
        '
        Me.btnMT.Location = New System.Drawing.Point(12, 496)
        Me.btnMT.Name = "btnMT"
        Me.btnMT.Size = New System.Drawing.Size(247, 30)
        Me.btnMT.TabIndex = 162
        Me.btnMT.Text = "Matcha Tea"
        Me.btnMT.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(604, 195)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(232, 39)
        Me.lblTitle.TabIndex = 163
        Me.lblTitle.Text = "Hidden Menu"
        '
        'pbox4
        '
        Me.pbox4.Image = Global.Cafeteria_Ordering_System.My.Resources.Resources._67799576_628470364329685_599481102700118016_n
        Me.pbox4.Location = New System.Drawing.Point(291, 338)
        Me.pbox4.Name = "pbox4"
        Me.pbox4.Size = New System.Drawing.Size(247, 152)
        Me.pbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbox4.TabIndex = 158
        Me.pbox4.TabStop = False
        '
        'pbox3
        '
        Me.pbox3.Image = Global.Cafeteria_Ordering_System.My.Resources.Resources._71538393
        Me.pbox3.Location = New System.Drawing.Point(14, 338)
        Me.pbox3.Name = "pbox3"
        Me.pbox3.Size = New System.Drawing.Size(245, 152)
        Me.pbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbox3.TabIndex = 157
        Me.pbox3.TabStop = False
        '
        'pbox2
        '
        Me.pbox2.Image = Global.Cafeteria_Ordering_System.My.Resources.Resources.Harrods_Roquefort_and_Almond_Sourdough_Bread_750x422
        Me.pbox2.Location = New System.Drawing.Point(291, 94)
        Me.pbox2.Name = "pbox2"
        Me.pbox2.Size = New System.Drawing.Size(245, 140)
        Me.pbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbox2.TabIndex = 156
        Me.pbox2.TabStop = False
        '
        'pbox1
        '
        Me.pbox1.BackgroundImage = Global.Cafeteria_Ordering_System.My.Resources.Resources.The_Shepherd_Loaf
        Me.pbox1.Image = Global.Cafeteria_Ordering_System.My.Resources.Resources.The_Shepherd_Loaf
        Me.pbox1.Location = New System.Drawing.Point(12, 94)
        Me.pbox1.Name = "pbox1"
        Me.pbox1.Size = New System.Drawing.Size(247, 140)
        Me.pbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbox1.TabIndex = 155
        Me.pbox1.TabStop = False
        '
        'btnReject
        '
        Me.btnReject.Location = New System.Drawing.Point(675, 365)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(75, 23)
        Me.btnReject.TabIndex = 164
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = True
        '
        'HiddenMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(877, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnMT)
        Me.Controls.Add(Me.btnBP)
        Me.Controls.Add(Me.btnHR_AS)
        Me.Controls.Add(Me.btnTSL)
        Me.Controls.Add(Me.pbox4)
        Me.Controls.Add(Me.pbox3)
        Me.Controls.Add(Me.pbox2)
        Me.Controls.Add(Me.pbox1)
        Me.Controls.Add(Me.txtboxUser)
        Me.Controls.Add(Me.mtxtboxTime)
        Me.Controls.Add(Me.mtxtboxDate)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.txtboxID)
        Me.Controls.Add(Me.lblTime)
        Me.Name = "HiddenMenu"
        Me.Text = "Hidden Menu"
        CType(Me.pbox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents txtboxUser As TextBox
    Friend WithEvents mtxtboxTime As MaskedTextBox
    Friend WithEvents mtxtboxDate As MaskedTextBox
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents txtboxID As TextBox
    Friend WithEvents pbox1 As PictureBox
    Friend WithEvents pbox2 As PictureBox
    Friend WithEvents pbox3 As PictureBox
    Friend WithEvents pbox4 As PictureBox
    Friend WithEvents btnTSL As Button
    Friend WithEvents btnHR_AS As Button
    Friend WithEvents btnBP As Button
    Friend WithEvents btnMT As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnReject As Button
End Class
