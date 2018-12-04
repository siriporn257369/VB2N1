Public Class Form1
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        lblRevenue.Text = Val(txtSalary.Text) * 12
        lblvat.Text = Val(lblRevenue.Text) * 0.05
        lblBalance.Text = Val(lblRevenue.Text) - Val(lblvat.Text)
    End Sub
End Class
