<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmColor
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFRad = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFViotet = New System.Windows.Forms.Label()
        Me.lblFBack = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFwhite = New System.Windows.Forms.Label()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblBRad = New System.Windows.Forms.Label()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.lblBBack = New System.Windows.Forms.Label()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.lblBwhie = New System.Windows.Forms.Label()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(173, 66)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(402, 100)
        Me.txtInput.TabIndex = 0
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUp.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(581, 66)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(61, 47)
        Me.btnUp.TabIndex = 1
        Me.btnUp.Text = "+"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDown.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(582, 119)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(61, 47)
        Me.btnDown.TabIndex = 1
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'cboSize
        '
        Me.cboSize.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.IntegralHeight = False
        Me.cboSize.Items.AddRange(New Object() {"12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50"})
        Me.cboSize.Location = New System.Drawing.Point(521, 172)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(53, 26)
        Me.cboSize.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFSky)
        Me.GroupBox1.Controls.Add(Me.lblFwhite)
        Me.GroupBox1.Controls.Add(Me.lblFBrown)
        Me.GroupBox1.Controls.Add(Me.lblFYellow)
        Me.GroupBox1.Controls.Add(Me.lblFOrange)
        Me.GroupBox1.Controls.Add(Me.lblFBack)
        Me.GroupBox1.Controls.Add(Me.lblFViotet)
        Me.GroupBox1.Controls.Add(Me.lblFGreen)
        Me.GroupBox1.Controls.Add(Me.lblFBlue)
        Me.GroupBox1.Controls.Add(Me.lblFRad)
        Me.GroupBox1.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(125, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 147)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ForeColor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblBOrange)
        Me.GroupBox2.Controls.Add(Me.lblBSky)
        Me.GroupBox2.Controls.Add(Me.lblBRad)
        Me.GroupBox2.Controls.Add(Me.lblBwhie)
        Me.GroupBox2.Controls.Add(Me.lblBBlue)
        Me.GroupBox2.Controls.Add(Me.lblBBrown)
        Me.GroupBox2.Controls.Add(Me.lblBGreen)
        Me.GroupBox2.Controls.Add(Me.lblBYellow)
        Me.GroupBox2.Controls.Add(Me.lblBViolet)
        Me.GroupBox2.Controls.Add(Me.lblBBack)
        Me.GroupBox2.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(453, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 147)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BgColor"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "กำหนดตัวเลข"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Minion Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(409, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ขนาดฟอนต์"
        '
        'lblFRad
        '
        Me.lblFRad.BackColor = System.Drawing.Color.Red
        Me.lblFRad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFRad.Location = New System.Drawing.Point(7, 30)
        Me.lblFRad.Name = "lblFRad"
        Me.lblFRad.Size = New System.Drawing.Size(54, 48)
        Me.lblFRad.TabIndex = 0
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFBlue.Location = New System.Drawing.Point(67, 30)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(54, 48)
        Me.lblFBlue.TabIndex = 0
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.Green
        Me.lblFGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFGreen.Location = New System.Drawing.Point(127, 30)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(54, 48)
        Me.lblFGreen.TabIndex = 0
        '
        'lblFViotet
        '
        Me.lblFViotet.BackColor = System.Drawing.Color.BlueViolet
        Me.lblFViotet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFViotet.Location = New System.Drawing.Point(187, 30)
        Me.lblFViotet.Name = "lblFViotet"
        Me.lblFViotet.Size = New System.Drawing.Size(54, 48)
        Me.lblFViotet.TabIndex = 0
        '
        'lblFBack
        '
        Me.lblFBack.BackColor = System.Drawing.Color.Black
        Me.lblFBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFBack.Location = New System.Drawing.Point(247, 30)
        Me.lblFBack.Name = "lblFBack"
        Me.lblFBack.Size = New System.Drawing.Size(54, 48)
        Me.lblFBack.TabIndex = 0
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.OrangeRed
        Me.lblFOrange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFOrange.Location = New System.Drawing.Point(7, 87)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(54, 48)
        Me.lblFOrange.TabIndex = 0
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFYellow.Location = New System.Drawing.Point(67, 87)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(54, 48)
        Me.lblFYellow.TabIndex = 0
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.Brown
        Me.lblFBrown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFBrown.Location = New System.Drawing.Point(127, 87)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(54, 48)
        Me.lblFBrown.TabIndex = 0
        '
        'lblFwhite
        '
        Me.lblFwhite.BackColor = System.Drawing.Color.White
        Me.lblFwhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFwhite.Location = New System.Drawing.Point(187, 87)
        Me.lblFwhite.Name = "lblFwhite"
        Me.lblFwhite.Size = New System.Drawing.Size(54, 48)
        Me.lblFwhite.TabIndex = 0
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.SkyBlue
        Me.lblFSky.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFSky.Location = New System.Drawing.Point(247, 87)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(54, 48)
        Me.lblFSky.TabIndex = 0
        '
        'lblBRad
        '
        Me.lblBRad.BackColor = System.Drawing.Color.Red
        Me.lblBRad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBRad.Location = New System.Drawing.Point(6, 30)
        Me.lblBRad.Name = "lblBRad"
        Me.lblBRad.Size = New System.Drawing.Size(54, 48)
        Me.lblBRad.TabIndex = 0
        '
        'lblBBlue
        '
        Me.lblBBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBBlue.Location = New System.Drawing.Point(68, 30)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(54, 48)
        Me.lblBBlue.TabIndex = 0
        '
        'lblBGreen
        '
        Me.lblBGreen.BackColor = System.Drawing.Color.Green
        Me.lblBGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBGreen.Location = New System.Drawing.Point(128, 30)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(54, 48)
        Me.lblBGreen.TabIndex = 0
        '
        'lblBViolet
        '
        Me.lblBViolet.BackColor = System.Drawing.Color.BlueViolet
        Me.lblBViolet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBViolet.Location = New System.Drawing.Point(188, 30)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(54, 48)
        Me.lblBViolet.TabIndex = 0
        '
        'lblBBack
        '
        Me.lblBBack.BackColor = System.Drawing.Color.Black
        Me.lblBBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBBack.Location = New System.Drawing.Point(248, 30)
        Me.lblBBack.Name = "lblBBack"
        Me.lblBBack.Size = New System.Drawing.Size(54, 48)
        Me.lblBBack.TabIndex = 0
        '
        'lblBYellow
        '
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBYellow.Location = New System.Drawing.Point(68, 87)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(54, 48)
        Me.lblBYellow.TabIndex = 0
        '
        'lblBBrown
        '
        Me.lblBBrown.BackColor = System.Drawing.Color.Brown
        Me.lblBBrown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBBrown.Location = New System.Drawing.Point(128, 87)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(54, 48)
        Me.lblBBrown.TabIndex = 0
        '
        'lblBwhie
        '
        Me.lblBwhie.BackColor = System.Drawing.Color.White
        Me.lblBwhie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBwhie.Location = New System.Drawing.Point(188, 87)
        Me.lblBwhie.Name = "lblBwhie"
        Me.lblBwhie.Size = New System.Drawing.Size(54, 48)
        Me.lblBwhie.TabIndex = 0
        '
        'lblBSky
        '
        Me.lblBSky.BackColor = System.Drawing.Color.SkyBlue
        Me.lblBSky.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBSky.Location = New System.Drawing.Point(248, 87)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(54, 48)
        Me.lblBSky.TabIndex = 0
        '
        'lblBOrange
        '
        Me.lblBOrange.BackColor = System.Drawing.Color.Orange
        Me.lblBOrange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBOrange.Location = New System.Drawing.Point(7, 87)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(55, 48)
        Me.lblBOrange.TabIndex = 1
        '
        'FrmColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(790, 419)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "FrmColor"
        Me.Text = "FrmColor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFSky As Label
    Friend WithEvents lblFwhite As Label
    Friend WithEvents lblFBrown As Label
    Friend WithEvents lblFYellow As Label
    Friend WithEvents lblFOrange As Label
    Friend WithEvents lblFBack As Label
    Friend WithEvents lblFViotet As Label
    Friend WithEvents lblFGreen As Label
    Friend WithEvents lblFBlue As Label
    Friend WithEvents lblFRad As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblBRad As Label
    Friend WithEvents lblBBlue As Label
    Friend WithEvents lblBGreen As Label
    Friend WithEvents lblBViolet As Label
    Friend WithEvents lblBBack As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBSky As Label
    Friend WithEvents lblBwhie As Label
    Friend WithEvents lblBBrown As Label
    Friend WithEvents lblBYellow As Label
    Friend WithEvents lblBOrange As Label
End Class
