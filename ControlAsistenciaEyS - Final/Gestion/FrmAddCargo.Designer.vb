<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddCargo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCargo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.GBCargo = New System.Windows.Forms.GroupBox()
        Me.DgvCargo = New System.Windows.Forms.DataGridView()
        Me.IdCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.CargoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.cargoTableAdapter()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnAddDep = New System.Windows.Forms.Button()
        Me.GBCargo.SuspendLayout()
        CType(Me.DgvCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gestion de Cargos"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(563, 438)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(125, 39)
        Me.BtnEliminar.TabIndex = 9
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(440, 438)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(115, 39)
        Me.BtnEditar.TabIndex = 8
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(315, 438)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(117, 39)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(383, 316)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(305, 73)
        Me.BtnNuevo.TabIndex = 7
        Me.BtnNuevo.Text = "Limpiar Campos"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(23, 197)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(664, 104)
        Me.TxtDescripcion.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 164)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Descripción:"
        '
        'TxtCargo
        '
        Me.TxtCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCargo.Location = New System.Drawing.Point(23, 122)
        Me.TxtCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(664, 34)
        Me.TxtCargo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cargo: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 316)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 29)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Departamento:"
        '
        'CmbDepartamento
        '
        Me.CmbDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDepartamento.FormattingEnabled = True
        Me.CmbDepartamento.Location = New System.Drawing.Point(23, 350)
        Me.CmbDepartamento.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Size = New System.Drawing.Size(351, 37)
        Me.CmbDepartamento.TabIndex = 3
        '
        'GBCargo
        '
        Me.GBCargo.Controls.Add(Me.DgvCargo)
        Me.GBCargo.Location = New System.Drawing.Point(21, 497)
        Me.GBCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.GBCargo.Name = "GBCargo"
        Me.GBCargo.Padding = New System.Windows.Forms.Padding(4)
        Me.GBCargo.Size = New System.Drawing.Size(667, 277)
        Me.GBCargo.TabIndex = 23
        Me.GBCargo.TabStop = False
        Me.GBCargo.Text = "Lista de Cargos"
        '
        'DgvCargo
        '
        Me.DgvCargo.AllowUserToAddRows = False
        Me.DgvCargo.AllowUserToDeleteRows = False
        Me.DgvCargo.AutoGenerateColumns = False
        Me.DgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCargo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCargoDataGridViewTextBoxColumn, Me.NombreCargoDataGridViewTextBoxColumn, Me.DescCargoDataGridViewTextBoxColumn, Me.IdDepDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DgvCargo.DataSource = Me.CargoBindingSource
        Me.DgvCargo.Location = New System.Drawing.Point(21, 26)
        Me.DgvCargo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvCargo.Name = "DgvCargo"
        Me.DgvCargo.ReadOnly = True
        Me.DgvCargo.RowHeadersWidth = 51
        Me.DgvCargo.RowTemplate.Height = 24
        Me.DgvCargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCargo.Size = New System.Drawing.Size(621, 234)
        Me.DgvCargo.TabIndex = 0
        '
        'IdCargoDataGridViewTextBoxColumn
        '
        Me.IdCargoDataGridViewTextBoxColumn.DataPropertyName = "idCargo"
        Me.IdCargoDataGridViewTextBoxColumn.HeaderText = "idCargo"
        Me.IdCargoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdCargoDataGridViewTextBoxColumn.Name = "IdCargoDataGridViewTextBoxColumn"
        Me.IdCargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCargoDataGridViewTextBoxColumn.Visible = False
        Me.IdCargoDataGridViewTextBoxColumn.Width = 125
        '
        'NombreCargoDataGridViewTextBoxColumn
        '
        Me.NombreCargoDataGridViewTextBoxColumn.DataPropertyName = "nombreCargo"
        Me.NombreCargoDataGridViewTextBoxColumn.HeaderText = "Cargo"
        Me.NombreCargoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreCargoDataGridViewTextBoxColumn.Name = "NombreCargoDataGridViewTextBoxColumn"
        Me.NombreCargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreCargoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NombreCargoDataGridViewTextBoxColumn.Width = 125
        '
        'DescCargoDataGridViewTextBoxColumn
        '
        Me.DescCargoDataGridViewTextBoxColumn.DataPropertyName = "descCargo"
        Me.DescCargoDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescCargoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescCargoDataGridViewTextBoxColumn.Name = "DescCargoDataGridViewTextBoxColumn"
        Me.DescCargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescCargoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DescCargoDataGridViewTextBoxColumn.Width = 300
        '
        'IdDepDataGridViewTextBoxColumn
        '
        Me.IdDepDataGridViewTextBoxColumn.DataPropertyName = "idDep"
        Me.IdDepDataGridViewTextBoxColumn.HeaderText = "idDep"
        Me.IdDepDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDepDataGridViewTextBoxColumn.Name = "IdDepDataGridViewTextBoxColumn"
        Me.IdDepDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDepDataGridViewTextBoxColumn.Visible = False
        Me.IdDepDataGridViewTextBoxColumn.Width = 125
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Visible = False
        Me.EstadoDataGridViewTextBoxColumn.Width = 125
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "cargo"
        Me.CargoBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'BDAsistenciasEySDataSet
        '
        Me.BDAsistenciasEySDataSet.DataSetName = "BDAsistenciasEySDataSet"
        Me.BDAsistenciasEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.BtnRegresar.Location = New System.Drawing.Point(552, 23)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(136, 41)
        Me.BtnRegresar.TabIndex = 24
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(113, 439)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(192, 34)
        Me.TxtBuscar.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 443)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Buscar: "
        '
        'BtnAddDep
        '
        Me.BtnAddDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddDep.Location = New System.Drawing.Point(203, 316)
        Me.BtnAddDep.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddDep.Name = "BtnAddDep"
        Me.BtnAddDep.Size = New System.Drawing.Size(172, 30)
        Me.BtnAddDep.TabIndex = 4
        Me.BtnAddDep.Text = "Nuevo"
        Me.BtnAddDep.UseVisualStyleBackColor = True
        '
        'FrmAddCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 794)
        Me.Controls.Add(Me.BtnAddDep)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.GBCargo)
        Me.Controls.Add(Me.CmbDepartamento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCargo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAddCargo"
        Me.Text = "Administrador de cargos"
        Me.GBCargo.ResumeLayout(False)
        CType(Me.DgvCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCargo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbDepartamento As ComboBox
    Friend WithEvents GBCargo As GroupBox
    Friend WithEvents DgvCargo As DataGridView
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As BDAsistenciasEySDataSetTableAdapters.cargoTableAdapter
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents IdCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAddDep As Button
End Class
