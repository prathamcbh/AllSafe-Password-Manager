<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.crtbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUname = New System.Windows.Forms.TextBox()
        Me.LabelRec = New System.Windows.Forms.Label()
        Me.backupkeyR = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextCPass = New System.Windows.Forms.TextBox()
        Me.Buttonconfirm = New System.Windows.Forms.Button()
        Me.IOP = New System.Windows.Forms.Button()
        Me.ICP = New System.Windows.Forms.Button()
        Me.IOCP = New System.Windows.Forms.Button()
        Me.ICCP = New System.Windows.Forms.Button()
        Me.ICR = New System.Windows.Forms.Button()
        Me.IOR = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crtbtn
        '
        Me.crtbtn.BackColor = System.Drawing.Color.Transparent
        Me.crtbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.crtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.crtbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crtbtn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.crtbtn.Location = New System.Drawing.Point(158, 461)
        Me.crtbtn.Name = "crtbtn"
        Me.crtbtn.Size = New System.Drawing.Size(282, 50)
        Me.crtbtn.TabIndex = 15
        Me.crtbtn.Text = "Create"
        Me.crtbtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(41, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 29)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password"
        '
        'TextPass
        '
        Me.TextPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPass.Location = New System.Drawing.Point(281, 268)
        Me.TextPass.Name = "TextPass"
        Me.TextPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextPass.Size = New System.Drawing.Size(276, 28)
        Me.TextPass.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(41, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Username"
        '
        'TextBoxUname
        '
        Me.TextBoxUname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUname.Location = New System.Drawing.Point(281, 211)
        Me.TextBoxUname.Name = "TextBoxUname"
        Me.TextBoxUname.Size = New System.Drawing.Size(276, 28)
        Me.TextBoxUname.TabIndex = 10
        '
        'LabelRec
        '
        Me.LabelRec.AutoSize = True
        Me.LabelRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRec.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LabelRec.Location = New System.Drawing.Point(41, 381)
        Me.LabelRec.Name = "LabelRec"
        Me.LabelRec.Size = New System.Drawing.Size(161, 29)
        Me.LabelRec.TabIndex = 16
        Me.LabelRec.Text = "Recovery Key"
        '
        'backupkeyR
        '
        Me.backupkeyR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.backupkeyR.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backupkeyR.Location = New System.Drawing.Point(281, 382)
        Me.backupkeyR.Name = "backupkeyR"
        Me.backupkeyR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.backupkeyR.ReadOnly = True
        Me.backupkeyR.Size = New System.Drawing.Size(276, 28)
        Me.backupkeyR.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Password_Manager_1._1.My.Resources.Resources.Allsafe4
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(71, -107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(457, 403)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(41, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 29)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Confirm Password"
        '
        'TextCPass
        '
        Me.TextCPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextCPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCPass.Location = New System.Drawing.Point(281, 325)
        Me.TextCPass.Name = "TextCPass"
        Me.TextCPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextCPass.Size = New System.Drawing.Size(276, 28)
        Me.TextCPass.TabIndex = 17
        '
        'Buttonconfirm
        '
        Me.Buttonconfirm.BackColor = System.Drawing.Color.Transparent
        Me.Buttonconfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Buttonconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonconfirm.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Buttonconfirm.Location = New System.Drawing.Point(158, 461)
        Me.Buttonconfirm.Name = "Buttonconfirm"
        Me.Buttonconfirm.Size = New System.Drawing.Size(282, 50)
        Me.Buttonconfirm.TabIndex = 19
        Me.Buttonconfirm.Text = "Confirm"
        Me.Buttonconfirm.UseVisualStyleBackColor = False
        '
        'IOP
        '
        Me.IOP.BackColor = System.Drawing.SystemColors.Control
        Me.IOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IOP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.IOP.FlatAppearance.BorderSize = 0
        Me.IOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IOP.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.IOP.Image = Global.Password_Manager_1._1.My.Resources.Resources.IO
        Me.IOP.Location = New System.Drawing.Point(512, 268)
        Me.IOP.Name = "IOP"
        Me.IOP.Size = New System.Drawing.Size(45, 28)
        Me.IOP.TabIndex = 35
        Me.IOP.UseVisualStyleBackColor = False
        '
        'ICP
        '
        Me.ICP.BackColor = System.Drawing.SystemColors.Control
        Me.ICP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ICP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ICP.FlatAppearance.BorderSize = 0
        Me.ICP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ICP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ICP.ForeColor = System.Drawing.SystemColors.Control
        Me.ICP.Image = Global.Password_Manager_1._1.My.Resources.Resources.IC
        Me.ICP.Location = New System.Drawing.Point(512, 268)
        Me.ICP.Name = "ICP"
        Me.ICP.Size = New System.Drawing.Size(45, 28)
        Me.ICP.TabIndex = 36
        Me.ICP.UseVisualStyleBackColor = False
        '
        'IOCP
        '
        Me.IOCP.BackColor = System.Drawing.SystemColors.Control
        Me.IOCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IOCP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.IOCP.FlatAppearance.BorderSize = 0
        Me.IOCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IOCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IOCP.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.IOCP.Image = Global.Password_Manager_1._1.My.Resources.Resources.IO
        Me.IOCP.Location = New System.Drawing.Point(512, 325)
        Me.IOCP.Name = "IOCP"
        Me.IOCP.Size = New System.Drawing.Size(45, 28)
        Me.IOCP.TabIndex = 37
        Me.IOCP.UseVisualStyleBackColor = False
        '
        'ICCP
        '
        Me.ICCP.BackColor = System.Drawing.SystemColors.Control
        Me.ICCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ICCP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ICCP.FlatAppearance.BorderSize = 0
        Me.ICCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ICCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ICCP.ForeColor = System.Drawing.SystemColors.Control
        Me.ICCP.Image = Global.Password_Manager_1._1.My.Resources.Resources.IC
        Me.ICCP.Location = New System.Drawing.Point(512, 325)
        Me.ICCP.Name = "ICCP"
        Me.ICCP.Size = New System.Drawing.Size(45, 28)
        Me.ICCP.TabIndex = 38
        Me.ICCP.UseVisualStyleBackColor = False
        '
        'ICR
        '
        Me.ICR.BackColor = System.Drawing.SystemColors.Control
        Me.ICR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ICR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ICR.FlatAppearance.BorderSize = 0
        Me.ICR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ICR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ICR.ForeColor = System.Drawing.SystemColors.Control
        Me.ICR.Image = Global.Password_Manager_1._1.My.Resources.Resources.IC
        Me.ICR.Location = New System.Drawing.Point(512, 382)
        Me.ICR.Name = "ICR"
        Me.ICR.Size = New System.Drawing.Size(45, 28)
        Me.ICR.TabIndex = 39
        Me.ICR.UseVisualStyleBackColor = False
        '
        'IOR
        '
        Me.IOR.BackColor = System.Drawing.SystemColors.Control
        Me.IOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IOR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.IOR.FlatAppearance.BorderSize = 0
        Me.IOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IOR.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.IOR.Image = Global.Password_Manager_1._1.My.Resources.Resources.IO
        Me.IOR.Location = New System.Drawing.Point(512, 382)
        Me.IOR.Name = "IOR"
        Me.IOR.Size = New System.Drawing.Size(45, 28)
        Me.IOR.TabIndex = 40
        Me.IOR.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(598, 552)
        Me.Controls.Add(Me.IOR)
        Me.Controls.Add(Me.ICR)
        Me.Controls.Add(Me.IOCP)
        Me.Controls.Add(Me.IOP)
        Me.Controls.Add(Me.Buttonconfirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelRec)
        Me.Controls.Add(Me.crtbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.backupkeyR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxUname)
        Me.Controls.Add(Me.ICP)
        Me.Controls.Add(Me.ICCP)
        Me.Controls.Add(Me.TextPass)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextCPass)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AllSafe-Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents crtbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUname As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelRec As Label
    Friend WithEvents backupkeyR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextCPass As TextBox
    Friend WithEvents Buttonconfirm As Button
    Friend WithEvents IOP As Button
    Friend WithEvents ICP As Button
    Friend WithEvents IOCP As Button
    Friend WithEvents ICCP As Button
    Friend WithEvents ICR As Button
    Friend WithEvents IOR As Button
End Class
