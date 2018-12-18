Public Class frmLab5
    Dim decTotal, decDiscount, decNet, decCredi As Decimal

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
    End Sub

    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
    End Sub

    Private Sub radPaid_CheckedChanged(sender As Object, e As EventArgs) Handles radPaid.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radCredit_CheckedChanged(sender As Object, e As EventArgs) Handles radCredit.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radMember_Click(sender As Object, e As EventArgs) Handles radMember.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        gbpPaid.Enabled = True
    End Sub

    Private Sub radOther_Click(sender As Object, e As EventArgs) Handles radOther.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        gbpPaid.Enabled = False
        radPaid.Checked = True
    End Sub

    Private Sub radPaid_Click(sender As Object, e As EventArgs) Handles radPaid.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radCredit_Click(sender As Object, e As EventArgs) Handles radCredit.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        lblTotal.Text = txtUnit.Text * txtPrice.Text
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim p As String = txtProdut.Text
        Dim pr As Integer = Val(txtPrice.Text)
        Dim u As Integer = Val(txtUnit.Text)
        decDiscount = 0
        decTotal = txtUnit.Text * txtPrice.Text


        If p = "" Or pr <= 0 Or u <= 0 Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
        Else
            If radMember.Checked = True And radPaid.Checked = True Then

                If lblTotal.Text < 1000 Then
                    decDiscount = 0

                ElseIf lblTotal.Text < 5000 Then
                    decDiscount = 0.05 * decTotal

                ElseIf lblTotal.Text < 10000 Then
                    decDiscount = 0.1 * decTotal

                Else
                    decDiscount = 0.15 * decTotal


                End If
                decNet = decTotal - decDiscount
                decCredi = 0

            ElseIf radMember.Checked = True Or radCredit.Checked = True Then
                decDiscount = 0
                decNet = decTotal
                decCredi = decTotal


            Else
                decDiscount = 0
                decNet = decTotal
                decCredi = 0

            End If
            lblDiscount.Text = decDiscount
            lblPaid.Text = decNet
            lblCredit.Text = decCredi



        End If


    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        lblTotal.Text = txtPrice.Text
    End Sub
End Class