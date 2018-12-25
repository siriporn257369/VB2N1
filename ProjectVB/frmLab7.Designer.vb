<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab7
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
        Me.lstAdd = New System.Windows.Forms.ListBox()
        Me.cboOutput = New System.Windows.Forms.ComboBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnMoveAll = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBackAll = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมควบคุม LisBox-ComboBox"
        '
        'lstAdd
        '
        Me.lstAdd.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAdd.FormattingEnabled = True
        Me.lstAdd.ItemHeight = 26
        Me.lstAdd.Location = New System.Drawing.Point(48, 88)
        Me.lstAdd.Name = "lstAdd"
        Me.lstAdd.Size = New System.Drawing.Size(157, 238)
        Me.lstAdd.TabIndex = 1
        '
        'cboOutput
        '
        Me.cboOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOutput.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOutput.FormattingEnabled = True
        Me.cboOutput.Location = New System.Drawing.Point(270, 88)
        Me.cboOutput.Name = "cboOutput"
        Me.cboOutput.Size = New System.Drawing.Size(106, 34)
        Me.cboOutput.TabIndex = 2
        '
        'btnMove
        '
        Me.btnMove.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMove.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMove.Location = New System.Drawing.Point(212, 130)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(60, 36)
        Me.btnMove.TabIndex = 3
        Me.btnMove.Text = ">"
        Me.btnMove.UseVisualStyleBackColor = False
        '
        'btnMoveAll
        '
        Me.btnMoveAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMoveAll.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveAll.Location = New System.Drawing.Point(212, 172)
        Me.btnMoveAll.Name = "btnMoveAll"
        Me.btnMoveAll.Size = New System.Drawing.Size(60, 36)
        Me.btnMoveAll.TabIndex = 3
        Me.btnMoveAll.Text = ">>"
        Me.btnMoveAll.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(211, 214)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(60, 36)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnBackAll
        '
        Me.btnBackAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBackAll.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackAll.Location = New System.Drawing.Point(211, 256)
        Me.btnBackAll.Name = "btnBackAll"
        Me.btnBackAll.Size = New System.Drawing.Size(60, 36)
        Me.btnBackAll.TabIndex = 3
        Me.btnBackAll.Text = "<<"
        Me.btnBackAll.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(104, 351)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 36)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(298, 351)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 36)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(165, 450)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(137, 36)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "ปิดหน้าต่าง"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAdd
        '
        Me.txtAdd.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(48, 406)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(143, 27)
        Me.txtAdd.TabIndex = 4
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOutput.Location = New System.Drawing.Point(267, 406)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(186, 27)
        Me.lblOutput.TabIndex = 0
        '
        'frmLab7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 498)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnBackAll)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMoveAll)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.cboOutput)
        Me.Controls.Add(Me.lstAdd)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab7"
        Me.Text = "frmLab7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstAdd As ListBox
    Friend WithEvents cboOutput As ComboBox
    Friend WithEvents btnMove As Button
    Friend WithEvents btnMoveAll As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnBackAll As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents lblOutput As Label
End Class
