<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeeCargos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSeeCargos))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBRptCargo = New System.Windows.Forms.GroupBox()
        Me.DgvCargos = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RptCargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.BtnSeeReport = New System.Windows.Forms.Button()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.cargoTableAdapter()
        Me.BDAsistenciasEySDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptCargoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.RptCargoTableAdapter()
        Me.GBRptCargo.SuspendLayout()
        CType(Me.DgvCargos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptCargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(576, 48)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Reporte y Manejo de Cargos"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(118, 116)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(466, 40)
        Me.TxtBuscar.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 33)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Buscar:"
        '
        'GBRptCargo
        '
        Me.GBRptCargo.Controls.Add(Me.DgvCargos)
        Me.GBRptCargo.Location = New System.Drawing.Point(24, 206)
        Me.GBRptCargo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBRptCargo.Name = "GBRptCargo"
        Me.GBRptCargo.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBRptCargo.Size = New System.Drawing.Size(831, 504)
        Me.GBRptCargo.TabIndex = 22
        Me.GBRptCargo.TabStop = False
        Me.GBRptCargo.Text = "Cargos: "
        '
        'DgvCargos
        '
        Me.DgvCargos.AllowUserToAddRows = False
        Me.DgvCargos.AllowUserToDeleteRows = False
        Me.DgvCargos.AutoGenerateColumns = False
        Me.DgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCargos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CargoDataGridViewTextBoxColumn, Me.DescripciónDataGridViewTextBoxColumn})
        Me.DgvCargos.DataSource = Me.RptCargoBindingSource
        Me.DgvCargos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCargos.Location = New System.Drawing.Point(4, 24)
        Me.DgvCargos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvCargos.Name = "DgvCargos"
        Me.DgvCargos.ReadOnly = True
        Me.DgvCargos.RowHeadersWidth = 51
        Me.DgvCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCargos.Size = New System.Drawing.Size(823, 475)
        Me.DgvCargos.TabIndex = 0
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
        'CargoDataGridViewTextBoxColumn
        '
        Me.CargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo"
        Me.CargoDataGridViewTextBoxColumn.HeaderText = "Cargo"
        Me.CargoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CargoDataGridViewTextBoxColumn.Name = "CargoDataGridViewTextBoxColumn"
        Me.CargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CargoDataGridViewTextBoxColumn.Width = 125
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        Me.DescripciónDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripciónDataGridViewTextBoxColumn.Width = 125
        '
        'RptCargoBindingSource
        '
        Me.RptCargoBindingSource.DataMember = "RptCargo"
        Me.RptCargoBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'BDAsistenciasEySDataSet
        '
        Me.BDAsistenciasEySDataSet.DataSetName = "BDAsistenciasEySDataSet"
        Me.BDAsistenciasEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnSeeReport
        '
        Me.BtnSeeReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSeeReport.Location = New System.Drawing.Point(594, 116)
        Me.BtnSeeReport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSeeReport.Name = "BtnSeeReport"
        Me.BtnSeeReport.Size = New System.Drawing.Size(261, 48)
        Me.BtnSeeReport.TabIndex = 15
        Me.BtnSeeReport.Text = "Ver Reporte Completo"
        Me.BtnSeeReport.UseVisualStyleBackColor = True
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "cargo"
        Me.CargoBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'BDAsistenciasEySDataSetBindingSource
        '
        Me.BDAsistenciasEySDataSetBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        Me.BDAsistenciasEySDataSetBindingSource.Position = 0
        '
        'RptCargoTableAdapter
        '
        Me.RptCargoTableAdapter.ClearBeforeFill = True
        '
        'FrmSeeCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 726)
        Me.Controls.Add(Me.BtnSeeReport)
        Me.Controls.Add(Me.GBRptCargo)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FrmSeeCargos"
        Me.Text = "Control de Asistencias - Reporte de Cargos"
        Me.GBRptCargo.ResumeLayout(False)
        CType(Me.DgvCargos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptCargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GBRptCargo As GroupBox
    Friend WithEvents DgvCargos As DataGridView
    Friend WithEvents BtnSeeReport As Button
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As BDAsistenciasEySDataSetTableAdapters.cargoTableAdapter
    Friend WithEvents BDAsistenciasEySDataSetBindingSource As BindingSource
    Friend WithEvents RptCargoBindingSource As BindingSource
    Friend WithEvents RptCargoTableAdapter As BDAsistenciasEySDataSetTableAdapters.RptCargoTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
