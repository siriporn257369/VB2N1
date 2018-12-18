Public Class frmJob4
    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click
        Dim decR_BONUS As Decimal = 0.2
        Dim decR_ALLOW As Decimal = 0.01
        Dim decR_TAX As Decimal = 0.07
        Dim datNowDate As Date = DateTime.Now
        Dim dblYearSalary, dblBonus, dblAllIncome, dblAllowance, dblTax As Double

        dblYearSalary = txtSalary.Text * 12
        dblBonus = Val(txtSale.Text) * Val(decR_BONUS)
        dblAllIncome = Val(dblYearSalary) + Val(dblBonus)
        dblAllowance = Val(dblAllIncome) * Val(decR_ALLOW)
        dblTax = Val(dblAllIncome - dblAllowance) * decR_TAX

        lblYearSalary.Text = dblYearSalary
        lblBonus.Text = dblBonus
        lblAllIncome.Text = dblAllIncome
        lblAllowance.Text = dblAllowance
        lblTax.Text = dblTax


    End Sub

    Private Sub frmJob4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now
    End Sub

    Private Sub radShortDate_CheckedChanged(sender As Object, e As EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = Format(Now, "Short date")
    End Sub

    Private Sub radGenDate_CheckedChanged(sender As Object, e As EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = Format(Now, "General date")
    End Sub

    Private Sub LongDate_CheckedChanged(sender As Object, e As EventArgs) Handles LongDate.CheckedChanged
        lblDate.Text = Format(Now, "Long date")
    End Sub
End Class