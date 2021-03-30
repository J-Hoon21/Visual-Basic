<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHours_Worked = New System.Windows.Forms.TextBox()
        Me.txtRate_per_Hour = New System.Windows.Forms.TextBox()
        Me.txtWage = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Hours Work"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rate Per Hour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Wage"
        '
        'txtHours_Worked
        '
        Me.txtHours_Worked.Location = New System.Drawing.Point(207, 67)
        Me.txtHours_Worked.Name = "txtHours_Worked"
        Me.txtHours_Worked.Size = New System.Drawing.Size(100, 20)
        Me.txtHours_Worked.TabIndex = 3
        '
        'txtRate_per_Hour
        '
        Me.txtRate_per_Hour.Location = New System.Drawing.Point(207, 121)
        Me.txtRate_per_Hour.Name = "txtRate_per_Hour"
        Me.txtRate_per_Hour.Size = New System.Drawing.Size(100, 20)
        Me.txtRate_per_Hour.TabIndex = 4
        '
        'txtWage
        '
        Me.txtWage.Location = New System.Drawing.Point(207, 174)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.Size = New System.Drawing.Size(100, 20)
        Me.txtWage.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calculate Wage"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(207, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 375)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtWage)
        Me.Controls.Add(Me.txtRate_per_Hour)
        Me.Controls.Add(Me.txtHours_Worked)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHours_Worked As TextBox
    Friend WithEvents txtRate_per_Hour As TextBox
    Friend WithEvents txtWage As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
