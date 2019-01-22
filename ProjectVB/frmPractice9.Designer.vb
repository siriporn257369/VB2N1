<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice10
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.ItemHeight = 16
        Me.lstData.Location = New System.Drawing.Point(48, 72)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(186, 212)
        Me.lstData.TabIndex = 0
        '
        'cboIndex
        '
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.Location = New System.Drawing.Point(48, 314)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(186, 24)
        Me.cboIndex.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(463, 305)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 33)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Updete"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(274, 305)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(159, 33)
        Me.txtInput.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(271, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ค่าเฉลี่ย"
        '
        'lblAvg
        '
        Me.lblAvg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.Location = New System.Drawing.Point(271, 120)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(211, 129)
        Me.lblAvg.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(217, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "โปรแกรมคำนวณค่าเฉลี่ยจากอาร์เรย์"
        '
        'frmPractice10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 379)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.lstData)
        Me.Name = "frmPractice10"
        Me.Text = "frmPractice10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstData As ListBox
    Friend WithEvents cboIndex As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents Label3 As Label
End Class
