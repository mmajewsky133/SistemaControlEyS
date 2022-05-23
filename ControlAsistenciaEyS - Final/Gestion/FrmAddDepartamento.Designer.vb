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
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.DgvDepartamento = New System.Windows.Forms.DataGridView()
        Me.IdDepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtTelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.DepartamentoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.departamentoTableAdapter()
        Me.GroupBox.SuspendLayout()
        CType(Me.DgvDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestion de Departamentos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Departamento: "
        '
        'TxtDepartamento
        '
        Me.TxtDepartamento.Location = New System.Drawing.Point(241, 85)
        Me.TxtDepartamento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDepartamento.Name = "TxtDepartamento"
        Me.TxtDepartamento.Size = New System.Drawing.Size(415, 22)
        Me.TxtDepartamento.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Extensión: "
        '
        'TxtExtension
        '
        Me.TxtExtension.Location = New System.Drawing.Point(241, 142)
        Me.TxtExtension.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtExtension.Name = "TxtExtension"
        Me.TxtExtension.Size = New System.Drawing.Size(132, 22)
        Me.TxtExtension.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 198)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Correo Electrónico:"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(241, 196)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(415, 22)
        Me.TxtCorreo.TabIndex = 6
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(549, 6)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(107, 38)
        Me.BtnNuevo.TabIndex = 7
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(241, 255)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(113, 38)
        Me.BtnGuardar.TabIndex = 8
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(362, 255)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(107, 38)
        Me.BtnEditar.TabIndex = 9
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(477, 255)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(109, 38)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.DgvDepartamento)
        Me.GroupBox.Location = New System.Drawing.Point(45, 338)
        Me.GroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox.Size = New System.Drawing.Size(683, 359)
        Me.GroupBox.TabIndex = 11
        Me.GroupBox.TabStop = False
        '
        'DgvDepartamento
        '
        Me.DgvDepartamento.AutoGenerateColumns = False
        Me.DgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDepartamento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDepDataGridViewTextBoxColumn, Me.NombreDepDataGridViewTextBoxColumn, Me.ExtTelDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DgvDepartamento.DataSource = Me.DepartamentoBindingSource
        Me.DgvDepartamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvDepartamento.Location = New System.Drawing.Point(4, 19)
        Me.DgvDepartamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvDepartamento.Name = "DgvDepartamento"
        Me.DgvDepartamento.RowHeadersWidth = 51
        Me.DgvDepartamento.RowTemplate.Height = 24
        Me.DgvDepartamento.Size = New System.Drawing.Size(675, 336)
        Me.DgvDepartamento.TabIndex = 0
        '
        'IdDepDataGridViewTextBoxColumn
        '
        Me.IdDepDataGridViewTextBoxColumn.DataPropertyName = "idDep"
        Me.IdDepDataGridViewTextBoxColumn.HeaderText = "idDep"
        Me.IdDepDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDepDataGridViewTextBoxColumn.Name = "IdDepDataGridViewTextBoxColumn"
        Me.IdDepDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDepDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDepDataGridViewTextBoxColumn
        '
        Me.NombreDepDataGridViewTextBoxColumn.DataPropertyName = "nombreDep"
        Me.NombreDepDataGridViewTextBoxColumn.HeaderText = "nombreDep"
        Me.NombreDepDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDepDataGridViewTextBoxColumn.Name = "NombreDepDataGridViewTextBoxColumn"
        Me.NombreDepDataGridViewTextBoxColumn.Width = 125
        '
        'ExtTelDataGridViewTextBoxColumn
        '
        Me.ExtTelDataGridViewTextBoxColumn.DataPropertyName = "extTel"
        Me.ExtTelDataGridViewTextBoxColumn.HeaderText = "extTel"
        Me.ExtTelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExtTelDataGridViewTextBoxColumn.Name = "ExtTelDataGridViewTextBoxColumn"
        Me.ExtTelDataGridViewTextBoxColumn.Width = 125
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "correo"
        Me.CorreoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.Width = 125
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
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
        'FrmAddDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 722)
        Me.Controls.Add(Me.GroupBox)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmAddDepartamento"
        Me.Text = "Administración de departamentos"
        Me.GroupBox.ResumeLayout(False)
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
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents DgvDepartamento As DataGridView
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As BDAsistenciasEySDataSetTableAdapters.departamentoTableAdapter
    Friend WithEvents IdDepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtTelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
