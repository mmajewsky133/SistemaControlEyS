<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarcadoEyS
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
        Me.BtnEntrada = New System.Windows.Forms.Button()
        Me.BtnSalida = New System.Windows.Forms.Button()
        Me.lblCed = New System.Windows.Forms.Label()
        Me.LblWarningMarcar = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DgvAsistencia = New System.Windows.Forms.DataGridView()
        Me.IdRegDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistroAsistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Contador = New System.Windows.Forms.Timer(Me.components)
        Me.GPEmpleado = New System.Windows.Forms.GroupBox()
        Me.DgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.IdEmpDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroAsistenciaTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.registroAsistenciaTableAdapter()
        Me.EmpleadoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter()
        Me.PAdmin = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DgvAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroAsistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GPEmpleado.SuspendLayout()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEntrada
        '
        Me.BtnEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnEntrada.Location = New System.Drawing.Point(130, 213)
        Me.BtnEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEntrada.Name = "BtnEntrada"
        Me.BtnEntrada.Size = New System.Drawing.Size(184, 80)
        Me.BtnEntrada.TabIndex = 11
        Me.BtnEntrada.Text = "Marcar Entrada"
        Me.BtnEntrada.UseVisualStyleBackColor = True
        '
        'BtnSalida
        '
        Me.BtnSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSalida.Location = New System.Drawing.Point(130, 213)
        Me.BtnSalida.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalida.Name = "BtnSalida"
        Me.BtnSalida.Size = New System.Drawing.Size(184, 80)
        Me.BtnSalida.TabIndex = 12
        Me.BtnSalida.Text = "Marcar Salida"
        Me.BtnSalida.UseVisualStyleBackColor = True
        '
        'lblCed
        '
        Me.lblCed.AutoSize = True
        Me.lblCed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.lblCed.Location = New System.Drawing.Point(39, 95)
        Me.lblCed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCed.Name = "lblCed"
        Me.lblCed.Size = New System.Drawing.Size(356, 29)
        Me.lblCed.TabIndex = 19
        Me.lblCed.Text = "[ Ingrese su cedula aqui dentro ]"
        '
        'LblWarningMarcar
        '
        Me.LblWarningMarcar.AutoSize = True
        Me.LblWarningMarcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.LblWarningMarcar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblWarningMarcar.Location = New System.Drawing.Point(47, 150)
        Me.LblWarningMarcar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblWarningMarcar.Name = "LblWarningMarcar"
        Me.LblWarningMarcar.Size = New System.Drawing.Size(26, 29)
        Me.LblWarningMarcar.TabIndex = 20
        Me.LblWarningMarcar.Text = "[ "
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(81, 326)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 22
        '
        'DgvAsistencia
        '
        Me.DgvAsistencia.AutoGenerateColumns = False
        Me.DgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAsistencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRegDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.HoraEntradaDataGridViewTextBoxColumn, Me.HoraSalidaDataGridViewTextBoxColumn, Me.IdEmpDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn})
        Me.DgvAsistencia.DataSource = Me.RegistroAsistenciaBindingSource
        Me.DgvAsistencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvAsistencia.Location = New System.Drawing.Point(3, 18)
        Me.DgvAsistencia.Name = "DgvAsistencia"
        Me.DgvAsistencia.RowHeadersWidth = 51
        Me.DgvAsistencia.RowTemplate.Height = 24
        Me.DgvAsistencia.Size = New System.Drawing.Size(394, 239)
        Me.DgvAsistencia.TabIndex = 23
        '
        'IdRegDataGridViewTextBoxColumn
        '
        Me.IdRegDataGridViewTextBoxColumn.DataPropertyName = "idReg"
        Me.IdRegDataGridViewTextBoxColumn.HeaderText = "idReg"
        Me.IdRegDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdRegDataGridViewTextBoxColumn.Name = "IdRegDataGridViewTextBoxColumn"
        Me.IdRegDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdRegDataGridViewTextBoxColumn.Visible = False
        Me.IdRegDataGridViewTextBoxColumn.Width = 125
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 125
        '
        'HoraEntradaDataGridViewTextBoxColumn
        '
        Me.HoraEntradaDataGridViewTextBoxColumn.DataPropertyName = "horaEntrada"
        Me.HoraEntradaDataGridViewTextBoxColumn.HeaderText = "horaEntrada"
        Me.HoraEntradaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoraEntradaDataGridViewTextBoxColumn.Name = "HoraEntradaDataGridViewTextBoxColumn"
        Me.HoraEntradaDataGridViewTextBoxColumn.Width = 125
        '
        'HoraSalidaDataGridViewTextBoxColumn
        '
        Me.HoraSalidaDataGridViewTextBoxColumn.DataPropertyName = "horaSalida"
        Me.HoraSalidaDataGridViewTextBoxColumn.HeaderText = "horaSalida"
        Me.HoraSalidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoraSalidaDataGridViewTextBoxColumn.Name = "HoraSalidaDataGridViewTextBoxColumn"
        Me.HoraSalidaDataGridViewTextBoxColumn.Width = 125
        '
        'IdEmpDataGridViewTextBoxColumn
        '
        Me.IdEmpDataGridViewTextBoxColumn.DataPropertyName = "idEmp"
        Me.IdEmpDataGridViewTextBoxColumn.HeaderText = "idEmp"
        Me.IdEmpDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdEmpDataGridViewTextBoxColumn.Name = "IdEmpDataGridViewTextBoxColumn"
        Me.IdEmpDataGridViewTextBoxColumn.Width = 125
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "cedula"
        Me.CedulaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.Width = 125
        '
        'RegistroAsistenciaBindingSource
        '
        Me.RegistroAsistenciaBindingSource.DataMember = "registroAsistencia"
        Me.RegistroAsistenciaBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'BDAsistenciasEySDataSet
        '
        Me.BDAsistenciasEySDataSet.DataSetName = "BDAsistenciasEySDataSet"
        Me.BDAsistenciasEySDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(383, 150)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 29)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "]"
        '
        'TxtCedula
        '
        Me.TxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TxtCedula.Location = New System.Drawing.Point(63, 150)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(322, 34)
        Me.TxtCedula.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvAsistencia)
        Me.GroupBox1.Location = New System.Drawing.Point(494, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 260)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asistencias: "
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblHora.Location = New System.Drawing.Point(150, 24)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(91, 39)
        Me.lblHora.TabIndex = 27
        Me.lblHora.Text = "Hora"
        '
        'Contador
        '
        '
        'GPEmpleado
        '
        Me.GPEmpleado.Controls.Add(Me.DgvEmpleado)
        Me.GPEmpleado.Location = New System.Drawing.Point(494, 24)
        Me.GPEmpleado.Name = "GPEmpleado"
        Me.GPEmpleado.Size = New System.Drawing.Size(397, 224)
        Me.GPEmpleado.TabIndex = 28
        Me.GPEmpleado.TabStop = False
        Me.GPEmpleado.Text = "Empleado"
        '
        'DgvEmpleado
        '
        Me.DgvEmpleado.AutoGenerateColumns = False
        Me.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpDataGridViewTextBoxColumn1, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn1})
        Me.DgvEmpleado.DataSource = Me.EmpleadoBindingSource
        Me.DgvEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvEmpleado.Location = New System.Drawing.Point(3, 18)
        Me.DgvEmpleado.Name = "DgvEmpleado"
        Me.DgvEmpleado.RowHeadersWidth = 51
        Me.DgvEmpleado.RowTemplate.Height = 24
        Me.DgvEmpleado.Size = New System.Drawing.Size(391, 203)
        Me.DgvEmpleado.TabIndex = 0
        '
        'IdEmpDataGridViewTextBoxColumn1
        '
        Me.IdEmpDataGridViewTextBoxColumn1.DataPropertyName = "idEmp"
        Me.IdEmpDataGridViewTextBoxColumn1.HeaderText = "idEmp"
        Me.IdEmpDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IdEmpDataGridViewTextBoxColumn1.Name = "IdEmpDataGridViewTextBoxColumn1"
        Me.IdEmpDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdEmpDataGridViewTextBoxColumn1.Width = 125
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "nombres"
        Me.NombresDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.Width = 125
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.Width = 125
        '
        'CedulaDataGridViewTextBoxColumn1
        '
        Me.CedulaDataGridViewTextBoxColumn1.DataPropertyName = "cedula"
        Me.CedulaDataGridViewTextBoxColumn1.HeaderText = "cedula"
        Me.CedulaDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.CedulaDataGridViewTextBoxColumn1.Name = "CedulaDataGridViewTextBoxColumn1"
        Me.CedulaDataGridViewTextBoxColumn1.Width = 125
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me.BDAsistenciasEySDataSet
        '
        'RegistroAsistenciaTableAdapter
        '
        Me.RegistroAsistenciaTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'PAdmin
        '
        Me.PAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PAdmin.Location = New System.Drawing.Point(920, 493)
        Me.PAdmin.Name = "PAdmin"
        Me.PAdmin.Size = New System.Drawing.Size(37, 40)
        Me.PAdmin.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(900, 454)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Doble clic"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(902, 470)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "cuadrito"
        '
        'FrmMarcadoEyS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 554)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PAdmin)
        Me.Controls.Add(Me.GPEmpleado)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.LblWarningMarcar)
        Me.Controls.Add(Me.lblCed)
        Me.Controls.Add(Me.BtnSalida)
        Me.Controls.Add(Me.BtnEntrada)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMarcadoEyS"
        Me.Text = "Marcado de Entrada y Salida"
        CType(Me.DgvAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroAsistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GPEmpleado.ResumeLayout(False)
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEntrada As Button
    Friend WithEvents BtnSalida As Button
    Friend WithEvents lblCed As Label
    Friend WithEvents LblWarningMarcar As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DgvAsistencia As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblHora As Label
    Friend WithEvents Contador As Timer
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents RegistroAsistenciaBindingSource As BindingSource
    Friend WithEvents RegistroAsistenciaTableAdapter As BDAsistenciasEySDataSetTableAdapters.registroAsistenciaTableAdapter
    Friend WithEvents GPEmpleado As GroupBox
    Friend WithEvents DgvEmpleado As DataGridView
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents IdEmpDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdRegDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraEntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAdmin As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
