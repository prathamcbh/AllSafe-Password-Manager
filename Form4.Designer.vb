<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.btnpnl = New System.Windows.Forms.Panel()
        Me.btnset = New System.Windows.Forms.Button()
        Me.binbtn = New System.Windows.Forms.Button()
        Me.btnlck = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.datapnl = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cpyu = New System.Windows.Forms.Button()
        Me.Cpypw = New System.Windows.Forms.Button()
        Me.lnkgen = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btndel = New System.Windows.Forms.Button()
        Me.TextBoxsite = New System.Windows.Forms.TextBox()
        Me.oplnk = New System.Windows.Forms.LinkLabel()
        Me.BtnUpd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxlink = New System.Windows.Forms.TextBox()
        Me.TextBoxuname = New System.Windows.Forms.TextBox()
        Me.IO = New System.Windows.Forms.Button()
        Me.IC = New System.Windows.Forms.Button()
        Me.TextBoxpass = New System.Windows.Forms.TextBox()
        Me.btnpnl.SuspendLayout()
        Me.datapnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnpnl
        '
        Me.btnpnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnpnl.Controls.Add(Me.btnset)
        Me.btnpnl.Controls.Add(Me.binbtn)
        Me.btnpnl.Controls.Add(Me.btnlck)
        Me.btnpnl.Controls.Add(Me.addbtn)
        Me.btnpnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnpnl.Location = New System.Drawing.Point(0, 393)
        Me.btnpnl.Name = "btnpnl"
        Me.btnpnl.Size = New System.Drawing.Size(805, 66)
        Me.btnpnl.TabIndex = 0
        '
        'btnset
        '
        Me.btnset.BackColor = System.Drawing.Color.Transparent
        Me.btnset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnset.FlatAppearance.BorderSize = 0
        Me.btnset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnset.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnset.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnset.Image = Global.Password_Manager_1._1.My.Resources.Resources.Settings
        Me.btnset.Location = New System.Drawing.Point(611, 14)
        Me.btnset.Name = "btnset"
        Me.btnset.Size = New System.Drawing.Size(165, 39)
        Me.btnset.TabIndex = 2
        Me.btnset.UseVisualStyleBackColor = False
        '
        'binbtn
        '
        Me.binbtn.BackColor = System.Drawing.Color.Transparent
        Me.binbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.binbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.binbtn.FlatAppearance.BorderSize = 0
        Me.binbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.binbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.binbtn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.binbtn.Image = CType(resources.GetObject("binbtn.Image"), System.Drawing.Image)
        Me.binbtn.Location = New System.Drawing.Point(417, 13)
        Me.binbtn.Name = "binbtn"
        Me.binbtn.Size = New System.Drawing.Size(177, 41)
        Me.binbtn.TabIndex = 1
        Me.binbtn.UseVisualStyleBackColor = False
        '
        'btnlck
        '
        Me.btnlck.BackColor = System.Drawing.Color.Transparent
        Me.btnlck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnlck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btnlck.FlatAppearance.BorderSize = 0
        Me.btnlck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlck.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlck.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnlck.Image = Global.Password_Manager_1._1.My.Resources.Resources.Lock
        Me.btnlck.Location = New System.Drawing.Point(223, 15)
        Me.btnlck.Name = "btnlck"
        Me.btnlck.Size = New System.Drawing.Size(165, 39)
        Me.btnlck.TabIndex = 1
        Me.btnlck.UseVisualStyleBackColor = False
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.Transparent
        Me.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.addbtn.FlatAppearance.BorderSize = 0
        Me.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.addbtn.Location = New System.Drawing.Point(29, 13)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(165, 39)
        Me.addbtn.TabIndex = 0
        Me.addbtn.Text = "+"
        Me.addbtn.UseVisualStyleBackColor = False
        '
        'datapnl
        '
        Me.datapnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.datapnl.Controls.Add(Me.ComboBox1)
        Me.datapnl.Controls.Add(Me.cpyu)
        Me.datapnl.Controls.Add(Me.Cpypw)
        Me.datapnl.Controls.Add(Me.lnkgen)
        Me.datapnl.Controls.Add(Me.Label5)
        Me.datapnl.Controls.Add(Me.btndel)
        Me.datapnl.Controls.Add(Me.TextBoxsite)
        Me.datapnl.Controls.Add(Me.oplnk)
        Me.datapnl.Controls.Add(Me.BtnUpd)
        Me.datapnl.Controls.Add(Me.Label2)
        Me.datapnl.Controls.Add(Me.Label3)
        Me.datapnl.Controls.Add(Me.Label1)
        Me.datapnl.Controls.Add(Me.TextBoxlink)
        Me.datapnl.Controls.Add(Me.TextBoxuname)
        Me.datapnl.Controls.Add(Me.IO)
        Me.datapnl.Controls.Add(Me.IC)
        Me.datapnl.Controls.Add(Me.TextBoxpass)
        Me.datapnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datapnl.Location = New System.Drawing.Point(0, 0)
        Me.datapnl.Name = "datapnl"
        Me.datapnl.Size = New System.Drawing.Size(805, 393)
        Me.datapnl.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9), "Amazon", "Flipkart", "Google", "Microsoft"})
        Me.ComboBox1.Location = New System.Drawing.Point(176, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(453, 24)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 29
        '
        'cpyu
        '
        Me.cpyu.BackColor = System.Drawing.Color.Transparent
        Me.cpyu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cpyu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.cpyu.FlatAppearance.BorderSize = 0
        Me.cpyu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cpyu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpyu.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cpyu.Image = Global.Password_Manager_1._1.My.Resources.Resources.Copy1
        Me.cpyu.Location = New System.Drawing.Point(628, 141)
        Me.cpyu.Name = "cpyu"
        Me.cpyu.Size = New System.Drawing.Size(58, 37)
        Me.cpyu.TabIndex = 28
        Me.cpyu.UseVisualStyleBackColor = False
        '
        'Cpypw
        '
        Me.Cpypw.BackColor = System.Drawing.Color.Transparent
        Me.Cpypw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Cpypw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Cpypw.FlatAppearance.BorderSize = 0
        Me.Cpypw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cpypw.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cpypw.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Cpypw.Image = Global.Password_Manager_1._1.My.Resources.Resources.Copy1
        Me.Cpypw.Location = New System.Drawing.Point(628, 204)
        Me.Cpypw.Name = "Cpypw"
        Me.Cpypw.Size = New System.Drawing.Size(58, 37)
        Me.Cpypw.TabIndex = 3
        Me.Cpypw.UseVisualStyleBackColor = False
        '
        'lnkgen
        '
        Me.lnkgen.AutoSize = True
        Me.lnkgen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkgen.LinkColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lnkgen.Location = New System.Drawing.Point(539, 239)
        Me.lnkgen.Name = "lnkgen"
        Me.lnkgen.Size = New System.Drawing.Size(77, 18)
        Me.lnkgen.TabIndex = 25
        Me.lnkgen.TabStop = True
        Me.lnkgen.Text = "Generate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(61, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 29)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Site     "
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.Transparent
        Me.btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btndel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btndel.Location = New System.Drawing.Point(557, 335)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(219, 39)
        Me.btndel.TabIndex = 1
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'TextBoxsite
        '
        Me.TextBoxsite.BackColor = System.Drawing.Color.White
        Me.TextBoxsite.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxsite.Location = New System.Drawing.Point(222, 88)
        Me.TextBoxsite.Name = "TextBoxsite"
        Me.TextBoxsite.ReadOnly = True
        Me.TextBoxsite.Size = New System.Drawing.Size(395, 28)
        Me.TextBoxsite.TabIndex = 21
        '
        'oplnk
        '
        Me.oplnk.AutoSize = True
        Me.oplnk.BackColor = System.Drawing.Color.Transparent
        Me.oplnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oplnk.LinkColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.oplnk.Location = New System.Drawing.Point(644, 266)
        Me.oplnk.Name = "oplnk"
        Me.oplnk.Size = New System.Drawing.Size(132, 29)
        Me.oplnk.TabIndex = 20
        Me.oplnk.TabStop = True
        Me.oplnk.Text = "Open Link"
        '
        'BtnUpd
        '
        Me.BtnUpd.BackColor = System.Drawing.Color.Transparent
        Me.BtnUpd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnUpd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BtnUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpd.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnUpd.Image = Global.Password_Manager_1._1.My.Resources.Resources.update
        Me.BtnUpd.Location = New System.Drawing.Point(29, 335)
        Me.BtnUpd.Name = "BtnUpd"
        Me.BtnUpd.Size = New System.Drawing.Size(522, 39)
        Me.BtnUpd.TabIndex = 3
        Me.BtnUpd.Text = "Update"
        Me.BtnUpd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnUpd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(60, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 29)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(62, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 29)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Link     "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(60, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 29)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Username"
        '
        'TextBoxlink
        '
        Me.TextBoxlink.BackColor = System.Drawing.Color.White
        Me.TextBoxlink.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxlink.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxlink.Location = New System.Drawing.Point(221, 267)
        Me.TextBoxlink.Name = "TextBoxlink"
        Me.TextBoxlink.Size = New System.Drawing.Size(395, 28)
        Me.TextBoxlink.TabIndex = 15
        '
        'TextBoxuname
        '
        Me.TextBoxuname.BackColor = System.Drawing.Color.White
        Me.TextBoxuname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxuname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxuname.Location = New System.Drawing.Point(221, 147)
        Me.TextBoxuname.Name = "TextBoxuname"
        Me.TextBoxuname.Size = New System.Drawing.Size(395, 28)
        Me.TextBoxuname.TabIndex = 15
        '
        'IO
        '
        Me.IO.BackColor = System.Drawing.Color.White
        Me.IO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.IO.FlatAppearance.BorderSize = 0
        Me.IO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.IO.Image = Global.Password_Manager_1._1.My.Resources.Resources.IO
        Me.IO.Location = New System.Drawing.Point(571, 207)
        Me.IO.Name = "IO"
        Me.IO.Size = New System.Drawing.Size(45, 28)
        Me.IO.TabIndex = 3
        Me.IO.UseVisualStyleBackColor = False
        '
        'IC
        '
        Me.IC.BackColor = System.Drawing.Color.White
        Me.IC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.IC.FlatAppearance.BorderSize = 0
        Me.IC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IC.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.IC.Image = Global.Password_Manager_1._1.My.Resources.Resources.IC
        Me.IC.Location = New System.Drawing.Point(571, 207)
        Me.IC.Name = "IC"
        Me.IC.Size = New System.Drawing.Size(45, 28)
        Me.IC.TabIndex = 27
        Me.IC.UseVisualStyleBackColor = False
        '
        'TextBoxpass
        '
        Me.TextBoxpass.BackColor = System.Drawing.Color.White
        Me.TextBoxpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxpass.Location = New System.Drawing.Point(221, 207)
        Me.TextBoxpass.Name = "TextBoxpass"
        Me.TextBoxpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxpass.Size = New System.Drawing.Size(395, 28)
        Me.TextBoxpass.TabIndex = 17
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(805, 459)
        Me.Controls.Add(Me.datapnl)
        Me.Controls.Add(Me.btnpnl)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AllSafe-Dashboard"
        Me.btnpnl.ResumeLayout(False)
        Me.datapnl.ResumeLayout(False)
        Me.datapnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnpnl As Panel
    Friend WithEvents addbtn As Button
    Friend WithEvents datapnl As Panel
    Friend WithEvents btnlck As Button
    Friend WithEvents btnset As Button
    Friend WithEvents oplnk As LinkLabel
    Friend WithEvents BtnUpd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxlink As TextBox
    Friend WithEvents TextBoxuname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxsite As TextBox
    Friend WithEvents binbtn As Button
    Friend WithEvents btndel As Button
    Friend WithEvents lnkgen As LinkLabel
    Friend WithEvents IO As Button
    Friend WithEvents IC As Button
    Friend WithEvents Cpypw As Button
    Friend WithEvents cpyu As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
