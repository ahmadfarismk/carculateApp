<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class history
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(history))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarculatedbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarculatedbDataSet = New carculateApp.carculatedbDataSet()
        Me.HistoryTableAdapter = New carculateApp.carculatedbDataSetTableAdapters.historyTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarculatedbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarculatedbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(256, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 26)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Your order history"
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
        Me.PictureBox1.Size = New System.Drawing.Size(785, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'HistoryBindingSource
        '
        Me.HistoryBindingSource.DataMember = "history"
        Me.HistoryBindingSource.DataSource = Me.CarculatedbDataSetBindingSource
        '
        'CarculatedbDataSetBindingSource
        '
        Me.CarculatedbDataSetBindingSource.DataSource = Me.CarculatedbDataSet
        Me.CarculatedbDataSetBindingSource.Position = 0
        '
        'CarculatedbDataSet
        '
        Me.CarculatedbDataSet.DataSetName = "carculatedbDataSet"
        Me.CarculatedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistoryTableAdapter
        '
        Me.HistoryTableAdapter.ClearBeforeFill = True
        '
        'history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 540)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "history"
        Me.Text = "history"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarculatedbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarculatedbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CarculatedbDataSetBindingSource As BindingSource
    Friend WithEvents CarculatedbDataSet As carculatedbDataSet
    Friend WithEvents HistoryBindingSource As BindingSource
    Friend WithEvents HistoryTableAdapter As carculatedbDataSetTableAdapters.historyTableAdapter
End Class
