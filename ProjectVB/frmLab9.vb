Public Class frmLab10
    Dim decSale(4, 2) As Integer
    Dim saleName(4) As Integer
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
            txtSaleA.Clear()
            txtSaleB.Clear()
            txtSaleC.Clear()
        End If
        Dim A As Integer = Val(cboIndex.SelectedIndex)
        decSale(A, 0) = Val(txtSaleA.Text)
        decSale(A, 1) = Val(txtSaleB.Text)
        decSale(A, 2) = Val(txtSaleC.Text)
        saleName(A) = Val(txtSaleName .Text )
        Call ShowData()


    End Sub
    Sub ShowData()
        lstData.Items.Clear()
        For i = 0 To 4
            lstData.Items.Add((txtSaleName.Text) + (", ") + (txtSaleA.Text) + (",") + (txtSaleB.Text) + (",") + (txtSaleC.Text) + (","))
            Exit For
        Next

    End Sub
End Class