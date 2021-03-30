Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Hours_Worked, Rate_per_Hour As Integer
        Dim Wage As Single
        Hours_Worked = Val(txtHours_Worked.Text)
        Rate_per_Hour = Val(txtRate_per_Hour.Text)
        If Hours_Worked > 40 Then
            Wage = 40 * Rate_per_Hour
            Wage = Wage + (Hours_Worked * 40) * Rate_per_Hour * 1.5
        Else Wage = Hours_Worked * Rate_per_Hour
        End If
        txtWage.Text = Wage
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
