<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab5
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radMember = New System.Windows.Forms.RadioButton()
        Me.gbpPaid = New System.Windows.Forms.GroupBox()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.radPaid = New System.Windows.Forms.RadioButton()
        Me.txtProdut = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gbpPaid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(145, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณการขาย"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(31, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(31, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ราคาขาย"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(31, 186)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 28)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "จำนวนซื้อ"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(31, 233)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 28)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "เป็นเงิน"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(31, 378)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 28)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ส่วนลด"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(0, 430)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(241, 28)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "จำนวนเงินที่ต้องชำระ"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(31, 481)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 28)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "ยอดค้างชำระ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radOther)
        Me.GroupBox1.Controls.Add(Me.radMember)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(37, 278)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(252, 96)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทลูกค้า"
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOther.ForeColor = System.Drawing.Color.Red
        Me.radOther.Location = New System.Drawing.Point(115, 38)
        Me.radOther.Margin = New System.Windows.Forms.Padding(4)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(111, 29)
        Me.radOther.TabIndex = 1
        Me.radOther.TabStop = True
        Me.radOther.Text = "ลูกค้าทั่วไป"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'radMember
        '
        Me.radMember.AutoSize = True
        Me.radMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMember.ForeColor = System.Drawing.Color.Red
        Me.radMember.Location = New System.Drawing.Point(9, 38)
        Me.radMember.Margin = New System.Windows.Forms.Padding(4)
        Me.radMember.Name = "radMember"
        Me.radMember.Size = New System.Drawing.Size(82, 29)
        Me.radMember.TabIndex = 0
        Me.radMember.TabStop = True
        Me.radMember.Text = "สมาชิก"
        Me.radMember.UseVisualStyleBackColor = True
        '
        'gbpPaid
        '
        Me.gbpPaid.Controls.Add(Me.radCredit)
        Me.gbpPaid.Controls.Add(Me.radPaid)
        Me.gbpPaid.Enabled = False
        Me.gbpPaid.ForeColor = System.Drawing.Color.Blue
        Me.gbpPaid.Location = New System.Drawing.Point(333, 278)
        Me.gbpPaid.Margin = New System.Windows.Forms.Padding(4)
        Me.gbpPaid.Name = "gbpPaid"
        Me.gbpPaid.Padding = New System.Windows.Forms.Padding(4)
        Me.gbpPaid.Size = New System.Drawing.Size(216, 96)
        Me.gbpPaid.TabIndex = 2
        Me.gbpPaid.TabStop = False
        Me.gbpPaid.Text = "การชำระเงิน"
        '
        'radCredit
        '
        Me.radCredit.AutoSize = True
        Me.radCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCredit.ForeColor = System.Drawing.Color.Red
        Me.radCredit.Location = New System.Drawing.Point(89, 38)
        Me.radCredit.Margin = New System.Windows.Forms.Padding(4)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(58, 29)
        Me.radCredit.TabIndex = 1
        Me.radCredit.TabStop = True
        Me.radCredit.Text = "เชื่อ"
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'radPaid
        '
        Me.radPaid.AutoSize = True
        Me.radPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPaid.ForeColor = System.Drawing.Color.Red
        Me.radPaid.Location = New System.Drawing.Point(8, 38)
        Me.radPaid.Margin = New System.Windows.Forms.Padding(4)
        Me.radPaid.Name = "radPaid"
        Me.radPaid.Size = New System.Drawing.Size(53, 29)
        Me.radPaid.TabIndex = 1
        Me.radPaid.TabStop = True
        Me.radPaid.Text = "สด"
        Me.radPaid.UseVisualStyleBackColor = True
        '
        'txtProdut
        '
        Me.txtProdut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdut.Location = New System.Drawing.Point(191, 92)
        Me.txtProdut.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProdut.Multiline = True
        Me.txtProdut.Name = "txtProdut"
        Me.txtProdut.Size = New System.Drawing.Size(332, 35)
        Me.txtProdut.TabIndex = 0
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(191, 140)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(332, 35)
        Me.txtPrice.TabIndex = 1
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(191, 187)
        Me.txtUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnit.Multiline = True
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(332, 35)
        Me.txtUnit.TabIndex = 2
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(192, 244)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(332, 28)
        Me.lblTotal.TabIndex = 4
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(217, 378)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(332, 28)
        Me.lblDiscount.TabIndex = 4
        '
        'lblPaid
        '
        Me.lblPaid.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaid.Location = New System.Drawing.Point(217, 430)
        Me.lblPaid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(332, 28)
        Me.lblPaid.TabIndex = 4
        '
        'lblCredit
        '
        Me.lblCredit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredit.Location = New System.Drawing.Point(217, 481)
        Me.lblCredit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(332, 28)
        Me.lblCredit.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalculate.Location = New System.Drawing.Point(473, 527)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 44)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'frmLab5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 575)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProdut)
        Me.Controls.Add(Me.gbpPaid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLab5"
        Me.Text = "frmLab5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbpPaid.ResumeLayout(False)
        Me.gbpPaid.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radOther As RadioButton
    Friend WithEvents radMember As RadioButton
    Friend WithEvents gbpPaid As GroupBox
    Friend WithEvents radCredit As RadioButton
    Friend WithEvents radPaid As RadioButton
    Friend WithEvents txtProdut As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblPaid As Label
    Friend WithEvents lblCredit As Label
    Friend WithEvents btnCalculate As Button
End Class
