Public Class FrmColor
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblFOrange.Click
        txtInput.ForeColor = Color.Orange
    End Sub

    Private Sub lblFRad_Click(sender As Object, e As EventArgs) Handles lblFRad.Click
        txtInput.ForeColor = Color.Red
    End Sub

    Private Sub lblFBlue_Click(sender As Object, e As EventArgs) Handles lblFBlue.Click
        txtInput.ForeColor = Color.Blue
    End Sub

    Private Sub lblFGeer_Click(sender As Object, e As EventArgs) Handles lblFGreen.Click
        txtInput.ForeColor = Color.Green
    End Sub

    Private Sub lblFViotet_Click(sender As Object, e As EventArgs) Handles lblFViotet.Click
        txtInput.ForeColor = Color.Violet
    End Sub

    Private Sub lblFBack_Click(sender As Object, e As EventArgs) Handles lblFBack.Click
        txtInput.ForeColor = Color.Black
    End Sub

    Private Sub lblFYellow_Click(sender As Object, e As EventArgs) Handles lblFYellow.Click
        txtInput.ForeColor = Color.Yellow
    End Sub

    Private Sub lblFBrown_Click(sender As Object, e As EventArgs) Handles lblFBrown.Click
        txtInput.ForeColor = Color.Brown
    End Sub

    Private Sub lblFwhite_Click(sender As Object, e As EventArgs) Handles lblFwhite.Click
        txtInput.ForeColor = Color.White
    End Sub

    Private Sub lblFSky_Click(sender As Object, e As EventArgs) Handles lblFSky.Click
        txtInput.ForeColor = Color.SkyBlue
    End Sub

    Private Sub lblBRad_Click(sender As Object, e As EventArgs) Handles lblBRad.Click
        txtInput.BackColor = Color.Red
    End Sub

    Private Sub lblBBlue_Click(sender As Object, e As EventArgs) Handles lblBBlue.Click
        txtInput.BackColor = Color.Blue
    End Sub

    Private Sub lblBGreen_Click(sender As Object, e As EventArgs) Handles lblBGreen.Click
        txtInput.BackColor = Color.Green
    End Sub

    Private Sub lblBViolet_Click(sender As Object, e As EventArgs) Handles lblBViolet.Click
        txtInput.BackColor = Color.Violet

    End Sub

    Private Sub lblBBack_Click(sender As Object, e As EventArgs) Handles lblBBack.Click
        txtInput.BackColor = Color.Black
    End Sub

    Private Sub lblBYellow_Click(sender As Object, e As EventArgs) Handles lblBYellow.Click
        txtInput.BackColor = Color.Yellow
    End Sub

    Private Sub lblBBrown_Click(sender As Object, e As EventArgs) Handles lblBBrown.Click
        txtInput.BackColor = Color.Brown
    End Sub

    Private Sub lblBOrange_Click(sender As Object, e As EventArgs) Handles lblBOrange.Click
        txtInput.BackColor = Color.Orange
    End Sub

    Private Sub lblBwhie_Click(sender As Object, e As EventArgs) Handles lblBwhie.Click
        txtInput.BackColor = Color.White
    End Sub

    Private Sub lblBSky_Click(sender As Object, e As EventArgs) Handles lblBSky.Click
        txtInput.BackColor = Color.SkyBlue


    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        txtInput.Text = Val(txtInput.Text) + 2
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        txtInput.Text = Val(txtInput.Text) - 2
    End Sub

    Private Sub cboSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSize.SelectedIndexChanged
        txtInput.Font = New Font(txtInput.Font.Name, cboSize.SelectedItem, FontStyle.Regular)
    End Sub
End Class