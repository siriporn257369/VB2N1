Public Class frmLab10
    Dim decSale(4, 2) As Integer
    Dim saleName(4) As String
    Dim intIndex As Integer
    Dim decSumSale As Decimal

    Private Sub frmLab10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 4
            cboIndex.Items.Add(i + 1)
        Next
        cboIndex.SelectedIndex = 0

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtSaleA.Text.Trim = "" Or Not IsNumeric(txtSaleA.Text) Or Not IsNumeric(txtSaleB.Text) Or Not IsNumeric(txtSaleC.Text) Then
            MessageBox.Show("ข้อมูลไม่ถูกต้อง")
            txtSaleName.Clear()
            txtSaleA.Clear()
            txtSaleB.Clear()
            txtSaleC.Clear()

            Exit Sub
        End If
        Dim A As Integer = Val(cboIndex.SelectedIndex)
        decSale(A, 0) = Val(txtSaleA.Text)
        decSale(A, 1) = Val(txtSaleB.Text)
        decSale(A, 2) = Val(txtSaleC.Text)
        saleName(A) = txtSaleName.Text

        Call ShowData()


    End Sub
    Sub ShowData()
        Dim saleA, saleB, saleC As Decimal
        lstData.Items.Clear()
        For i = 0 To cboIndex.Items.Count - 1
            lstData.Items.Add(saleName(i) & "," & decSale(i, 0) & "," & decSale(i, 1) & "," & decSale(i, 2))

        Next
        For i = 0 To 4
            saleA += decSale(i, 0)
            saleB += decSale(i, 1)
            saleC += decSale(i, 2)

        Next
        lblSumA.Text = saleA
        lblSumB.Text = saleB
        lblSumC.Text = saleC
        decSumSale = saleA + saleB + saleC
        lblMaxSaleAmount.Text = decSumSale

        Dim max As Decimal = decSale(0, 0) + decSale(0, 1) + decSale(0, 2)
        Dim c As Integer
        For i = 1 To cboIndex.Items.Count - 1
            If max < decSale(i, 0) + decSale(0, 1) + decSale(0, 2) Then
                c = i
            End If
            lblMaxSaleName.Text = saleName(c)
        Next
    End Sub
End Class