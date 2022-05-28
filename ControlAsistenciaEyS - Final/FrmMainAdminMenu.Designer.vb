<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMainAdminMenu
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeDepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeDepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManejoDeOpcionesAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemaEySToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EmpleadoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter()
        Me.IdEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoInstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.CorreoInstDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmpleadoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 250)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(911, 414)
        Me.DataGridView1.TabIndex = 0
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
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.GestionToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.SistemaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1101, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeEmpleadosToolStripMenuItem, Me.ReporteDeCargosToolStripMenuItem, Me.ReporteDeDepartamentosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteDeEmpleadosToolStripMenuItem
        '
        Me.ReporteDeEmpleadosToolStripMenuItem.Name = "ReporteDeEmpleadosToolStripMenuItem"
        Me.ReporteDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.ReporteDeEmpleadosToolStripMenuItem.Text = "Reporte de Empleados"
        '
        'ReporteDeCargosToolStripMenuItem
        '
        Me.ReporteDeCargosToolStripMenuItem.Name = "ReporteDeCargosToolStripMenuItem"
        Me.ReporteDeCargosToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.ReporteDeCargosToolStripMenuItem.Text = "Reporte de Cargos"
        '
        'ReporteDeDepartamentosToolStripMenuItem
        '
        Me.ReporteDeDepartamentosToolStripMenuItem.Name = "ReporteDeDepartamentosToolStripMenuItem"
        Me.ReporteDeDepartamentosToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.ReporteDeDepartamentosToolStripMenuItem.Text = "Reporte de Departamentos"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeEmpleadosToolStripMenuItem, Me.GestionDeCargosToolStripMenuItem, Me.GestionDeDepartamentosToolStripMenuItem})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'GestionDeEmpleadosToolStripMenuItem
        '
        Me.GestionDeEmpleadosToolStripMenuItem.Name = "GestionDeEmpleadosToolStripMenuItem"
        Me.GestionDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.GestionDeEmpleadosToolStripMenuItem.Text = "Gestion de Empleados"
        '
        'GestionDeCargosToolStripMenuItem
        '
        Me.GestionDeCargosToolStripMenuItem.Name = "GestionDeCargosToolStripMenuItem"
        Me.GestionDeCargosToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.GestionDeCargosToolStripMenuItem.Text = "Gestion de Cargos"
        '
        'GestionDeDepartamentosToolStripMenuItem
        '
        Me.GestionDeDepartamentosToolStripMenuItem.Name = "GestionDeDepartamentosToolStripMenuItem"
        Me.GestionDeDepartamentosToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.GestionDeDepartamentosToolStripMenuItem.Text = "Gestion de Departamentos"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManejoDeOpcionesAdminToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ManejoDeOpcionesAdminToolStripMenuItem
        '
        Me.ManejoDeOpcionesAdminToolStripMenuItem.Name = "ManejoDeOpcionesAdminToolStripMenuItem"
        Me.ManejoDeOpcionesAdminToolStripMenuItem.Size = New System.Drawing.Size(287, 26)
        Me.ManejoDeOpcionesAdminToolStripMenuItem.Text = "Manejo de Opciones (Admin)"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaEySToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'SistemaEySToolStripMenuItem
        '
        Me.SistemaEySToolStripMenuItem.Name = "SistemaEySToolStripMenuItem"
        Me.SistemaEySToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.SistemaEySToolStripMenuItem.Text = "Sistema EyS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Acceso Rapido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 209)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscar:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(121, 206)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(804, 34)
        Me.TextBox1.TabIndex = 6
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'IdEmpDataGridViewTextBoxColumn
        '
        Me.IdEmpDataGridViewTextBoxColumn.DataPropertyName = "idEmp"
        Me.IdEmpDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdEmpDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdEmpDataGridViewTextBoxColumn.Name = "IdEmpDataGridViewTextBoxColumn"
        Me.IdEmpDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdEmpDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdEmpDataGridViewTextBoxColumn.Width = 40
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
        'FrmMainAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 678)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmMainAdminMenu"
        Me.Text = "Control de Asistencias - Panel de Control"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeCargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteDeDepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeCargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeDepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SistemaEySToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManejoDeOpcionesAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BDAsistenciasEySDataSetBindingSource As BindingSource
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoInstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
