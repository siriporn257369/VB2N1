Public Class frmLab8
    Dim sumScore As Double
    Dim sumCredit As Double
    Private Sub frmLab8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intScore As Decimal = 150
        Dim intCredit As Decimal = 50
        Dim intGPA As Decimal
        lblOldTotalScore.Text = intScore
        lblOldTotalCredit.Text = intCredit
        intGPA = intScore / intCredit
        lblOldGPA.Text = FormatNumber(intGPA)

        lstSubject.Items.Clear()
        lstScore.Items.Clear()
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()

        txtSubject.Clear()
        txtScore.Clear()
        txtCredit.Clear()
        lblNewGPA.Text = ""

    End Sub
    Private Function getCalNewGPA(ByVal score As String) As String
        Dim Grade As String
        If score >= 80 Then
            Grade = "A"
        ElseIf score >= 75 Then
            Grade = "B+"
        ElseIf score >= 70 Then
            Grade = "B"
        ElseIf score >= 65 Then
            Grade = "C+"
        ElseIf score >= 60 Then
            Grade = "C"
        ElseIf score >= 55 Then
            Grade = "D+"
        ElseIf score >= 50 Then
            Grade = "D"
        Else
            Grade = "F"

        End If
        Return Grade
    End Function
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim grade As String
        If txtSubject.Text = "" Or txtScore.Text = "" Or txtCredit.Text = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบถ้วน", "Error...", MessageBoxButtons.OK)
            txtSubject.Focus()
            Exit Sub
        Else
            grade = getCalNewGPA(Val(txtScore.Text))
            lstSubject.Items.Add(txtSubject.Text)
            lstScore.Items.Add(Val(txtScore.Text))
            lstCredit.Items.Add(Val(txtCredit.Text))
            lstGrade.Items.Add(grade)

            lstSubject.SelectedIndex = lstSubject.Items.Count - 1
            lstScore.SelectedIndex = lstScore.Items.Count - 1
            lstCredit.SelectedIndex = lstCredit.Items.Count - 1
            lstGrade.SelectedIndex = lstGrade.Items.Count - 1

            Call NEWGAP()
            txtSubject.Text = ""
            txtScore.Text = ""
            txtCredit.Text = ""
        End If
    End Sub
    Private Sub NEWGAP()
        Dim G, Grade, sum As Double

        sumScore = Val(lblOldTotalScore.Text)
        sumCredit = Val(lblOldTotalCredit.Text)

        For i = 0 To lstCredit.Items.Count - 1

            sum = lstCredit.Items(i)


            If lstGrade.Items(i) = "A" Then
                Grade = 4
            ElseIf lstGrade.Items(i) = "B+" Then
                Grade = 3.5
            ElseIf lstGrade.Items(i) = "B" Then
                Grade = 3
            ElseIf lstGrade.Items(i) = "C+" Then
                Grade = 2.5
            ElseIf lstGrade.Items(i) = "C" Then
                Grade = 2
            ElseIf lstGrade.Items(i) = "D+" Then
                Grade = 1.5
            ElseIf lstGrade.Items(i) = "D" Then
                Grade = 1
            ElseIf lstGrade.Items(i) = "F" Then
                Grade = 0
            End If

            sumScore += Grade * sum
            sumCredit += sum

        Next

        G = sumScore / sumCredit
        lblNewGPA.Text = G.ToString("n")
    End Sub
    Private Sub lstSubject_Click(sender As Object, e As EventArgs) Handles lstSubject.Click
        If lstSubject.SelectedIndex = 0 Then
            lstScore.SelectedIndex = lstSubject.SelectedIndex
            lstCredit.SelectedIndex = lstSubject.SelectedIndex
            lstGrade.SelectedIndex = lstSubject.SelectedIndex
        Else

            lstScore.SelectedIndex = lstSubject.SelectedIndex
            lstCredit.SelectedIndex = lstSubject.SelectedIndex
            lstGrade.SelectedIndex = lstSubject.SelectedIndex
        End If
    End Sub

    Private Sub lstScore_Click(sender As Object, e As EventArgs) Handles lstScore.Click
        If lstScore.SelectedIndex = 0 Then
            lstSubject.SelectedIndex = lstScore.SelectedIndex
            lstCredit.SelectedIndex = lstScore.SelectedIndex
            lstGrade.SelectedIndex = lstScore.SelectedIndex
        Else
            lstSubject.SelectedIndex = lstScore.SelectedIndex
            lstCredit.SelectedIndex = lstScore.SelectedIndex
            lstGrade.SelectedIndex = lstScore.SelectedIndex
        End If
    End Sub

    Private Sub lstCredit_Click(sender As Object, e As EventArgs) Handles lstCredit.Click
        If lstCredit.SelectedIndex = 0 Then
            lstSubject.SelectedIndex = lstCredit.SelectedIndex
            lstScore.SelectedIndex = lstCredit.SelectedIndex
            lstGrade.SelectedIndex = lstCredit.SelectedIndex
        Else
            lstSubject.SelectedIndex = lstCredit.SelectedIndex
            lstScore.SelectedIndex = lstCredit.SelectedIndex
            lstGrade.SelectedIndex = lstCredit.SelectedIndex
        End If
    End Sub

    Private Sub lstGrade_Click(sender As Object, e As EventArgs) Handles lstGrade.Click
        If lstGrade.SelectedIndex = 0 Then
            lstSubject.SelectedIndex = lstGrade.SelectedIndex
            lstScore.SelectedIndex = lstGrade.SelectedIndex
            lstCredit.SelectedIndex = lstGrade.SelectedIndex
        Else
            lstSubject.SelectedIndex = lstGrade.SelectedIndex
            lstScore.SelectedIndex = lstGrade.SelectedIndex
            lstCredit.SelectedIndex = lstGrade.SelectedIndex
        End If
    End Sub
    Private Sub txtScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScore.KeyPress
        Dim keyint As Integer = Asc(e.KeyChar)
        If (keyint >= 48 And keyint <= 57) Or keyint = 46 Or keyint = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtCredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCredit.KeyPress
        Dim keyint As Integer = Asc(e.KeyChar)
        If (keyint >= 48 And keyint <= 57) Or keyint = 46 Or keyint = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSubject.Items.Clear()
        lstScore.Items.Clear()
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()
        txtSubject.Text = ""
        txtScore.Text = ""
        txtCredit.Text = ""
        lblNewGPA.Text = ""

    End Sub
End Class