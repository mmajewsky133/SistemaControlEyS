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
        Me.IdEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fotoEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoInstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PwpinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnNewEmp = New System.Windows.Forms.Button()
        Me.BtnGuardarEmp = New System.Windows.Forms.Button()
        Me.BtnEditarEmp = New System.Windows.Forms.Button()
        Me.BtnEliminarEmp = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTPNac = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EmpleadoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter()
        Me.BtnAsignar = New System.Windows.Forms.Button()
        CType(Me.PBEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 31)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Gestion de Empleados"
        '
        'PBEmp
        '
        Me.PBEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBEmp.Location = New System.Drawing.Point(21, 102)
        Me.PBEmp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PBEmp.Name = "PBEmp"
        Me.PBEmp.Size = New System.Drawing.Size(253, 225)
        Me.PBEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBEmp.TabIndex = 15
        Me.PBEmp.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 29)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Foto de Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(283, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 29)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre Completo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label5.Location = New System.Drawing.Point(283, 176)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 29)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Cedula:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label6.Location = New System.Drawing.Point(487, 176)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 29)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Correo Personal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label7.Location = New System.Drawing.Point(487, 261)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(226, 29)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Correo Institucional:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label8.Location = New System.Drawing.Point(283, 261)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 29)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Telefono:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 342)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 29)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Direccion:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(288, 102)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(265, 34)
        Me.TxtNombre.TabIndex = 26
        '
        'TxtApellido
        '
        Me.TxtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(563, 102)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(265, 34)
        Me.TxtApellido.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label11.Location = New System.Drawing.Point(284, 143)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Nombres"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label12.Location = New System.Drawing.Point(559, 143)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 20)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Apellidos"
        '
        'TxtCedula
        '
        Me.TxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtCedula.Location = New System.Drawing.Point(288, 206)
        Me.TxtCedula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(195, 34)
        Me.TxtCedula.TabIndex = 30
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(492, 206)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(336, 34)
        Me.TxtCorreo.TabIndex = 31
        '
        'TxtTel
        '
        Me.TxtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(288, 290)
        Me.TxtTel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(195, 34)
        Me.TxtTel.TabIndex = 32
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(21, 372)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(807, 34)
        Me.TxtDireccion.TabIndex = 33
        '
        'TxtCorreoInst
        '
        Me.TxtCorreoInst.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtCorreoInst.Location = New System.Drawing.Point(492, 290)
        Me.TxtCorreoInst.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCorreoInst.Name = "TxtCorreoInst"
        Me.TxtCorreoInst.Size = New System.Drawing.Size(336, 34)
        Me.TxtCorreoInst.TabIndex = 34
        '
        'DgvEmpleado
        '
        Me.DgvEmpleado.AllowUserToAddRows = False
        Me.DgvEmpleado.AllowUserToDeleteRows = False
        Me.DgvEmpleado.AutoGenerateColumns = False
        Me.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.fotoEmp, Me.fechaNac, Me.DireccionDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn, Me.CorreoInstDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PwpinDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DgvEmpleado.DataSource = Me.EmpleadoBindingSource
        Me.DgvEmpleado.Location = New System.Drawing.Point(20, 46)
        Me.DgvEmpleado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DgvEmpleado.Name = "DgvEmpleado"
        Me.DgvEmpleado.ReadOnly = True
        Me.DgvEmpleado.RowHeadersWidth = 51
        Me.DgvEmpleado.Size = New System.Drawing.Size(768, 217)
        Me.DgvEmpleado.TabIndex = 35
        '
        'IdEmpDataGridViewTextBoxColumn
        '
        Me.IdEmpDataGridViewTextBoxColumn.DataPropertyName = "idEmp"
        Me.IdEmpDataGridViewTextBoxColumn.HeaderText = "idEmp"
        Me.IdEmpDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdEmpDataGridViewTextBoxColumn.Name = "IdEmpDataGridViewTextBoxColumn"
        Me.IdEmpDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEmpDataGridViewTextBoxColumn.Width = 125
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "nombres"
        Me.NombresDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombresDataGridViewTextBoxColumn.Width = 125
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidosDataGridViewTextBoxColumn.Width = 125
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.fechaNac.Width = 125
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.Width = 125
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Width = 125
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "correo"
        Me.CorreoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoDataGridViewTextBoxColumn.Width = 125
        '
        'CorreoInstDataGridViewTextBoxColumn
        '
        Me.CorreoInstDataGridViewTextBoxColumn.DataPropertyName = "correoInst"
        Me.CorreoInstDataGridViewTextBoxColumn.HeaderText = "correoInst"
        Me.CorreoInstDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoInstDataGridViewTextBoxColumn.Name = "CorreoInstDataGridViewTextBoxColumn"
        Me.CorreoInstDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoInstDataGridViewTextBoxColumn.Width = 125
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameDataGridViewTextBoxColumn.Width = 125
        '
        'PwpinDataGridViewTextBoxColumn
        '
        Me.PwpinDataGridViewTextBoxColumn.DataPropertyName = "pwpin"
        Me.PwpinDataGridViewTextBoxColumn.HeaderText = "pwpin"
        Me.PwpinDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PwpinDataGridViewTextBoxColumn.Name = "PwpinDataGridViewTextBoxColumn"
        Me.PwpinDataGridViewTextBoxColumn.ReadOnly = True
        Me.PwpinDataGridViewTextBoxColumn.Width = 125
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Width = 125
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
        Me.Label4.Location = New System.Drawing.Point(17, 526)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 29)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Buscar:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(117, 526)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(333, 34)
        Me.TxtBuscar.TabIndex = 37
        '
        'BtnNewEmp
        '
        Me.BtnNewEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnNewEmp.Location = New System.Drawing.Point(719, 14)
        Me.BtnNewEmp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNewEmp.Name = "BtnNewEmp"
        Me.BtnNewEmp.Size = New System.Drawing.Size(103, 37)
        Me.BtnNewEmp.TabIndex = 38
        Me.BtnNewEmp.Text = "Nuevo"
        Me.BtnNewEmp.UseVisualStyleBackColor = True
        '
        'BtnGuardarEmp
        '
        Me.BtnGuardarEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnGuardarEmp.Location = New System.Drawing.Point(469, 524)
        Me.BtnGuardarEmp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardarEmp.Name = "BtnGuardarEmp"
        Me.BtnGuardarEmp.Size = New System.Drawing.Size(125, 37)
        Me.BtnGuardarEmp.TabIndex = 39
        Me.BtnGuardarEmp.Text = "Guardar"
        Me.BtnGuardarEmp.UseVisualStyleBackColor = True
        '
        'BtnEditarEmp
        '
        Me.BtnEditarEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnEditarEmp.Location = New System.Drawing.Point(603, 526)
        Me.BtnEditarEmp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEditarEmp.Name = "BtnEditarEmp"
        Me.BtnEditarEmp.Size = New System.Drawing.Size(109, 37)
        Me.BtnEditarEmp.TabIndex = 40
        Me.BtnEditarEmp.Text = "Editar"
        Me.BtnEditarEmp.UseVisualStyleBackColor = True
        '
        'BtnEliminarEmp
        '
        Me.BtnEliminarEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnEliminarEmp.Location = New System.Drawing.Point(719, 526)
        Me.BtnEliminarEmp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminarEmp.Name = "BtnEliminarEmp"
        Me.BtnEliminarEmp.Size = New System.Drawing.Size(121, 37)
        Me.BtnEliminarEmp.TabIndex = 41
        Me.BtnEliminarEmp.Text = "Eliminar"
        Me.BtnEliminarEmp.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvEmpleado)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 590)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(805, 286)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DTPNac
        '
        Me.DTPNac.CustomFormat = "dd-MM-yyyy"
        Me.DTPNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.DTPNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPNac.Location = New System.Drawing.Point(22, 460)
        Me.DTPNac.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTPNac.Name = "DTPNac"
        Me.DTPNac.Size = New System.Drawing.Size(161, 34)
        Me.DTPNac.TabIndex = 43
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(17, 429)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(243, 29)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Fecha de nacimiento:"
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'BtnAsignar
        '
        Me.BtnAsignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.BtnAsignar.Location = New System.Drawing.Point(374, 13)
        Me.BtnAsignar.Name = "BtnAsignar"
        Me.BtnAsignar.Size = New System.Drawing.Size(270, 38)
        Me.BtnAsignar.TabIndex = 45
        Me.BtnAsignar.Text = "Asignar cargo"
        Me.BtnAsignar.UseVisualStyleBackColor = True
        '
        'FrmAddEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 890)
        Me.Controls.Add(Me.BtnAsignar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DTPNac)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmAddEmpleado"
        Me.Text = "Gestor de empleados"
        CType(Me.PBEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BDAsistenciasEySDataSetBindingSource As BindingSource
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents FotoEmpDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents FechaNacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DTPNac As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents IdEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents fotoEmp As DataGridViewTextBoxColumn
    Friend WithEvents fechaNac As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoInstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PwpinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnAsignar As Button
End Class
