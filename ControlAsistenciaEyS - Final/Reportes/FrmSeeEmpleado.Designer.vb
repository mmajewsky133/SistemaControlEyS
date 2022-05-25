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
        Me.DgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.IdEmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoInstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefEmpleados5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvEmpleados
        '
        Me.DgvEmpleados.AllowUserToAddRows = False
        Me.DgvEmpleados.AllowUserToDeleteRows = False
        Me.DgvEmpleados.AutoGenerateColumns = False
        Me.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.CorreoInstDataGridViewTextBoxColumn})
        Me.DgvEmpleados.DataSource = Me.EmpleadoBindingSource
        Me.DgvEmpleados.Location = New System.Drawing.Point(8, 23)
        Me.DgvEmpleados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DgvEmpleados.Name = "DgvEmpleados"
        Me.DgvEmpleados.ReadOnly = True
        Me.DgvEmpleados.RowHeadersWidth = 51
        Me.DgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmpleados.Size = New System.Drawing.Size(1017, 484)
        Me.DgvEmpleados.TabIndex = 0
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
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Nombre de Usuario"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UsernameDataGridViewTextBoxColumn.Width = 140
        '
        'CorreoInstDataGridViewTextBoxColumn
        '
        Me.CorreoInstDataGridViewTextBoxColumn.DataPropertyName = "correoInst"
        Me.CorreoInstDataGridViewTextBoxColumn.HeaderText = "Correo Institucional"
        Me.CorreoInstDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CorreoInstDataGridViewTextBoxColumn.Name = "CorreoInstDataGridViewTextBoxColumn"
        Me.CorreoInstDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoInstDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CorreoInstDataGridViewTextBoxColumn.Width = 140
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvEmpleados)
        Me.GroupBox1.Controls.Add(Me.BtnSeeReport)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 242)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1033, 562)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'FrmSeeEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 822)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnAddCargos)
        Me.Controls.Add(Me.TxtEmpSelct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmSeeEmpleado"
        Me.Text = "Control de Asistencias - Reporte de Empleados"
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefEmpleados5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvEmpleados As DataGridView
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdEmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoInstDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
