Public Class frmPractice6
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intSumScore As Integer
        Dim StrGrade As String
        Dim drResult As DialogResult

        txtStudentName.Text = txtStudentName.Text.Trim()
        If txtStudentName.Text.Length = 0 Then
            MessageBox.Show("ท่านไม่ได้ป้อนชื่อกรุณาป้อนให้เรียบร้อย", "invalid Data", MessageBoxButtons.OK)
            Exit Sub
        ElseIf Not (IsNumeric(txtLabScore.Text) And IsNumeric(txtMidterm.Enabled) And IsNumeric(txtFinal.Text)) Then
            MessageBox.Show("ท่านป้อนคะแนนบางรายการไม่เป็นตัวเลข", "invalid Data", MessageBoxButtons.OK)
            Exit Sub
        ElseIf Val(txtLabScore.Text) < 0 Or Val(txtLabScore.Text) > 40 Or Val(txtMidterm.Text) < 0 Or Val(txtMidterm.Text) > 30 Or Val(txtFinal.Text) < 0 Or Val(txtFinal.Text > 30) Then
            MessageBox.Show("ท่านป้อนคะแนนต่ำหรือสูงเกณฑ์คะแนนที่กำหนด", "invalid Data", MessageBoxButtons.OK)
            Exit Sub
        Else
            intSumScore = Val(txtLabScore.Text) + Val(txtMidterm.Text) + Val(txtFinal.Text)
            If intSumScore < 50 Then
                If (40 + Val(txtMidterm.Text) + Val(txtFinal.Text)) >= 50 Then
                    drResult = MessageBox.Show("ระดับคะแนนอยู่ในเกณฑ์ช่วยได้หากปรับคะแนนเก็บเพิ่มขึ้น" &
                    ControlChars.NewLine & "ท่านต้องการติด I ไว้ก่อนหรือไม่", "สอบถาม", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If drResult = DialogResult.Yes Then
                        StrGrade = "I"
                    Else
                        StrGrade = "F"
                    End If
                Else
                    StrGrade = "F"

                End If
            Else
                Select Case intSumScore
                    Case Is < 55 : StrGrade = "D"
                    Case Is < 60 : StrGrade = "D+"
                    Case Is < 65 : StrGrade = "C"
                    Case Is < 70 : StrGrade = "C+"
                    Case Is < 75 : StrGrade = "B"
                    Case Is < 80 : StrGrade = "B+"
                    Case Else : StrGrade = "A"
                End Select
            End If

        End If
        lblSumScore.Text = intSumScore
        lblGrade.Text = StrGrade
    End Sub
End Class