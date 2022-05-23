<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAsignarCargo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvCargoEmp = New System.Windows.Forms.DataGridView()
        Me.IdCargoEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoEmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CargoEmpTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.cargoEmpTableAdapter()
        Me.CmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoEmpBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbCargo = New System.Windows.Forms.ComboBox()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CargoEmpBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter()
        Me.CargoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.cargoTableAdapter()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvCargoEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoEmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoEmpBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoEmpBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asignar cargo a un empleado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label2.Location = New System.Drawing.Point(77, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Empleado"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvCargoEmp)
        Me.GroupBox1.Location = New System.Drawing.Point(82, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 162)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empleados con cargos"
        '
        'DgvCargoEmp
        '
        Me.DgvCargoEmp.AutoGenerateColumns = False
        Me.DgvCargoEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCargoEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCargoEmpDataGridViewTextBoxColumn, Me.IdEmpDataGridViewTextBoxColumn, Me.IdCargoDataGridViewTextBoxColumn})
        Me.DgvCargoEmp.DataSource = Me.CargoEmpBindingSource
        Me.DgvCargoEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCargoEmp.Location = New System.Drawing.Point(3, 18)
        Me.DgvCargoEmp.Name = "DgvCargoEmp"
        Me.DgvCargoEmp.RowHeadersWidth = 51
        Me.DgvCargoEmp.RowTemplate.Height = 24
        Me.DgvCargoEmp.Size = New System.Drawing.Size(514, 141)
        Me.DgvCargoEmp.TabIndex = 0
        '
        'IdCargoEmpDataGridViewTextBoxColumn
        '
        Me.IdCargoEmpDataGridViewTextBoxColumn.DataPropertyName = "idCargoEmp"
        Me.IdCargoEmpDataGridViewTextBoxColumn.HeaderText = "idCargoEmp"
        Me.IdCargoEmpDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdCargoEmpDataGridViewTextBoxColumn.Name = "IdCargoEmpDataGridViewTextBoxColumn"
        Me.IdCargoEmpDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCargoEmpDataGridViewTextBoxColumn.Width = 125
        '
        'IdEmpDataGridViewTextBoxColumn
        '
        Me.IdEmpDataGridViewTextBoxColumn.DataPropertyName = "idEmp"
        Me.IdEmpDataGridViewTextBoxColumn.HeaderText = "idEmp"
        Me.IdEmpDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdEmpDataGridViewTextBoxColumn.Name = "IdEmpDataGridViewTextBoxColumn"
        Me.IdEmpDataGridViewTextBoxColumn.Width = 125
        '
        'IdCargoDataGridViewTextBoxColumn
        '
        Me.IdCargoDataGridViewTextBoxColumn.DataPropertyName = "idCargo"
        Me.IdCargoDataGridViewTextBoxColumn.HeaderText = "idCargo"
        Me.IdCargoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdCargoDataGridViewTextBoxColumn.Name = "IdCargoDataGridViewTextBoxColumn"
        Me.IdCargoDataGridViewTextBoxColumn.Width = 125
        '
        'CargoEmpBindingSource
        '
        Me.CargoEmpBindingSource.DataMember = "cargoEmp"
        Me.CargoEmpBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'BDAsistenciasEySDataSet
        '
        Me.BDAsistenciasEySDataSet.DataSetName = "BDAsistenciasEySDataSet"
        Me.BDAsistenciasEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!)
        Me.Label4.Location = New System.Drawing.Point(115, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cargo"
        '
        'CargoEmpTableAdapter
        '
        Me.CargoEmpTableAdapter.ClearBeforeFill = True
        '
        'CmbEmpleado
        '
        Me.CmbEmpleado.FormattingEnabled = True
        Me.CmbEmpleado.Location = New System.Drawing.Point(211, 97)
        Me.CmbEmpleado.Name = "CmbEmpleado"
        Me.CmbEmpleado.Size = New System.Drawing.Size(121, 24)
        Me.CmbEmpleado.TabIndex = 5
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'CargoEmpBindingSource1
        '
        Me.CargoEmpBindingSource1.DataMember = "cargoEmp"
        Me.CargoEmpBindingSource1.DataSource = Me.BDAsistenciasEySDataSet
        '
        'CmbCargo
        '
        Me.CmbCargo.FormattingEnabled = True
        Me.CmbCargo.Location = New System.Drawing.Point(211, 153)
        Me.CmbCargo.Name = "CmbCargo"
        Me.CmbCargo.Size = New System.Drawing.Size(121, 24)
        Me.CmbCargo.TabIndex = 6
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "cargo"
        Me.CargoBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'CargoEmpBindingSource2
        '
        Me.CargoEmpBindingSource2.DataMember = "cargoEmp"
        Me.CargoEmpBindingSource2.DataSource = Me.BDAsistenciasEySDataSet
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.BtnGuardar.Location = New System.Drawing.Point(85, 219)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(108, 36)
        Me.BtnGuardar.TabIndex = 7
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.BtnEditar.Location = New System.Drawing.Point(371, 219)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(108, 36)
        Me.BtnEditar.TabIndex = 8
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.BtnEliminar.Location = New System.Drawing.Point(485, 219)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(114, 36)
        Me.BtnEliminar.TabIndex = 9
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FrmAsignarCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 517)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.CmbCargo)
        Me.Controls.Add(Me.CmbEmpleado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAsignarCargo"
        Me.Text = "FrmAsignarCargo"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvCargoEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoEmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoEmpBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoEmpBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvCargoEmp As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents CargoEmpBindingSource As BindingSource
    Friend WithEvents CargoEmpTableAdapter As BDAsistenciasEySDataSetTableAdapters.cargoEmpTableAdapter
    Friend WithEvents IdCargoEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CmbEmpleado As ComboBox
    Friend WithEvents CmbCargo As ComboBox
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents CargoEmpBindingSource1 As BindingSource
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As BDAsistenciasEySDataSetTableAdapters.cargoTableAdapter
    Friend WithEvents CargoEmpBindingSource2 As BindingSource
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
End Class
