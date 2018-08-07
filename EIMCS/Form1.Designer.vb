<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.btncancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnlogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtid = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.btncancel)
        Me.BunifuCards1.Controls.Add(Me.btnlogin)
        Me.BunifuCards1.Controls.Add(Me.PictureBox1)
        Me.BunifuCards1.Controls.Add(Me.Label2)
        Me.BunifuCards1.Controls.Add(Me.Label1)
        Me.BunifuCards1.Controls.Add(Me.txtpass)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuCards1.Controls.Add(Me.txtid)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(7, 10)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(437, 521)
        Me.BunifuCards1.TabIndex = 1
        '
        'btncancel
        '
        Me.btncancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.BorderRadius = 0
        Me.btncancel.ButtonText = "Cancel"
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.DisabledColor = System.Drawing.Color.Gray
        Me.btncancel.Iconcolor = System.Drawing.Color.Transparent
        Me.btncancel.Iconimage = CType(resources.GetObject("btncancel.Iconimage"), System.Drawing.Image)
        Me.btncancel.Iconimage_right = Nothing
        Me.btncancel.Iconimage_right_Selected = Nothing
        Me.btncancel.Iconimage_Selected = Nothing
        Me.btncancel.IconMarginLeft = 0
        Me.btncancel.IconMarginRight = 0
        Me.btncancel.IconRightVisible = True
        Me.btncancel.IconRightZoom = 0.0R
        Me.btncancel.IconVisible = True
        Me.btncancel.IconZoom = 90.0R
        Me.btncancel.IsTab = False
        Me.btncancel.Location = New System.Drawing.Point(219, 337)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btncancel.OnHovercolor = System.Drawing.Color.Green
        Me.btncancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btncancel.selected = False
        Me.btncancel.Size = New System.Drawing.Size(124, 38)
        Me.btncancel.TabIndex = 36
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Textcolor = System.Drawing.Color.White
        Me.btncancel.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnlogin
        '
        Me.btnlogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlogin.BorderRadius = 0
        Me.btnlogin.ButtonText = "Login"
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.DisabledColor = System.Drawing.Color.Gray
        Me.btnlogin.Iconcolor = System.Drawing.Color.Transparent
        Me.btnlogin.Iconimage = CType(resources.GetObject("btnlogin.Iconimage"), System.Drawing.Image)
        Me.btnlogin.Iconimage_right = Nothing
        Me.btnlogin.Iconimage_right_Selected = Nothing
        Me.btnlogin.Iconimage_Selected = Nothing
        Me.btnlogin.IconMarginLeft = 0
        Me.btnlogin.IconMarginRight = 0
        Me.btnlogin.IconRightVisible = True
        Me.btnlogin.IconRightZoom = 0.0R
        Me.btnlogin.IconVisible = True
        Me.btnlogin.IconZoom = 90.0R
        Me.btnlogin.IsTab = False
        Me.btnlogin.Location = New System.Drawing.Point(81, 337)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlogin.OnHovercolor = System.Drawing.Color.Green
        Me.btnlogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btnlogin.selected = False
        Me.btnlogin.Size = New System.Drawing.Size(124, 38)
        Me.btnlogin.TabIndex = 35
        Me.btnlogin.Text = "Login"
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogin.Textcolor = System.Drawing.Color.White
        Me.btnlogin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EIMCS.My.Resources.Resources.LOGInN
        Me.PictureBox1.Location = New System.Drawing.Point(148, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(66, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(66, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "*"
        '
        'txtpass
        '
        Me.txtpass.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtpass.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpass.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtpass.BorderThickness = 3
        Me.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpass.isPassword = True
        Me.txtpass.Location = New System.Drawing.Point(81, 281)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(262, 31)
        Me.txtpass.TabIndex = 31
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(82, 262)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(69, 17)
        Me.BunifuCustomLabel2.TabIndex = 30
        Me.BunifuCustomLabel2.Text = "Password"
        '
        'txtid
        '
        Me.txtid.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtid.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtid.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtid.BorderThickness = 3
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtid.isPassword = False
        Me.txtid.Location = New System.Drawing.Point(81, 218)
        Me.txtid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(262, 31)
        Me.txtid.TabIndex = 29
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(82, 197)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(71, 17)
        Me.BunifuCustomLabel1.TabIndex = 28
        Me.BunifuCustomLabel1.Text = "Username"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(449, 535)
        Me.Controls.Add(Me.BunifuCards1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btncancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnlogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtid As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel

End Class
