Public Class frmPractice5
    Dim decTotal, decDiscount, decNet As Decimal

    Private Sub btnCulculate_Click(sender As Object, e As EventArgs) Handles btnCulculate.Click
        decTotal = Val(txtPcrie.Text) * Val(txtUnit.Text)
        If decTotal < 1000 Then
            decDiscount = 0
        ElseIf decTotal < 5000 Then
            decDiscount = 300
        ElseIf decTotal < 10000 Then
            decDiscount = 500
        Else
            decDiscount = 1000
        End If
        decNet = decTotal - decDiscount
        lblTotal.Text = FormatNumber(decTotal)
        lblDiscount.Text = FormatNumber(decDiscount)
        lblNet.Text = FormatNumber(decNet)
    End Sub


    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        ' Call btnCulculate_Click(sender, e)
    End Sub

    Private Sub txtPcrie_TextChanged(sender As Object, e As EventArgs) Handles txtPcrie.TextChanged
        'Call btnCulculate_Click(sender, e)

    End Sub
End Class