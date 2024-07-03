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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlPer = New System.Windows.Forms.Panel()
        Me.radBut30 = New System.Windows.Forms.RadioButton()
        Me.radBut20 = New System.Windows.Forms.RadioButton()
        Me.radBut10 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblCompPay = New System.Windows.Forms.TextBox()
        Me.lblPercent = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPer.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(669, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'pnlPer
        '
        Me.pnlPer.Controls.Add(Me.radBut30)
        Me.pnlPer.Controls.Add(Me.radBut20)
        Me.pnlPer.Controls.Add(Me.radBut10)
        Me.pnlPer.Location = New System.Drawing.Point(195, 464)
        Me.pnlPer.Name = "pnlPer"
        Me.pnlPer.Size = New System.Drawing.Size(297, 31)
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
        Me.Label11.Location = New System.Drawing.Point(225, 438)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(238, 18)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Choose downpayment percentage "
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnEnter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEnter.Location = New System.Drawing.Point(274, 549)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(110, 35)
        Me.btnEnter.TabIndex = 25
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'lblCompPay
        '
        Me.lblCompPay.Location = New System.Drawing.Point(219, 397)
        Me.lblCompPay.Name = "lblCompPay"
        Me.lblCompPay.Size = New System.Drawing.Size(251, 20)
        Me.lblCompPay.TabIndex = 24
        '
        'lblPercent
        '
        Me.lblPercent.Location = New System.Drawing.Point(211, 328)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(252, 20)
        Me.lblPercent.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(192, 365)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(324, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Enter amount of year to complete the payment : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(208, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(271, 18)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Enter percentage to deduct from salary :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(274, 185)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 20)
        Me.TextBox1.TabIndex = 28
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(274, 221)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(252, 20)
        Me.TextBox2.TabIndex = 30
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(274, 259)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(252, 20)
        Me.TextBox3.TabIndex = 32
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
        Me.Panel1.Location = New System.Drawing.Point(130, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 370)
        Me.Panel1.TabIndex = 34
        '
        'InputCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 617)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlPer)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblCompPay)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "InputCar"
        Me.Text = "InputCar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPer.ResumeLayout(False)
        Me.pnlPer.PerformLayout()
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
    Friend WithEvents lblCompPay As TextBox
    Friend WithEvents lblPercent As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
End Class
