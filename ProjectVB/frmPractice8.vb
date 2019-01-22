Public Class frmPractice8
    Dim saleTotal As Decimal
    Dim commTotal As Decimal
    Dim yoursale As Decimal
    Private Sub txtYoursale_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYoursale.KeyPress
        Dim keyint As Integer = Asc(e.KeyChar)
        If (keyint >= 48 And keyint <= 57) Or keyint = 46 Or keyint = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub
    Private Function getCommission(ByVal yoursale As Decimal) As Decimal
        If yoursale <= 5000 Then
            Return 0
        ElseIf yoursale <= 10000 Then
            Return yoursale * 0.025
        ElseIf yoursale <= 50000 Then
            Return yoursale * 0.05
        Else
            Return yoursale * 0.1
        End If
    End Function
    Private Sub startUp()
        txtName.Clear()
        txtYoursale.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim commission As Decimal
        If txtName.Text.Trim() = "" Or txtYoursale.Text.Trim() = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์", "Error..", MessageBoxButtons.OK)
            txtName.Focus()
            Exit Sub
        Else
            commission = getCommission(Val(txtYoursale.Text))
            saleTotal += CDec(txtYoursale.Text)
            commTotal += commission
            lstData.Items.Add(txtName.Text & "," & txtYoursale.Text & "," & commission)
            lblSaleTotal.Text = saleTotal
            lblCommTotal.Text = commTotal
            Call startUp()
        End If
    End Sub
End Class