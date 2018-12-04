Public Class FormLAB2
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim salesCom As Double
        Dim salesPrint As Double
        Dim TotalSales As Double
        Dim CommitCom As Double
        Dim CommitPrint As Double
        Dim TotalCommit As Double

        salesCom = Val(txtCom.Text)
        salesPrint = Val(txtPrint.Text)
        TotalSales = salesCom + salesPrint
        CommitCom = Val(txtCom.Text) * 0.05
        CommitPrint = Val(txtPrint.Text) * 0.1
        TotalCommit = CommitCom + CommitPrint


        lblTotalSales.Text = TotalSales
        lblCommitCom.Text = CommitCom
        lblCommitPrint.Text = CommitPrint
        lblTotaClommit.Text = TotalCommit



    End Sub
End Class