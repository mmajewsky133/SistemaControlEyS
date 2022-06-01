<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeeEmpleado
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
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEmpSelct = New System.Windows.Forms.TextBox()
        Me.BtnAddCargos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSeeReport = New System.Windows.Forms.Button()
        Me.RefEmpleados5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter()
        Me.GBRptEmpleado = New System.Windows.Forms.GroupBox()
        Me.DgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.RptTremendoEmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RptTremendoEmpTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.RptTremendoEmpTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CédulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirecciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeléfonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstitucionalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefEmpleados5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBRptEmpleado.SuspendLayout()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptTremendoEmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'BDAsistenciasEySDataSet
        '
        Me.BDAsistenciasEySDataSet.DataSetName = "BDAsistenciasEySDataSet"
        Me.BDAsistenciasEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Buscar:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(105, 198)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(748, 34)
        Me.TxtBuscar.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Empleado Seleccionado:"
        '
        'TxtEmpSelct
        '
        Me.TxtEmpSelct.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtEmpSelct.Location = New System.Drawing.Point(21, 130)
        Me.TxtEmpSelct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEmpSelct.Name = "TxtEmpSelct"
        Me.TxtEmpSelct.ReadOnly = True
        Me.TxtEmpSelct.Size = New System.Drawing.Size(231, 34)
        Me.TxtEmpSelct.TabIndex = 9
        '
        'BtnAddCargos
        '
        Me.BtnAddCargos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddCargos.Location = New System.Drawing.Point(281, 130)
        Me.BtnAddCargos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAddCargos.Name = "BtnAddCargos"
        Me.BtnAddCargos.Size = New System.Drawing.Size(232, 38)
        Me.BtnAddCargos.TabIndex = 11
        Me.BtnAddCargos.Text = "Asignar Cargos"
        Me.BtnAddCargos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(435, 31)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Reporte y Manejo de Empleados"
        '
        'BtnSeeReport
        '
        Me.BtnSeeReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSeeReport.Location = New System.Drawing.Point(793, 514)
        Me.BtnSeeReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSeeReport.Name = "BtnSeeReport"
        Me.BtnSeeReport.Size = New System.Drawing.Size(232, 38)
        Me.BtnSeeReport.TabIndex = 14
        Me.BtnSeeReport.Text = "Ver Reporte Completo"
        Me.BtnSeeReport.UseVisualStyleBackColor = True
        '
        'BDAsistenciasEySDataSetBindingSource
        '
        Me.BDAsistenciasEySDataSetBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        Me.BDAsistenciasEySDataSetBindingSource.Position = 0
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'GBRptEmpleado
        '
        Me.GBRptEmpleado.Controls.Add(Me.DgvEmpleados)
        Me.GBRptEmpleado.Controls.Add(Me.BtnSeeReport)
        Me.GBRptEmpleado.Location = New System.Drawing.Point(21, 242)
        Me.GBRptEmpleado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBRptEmpleado.Name = "GBRptEmpleado"
        Me.GBRptEmpleado.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBRptEmpleado.Size = New System.Drawing.Size(1033, 562)
        Me.GBRptEmpleado.TabIndex = 15
        Me.GBRptEmpleado.TabStop = False
        '
        'DgvEmpleados
        '
        Me.DgvEmpleados.AutoGenerateColumns = False
        Me.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.CédulaDataGridViewTextBoxColumn, Me.DirecciónDataGridViewTextBoxColumn, Me.TeléfonoDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.InstitucionalDataGridViewTextBoxColumn})
        Me.DgvEmpleados.DataSource = Me.RptTremendoEmpBindingSource
        Me.DgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvEmpleados.Location = New System.Drawing.Point(4, 19)
        Me.DgvEmpleados.Name = "DgvEmpleados"
        Me.DgvEmpleados.RowHeadersWidth = 51
        Me.DgvEmpleados.RowTemplate.Height = 24
        Me.DgvEmpleados.Size = New System.Drawing.Size(1025, 539)
        Me.DgvEmpleados.TabIndex = 15
        '
        'RptTremendoEmpBindingSource
        '
        Me.RptTremendoEmpBindingSource.DataMember = "RptTremendoEmp"
        Me.RptTremendoEmpBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'RptTremendoEmpTableAdapter
        '
        Me.RptTremendoEmpTableAdapter.ClearBeforeFill = True
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
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.Width = 125
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.Width = 125
        '
        'CédulaDataGridViewTextBoxColumn
        '
        Me.CédulaDataGridViewTextBoxColumn.DataPropertyName = "Cédula"
        Me.CédulaDataGridViewTextBoxColumn.HeaderText = "Cédula"
        Me.CédulaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CédulaDataGridViewTextBoxColumn.Name = "CédulaDataGridViewTextBoxColumn"
        Me.CédulaDataGridViewTextBoxColumn.Width = 125
        '
        'DirecciónDataGridViewTextBoxColumn
        '
        Me.DirecciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DirecciónDataGridViewTextBoxColumn.Name = "DirecciónDataGridViewTextBoxColumn"
        Me.DirecciónDataGridViewTextBoxColumn.Width = 125
        '
        'TeléfonoDataGridViewTextBoxColumn
        '
        Me.TeléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TeléfonoDataGridViewTextBoxColumn.Name = "TeléfonoDataGridViewTextBoxColumn"
        Me.TeléfonoDataGridViewTextBoxColumn.Width = 125
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.Width = 125
        '
        'InstitucionalDataGridViewTextBoxColumn
        '
        Me.InstitucionalDataGridViewTextBoxColumn.DataPropertyName = "Institucional"
        Me.InstitucionalDataGridViewTextBoxColumn.HeaderText = "Institucional"
        Me.InstitucionalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InstitucionalDataGridViewTextBoxColumn.Name = "InstitucionalDataGridViewTextBoxColumn"
        Me.InstitucionalDataGridViewTextBoxColumn.Width = 125
        '
        'FrmSeeEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 822)
        Me.Controls.Add(Me.GBRptEmpleado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnAddCargos)
        Me.Controls.Add(Me.TxtEmpSelct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmSeeEmpleado"
        Me.Text = "Control de Asistencias - Reporte de Empleados"
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefEmpleados5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBRptEmpleado.ResumeLayout(False)
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptTremendoEmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEmpSelct As TextBox
    Friend WithEvents BtnAddCargos As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSeeReport As Button
    Friend WithEvents RefEmpleados5BindingSource As BindingSource
    Friend WithEvents BDAsistenciasEySDataSetBindingSource As BindingSource
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents GBRptEmpleado As GroupBox
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DgvEmpleados As DataGridView
    Friend WithEvents RptTremendoEmpBindingSource As BindingSource
    Friend WithEvents RptTremendoEmpTableAdapter As BDAsistenciasEySDataSetTableAdapters.RptTremendoEmpTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CédulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirecciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeléfonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstitucionalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
