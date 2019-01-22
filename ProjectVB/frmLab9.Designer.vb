<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab10
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.lblSumA = New System.Windows.Forms.Label()
        Me.lblSumB = New System.Windows.Forms.Label()
        Me.lblSumC = New System.Windows.Forms.Label()
        Me.lblMaxSaleName = New System.Windows.Forms.Label()
        Me.lblMaxSaleAmount = New System.Windows.Forms.Label()
        Me.txtSaleName = New System.Windows.Forms.TextBox()
        Me.txtSaleA = New System.Windows.Forms.TextBox()
        Me.txtSaleB = New System.Windows.Forms.TextBox()
        Me.txtSaleC = New System.Windows.Forms.TextBox()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รายการข้อมูล"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รวมยอดขายสินค้า A"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(299, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "รวมยอดขายสินค้า B"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(299, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "รวมยอดขายสินค้า C"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(299, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 33)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ผู้ที่ทำยอดขายสูงสุด"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(299, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "เป็นเงิน"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ชื่อพนง.ขาย"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(44, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "พนักงานขายคนที่"
        '
        'lstData
        '
        Me.lstData.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstData.FormattingEnabled = True
        Me.lstData.ItemHeight = 31
        Me.lstData.Location = New System.Drawing.Point(43, 128)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(233, 190)
        Me.lstData.TabIndex = 1
        '
        'lblSumA
        '
        Me.lblSumA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumA.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumA.Location = New System.Drawing.Point(487, 128)
        Me.lblSumA.Name = "lblSumA"
        Me.lblSumA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSumA.Size = New System.Drawing.Size(145, 32)
        Me.lblSumA.TabIndex = 2
        Me.lblSumA.Text = "0"
        '
        'lblSumB
        '
        Me.lblSumB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumB.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumB.Location = New System.Drawing.Point(487, 171)
        Me.lblSumB.Name = "lblSumB"
        Me.lblSumB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSumB.Size = New System.Drawing.Size(145, 32)
        Me.lblSumB.TabIndex = 2
        Me.lblSumB.Text = "0"
        '
        'lblSumC
        '
        Me.lblSumC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumC.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumC.Location = New System.Drawing.Point(487, 219)
        Me.lblSumC.Name = "lblSumC"
        Me.lblSumC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSumC.Size = New System.Drawing.Size(145, 32)
        Me.lblSumC.TabIndex = 2
        Me.lblSumC.Text = "0"
        '
        'lblMaxSaleName
        '
        Me.lblMaxSaleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxSaleName.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxSaleName.Location = New System.Drawing.Point(487, 308)
        Me.lblMaxSaleName.Name = "lblMaxSaleName"
        Me.lblMaxSaleName.Size = New System.Drawing.Size(145, 32)
        Me.lblMaxSaleName.TabIndex = 2
        '
        'lblMaxSaleAmount
        '
        Me.lblMaxSaleAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaxSaleAmount.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxSaleAmount.Location = New System.Drawing.Point(487, 358)
        Me.lblMaxSaleAmount.Name = "lblMaxSaleAmount"
        Me.lblMaxSaleAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblMaxSaleAmount.Size = New System.Drawing.Size(145, 32)
        Me.lblMaxSaleAmount.TabIndex = 2
        Me.lblMaxSaleAmount.Text = "0"
        '
        'txtSaleName
        '
        Me.txtSaleName.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleName.Location = New System.Drawing.Point(47, 459)
        Me.txtSaleName.Multiline = True
        Me.txtSaleName.Name = "txtSaleName"
        Me.txtSaleName.Size = New System.Drawing.Size(172, 33)
        Me.txtSaleName.TabIndex = 3
        '
        'txtSaleA
        '
        Me.txtSaleA.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleA.Location = New System.Drawing.Point(302, 459)
        Me.txtSaleA.Multiline = True
        Me.txtSaleA.Name = "txtSaleA"
        Me.txtSaleA.Size = New System.Drawing.Size(104, 33)
        Me.txtSaleA.TabIndex = 3
        '
        'txtSaleB
        '
        Me.txtSaleB.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleB.Location = New System.Drawing.Point(430, 459)
        Me.txtSaleB.Multiline = True
        Me.txtSaleB.Name = "txtSaleB"
        Me.txtSaleB.Size = New System.Drawing.Size(104, 33)
        Me.txtSaleB.TabIndex = 3
        '
        'txtSaleC
        '
        Me.txtSaleC.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaleC.Location = New System.Drawing.Point(556, 459)
        Me.txtSaleC.Multiline = True
        Me.txtSaleC.Name = "txtSaleC"
        Me.txtSaleC.Size = New System.Drawing.Size(104, 33)
        Me.txtSaleC.TabIndex = 3
        '
        'cboIndex
        '
        Me.cboIndex.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.Location = New System.Drawing.Point(50, 368)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(143, 39)
        Me.cboIndex.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(293, 415)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 36)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "ยอดขาย A"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(425, 415)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 36)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "ยอดขาย B"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(548, 415)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 36)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "ยอดขาย C"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(212, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(275, 23)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "โปแกรมคำนวณยอดขายจากอาร์เรย์"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Angsana New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(586, 507)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 37)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmLab10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 556)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.txtSaleC)
        Me.Controls.Add(Me.txtSaleB)
        Me.Controls.Add(Me.txtSaleA)
        Me.Controls.Add(Me.txtSaleName)
        Me.Controls.Add(Me.lblMaxSaleAmount)
        Me.Controls.Add(Me.lblMaxSaleName)
        Me.Controls.Add(Me.lblSumC)
        Me.Controls.Add(Me.lblSumB)
        Me.Controls.Add(Me.lblSumA)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab10"
        Me.Text = "frmLab10"
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
    Friend WithEvents lstData As ListBox
    Friend WithEvents lblSumA As Label
    Friend WithEvents lblSumB As Label
    Friend WithEvents lblSumC As Label
    Friend WithEvents lblMaxSaleName As Label
    Friend WithEvents lblMaxSaleAmount As Label
    Friend WithEvents txtSaleName As TextBox
    Friend WithEvents txtSaleA As TextBox
    Friend WithEvents txtSaleB As TextBox
    Friend WithEvents txtSaleC As TextBox
    Friend WithEvents cboIndex As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnAdd As Button
End Class
