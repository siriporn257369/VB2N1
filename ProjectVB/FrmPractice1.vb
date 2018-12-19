Public Class FrmPractice1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        lblFullName.Text = txtFirstName.Text & "   " & txtLastName.Text
    End Sub
End Class