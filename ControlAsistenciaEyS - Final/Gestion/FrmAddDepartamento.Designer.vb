<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddDepartamento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddDepartamento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtExtension = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.GBDepartamento = New System.Windows.Forms.GroupBox()
        Me.DgvDepartamento = New System.Windows.Forms.DataGridView()
        Me.IdDepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtTelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.DepartamentoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.departamentoTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.GBDepartamento.SuspendLayout()
        CType(Me.DgvDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(423, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestion de Departamentos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Departamento: "
        '
        'TxtDepartamento
        '
        Me.TxtDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepartamento.Location = New System.Drawing.Point(26, 155)
        Me.TxtDepartamento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtDepartamento.Name = "TxtDepartamento"
        Me.TxtDepartamento.Size = New System.Drawing.Size(472, 40)
        Me.TxtDepartamento.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(508, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 33)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Extensión: "
        '
        'TxtExtension
        '
        Me.TxtExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExtension.Location = New System.Drawing.Point(514, 155)
        Me.TxtExtension.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtExtension.Name = "TxtExtension"
        Me.TxtExtension.Size = New System.Drawing.Size(237, 40)
        Me.TxtExtension.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 215)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(265, 33)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Correo Electrónico:"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(27, 258)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(724, 40)
        Me.TxtCorreo.TabIndex = 3
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(357, 319)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(396, 91)
        Me.BtnNuevo.TabIndex = 4
        Me.BtnNuevo.Text = "Limpiar Campos"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(357, 485)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(143, 48)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(508, 485)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(107, 48)
        Me.BtnEditar.TabIndex = 7
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(624, 485)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(129, 48)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'GBDepartamento
        '
        Me.GBDepartamento.Controls.Add(Me.DgvDepartamento)
        Me.GBDepartamento.Location = New System.Drawing.Point(27, 575)
        Me.GBDepartamento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBDepartamento.Name = "GBDepartamento"
        Me.GBDepartamento.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBDepartamento.Size = New System.Drawing.Size(726, 486)
        Me.GBDepartamento.TabIndex = 11
        Me.GBDepartamento.TabStop = False
        Me.GBDepartamento.Text = "Lista de Departamentos"
        '
        'DgvDepartamento
        '
        Me.DgvDepartamento.AllowUserToAddRows = False
        Me.DgvDepartamento.AllowUserToDeleteRows = False
        Me.DgvDepartamento.AutoGenerateColumns = False
        Me.DgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDepartamento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDepDataGridViewTextBoxColumn, Me.NombreDepDataGridViewTextBoxColumn, Me.ExtTelDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DgvDepartamento.DataSource = Me.DepartamentoBindingSource
        Me.DgvDepartamento.Location = New System.Drawing.Point(22, 34)
        Me.DgvDepartamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvDepartamento.Name = "DgvDepartamento"
        Me.DgvDepartamento.ReadOnly = True
        Me.DgvDepartamento.RowHeadersWidth = 51
        Me.DgvDepartamento.RowTemplate.Height = 24
        Me.DgvDepartamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDepartamento.Size = New System.Drawing.Size(680, 432)
        Me.DgvDepartamento.TabIndex = 0
        '
        'IdDepDataGridViewTextBoxColumn
        '
        Me.IdDepDataGridViewTextBoxColumn.DataPropertyName = "idDep"
        Me.IdDepDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDepDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDepDataGridViewTextBoxColumn.Name = "IdDepDataGridViewTextBoxColumn"
        Me.IdDepDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDepDataGridViewTextBoxColumn.Visible = False
        Me.IdDepDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDepDataGridViewTextBoxColumn
        '
        Me.NombreDepDataGridViewTextBoxColumn.DataPropertyName = "nombreDep"
        Me.NombreDepDataGridViewTextBoxColumn.HeaderText = "Departamento"
        Me.NombreDepDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDepDataGridViewTextBoxColumn.Name = "NombreDepDataGridViewTextBoxColumn"
        Me.NombreDepDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDepDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NombreDepDataGridViewTextBoxColumn.Width = 125
        '
        'ExtTelDataGridViewTextBoxColumn
        '
        Me.ExtTelDataGridViewTextBoxColumn.DataPropertyName = "extTel"
        Me.ExtTelDataGridViewTextBoxColumn.HeaderText = "Extension"
        Me.ExtTelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExtTelDataGridViewTextBoxColumn.Name = "ExtTelDataGridViewTextBoxColumn"
        Me.ExtTelDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExtTelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ExtTelDataGridViewTextBoxColumn.Width = 80
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CorreoDataGridViewTextBoxColumn.Width = 190
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
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "departamento"
        Me.DepartamentoBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'BDAsistenciasEySDataSet
        '
        Me.BDAsistenciasEySDataSet.DataSetName = "BDAsistenciasEySDataSet"
        Me.BDAsistenciasEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 489)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 33)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Buscar: "
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(130, 485)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(216, 40)
        Me.TxtBuscar.TabIndex = 5
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(544, 29)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(208, 51)
        Me.BtnRegresar.TabIndex = 47
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'FrmAddDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 1081)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GBDepartamento)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtExtension)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDepartamento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FrmAddDepartamento"
        Me.Text = "Administración de departamentos"
        Me.GBDepartamento.ResumeLayout(False)
        CType(Me.DgvDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDepartamento As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtExtension As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents GBDepartamento As GroupBox
    Friend WithEvents DgvDepartamento As DataGridView
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As BDAsistenciasEySDataSetTableAdapters.departamentoTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents IdDepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtTelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
