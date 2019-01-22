<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPractice2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.radUs = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.radKorea = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radUnLock = New System.Windows.Forms.RadioButton()
        Me.radLock = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtBaht = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณอัตราแลกเปลี่ยน"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "เงินไทย"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 363)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "แลกได้"
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(160, 363)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(238, 112)
        Me.lblResult.TabIndex = 1
        '
        'radUs
        '
        Me.radUs.AutoSize = True
        Me.radUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUs.Location = New System.Drawing.Point(160, 194)
        Me.radUs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radUs.Name = "radUs"
        Me.radUs.Size = New System.Drawing.Size(109, 33)
        Me.radUs.TabIndex = 2
        Me.radUs.TabStop = True
        Me.radUs.Text = "US(39)"
        Me.radUs.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFrench.Location = New System.Drawing.Point(160, 246)
        Me.radFrench.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(144, 33)
        Me.radFrench.TabIndex = 2
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "Frenct(37)"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'radKorea
        '
        Me.radKorea.AutoSize = True
        Me.radKorea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radKorea.Location = New System.Drawing.Point(160, 298)
        Me.radKorea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radKorea.Name = "radKorea"
        Me.radKorea.Size = New System.Drawing.Size(141, 33)
        Me.radKorea.TabIndex = 2
        Me.radKorea.TabStop = True
        Me.radKorea.Text = "Korea(30)"
        Me.radKorea.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radUnLock)
        Me.GroupBox1.Controls.Add(Me.radLock)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(417, 194)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(200, 123)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ควบคุม"
        '
        'radUnLock
        '
        Me.radUnLock.AutoSize = True
        Me.radUnLock.Location = New System.Drawing.Point(31, 82)
        Me.radUnLock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radUnLock.Name = "radUnLock"
        Me.radUnLock.Size = New System.Drawing.Size(115, 33)
        Me.radUnLock.TabIndex = 2
        Me.radUnLock.TabStop = True
        Me.radUnLock.Text = "UnLock"
        Me.radUnLock.UseVisualStyleBackColor = True
        '
        'radLock
        '
        Me.radLock.AutoSize = True
        Me.radLock.Location = New System.Drawing.Point(31, 37)
        Me.radLock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radLock.Name = "radLock"
        Me.radLock.Size = New System.Drawing.Size(85, 33)
        Me.radLock.TabIndex = 2
        Me.radLock.TabStop = True
        Me.radLock.Text = "Lock"
        Me.radLock.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(448, 383)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(131, 73)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "ปิด"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtBaht
        '
        Me.txtBaht.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaht.Location = New System.Drawing.Point(179, 100)
        Me.txtBaht.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBaht.Multiline = True
        Me.txtBaht.Name = "txtBaht"
        Me.txtBaht.Size = New System.Drawing.Size(283, 74)
        Me.txtBaht.TabIndex = 0
        '
        'FrmPractice2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 554)
        Me.Controls.Add(Me.txtBaht)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.radKorea)
        Me.Controls.Add(Me.radFrench)
        Me.Controls.Add(Me.radUs)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmPractice2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmPractice2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents radUs As RadioButton
    Friend WithEvents radFrench As RadioButton
    Friend WithEvents radKorea As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radUnLock As RadioButton
    Friend WithEvents radLock As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents txtBaht As TextBox
End Class
