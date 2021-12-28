<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bin
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
        Me.btnpnl = New System.Windows.Forms.Panel()
        Me.BtnDelA = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BtnRestore = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxLink = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxSite = New System.Windows.Forms.TextBox()
        Me.datapnl = New System.Windows.Forms.Panel()
        Me.IO = New System.Windows.Forms.Button()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IC = New System.Windows.Forms.Button()
        Me.TextBoxpass = New System.Windows.Forms.TextBox()
        Me.btnpnl.SuspendLayout()
        Me.datapnl.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnpnl
        '
        Me.btnpnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnpnl.Controls.Add(Me.BtnDelA)
        Me.btnpnl.Controls.Add(Me.BtnDel)
        Me.btnpnl.Controls.Add(Me.BtnRestore)
        Me.btnpnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnpnl.Location = New System.Drawing.Point(0, 445)
        Me.btnpnl.Name = "btnpnl"
        Me.btnpnl.Size = New System.Drawing.Size(615, 66)
        Me.btnpnl.TabIndex = 1
        '
        'BtnDelA
        '
        Me.BtnDelA.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnDelA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BtnDelA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelA.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDelA.Location = New System.Drawing.Point(419, 14)
        Me.BtnDelA.Name = "BtnDelA"
        Me.BtnDelA.Size = New System.Drawing.Size(165, 39)
        Me.BtnDelA.TabIndex = 2
        Me.BtnDelA.Text = "Delete all"
        Me.BtnDelA.UseVisualStyleBackColor = False
        '
        'BtnDel
        '
        Me.BtnDel.BackColor = System.Drawing.Color.Transparent
        Me.BtnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDel.Location = New System.Drawing.Point(225, 15)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(165, 39)
        Me.BtnDel.TabIndex = 1
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.UseVisualStyleBackColor = False
        '
        'BtnRestore
        '
        Me.BtnRestore.BackColor = System.Drawing.Color.Transparent
        Me.BtnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRestore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BtnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestore.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnRestore.Location = New System.Drawing.Point(31, 15)
        Me.BtnRestore.Name = "BtnRestore"
        Me.BtnRestore.Size = New System.Drawing.Size(165, 39)
        Me.BtnRestore.TabIndex = 1
        Me.BtnRestore.Text = "Restore"
        Me.BtnRestore.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9), "Amazon", "Flipkart", "Google", "Microsoft"})
        Me.ComboBox1.Location = New System.Drawing.Point(80, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(453, 33)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 0
        '
        'TextBoxName
        '
        Me.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(216, 257)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.ReadOnly = True
        Me.TextBoxName.Size = New System.Drawing.Size(342, 28)
        Me.TextBoxName.TabIndex = 15
        '
        'TextBoxLink
        '
        Me.TextBoxLink.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLink.Location = New System.Drawing.Point(216, 377)
        Me.TextBoxLink.Name = "TextBoxLink"
        Me.TextBoxLink.ReadOnly = True
        Me.TextBoxLink.Size = New System.Drawing.Size(342, 28)
        Me.TextBoxLink.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(56, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 29)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(56, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 29)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Link     "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(56, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 29)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Password"
        '
        'TextBoxSite
        '
        Me.TextBoxSite.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSite.Location = New System.Drawing.Point(217, 198)
        Me.TextBoxSite.Name = "TextBoxSite"
        Me.TextBoxSite.ReadOnly = True
        Me.TextBoxSite.Size = New System.Drawing.Size(341, 28)
        Me.TextBoxSite.TabIndex = 21
        '
        'datapnl
        '
        Me.datapnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.datapnl.Controls.Add(Me.IO)
        Me.datapnl.Controls.Add(Me.backbtn)
        Me.datapnl.Controls.Add(Me.Label5)
        Me.datapnl.Controls.Add(Me.TextBoxSite)
        Me.datapnl.Controls.Add(Me.Label2)
        Me.datapnl.Controls.Add(Me.Label3)
        Me.datapnl.Controls.Add(Me.Label1)
        Me.datapnl.Controls.Add(Me.TextBoxLink)
        Me.datapnl.Controls.Add(Me.TextBoxName)
        Me.datapnl.Controls.Add(Me.ComboBox1)
        Me.datapnl.Controls.Add(Me.PictureBox1)
        Me.datapnl.Controls.Add(Me.IC)
        Me.datapnl.Controls.Add(Me.TextBoxpass)
        Me.datapnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datapnl.Location = New System.Drawing.Point(0, 0)
        Me.datapnl.Name = "datapnl"
        Me.datapnl.Size = New System.Drawing.Size(615, 445)
        Me.datapnl.TabIndex = 3
        '
        'IO
        '
        Me.IO.BackColor = System.Drawing.SystemColors.Control
        Me.IO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.IO.FlatAppearance.BorderSize = 0
        Me.IO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.IO.Image = Global.Password_Manager_1._1.My.Resources.Resources.IO
        Me.IO.Location = New System.Drawing.Point(515, 316)
        Me.IO.Name = "IO"
        Me.IO.Size = New System.Drawing.Size(45, 28)
        Me.IO.TabIndex = 34
        Me.IO.UseVisualStyleBackColor = False
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.Color.Transparent
        Me.backbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.backbtn.FlatAppearance.BorderSize = 0
        Me.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbtn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.backbtn.Image = Global.Password_Manager_1._1.My.Resources.Resources.Back1
        Me.backbtn.Location = New System.Drawing.Point(12, 27)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(67, 31)
        Me.backbtn.TabIndex = 30
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(56, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 29)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Site     "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Password_Manager_1._1.My.Resources.Resources.Allsafe4
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(94, -114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(426, 349)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'IC
        '
        Me.IC.BackColor = System.Drawing.SystemColors.Control
        Me.IC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.IC.FlatAppearance.BorderSize = 0
        Me.IC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IC.ForeColor = System.Drawing.SystemColors.Control
        Me.IC.Image = Global.Password_Manager_1._1.My.Resources.Resources.IC
        Me.IC.Location = New System.Drawing.Point(515, 316)
        Me.IC.Name = "IC"
        Me.IC.Size = New System.Drawing.Size(45, 28)
        Me.IC.TabIndex = 35
        Me.IC.UseVisualStyleBackColor = False
        '
        'TextBoxpass
        '
        Me.TextBoxpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxpass.Location = New System.Drawing.Point(218, 316)
        Me.TextBoxpass.Name = "TextBoxpass"
        Me.TextBoxpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxpass.ReadOnly = True
        Me.TextBoxpass.Size = New System.Drawing.Size(342, 28)
        Me.TextBoxpass.TabIndex = 33
        '
        'Bin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 511)
        Me.Controls.Add(Me.datapnl)
        Me.Controls.Add(Me.btnpnl)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Bin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deleted Passwords"
        Me.btnpnl.ResumeLayout(False)
        Me.datapnl.ResumeLayout(False)
        Me.datapnl.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnpnl As Panel
    Friend WithEvents BtnDelA As Button
    Friend WithEvents BtnDel As Button
    Friend WithEvents BtnRestore As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxLink As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxSite As TextBox
    Friend WithEvents datapnl As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents backbtn As Button
    Friend WithEvents TextBoxpass As TextBox
    Friend WithEvents IO As Button
    Friend WithEvents IC As Button
End Class
