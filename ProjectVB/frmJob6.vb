Public Class frmJob6

    Dim startPrice As Double = 1250000
    Dim total As Double = startPrice
    Private Sub chkCarForMe_Click(sender As Object, e As EventArgs) Handles chkCarForMe.Click


    End Sub

    Private Sub frmJob6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total = total + Val(lblFree1.Text) + Val(lblFree2.Text) + Val(lblFree3.Text)
        lblStartPrice.Text = startPrice

        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub chkFree1_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked Then
            total = total - Val(lblFree1.Text)
            lblPaidPrice.Text = total

        Else
            total = total + Val(lblFree1.Text)
            lblPaidPrice.Text = total
        End If
    End Sub
    Private Sub chkFree2_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked Then
            total = total - Val(lblFree2.Text)
            lblPaidPrice.Text = total
        Else
            total = total + Val(lblFree2.Text)
            lblPaidPrice.Text = total
        End If
    End Sub
    Private Sub chkFree3_CheckedChanged(sender As Object, e As EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked Then
            total = total - Val(lblFree3.Text)
            lblPaidPrice.Text = total
        Else
            total = total + Val(lblFree3.Text)
            lblPaidPrice.Text = total
        End If
    End Sub
    Private Sub chkItemsAdd1_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked Then
            total = total + Val(lblItemsAdd1.Text)
            lblPaidPrice.Text = total

        Else
            total = total - Val(lblItemsAdd1.Text)
            lblPaidPrice.Text = total
        End If
    End Sub
    Private Sub chkItemsAdd2_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked Then
            total = total + Val(lblItemsAdd2.Text)
            lblPaidPrice.Text = total
        Else
            total = total - Val(lblItemsAdd2.Text)
            lblPaidPrice.Text = total
        End If
    End Sub
    Private Sub chkItemsAdd3_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked Then
            total = total + Val(lblItemsAdd3.Text)
            lblPaidPrice.Text = total
        Else
            total = total - Val(lblItemsAdd3.Text)
            lblPaidPrice.Text = total
        End If
    End Sub
    Private Sub chkItemsAdd4_CheckedChanged(sender As Object, e As EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked Then
            total = total + Val(lblItemsAdd4.Text)
            lblPaidPrice.Text = total
        Else
            total = total - Val(lblItemsAdd4.Text)
            lblPaidPrice.Text = total
        End If
    End Sub
    Private Sub chkCarForMe_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarForMe.CheckedChanged
        If chkCarForMe.Checked = True Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            lblPaidPrice.Text = total
            lblStartPrice.Text = startPrice
        Else
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False

            If MsgBox("ท่านต้องการยกเลิกรายการหรือไม่", vbYesNo) = vbYes Then
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False

                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False

                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                lblStartPrice.Text = ""
                lblPaidPrice.Text = ""

            Else
                chkCarForMe.Checked = True
            End If
        End If

    End Sub


End Class