<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PatientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullName2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumber2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmergencyContactNumber2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddress2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nationality2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sex2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diagnosis2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoctorName2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicalFieldSpecialization2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartingScheduleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndOfScheduleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientSchedule1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._MRCM1_0DataSet1 = New MRCM._MRCM1_0DataSet1()
        Me.PatientSchedule1TableAdapter = New MRCM._MRCM1_0DataSet1TableAdapters.PatientSchedule1TableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientSchedule1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._MRCM1_0DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton3})
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
        Me.ToolStripButton2.Size = New System.Drawing.Size(144, 36)
        Me.ToolStripButton2.Text = "ADD RECORD"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.MRCM.My.Resources.Resources.log_out
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(112, 36)
        Me.ToolStripButton3.Text = "LOG-OUT"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientIDDataGridViewTextBoxColumn, Me.FullName2DataGridViewTextBoxColumn, Me.Address2DataGridViewTextBoxColumn, Me.ContactNumber2DataGridViewTextBoxColumn, Me.EmergencyContactNumber2DataGridViewTextBoxColumn, Me.EmailAddress2DataGridViewTextBoxColumn, Me.Nationality2DataGridViewTextBoxColumn, Me.Sex2DataGridViewTextBoxColumn, Me.Diagnosis2DataGridViewTextBoxColumn, Me.DoctorName2DataGridViewTextBoxColumn, Me.MedicalFieldSpecialization2DataGridViewTextBoxColumn, Me.StartingScheduleDataGridViewTextBoxColumn, Me.EndOfScheduleDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PatientSchedule1BindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(12, 130)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(1426, 334)
        Me.DataGridView1.TabIndex = 1
        '
        'PatientIDDataGridViewTextBoxColumn
        '
        Me.PatientIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PatientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID"
        Me.PatientIDDataGridViewTextBoxColumn.HeaderText = "PatientID"
        Me.PatientIDDataGridViewTextBoxColumn.Name = "PatientIDDataGridViewTextBoxColumn"
        Me.PatientIDDataGridViewTextBoxColumn.Width = 106
        '
        'FullName2DataGridViewTextBoxColumn
        '
        Me.FullName2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FullName2DataGridViewTextBoxColumn.DataPropertyName = "FullName2"
        Me.FullName2DataGridViewTextBoxColumn.HeaderText = "FullName2"
        Me.FullName2DataGridViewTextBoxColumn.Name = "FullName2DataGridViewTextBoxColumn"
        '
        'Address2DataGridViewTextBoxColumn
        '
        Me.Address2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Address2DataGridViewTextBoxColumn.DataPropertyName = "Address2"
        Me.Address2DataGridViewTextBoxColumn.HeaderText = "Address2"
        Me.Address2DataGridViewTextBoxColumn.Name = "Address2DataGridViewTextBoxColumn"
        '
        'ContactNumber2DataGridViewTextBoxColumn
        '
        Me.ContactNumber2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ContactNumber2DataGridViewTextBoxColumn.DataPropertyName = "ContactNumber2"
        Me.ContactNumber2DataGridViewTextBoxColumn.HeaderText = "ContactNumber2"
        Me.ContactNumber2DataGridViewTextBoxColumn.Name = "ContactNumber2DataGridViewTextBoxColumn"
        Me.ContactNumber2DataGridViewTextBoxColumn.Width = 147
        '
        'EmergencyContactNumber2DataGridViewTextBoxColumn
        '
        Me.EmergencyContactNumber2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EmergencyContactNumber2DataGridViewTextBoxColumn.DataPropertyName = "EmergencyContactNumber2"
        Me.EmergencyContactNumber2DataGridViewTextBoxColumn.HeaderText = "EmergencyContactNumber2"
        Me.EmergencyContactNumber2DataGridViewTextBoxColumn.Name = "EmergencyContactNumber2DataGridViewTextBoxColumn"
        Me.EmergencyContactNumber2DataGridViewTextBoxColumn.Width = 218
        '
        'EmailAddress2DataGridViewTextBoxColumn
        '
        Me.EmailAddress2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EmailAddress2DataGridViewTextBoxColumn.DataPropertyName = "EmailAddress2"
        Me.EmailAddress2DataGridViewTextBoxColumn.HeaderText = "EmailAddress2"
        Me.EmailAddress2DataGridViewTextBoxColumn.Name = "EmailAddress2DataGridViewTextBoxColumn"
        Me.EmailAddress2DataGridViewTextBoxColumn.Width = 124
        '
        'Nationality2DataGridViewTextBoxColumn
        '
        Me.Nationality2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Nationality2DataGridViewTextBoxColumn.DataPropertyName = "Nationality2"
        Me.Nationality2DataGridViewTextBoxColumn.HeaderText = "Nationality2"
        Me.Nationality2DataGridViewTextBoxColumn.Name = "Nationality2DataGridViewTextBoxColumn"
        Me.Nationality2DataGridViewTextBoxColumn.Width = 110
        '
        'Sex2DataGridViewTextBoxColumn
        '
        Me.Sex2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Sex2DataGridViewTextBoxColumn.DataPropertyName = "Sex2"
        Me.Sex2DataGridViewTextBoxColumn.HeaderText = "Sex2"
        Me.Sex2DataGridViewTextBoxColumn.Name = "Sex2DataGridViewTextBoxColumn"
        Me.Sex2DataGridViewTextBoxColumn.Width = 107
        '
        'Diagnosis2DataGridViewTextBoxColumn
        '
        Me.Diagnosis2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Diagnosis2DataGridViewTextBoxColumn.DataPropertyName = "Diagnosis2"
        Me.Diagnosis2DataGridViewTextBoxColumn.HeaderText = "Diagnosis2"
        Me.Diagnosis2DataGridViewTextBoxColumn.Name = "Diagnosis2DataGridViewTextBoxColumn"
        Me.Diagnosis2DataGridViewTextBoxColumn.Width = 101
        '
        'DoctorName2DataGridViewTextBoxColumn
        '
        Me.DoctorName2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DoctorName2DataGridViewTextBoxColumn.DataPropertyName = "DoctorName2"
        Me.DoctorName2DataGridViewTextBoxColumn.HeaderText = "DoctorName2"
        Me.DoctorName2DataGridViewTextBoxColumn.Name = "DoctorName2DataGridViewTextBoxColumn"
        Me.DoctorName2DataGridViewTextBoxColumn.Width = 125
        '
        'MedicalFieldSpecialization2DataGridViewTextBoxColumn
        '
        Me.MedicalFieldSpecialization2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MedicalFieldSpecialization2DataGridViewTextBoxColumn.DataPropertyName = "MedicalFieldSpecialization2"
        Me.MedicalFieldSpecialization2DataGridViewTextBoxColumn.HeaderText = "MedicalFieldSpecialization2"
        Me.MedicalFieldSpecialization2DataGridViewTextBoxColumn.Name = "MedicalFieldSpecialization2DataGridViewTextBoxColumn"
        Me.MedicalFieldSpecialization2DataGridViewTextBoxColumn.Width = 209
        '
        'StartingScheduleDataGridViewTextBoxColumn
        '
        Me.StartingScheduleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StartingScheduleDataGridViewTextBoxColumn.DataPropertyName = "StartingSchedule"
        Me.StartingScheduleDataGridViewTextBoxColumn.HeaderText = "StartingSchedule"
        Me.StartingScheduleDataGridViewTextBoxColumn.Name = "StartingScheduleDataGridViewTextBoxColumn"
        Me.StartingScheduleDataGridViewTextBoxColumn.Width = 140
        '
        'EndOfScheduleDataGridViewTextBoxColumn
        '
        Me.EndOfScheduleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EndOfScheduleDataGridViewTextBoxColumn.DataPropertyName = "EndOfSchedule"
        Me.EndOfScheduleDataGridViewTextBoxColumn.HeaderText = "EndOfSchedule"
        Me.EndOfScheduleDataGridViewTextBoxColumn.Name = "EndOfScheduleDataGridViewTextBoxColumn"
        Me.EndOfScheduleDataGridViewTextBoxColumn.Width = 130
        '
        'PatientSchedule1BindingSource
        '
        Me.PatientSchedule1BindingSource.DataMember = "PatientSchedule1"
        Me.PatientSchedule1BindingSource.DataSource = Me._MRCM1_0DataSet1
        '
        '_MRCM1_0DataSet1
        '
        Me._MRCM1_0DataSet1.DataSetName = "_MRCM1_0DataSet1"
        Me._MRCM1_0DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientSchedule1TableAdapter
        '
        Me.PatientSchedule1TableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(613, 93)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(282, 31)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(645, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Appointment Record"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MRCM.My.Resources.Resources.adminbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1450, 490)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment Record"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientSchedule1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._MRCM1_0DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _MRCM1_0DataSet1 As _MRCM1_0DataSet1
    Friend WithEvents PatientSchedule1BindingSource As BindingSource
    Friend WithEvents PatientSchedule1TableAdapter As _MRCM1_0DataSet1TableAdapters.PatientSchedule1TableAdapter
    Friend WithEvents PatientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullName2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Address2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumber2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmergencyContactNumber2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddress2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Nationality2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Sex2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Diagnosis2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DoctorName2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicalFieldSpecialization2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartingScheduleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndOfScheduleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
