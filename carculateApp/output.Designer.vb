<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class output
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(output))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCarName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblYearExp = New System.Windows.Forms.Label()
        Me.lblTotYear = New System.Windows.Forms.Label()
        Me.lblInstallment = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblMonthPay = New System.Windows.Forms.Label()
        Me.lblDown = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me._carculatedb_1__1_DataSet1 = New carculateApp._carculatedb_1__1_DataSet1()
        Me.CarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarTableAdapter = New carculateApp._carculatedb_1__1_DataSet1TableAdapters.carTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me._carculatedb_1__1_DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(660, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Estimation cost to own"
        '
        'lblCarName
        '
        Me.lblCarName.AutoSize = True
        Me.lblCarName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarName.Location = New System.Drawing.Point(295, 139)
        Me.lblCarName.Name = "lblCarName"
        Me.lblCarName.Size = New System.Drawing.Size(89, 18)
        Me.lblCarName.TabIndex = 2
        Me.lblCarName.Text = "Car  Name"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblSalary)
        Me.Panel1.Controls.Add(Me.lblMonthPay)
        Me.Panel1.Controls.Add(Me.lblDown)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblTotYear)
        Me.Panel1.Controls.Add(Me.lblInstallment)
        Me.Panel1.Controls.Add(Me.lblYearExp)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(194, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 157)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Downpayment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Yearly installment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Yearly expenses"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total yearly"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Monthly payment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Minimum salary own"
        '
        'lblYearExp
        '
        Me.lblYearExp.AutoSize = True
        Me.lblYearExp.Location = New System.Drawing.Point(154, 62)
        Me.lblYearExp.Name = "lblYearExp"
        Me.lblYearExp.Size = New System.Drawing.Size(39, 13)
        Me.lblYearExp.TabIndex = 10
        Me.lblYearExp.Text = "Label8"
        '
        'lblTotYear
        '
        Me.lblTotYear.AutoSize = True
        Me.lblTotYear.Location = New System.Drawing.Point(154, 84)
        Me.lblTotYear.Name = "lblTotYear"
        Me.lblTotYear.Size = New System.Drawing.Size(39, 13)
        Me.lblTotYear.TabIndex = 11
        Me.lblTotYear.Text = "Label9"
        '
        'lblInstallment
        '
        Me.lblInstallment.AutoSize = True
        Me.lblInstallment.Location = New System.Drawing.Point(154, 39)
        Me.lblInstallment.Name = "lblInstallment"
        Me.lblInstallment.Size = New System.Drawing.Size(45, 13)
        Me.lblInstallment.TabIndex = 12
        Me.lblInstallment.Text = "Label10"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(154, 129)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(45, 13)
        Me.lblSalary.TabIndex = 13
        Me.lblSalary.Text = "Label11"
        '
        'lblMonthPay
        '
        Me.lblMonthPay.AutoSize = True
        Me.lblMonthPay.Location = New System.Drawing.Point(154, 105)
        Me.lblMonthPay.Name = "lblMonthPay"
        Me.lblMonthPay.Size = New System.Drawing.Size(45, 13)
        Me.lblMonthPay.TabIndex = 14
        Me.lblMonthPay.Text = "Label12"
        '
        'lblDown
        '
        Me.lblDown.AutoSize = True
        Me.lblDown.Location = New System.Drawing.Point(154, 18)
        Me.lblDown.Name = "lblDown"
        Me.lblDown.Size = New System.Drawing.Size(45, 13)
        Me.lblDown.TabIndex = 15
        Me.lblDown.Text = "Label13"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(288, 329)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        '_carculatedb_1__1_DataSet1
        '
        Me._carculatedb_1__1_DataSet1.DataSetName = "_carculatedb_1__1_DataSet1"
        Me._carculatedb_1__1_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CarBindingSource
        '
        Me.CarBindingSource.DataMember = "car"
        Me.CarBindingSource.DataSource = Me._carculatedb_1__1_DataSet1
        '
        'CarTableAdapter
        '
        Me.CarTableAdapter.ClearBeforeFill = True
        '
        'output
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 373)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblCarName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "output"
        Me.Text = "output"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._carculatedb_1__1_DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCarName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblMonthPay As Label
    Friend WithEvents lblDown As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotYear As Label
    Friend WithEvents lblInstallment As Label
    Friend WithEvents lblYearExp As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents _carculatedb_1__1_DataSet1 As _carculatedb_1__1_DataSet1
    Friend WithEvents CarBindingSource As BindingSource
    Friend WithEvents CarTableAdapter As _carculatedb_1__1_DataSet1TableAdapters.carTableAdapter
End Class
