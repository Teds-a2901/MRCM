<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Covid19ScreeningIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name19DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address19DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumber19DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VaccineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeOfVaccineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Question1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Question2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Question3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Question4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Question5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrivalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Covid19screnningBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._MRCM1_0DataSet2 = New MRCM._MRCM1_0DataSet2()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Covid19screnningTableAdapter = New MRCM._MRCM1_0DataSet2TableAdapters.covid19screnningTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Covid19screnningBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._MRCM1_0DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1450, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.MRCM.My.Resources.Resources.Home
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(91, 36)
        Me.ToolStripButton1.Text = "HOME"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.MRCM.My.Resources.Resources.add
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(153, 36)
        Me.ToolStripButton2.Text = "Add Screening"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.MRCM.My.Resources.Resources.log_out
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(112, 36)
        Me.ToolStripButton4.Text = "LOG-OUT"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Covid19ScreeningIDDataGridViewTextBoxColumn, Me.Name19DataGridViewTextBoxColumn, Me.Address19DataGridViewTextBoxColumn, Me.ContactNumber19DataGridViewTextBoxColumn, Me.VaccineDataGridViewTextBoxColumn, Me.TypeOfVaccineDataGridViewTextBoxColumn, Me.Question1DataGridViewTextBoxColumn, Me.Question2DataGridViewTextBoxColumn, Me.Question3DataGridViewTextBoxColumn, Me.Question4DataGridViewTextBoxColumn, Me.Question5DataGridViewTextBoxColumn, Me.ArrivalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Covid19screnningBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 137)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1426, 322)
        Me.DataGridView1.TabIndex = 1
        '
        'Covid19ScreeningIDDataGridViewTextBoxColumn
        '
        Me.Covid19ScreeningIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Covid19ScreeningIDDataGridViewTextBoxColumn.DataPropertyName = "Covid19ScreeningID"
        Me.Covid19ScreeningIDDataGridViewTextBoxColumn.HeaderText = "Covid19ScreeningID"
        Me.Covid19ScreeningIDDataGridViewTextBoxColumn.Name = "Covid19ScreeningIDDataGridViewTextBoxColumn"
        Me.Covid19ScreeningIDDataGridViewTextBoxColumn.Width = 162
        '
        'Name19DataGridViewTextBoxColumn
        '
        Me.Name19DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Name19DataGridViewTextBoxColumn.DataPropertyName = "Name_19"
        Me.Name19DataGridViewTextBoxColumn.HeaderText = "Name_19"
        Me.Name19DataGridViewTextBoxColumn.Name = "Name19DataGridViewTextBoxColumn"
        Me.Name19DataGridViewTextBoxColumn.Width = 94
        '
        'Address19DataGridViewTextBoxColumn
        '
        Me.Address19DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Address19DataGridViewTextBoxColumn.DataPropertyName = "Address_19"
        Me.Address19DataGridViewTextBoxColumn.HeaderText = "Address_19"
        Me.Address19DataGridViewTextBoxColumn.Name = "Address19DataGridViewTextBoxColumn"
        Me.Address19DataGridViewTextBoxColumn.Width = 103
        '
        'ContactNumber19DataGridViewTextBoxColumn
        '
        Me.ContactNumber19DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ContactNumber19DataGridViewTextBoxColumn.DataPropertyName = "ContactNumber_19"
        Me.ContactNumber19DataGridViewTextBoxColumn.HeaderText = "ContactNumber_19"
        Me.ContactNumber19DataGridViewTextBoxColumn.Name = "ContactNumber19DataGridViewTextBoxColumn"
        Me.ContactNumber19DataGridViewTextBoxColumn.Width = 161
        '
        'VaccineDataGridViewTextBoxColumn
        '
        Me.VaccineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.VaccineDataGridViewTextBoxColumn.DataPropertyName = "Vaccine"
        Me.VaccineDataGridViewTextBoxColumn.HeaderText = "Vaccine"
        Me.VaccineDataGridViewTextBoxColumn.Name = "VaccineDataGridViewTextBoxColumn"
        Me.VaccineDataGridViewTextBoxColumn.Width = 86
        '
        'TypeOfVaccineDataGridViewTextBoxColumn
        '
        Me.TypeOfVaccineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TypeOfVaccineDataGridViewTextBoxColumn.DataPropertyName = "TypeOfVaccine"
        Me.TypeOfVaccineDataGridViewTextBoxColumn.HeaderText = "TypeOfVaccine"
        Me.TypeOfVaccineDataGridViewTextBoxColumn.Name = "TypeOfVaccineDataGridViewTextBoxColumn"
        Me.TypeOfVaccineDataGridViewTextBoxColumn.Width = 129
        '
        'Question1DataGridViewTextBoxColumn
        '
        Me.Question1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Question1DataGridViewTextBoxColumn.DataPropertyName = "Question1"
        Me.Question1DataGridViewTextBoxColumn.HeaderText = "Question1"
        Me.Question1DataGridViewTextBoxColumn.Name = "Question1DataGridViewTextBoxColumn"
        Me.Question1DataGridViewTextBoxColumn.Width = 97
        '
        'Question2DataGridViewTextBoxColumn
        '
        Me.Question2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Question2DataGridViewTextBoxColumn.DataPropertyName = "Question2"
        Me.Question2DataGridViewTextBoxColumn.HeaderText = "Question2"
        Me.Question2DataGridViewTextBoxColumn.Name = "Question2DataGridViewTextBoxColumn"
        Me.Question2DataGridViewTextBoxColumn.Width = 97
        '
        'Question3DataGridViewTextBoxColumn
        '
        Me.Question3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Question3DataGridViewTextBoxColumn.DataPropertyName = "Question3"
        Me.Question3DataGridViewTextBoxColumn.HeaderText = "Question3"
        Me.Question3DataGridViewTextBoxColumn.Name = "Question3DataGridViewTextBoxColumn"
        Me.Question3DataGridViewTextBoxColumn.Width = 97
        '
        'Question4DataGridViewTextBoxColumn
        '
        Me.Question4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Question4DataGridViewTextBoxColumn.DataPropertyName = "Question4"
        Me.Question4DataGridViewTextBoxColumn.HeaderText = "Question4"
        Me.Question4DataGridViewTextBoxColumn.Name = "Question4DataGridViewTextBoxColumn"
        Me.Question4DataGridViewTextBoxColumn.Width = 97
        '
        'Question5DataGridViewTextBoxColumn
        '
        Me.Question5DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Question5DataGridViewTextBoxColumn.DataPropertyName = "Question5"
        Me.Question5DataGridViewTextBoxColumn.HeaderText = "Question5"
        Me.Question5DataGridViewTextBoxColumn.Name = "Question5DataGridViewTextBoxColumn"
        Me.Question5DataGridViewTextBoxColumn.Width = 97
        '
        'ArrivalDataGridViewTextBoxColumn
        '
        Me.ArrivalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ArrivalDataGridViewTextBoxColumn.DataPropertyName = "Arrival"
        Me.ArrivalDataGridViewTextBoxColumn.HeaderText = "Arrival"
        Me.ArrivalDataGridViewTextBoxColumn.Name = "ArrivalDataGridViewTextBoxColumn"
        '
        'Covid19screnningBindingSource
        '
        Me.Covid19screnningBindingSource.DataMember = "covid19screnning"
        Me.Covid19screnningBindingSource.DataSource = Me._MRCM1_0DataSet2
        '
        '_MRCM1_0DataSet2
        '
        Me._MRCM1_0DataSet2.DataSetName = "_MRCM1_0DataSet2"
        Me._MRCM1_0DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(582, 100)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(282, 31)
        Me.TextBox1.TabIndex = 2
        '
        'Covid19screnningTableAdapter
        '
        Me.Covid19screnningTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(578, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Covid-19 Screening Record"
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.MRCM.My.Resources.Resources.adminbg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1450, 471)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Covid-19 Screening Record"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Covid19screnningBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._MRCM1_0DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents _MRCM1_0DataSet2 As _MRCM1_0DataSet2
    Friend WithEvents Covid19screnningBindingSource As BindingSource
    Friend WithEvents Covid19screnningTableAdapter As _MRCM1_0DataSet2TableAdapters.covid19screnningTableAdapter
    Friend WithEvents Covid19ScreeningIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Name19DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Address19DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumber19DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaccineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeOfVaccineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Question1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Question2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Question3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Question4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Question5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArrivalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
