<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnpass = New System.Windows.Forms.Button()
        Me.Btnbkpstr = New System.Windows.Forms.Button()
        Me.PanelBkpstr = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Textboxbkpstr = New System.Windows.Forms.TextBox()
        Me.BtnChgbkpstr = New System.Windows.Forms.Button()
        Me.BtnSavebkpstr = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panelpass = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCurrentPass = New System.Windows.Forms.TextBox()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNP = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.PanelBkpstr.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelpass.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnpass)
        Me.Panel1.Controls.Add(Me.Btnbkpstr)
        Me.Panel1.Location = New System.Drawing.Point(0, 361)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 85)
        Me.Panel1.TabIndex = 5
        '
        'btnpass
        '
        Me.btnpass.BackColor = System.Drawing.Color.Transparent
        Me.btnpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnpass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnpass.FlatAppearance.BorderSize = 0
        Me.btnpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpass.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnpass.Location = New System.Drawing.Point(297, 11)
        Me.btnpass.Name = "btnpass"
        Me.btnpass.Size = New System.Drawing.Size(264, 39)
        Me.btnpass.TabIndex = 2
        Me.btnpass.Text = "Change password"
        Me.btnpass.UseVisualStyleBackColor = False
        '
        'Btnbkpstr
        '
        Me.Btnbkpstr.BackColor = System.Drawing.Color.Transparent
        Me.Btnbkpstr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btnbkpstr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Btnbkpstr.FlatAppearance.BorderSize = 0
        Me.Btnbkpstr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnbkpstr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbkpstr.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Btnbkpstr.Location = New System.Drawing.Point(13, 11)
        Me.Btnbkpstr.Name = "Btnbkpstr"
        Me.Btnbkpstr.Size = New System.Drawing.Size(264, 39)
        Me.Btnbkpstr.TabIndex = 3
        Me.Btnbkpstr.Text = "Change Recovery Key"
        Me.Btnbkpstr.UseVisualStyleBackColor = False
        '
        'PanelBkpstr
        '
        Me.PanelBkpstr.Controls.Add(Me.Button1)
        Me.PanelBkpstr.Controls.Add(Me.Textboxbkpstr)
        Me.PanelBkpstr.Controls.Add(Me.BtnChgbkpstr)
        Me.PanelBkpstr.Controls.Add(Me.BtnSavebkpstr)
        Me.PanelBkpstr.Controls.Add(Me.PictureBox1)
        Me.PanelBkpstr.Location = New System.Drawing.Point(0, 1)
        Me.PanelBkpstr.Name = "PanelBkpstr"
        Me.PanelBkpstr.Size = New System.Drawing.Size(574, 354)
        Me.PanelBkpstr.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Image = Global.Password_Manager_1._1.My.Resources.Resources.Back1
        Me.Button1.Location = New System.Drawing.Point(18, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 31)
        Me.Button1.TabIndex = 33
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Textboxbkpstr
        '
        Me.Textboxbkpstr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Textboxbkpstr.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textboxbkpstr.Location = New System.Drawing.Point(59, 191)
        Me.Textboxbkpstr.Name = "Textboxbkpstr"
        Me.Textboxbkpstr.ReadOnly = True
        Me.Textboxbkpstr.Size = New System.Drawing.Size(457, 28)
        Me.Textboxbkpstr.TabIndex = 6
        '
        'BtnChgbkpstr
        '
        Me.BtnChgbkpstr.BackColor = System.Drawing.Color.Transparent
        Me.BtnChgbkpstr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnChgbkpstr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BtnChgbkpstr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChgbkpstr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChgbkpstr.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnChgbkpstr.Location = New System.Drawing.Point(36, 278)
        Me.BtnChgbkpstr.Name = "BtnChgbkpstr"
        Me.BtnChgbkpstr.Size = New System.Drawing.Size(241, 39)
        Me.BtnChgbkpstr.TabIndex = 5
        Me.BtnChgbkpstr.Text = "Change Key"
        Me.BtnChgbkpstr.UseVisualStyleBackColor = False
        '
        'BtnSavebkpstr
        '
        Me.BtnSavebkpstr.BackColor = System.Drawing.Color.Transparent
        Me.BtnSavebkpstr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSavebkpstr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BtnSavebkpstr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSavebkpstr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavebkpstr.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnSavebkpstr.Location = New System.Drawing.Point(293, 278)
        Me.BtnSavebkpstr.Name = "BtnSavebkpstr"
        Me.BtnSavebkpstr.Size = New System.Drawing.Size(241, 39)
        Me.BtnSavebkpstr.TabIndex = 7
        Me.BtnSavebkpstr.Text = "Save"
        Me.BtnSavebkpstr.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Password_Manager_1._1.My.Resources.Resources.Allsafe4
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(59, -124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(457, 403)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Panelpass
        '
        Me.Panelpass.Controls.Add(Me.Label4)
        Me.Panelpass.Controls.Add(Me.btnsave)
        Me.Panelpass.Controls.Add(Me.Label3)
        Me.Panelpass.Controls.Add(Me.TextBoxCurrentPass)
        Me.Panelpass.Controls.Add(Me.backbtn)
        Me.Panelpass.Controls.Add(Me.Label2)
        Me.Panelpass.Controls.Add(Me.TextBoxCP)
        Me.Panelpass.Controls.Add(Me.Label1)
        Me.Panelpass.Controls.Add(Me.TextBoxNP)
        Me.Panelpass.Location = New System.Drawing.Point(0, 1)
        Me.Panelpass.Name = "Panelpass"
        Me.Panelpass.Size = New System.Drawing.Size(574, 354)
        Me.Panelpass.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(116, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(348, 31)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Change Master Password"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnsave.Location = New System.Drawing.Point(77, 302)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(422, 39)
        Me.btnsave.TabIndex = 35
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(21, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 29)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Current Password"
        '
        'TextBoxCurrentPass
        '
        Me.TextBoxCurrentPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCurrentPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCurrentPass.Location = New System.Drawing.Point(270, 114)
        Me.TextBoxCurrentPass.Name = "TextBoxCurrentPass"
        Me.TextBoxCurrentPass.Size = New System.Drawing.Size(276, 28)
        Me.TextBoxCurrentPass.TabIndex = 33
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
        Me.backbtn.Location = New System.Drawing.Point(18, 35)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(67, 31)
        Me.backbtn.TabIndex = 32
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(21, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 29)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Confirm Password"
        '
        'TextBoxCP
        '
        Me.TextBoxCP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCP.Location = New System.Drawing.Point(270, 231)
        Me.TextBoxCP.Name = "TextBoxCP"
        Me.TextBoxCP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxCP.Size = New System.Drawing.Size(276, 28)
        Me.TextBoxCP.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(21, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 29)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "New Password"
        '
        'TextBoxNP
        '
        Me.TextBoxNP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNP.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNP.Location = New System.Drawing.Point(270, 172)
        Me.TextBoxNP.Name = "TextBoxNP"
        Me.TextBoxNP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxNP.Size = New System.Drawing.Size(276, 28)
        Me.TextBoxNP.TabIndex = 28
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(574, 427)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelBkpstr)
        Me.Controls.Add(Me.Panelpass)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.Panel1.ResumeLayout(False)
        Me.PanelBkpstr.ResumeLayout(False)
        Me.PanelBkpstr.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelpass.ResumeLayout(False)
        Me.Panelpass.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btnbkpstr As Button
    Friend WithEvents btnpass As Button
    Friend WithEvents PanelBkpstr As Panel
    Friend WithEvents Textboxbkpstr As TextBox
    Friend WithEvents BtnChgbkpstr As Button
    Friend WithEvents BtnSavebkpstr As Button
    Friend WithEvents Panelpass As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCurrentPass As TextBox
    Friend WithEvents backbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNP As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
