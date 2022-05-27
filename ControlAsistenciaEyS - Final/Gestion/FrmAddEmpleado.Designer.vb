<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddEmpleado
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PBEmp = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtCorreoInst = New System.Windows.Forms.TextBox()
        Me.DgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.idEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fotoEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoInstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnNewEmp = New System.Windows.Forms.Button()
        Me.BtnGuardarEmp = New System.Windows.Forms.Button()
        Me.BtnEditarEmp = New System.Windows.Forms.Button()
        Me.BtnEliminarEmp = New System.Windows.Forms.Button()
        Me.GBEmpleado = New System.Windows.Forms.GroupBox()
        Me.DTPNac = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnAsignar = New System.Windows.Forms.Button()
        Me.EmpleadoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        CType(Me.PBEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBEmpleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Gestion de Empleados"
        '
        'PBEmp
        '
        Me.PBEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBEmp.InitialImage = Nothing
        Me.PBEmp.Location = New System.Drawing.Point(16, 98)
        Me.PBEmp.Name = "PBEmp"
        Me.PBEmp.Size = New System.Drawing.Size(190, 183)
        Me.PBEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBEmp.TabIndex = 15
        Me.PBEmp.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Foto (Dar doble clic):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre Completo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label5.Location = New System.Drawing.Point(212, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Cedula:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label6.Location = New System.Drawing.Point(365, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Correo Personal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label7.Location = New System.Drawing.Point(365, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 24)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Correo Institucional:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label8.Location = New System.Drawing.Point(212, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 24)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Telefono:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 24)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Direccion:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(216, 98)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(200, 29)
        Me.TxtNombre.TabIndex = 26
        '
        'TxtApellido
        '
        Me.TxtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(422, 98)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(200, 29)
        Me.TxtApellido.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label11.Location = New System.Drawing.Point(213, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 16)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Nombres"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label12.Location = New System.Drawing.Point(419, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Apellidos"
        '
        'TxtCedula
        '
        Me.TxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtCedula.Location = New System.Drawing.Point(216, 182)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(147, 29)
        Me.TxtCedula.TabIndex = 30
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(369, 182)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(253, 29)
        Me.TxtCorreo.TabIndex = 31
        '
        'TxtTel
        '
        Me.TxtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(216, 251)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(147, 29)
        Me.TxtTel.TabIndex = 32
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(16, 317)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(606, 29)
        Me.TxtDireccion.TabIndex = 33
        '
        'TxtCorreoInst
        '
        Me.TxtCorreoInst.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtCorreoInst.Location = New System.Drawing.Point(369, 251)
        Me.TxtCorreoInst.Name = "TxtCorreoInst"
        Me.TxtCorreoInst.Size = New System.Drawing.Size(253, 29)
        Me.TxtCorreoInst.TabIndex = 34
        '
        'DgvEmpleado
        '
        Me.DgvEmpleado.AllowUserToAddRows = False
        Me.DgvEmpleado.AllowUserToDeleteRows = False
        Me.DgvEmpleado.AutoGenerateColumns = False
        Me.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmp, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.fotoEmp, Me.fechaNac, Me.DireccionDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.CorreoInstDataGridViewTextBoxColumn})
        Me.DgvEmpleado.DataSource = Me.EmpleadoBindingSource
        Me.DgvEmpleado.Location = New System.Drawing.Point(15, 18)
        Me.DgvEmpleado.Name = "DgvEmpleado"
        Me.DgvEmpleado.ReadOnly = True
        Me.DgvEmpleado.RowHeadersWidth = 51
        Me.DgvEmpleado.Size = New System.Drawing.Size(576, 197)
        Me.DgvEmpleado.TabIndex = 35
        '
        'idEmp
        '
        Me.idEmp.DataPropertyName = "idEmp"
        Me.idEmp.HeaderText = "ID"
        Me.idEmp.MinimumWidth = 6
        Me.idEmp.Name = "idEmp"
        Me.idEmp.ReadOnly = True
        Me.idEmp.Visible = False
        Me.idEmp.Width = 125
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombresDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NombresDataGridViewTextBoxColumn.Width = 125
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidosDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ApellidosDataGridViewTextBoxColumn.Width = 125
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CedulaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CedulaDataGridViewTextBoxColumn.Width = 125
        '
        'fotoEmp
        '
        Me.fotoEmp.DataPropertyName = "fotoEmp"
        Me.fotoEmp.HeaderText = "fotoEmp"
        Me.fotoEmp.MinimumWidth = 6
        Me.fotoEmp.Name = "fotoEmp"
        Me.fotoEmp.ReadOnly = True
        Me.fotoEmp.Visible = False
        Me.fotoEmp.Width = 125
        '
        'fechaNac
        '
        Me.fechaNac.DataPropertyName = "fechaNac"
        Me.fechaNac.HeaderText = "fechaNac"
        Me.fechaNac.MinimumWidth = 6
        Me.fechaNac.Name = "fechaNac"
        Me.fechaNac.ReadOnly = True
        Me.fechaNac.Visible = False
        Me.fechaNac.Width = 125
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DireccionDataGridViewTextBoxColumn.Width = 150
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TelefonoDataGridViewTextBoxColumn.Width = 125
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CorreoDataGridViewTextBoxColumn.Width = 125
        '
        'CorreoInstDataGridViewTextBoxColumn
        '
        Me.CorreoInstDataGridViewTextBoxColumn.DataPropertyName = "correoInst"
        Me.CorreoInstDataGridViewTextBoxColumn.HeaderText = "Correo Institucional"
        Me.CorreoInstDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoInstDataGridViewTextBoxColumn.Name = "CorreoInstDataGridViewTextBoxColumn"
        Me.CorreoInstDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoInstDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CorreoInstDataGridViewTextBoxColumn.Width = 150
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me.BDAsistenciasEySDataSetBindingSource
        '
        'BDAsistenciasEySDataSetBindingSource
        '
        Me.BDAsistenciasEySDataSetBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        Me.BDAsistenciasEySDataSetBindingSource.Position = 0
        '
        'BDAsistenciasEySDataSet
        '
        Me.BDAsistenciasEySDataSet.DataSetName = "BDAsistenciasEySDataSet"
        Me.BDAsistenciasEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 482)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 24)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Buscar:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(88, 479)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(214, 29)
        Me.TxtBuscar.TabIndex = 37
        '
        'BtnNewEmp
        '
        Me.BtnNewEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnNewEmp.Location = New System.Drawing.Point(449, 364)
        Me.BtnNewEmp.Name = "BtnNewEmp"
        Me.BtnNewEmp.Size = New System.Drawing.Size(173, 57)
        Me.BtnNewEmp.TabIndex = 38
        Me.BtnNewEmp.Text = "Limpiar Campos"
        Me.BtnNewEmp.UseVisualStyleBackColor = True
        '
        'BtnGuardarEmp
        '
        Me.BtnGuardarEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnGuardarEmp.Location = New System.Drawing.Point(308, 479)
        Me.BtnGuardarEmp.Name = "BtnGuardarEmp"
        Me.BtnGuardarEmp.Size = New System.Drawing.Size(108, 30)
        Me.BtnGuardarEmp.TabIndex = 39
        Me.BtnGuardarEmp.Text = "Guardar"
        Me.BtnGuardarEmp.UseVisualStyleBackColor = True
        '
        'BtnEditarEmp
        '
        Me.BtnEditarEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnEditarEmp.Location = New System.Drawing.Point(422, 479)
        Me.BtnEditarEmp.Name = "BtnEditarEmp"
        Me.BtnEditarEmp.Size = New System.Drawing.Size(95, 30)
        Me.BtnEditarEmp.TabIndex = 40
        Me.BtnEditarEmp.Text = "Editar"
        Me.BtnEditarEmp.UseVisualStyleBackColor = True
        '
        'BtnEliminarEmp
        '
        Me.BtnEliminarEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnEliminarEmp.Location = New System.Drawing.Point(523, 478)
        Me.BtnEliminarEmp.Name = "BtnEliminarEmp"
        Me.BtnEliminarEmp.Size = New System.Drawing.Size(99, 30)
        Me.BtnEliminarEmp.TabIndex = 41
        Me.BtnEliminarEmp.Text = "Eliminar"
        Me.BtnEliminarEmp.UseVisualStyleBackColor = True
        '
        'GBEmpleado
        '
        Me.GBEmpleado.Controls.Add(Me.DgvEmpleado)
        Me.GBEmpleado.Location = New System.Drawing.Point(16, 534)
        Me.GBEmpleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GBEmpleado.Name = "GBEmpleado"
        Me.GBEmpleado.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GBEmpleado.Size = New System.Drawing.Size(606, 233)
        Me.GBEmpleado.TabIndex = 42
        Me.GBEmpleado.TabStop = False
        Me.GBEmpleado.Text = "Lista de Empleados"
        '
        'DTPNac
        '
        Me.DTPNac.CustomFormat = "dd-MM-yyyy"
        Me.DTPNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.DTPNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPNac.Location = New System.Drawing.Point(16, 392)
        Me.DTPNac.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DTPNac.Name = "DTPNac"
        Me.DTPNac.Size = New System.Drawing.Size(182, 29)
        Me.DTPNac.TabIndex = 43
        Me.DTPNac.Value = New Date(2022, 5, 22, 22, 9, 58, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(13, 363)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(193, 24)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Fecha de nacimiento:"
        '
        'BtnAsignar
        '
        Me.BtnAsignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.BtnAsignar.Location = New System.Drawing.Point(210, 364)
        Me.BtnAsignar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnAsignar.Name = "BtnAsignar"
        Me.BtnAsignar.Size = New System.Drawing.Size(234, 57)
        Me.BtnAsignar.TabIndex = 45
        Me.BtnAsignar.Text = "Asignar cargo"
        Me.BtnAsignar.UseVisualStyleBackColor = True
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnRegresar.Location = New System.Drawing.Point(483, 21)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(139, 33)
        Me.BtnRegresar.TabIndex = 46
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'FrmAddEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 783)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnAsignar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DTPNac)
        Me.Controls.Add(Me.GBEmpleado)
        Me.Controls.Add(Me.BtnEliminarEmp)
        Me.Controls.Add(Me.BtnEditarEmp)
        Me.Controls.Add(Me.BtnGuardarEmp)
        Me.Controls.Add(Me.BtnNewEmp)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCorreoInst)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.TxtTel)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBEmp)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmAddEmpleado"
        Me.Text = "Gestor de empleados"
        CType(Me.PBEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBEmpleado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents PBEmp As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtCorreoInst As TextBox
    Friend WithEvents DgvEmpleado As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnNewEmp As Button
    Friend WithEvents BtnGuardarEmp As Button
    Friend WithEvents BtnEditarEmp As Button
    Friend WithEvents BtnEliminarEmp As Button
    Friend WithEvents GBEmpleado As GroupBox
    Friend WithEvents BDAsistenciasEySDataSetBindingSource As BindingSource
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents FotoEmpDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents FechaNacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DTPNac As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnAsignar As Button
    Friend WithEvents idEmp As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents fotoEmp As DataGridViewTextBoxColumn
    Friend WithEvents fechaNac As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoInstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnRegresar As Button
End Class
