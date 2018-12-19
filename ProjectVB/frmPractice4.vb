Public Class frmPractice4
    Const decDISOUNT_RATE As Double = 0.05
    Dim strId, strName As String
    Dim intAmount As Integer
    Dim dblPcrie, dblTotal, dblDiscount, dblNet As Double

    Private Sub radProCredit_Click(sender As Object, e As EventArgs) Handles radProCredit.Click
        lblProNet.Text = lblProTotal.Text
    End Sub

    Private Sub radProCash_Click(sender As Object, e As EventArgs) Handles radProCash.Click
        dblDiscount = Val(lblProTotal.Text) * decDISOUNT_RATE
        lblProNet.Text = Val(lblProTotal.Text) - dblDiscount
    End Sub

    Private Sub txtProAmount_TextChanged(sender As Object, e As EventArgs) Handles txtProAmount.TextChanged
        lblProTotal.Text = Val(txtProAmount.Text) * dblPcrie
        radProCash.Checked = True
        Call radProCash_Click(sender, e)

    End Sub

    Private Sub frmPractice4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strId = "P001"
        strName = "Computer"
        dblPcrie = 55000
        lblProld.Text = strId
        lblProName.Text = strName
        lblProPrice.Text = dblPcrie
    End Sub


End Class