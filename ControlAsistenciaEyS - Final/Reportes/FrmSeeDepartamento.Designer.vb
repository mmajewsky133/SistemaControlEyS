<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeeDepartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSeeDepartamento))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvDepartamentos = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtensiónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RptDepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnSeeReport = New System.Windows.Forms.Button()
        Me.DepartamentoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.departamentoTableAdapter()
        Me.RptDepartamentoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.RptDepartamentoTableAdapter()
        Me.GBRptDepartamento = New System.Windows.Forms.GroupBox()
        CType(Me.DgvDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptDepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBRptDepartamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(707, 46)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Reporte y Manejo de Departamentos"
        '
        'DgvDepartamentos
        '
        Me.DgvDepartamentos.AllowUserToAddRows = False
        Me.DgvDepartamentos.AllowUserToDeleteRows = False
        Me.DgvDepartamentos.AutoGenerateColumns = False
        Me.DgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDepartamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DepartamentoDataGridViewTextBoxColumn, Me.ExtensiónDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1})
        Me.DgvDepartamentos.DataSource = Me.RptDepartamentoBindingSource
        Me.DgvDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvDepartamentos.Location = New System.Drawing.Point(3, 23)
        Me.DgvDepartamentos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvDepartamentos.Name = "DgvDepartamentos"
        Me.DgvDepartamentos.ReadOnly = True
        Me.DgvDepartamentos.RowHeadersWidth = 51
        Me.DgvDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDepartamentos.Size = New System.Drawing.Size(752, 545)
        Me.DgvDepartamentos.TabIndex = 17
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'DepartamentoDataGridViewTextBoxColumn
        '
        Me.DepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn.HeaderText = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DepartamentoDataGridViewTextBoxColumn.Name = "DepartamentoDataGridViewTextBoxColumn"
        Me.DepartamentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartamentoDataGridViewTextBoxColumn.Width = 125
        '
        'ExtensiónDataGridViewTextBoxColumn
        '
        Me.ExtensiónDataGridViewTextBoxColumn.DataPropertyName = "Extensión"
        Me.ExtensiónDataGridViewTextBoxColumn.HeaderText = "Extensión"
        Me.ExtensiónDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExtensiónDataGridViewTextBoxColumn.Name = "ExtensiónDataGridViewTextBoxColumn"
        Me.ExtensiónDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExtensiónDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Correo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'RptDepartamentoBindingSource
        '
        Me.RptDepartamentoBindingSource.DataMember = "RptDepartamento"
        Me.RptDepartamentoBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'BDAsistenciasEySDataSet
        '
        Me.BDAsistenciasEySDataSet.DataSetName = "BDAsistenciasEySDataSet"
        Me.BDAsistenciasEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "departamento"
        Me.DepartamentoBindingSource.DataSource = Me.BDAsistenciasEySDataSetBindingSource
        '
        'BDAsistenciasEySDataSetBindingSource
        '
        Me.BDAsistenciasEySDataSetBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        Me.BDAsistenciasEySDataSetBindingSource.Position = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 120)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 33)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(120, 116)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(384, 40)
        Me.TxtBuscar.TabIndex = 19
        '
        'BtnSeeReport
        '
        Me.BtnSeeReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSeeReport.Location = New System.Drawing.Point(520, 114)
        Me.BtnSeeReport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSeeReport.Name = "BtnSeeReport"
        Me.BtnSeeReport.Size = New System.Drawing.Size(261, 48)
        Me.BtnSeeReport.TabIndex = 21
        Me.BtnSeeReport.Text = "Ver Reporte Completo"
        Me.BtnSeeReport.UseVisualStyleBackColor = True
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'RptDepartamentoTableAdapter
        '
        Me.RptDepartamentoTableAdapter.ClearBeforeFill = True
        '
        'GBRptDepartamento
        '
        Me.GBRptDepartamento.Controls.Add(Me.DgvDepartamentos)
        Me.GBRptDepartamento.Location = New System.Drawing.Point(26, 206)
        Me.GBRptDepartamento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GBRptDepartamento.Name = "GBRptDepartamento"
        Me.GBRptDepartamento.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GBRptDepartamento.Size = New System.Drawing.Size(758, 572)
        Me.GBRptDepartamento.TabIndex = 22
        Me.GBRptDepartamento.TabStop = False
        Me.GBRptDepartamento.Text = "Departamentos: "
        '
        'FrmSeeDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 830)
        Me.Controls.Add(Me.GBRptDepartamento)
        Me.Controls.Add(Me.BtnSeeReport)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FrmSeeDepartamento"
        Me.Text = "Control de Asistencias - Reporte de Departamentos"
        CType(Me.DgvDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptDepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBRptDepartamento.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents DgvDepartamentos As DataGridView
    Friend WithEvents IddepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombredepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExttelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnSeeReport As Button
    Friend WithEvents BDAsistenciasEySDataSetBindingSource As BindingSource
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As BDAsistenciasEySDataSetTableAdapters.departamentoTableAdapter
    Friend WithEvents RptDepartamentoBindingSource As BindingSource
    Friend WithEvents RptDepartamentoTableAdapter As BDAsistenciasEySDataSetTableAdapters.RptDepartamentoTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtensiónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GBRptDepartamento As GroupBox
End Class
