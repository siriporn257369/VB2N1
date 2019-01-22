<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice8
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtYoursale = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSaleTotal = New System.Windows.Forms.Label()
        Me.lblCommTotal = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.ItemHeight = 16
        Me.lstData.Location = New System.Drawing.Point(57, 74)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(480, 276)
        Me.lstData.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(57, 385)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(201, 34)
        Me.txtName.TabIndex = 1
        '
        'txtYoursale
        '
        Me.txtYoursale.Location = New System.Drawing.Point(299, 385)
        Me.txtYoursale.Multiline = True
        Me.txtYoursale.Name = "txtYoursale"
        Me.txtYoursale.Size = New System.Drawing.Size(201, 34)
        Me.txtYoursale.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(569, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ยอดขายรวม"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(569, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ค่าคอมมิชชั่นรวม"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(54, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "พนักงานขาย ,ยอดขาย,ค่าคอมมิชั่น"
        '
        'lblSaleTotal
        '
        Me.lblSaleTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaleTotal.Location = New System.Drawing.Point(569, 102)
        Me.lblSaleTotal.Name = "lblSaleTotal"
        Me.lblSaleTotal.Size = New System.Drawing.Size(125, 28)
        Me.lblSaleTotal.TabIndex = 3
        '
        'lblCommTotal
        '
        Me.lblCommTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCommTotal.Location = New System.Drawing.Point(569, 261)
        Me.lblCommTotal.Name = "lblCommTotal"
        Me.lblCommTotal.Size = New System.Drawing.Size(125, 28)
        Me.lblCommTotal.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(572, 395)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 40)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmPractice8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 488)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCommTotal)
        Me.Controls.Add(Me.lblSaleTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtYoursale)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lstData)
        Me.Name = "frmPractice8"
        Me.Text = "frmPractice8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstData As ListBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtYoursale As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSaleTotal As Label
    Friend WithEvents lblCommTotal As Label
    Friend WithEvents btnAdd As Button
End Class
