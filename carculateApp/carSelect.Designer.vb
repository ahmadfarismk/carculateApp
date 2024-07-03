<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(carSelect))
        Me.pctCar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblCC = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.TextBox()
        Me.lblCompPay = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.radBut10 = New System.Windows.Forms.RadioButton()
        Me.radBut20 = New System.Windows.Forms.RadioButton()
        Me.radBut30 = New System.Windows.Forms.RadioButton()
        Me.carName = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pnlPer = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pctCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlPer.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctCar
        '
        Me.pctCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctCar.Location = New System.Drawing.Point(231, 91)
        Me.pctCar.Name = "pctCar"
        Me.pctCar.Size = New System.Drawing.Size(100, 77)
        Me.pctCar.TabIndex = 0
        Me.pctCar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Insurance Cost"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(213, 11)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(32, 18)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "Rm"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(213, 38)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(17, 18)
        Me.lblYear.TabIndex = 6
        Me.lblYear.Text = "Y"
        '
        'lblCC
        '
        Me.lblCC.AutoSize = True
        Me.lblCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCC.Location = New System.Drawing.Point(213, 74)
        Me.lblCC.Name = "lblCC"
        Me.lblCC.Size = New System.Drawing.Size(19, 18)
        Me.lblCC.TabIndex = 7
        Me.lblCC.Text = "C"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(213, 107)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(27, 18)
        Me.lblCost.TabIndex = 8
        Me.lblCost.Text = "Ins"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblPrice)
        Me.Panel1.Controls.Add(Me.lblCost)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblCC)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblYear)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(137, 229)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 136)
        Me.Panel1.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(165, 389)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(271, 18)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Enter percentage to deduct from salary :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(132, 477)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(324, 18)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Enter amount of year to complete the payment : "
        '
        'lblPercent
        '
        Me.lblPercent.Location = New System.Drawing.Point(158, 415)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(252, 20)
        Me.lblPercent.TabIndex = 12
        '
        'lblCompPay
        '
        Me.lblCompPay.Location = New System.Drawing.Point(159, 498)
        Me.lblCompPay.Name = "lblCompPay"
        Me.lblCompPay.Size = New System.Drawing.Size(251, 20)
        Me.lblCompPay.TabIndex = 13
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(238, 629)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 14
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
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
        'carName
        '
        Me.carName.AutoSize = True
        Me.carName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carName.Location = New System.Drawing.Point(264, 171)
        Me.carName.Name = "carName"
        Me.carName.Size = New System.Drawing.Size(35, 18)
        Me.carName.TabIndex = 18
        Me.carName.Text = "Car"
        Me.carName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(165, 555)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(238, 18)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Choose downpayment percentage "
        '
        'pnlPer
        '
        Me.pnlPer.Controls.Add(Me.radBut30)
        Me.pnlPer.Controls.Add(Me.radBut20)
        Me.pnlPer.Controls.Add(Me.radBut10)
        Me.pnlPer.Location = New System.Drawing.Point(135, 581)
        Me.pnlPer.Name = "pnlPer"
        Me.pnlPer.Size = New System.Drawing.Size(297, 31)
        Me.pnlPer.TabIndex = 0
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
        Me.PictureBox1.Size = New System.Drawing.Size(594, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'carSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 714)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlPer)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.carName)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblCompPay)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pctCar)
        Me.Name = "carSelect"
        Me.Text = "carSelect"
        CType(Me.pctCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlPer.ResumeLayout(False)
        Me.pnlPer.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctCar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblCC As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPercent As TextBox
    Friend WithEvents lblCompPay As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents radBut10 As RadioButton
    Friend WithEvents radBut20 As RadioButton
    Friend WithEvents radBut30 As RadioButton
    Friend WithEvents carName As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents pnlPer As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
