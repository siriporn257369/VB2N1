<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstSubject = New System.Windows.Forms.ListBox()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.lstCredit = New System.Windows.Forms.ListBox()
        Me.lstGrade = New System.Windows.Forms.ListBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOldTotalScore = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblOldTotalCredit = New System.Windows.Forms.Label()
        Me.lblNewGPA = New System.Windows.Forms.Label()
        Me.lblOldGPA = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณเกรดเฉลี่ยสะสม"
        '
        'lstSubject
        '
        Me.lstSubject.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSubject.FormattingEnabled = True
        Me.lstSubject.ItemHeight = 30
        Me.lstSubject.Location = New System.Drawing.Point(45, 125)
        Me.lstSubject.Name = "lstSubject"
        Me.lstSubject.Size = New System.Drawing.Size(175, 214)
        Me.lstSubject.TabIndex = 1
        '
        'lstScore
        '
        Me.lstScore.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.ItemHeight = 30
        Me.lstScore.Location = New System.Drawing.Point(246, 125)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(175, 214)
        Me.lstScore.TabIndex = 1
        '
        'lstCredit
        '
        Me.lstCredit.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCredit.FormattingEnabled = True
        Me.lstCredit.ItemHeight = 30
        Me.lstCredit.Location = New System.Drawing.Point(466, 125)
        Me.lstCredit.Name = "lstCredit"
        Me.lstCredit.Size = New System.Drawing.Size(175, 214)
        Me.lstCredit.TabIndex = 1
        '
        'lstGrade
        '
        Me.lstGrade.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGrade.FormattingEnabled = True
        Me.lstGrade.ItemHeight = 30
        Me.lstGrade.Location = New System.Drawing.Point(667, 125)
        Me.lstGrade.Name = "lstGrade"
        Me.lstGrade.Size = New System.Drawing.Size(175, 214)
        Me.lstGrade.TabIndex = 1
        '
        'txtSubject
        '
        Me.txtSubject.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(45, 345)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(175, 37)
        Me.txtSubject.TabIndex = 2
        '
        'txtScore
        '
        Me.txtScore.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(246, 345)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(175, 37)
        Me.txtScore.TabIndex = 2
        '
        'txtCredit
        '
        Me.txtCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredit.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredit.Location = New System.Drawing.Point(465, 345)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(175, 37)
        Me.txtCredit.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(667, 345)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 40)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(766, 345)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 40)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "คะแนนสะสมก่อนหน้า"
        '
        'lblOldTotalScore
        '
        Me.lblOldTotalScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblOldTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOldTotalScore.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldTotalScore.Location = New System.Drawing.Point(182, 406)
        Me.lblOldTotalScore.Name = "lblOldTotalScore"
        Me.lblOldTotalScore.Size = New System.Drawing.Size(79, 30)
        Me.lblOldTotalScore.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(267, 406)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 30)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "หน่วยกิตสะสม"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(494, 404)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 30)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "เกรดเฉลี่ยสะสม"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(67, 453)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(300, 34)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "เกรดเฉลี่ยสะสมภาคปัจจุบัน"
        '
        'lblOldTotalCredit
        '
        Me.lblOldTotalCredit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblOldTotalCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOldTotalCredit.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldTotalCredit.Location = New System.Drawing.Point(396, 406)
        Me.lblOldTotalCredit.Name = "lblOldTotalCredit"
        Me.lblOldTotalCredit.Size = New System.Drawing.Size(79, 30)
        Me.lblOldTotalCredit.TabIndex = 4
        '
        'lblNewGPA
        '
        Me.lblNewGPA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNewGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewGPA.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewGPA.Location = New System.Drawing.Point(373, 452)
        Me.lblNewGPA.Name = "lblNewGPA"
        Me.lblNewGPA.Size = New System.Drawing.Size(121, 34)
        Me.lblNewGPA.TabIndex = 4
        '
        'lblOldGPA
        '
        Me.lblOldGPA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblOldGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOldGPA.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldGPA.Location = New System.Drawing.Point(640, 403)
        Me.lblOldGPA.Name = "lblOldGPA"
        Me.lblOldGPA.Size = New System.Drawing.Size(79, 30)
        Me.lblOldGPA.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(45, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(175, 43)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "วิชา"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(246, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(175, 43)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "คะแนนสอบ"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(466, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(175, 43)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "หน่วยกิต"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(664, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(175, 43)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "เกรด"
        '
        'frmLab8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(891, 495)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblOldGPA)
        Me.Controls.Add(Me.lblNewGPA)
        Me.Controls.Add(Me.lblOldTotalCredit)
        Me.Controls.Add(Me.lblOldTotalScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lstGrade)
        Me.Controls.Add(Me.lstCredit)
        Me.Controls.Add(Me.lstScore)
        Me.Controls.Add(Me.lstSubject)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab8"
        Me.Text = "frmLab8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstSubject As ListBox
    Friend WithEvents lstScore As ListBox
    Friend WithEvents lstCredit As ListBox
    Friend WithEvents lstGrade As ListBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtScore As TextBox
    Friend WithEvents txtCredit As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOldTotalScore As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblOldTotalCredit As Label
    Friend WithEvents lblNewGPA As Label
    Friend WithEvents lblOldGPA As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
