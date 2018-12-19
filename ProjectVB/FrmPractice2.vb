Public Class FrmPractice2
    Private Sub radUs_Click(sender As Object, e As EventArgs) Handles radUs.Click
        lblResult.Text = Val(txtBaht.Text) / 39
    End Sub

    Private Sub radFrench_Click(sender As Object, e As EventArgs) Handles radFrench.Click
        lblResult.Text = Val(txtBaht.Text) / 37
    End Sub

    Private Sub radKorea_Click(sender As Object, e As EventArgs) Handles radKorea.Click
        lblResult.Text = Val(txtBaht.Text) / 30
    End Sub

    Private Sub radLock_Click(sender As Object, e As EventArgs) Handles radLock.Click
        txtBaht.Enabled = False
        radUs.Enabled = False
        radFrench.Enabled = False
        radKorea.Enabled = False
    End Sub

    Private Sub radUnLock_Click(sender As Object, e As EventArgs) Handles radUnLock.Click
        txtBaht.Enabled = True
        radUs.Enabled = True
        radFrench.Enabled = True
        radKorea.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class