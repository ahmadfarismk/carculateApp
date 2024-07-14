<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputCar))
        Me.pnlPer = New System.Windows.Forms.Panel()
        Me.radBut30 = New System.Windows.Forms.RadioButton()
        Me.radBut20 = New System.Windows.Forms.RadioButton()
        Me.radBut10 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtCarPercentage = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCarName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCarPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCarCC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCarYear = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInsurance = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbousUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YourHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlPer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPer
        '
        Me.pnlPer.Controls.Add(Me.radBut30)
        Me.pnlPer.Controls.Add(Me.radBut20)
        Me.pnlPer.Controls.Add(Me.radBut10)
        Me.pnlPer.Location = New System.Drawing.Point(64, 392)
        Me.pnlPer.Name = "pnlPer"
        Me.pnlPer.Size = New System.Drawing.Size(297, 35)
        Me.pnlPer.TabIndex = 20
        '
        'radBut30
        '
        Me.radBut30.AutoSize = True
        Me.radBut30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBut30.Location = New System.Drawing.Point(199, 3)
        Me.radBut30.Name = "radBut30"
        Me.radBut30.Size = New System.Drawing.Size(48, 17)
        Me.radBut30.TabIndex = 17
        Me.radBut30.TabStop = True
        Me.radBut30.Text = "30%"
        Me.radBut30.UseVisualStyleBackColor = True
        '
        'radBut20
        '
        Me.radBut20.AutoSize = True
        Me.radBut20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBut20.Location = New System.Drawing.Point(103, 3)
        Me.radBut20.Name = "radBut20"
        Me.radBut20.Size = New System.Drawing.Size(48, 17)
        Me.radBut20.TabIndex = 16
        Me.radBut20.TabStop = True
        Me.radBut20.Text = "20%"
        Me.radBut20.UseVisualStyleBackColor = True
        '
        'radBut10
        '
        Me.radBut10.AutoSize = True
        Me.radBut10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBut10.Location = New System.Drawing.Point(7, 3)
        Me.radBut10.Name = "radBut10"
        Me.radBut10.Size = New System.Drawing.Size(48, 17)
        Me.radBut10.TabIndex = 15
        Me.radBut10.TabStop = True
        Me.radBut10.Text = "10%"
        Me.radBut10.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(94, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(238, 18)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Choose downpayment percentage "
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnEnter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEnter.Location = New System.Drawing.Point(274, 613)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(110, 35)
        Me.btnEnter.TabIndex = 25
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(97, 325)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(251, 20)
        Me.txtYear.TabIndex = 24
        '
        'txtCarPercentage
        '
        Me.txtCarPercentage.Location = New System.Drawing.Point(96, 253)
        Me.txtCarPercentage.Name = "txtCarPercentage"
        Me.txtCarPercentage.Size = New System.Drawing.Size(252, 20)
        Me.txtCarPercentage.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(61, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(324, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Enter amount of year to complete the payment : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(77, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(271, 18)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Enter percentage to deduct from salary :"
        '
        'txtCarName
        '
        Me.txtCarName.Location = New System.Drawing.Point(274, 185)
        Me.txtCarName.Name = "txtCarName"
        Me.txtCarName.Size = New System.Drawing.Size(252, 20)
        Me.txtCarName.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Enter car name:"
        '
        'txtCarPrice
        '
        Me.txtCarPrice.Location = New System.Drawing.Point(274, 221)
        Me.txtCarPrice.Name = "txtCarPrice"
        Me.txtCarPrice.Size = New System.Drawing.Size(252, 20)
        Me.txtCarPrice.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Enter car price:"
        '
        'txtCarCC
        '
        Me.txtCarCC.Location = New System.Drawing.Point(274, 259)
        Me.txtCarCC.Name = "txtCarCC"
        Me.txtCarCC.Size = New System.Drawing.Size(252, 20)
        Me.txtCarCC.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(155, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Enter car cc:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(73, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(550, 26)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Let's calculate estimation for your dream car!"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCarYear)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtInsurance)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.pnlPer)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtYear)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtCarPercentage)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(130, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 448)
        Me.Panel1.TabIndex = 34
        '
        'txtCarYear
        '
        Me.txtCarYear.Location = New System.Drawing.Point(143, 174)
        Me.txtCarYear.Name = "txtCarYear"
        Me.txtCarYear.Size = New System.Drawing.Size(252, 20)
        Me.txtCarYear.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 18)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Enter year:"
        '
        'txtInsurance
        '
        Me.txtInsurance.Location = New System.Drawing.Point(143, 137)
        Me.txtInsurance.Name = "txtInsurance"
        Me.txtInsurance.Size = New System.Drawing.Size(252, 20)
        Me.txtInsurance.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 18)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Enter insurance:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(709, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainPageToolStripMenuItem, Me.AbousUsToolStripMenuItem, Me.YourHistoryToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'MainPageToolStripMenuItem
        '
        Me.MainPageToolStripMenuItem.Name = "MainPageToolStripMenuItem"
        Me.MainPageToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MainPageToolStripMenuItem.Text = "Main Page"
        '
        'AbousUsToolStripMenuItem
        '
        Me.AbousUsToolStripMenuItem.Name = "AbousUsToolStripMenuItem"
        Me.AbousUsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AbousUsToolStripMenuItem.Text = "Abous Us"
        '
        'YourHistoryToolStripMenuItem
        '
        Me.YourHistoryToolStripMenuItem.Name = "YourHistoryToolStripMenuItem"
        Me.YourHistoryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.YourHistoryToolStripMenuItem.Text = "Your History"
        '
        'InputCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 683)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCarCC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCarPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCarName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InputCar"
        Me.Text = "InputCar"
        Me.pnlPer.ResumeLayout(False)
        Me.pnlPer.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlPer As Panel
    Friend WithEvents radBut30 As RadioButton
    Friend WithEvents radBut20 As RadioButton
    Friend WithEvents radBut10 As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtCarPercentage As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCarName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCarPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCarCC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCarYear As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtInsurance As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbousUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YourHistoryToolStripMenuItem As ToolStripMenuItem
End Class
