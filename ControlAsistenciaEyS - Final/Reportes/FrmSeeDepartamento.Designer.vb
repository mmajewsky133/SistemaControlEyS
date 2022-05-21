<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeeDepartamento
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDepSelct = New System.Windows.Forms.TextBox()
        Me.DgvDepartamentos = New System.Windows.Forms.DataGridView()
        Me.IddepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombredepDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExttelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ControlAsistenciaDataSet = New ControlAsistenciaEyS___Final.ControlAsistenciaDataSet()
        Me.DepartamentoTableAdapter = New ControlAsistenciaEyS___Final.ControlAsistenciaDataSetTableAdapters.DepartamentoTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnAddDep = New System.Windows.Forms.Button()
        Me.BtnSeeReport = New System.Windows.Forms.Button()
        CType(Me.DgvDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Miriam CLM", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(344, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Reporte y Manejo de Departamentos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Departamento Seleccionado:"
        '
        'TxtDepSelct
        '
        Me.TxtDepSelct.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtDepSelct.Location = New System.Drawing.Point(12, 107)
        Me.TxtDepSelct.Name = "TxtDepSelct"
        Me.TxtDepSelct.ReadOnly = True
        Me.TxtDepSelct.Size = New System.Drawing.Size(201, 30)
        Me.TxtDepSelct.TabIndex = 16
        '
        'DgvDepartamentos
        '
        Me.DgvDepartamentos.AllowUserToAddRows = False
        Me.DgvDepartamentos.AllowUserToDeleteRows = False
        Me.DgvDepartamentos.AutoGenerateColumns = False
        Me.DgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDepartamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IddepDataGridViewTextBoxColumn, Me.NombredepDataGridViewTextBoxColumn, Me.ExttelDataGridViewTextBoxColumn, Me.CorreoDataGridViewTextBoxColumn})
        Me.DgvDepartamentos.DataSource = Me.DepartamentoBindingSource
        Me.DgvDepartamentos.Location = New System.Drawing.Point(12, 182)
        Me.DgvDepartamentos.Name = "DgvDepartamentos"
        Me.DgvDepartamentos.ReadOnly = True
        Me.DgvDepartamentos.Size = New System.Drawing.Size(513, 393)
        Me.DgvDepartamentos.TabIndex = 17
        '
        'IddepDataGridViewTextBoxColumn
        '
        Me.IddepDataGridViewTextBoxColumn.DataPropertyName = "id_dep"
        Me.IddepDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IddepDataGridViewTextBoxColumn.Name = "IddepDataGridViewTextBoxColumn"
        Me.IddepDataGridViewTextBoxColumn.ReadOnly = True
        Me.IddepDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IddepDataGridViewTextBoxColumn.Width = 50
        '
        'NombredepDataGridViewTextBoxColumn
        '
        Me.NombredepDataGridViewTextBoxColumn.DataPropertyName = "nombre_dep"
        Me.NombredepDataGridViewTextBoxColumn.HeaderText = "Departamento"
        Me.NombredepDataGridViewTextBoxColumn.Name = "NombredepDataGridViewTextBoxColumn"
        Me.NombredepDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombredepDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NombredepDataGridViewTextBoxColumn.Width = 150
        '
        'ExttelDataGridViewTextBoxColumn
        '
        Me.ExttelDataGridViewTextBoxColumn.DataPropertyName = "ext_tel"
        Me.ExttelDataGridViewTextBoxColumn.HeaderText = "Extencion"
        Me.ExttelDataGridViewTextBoxColumn.Name = "ExttelDataGridViewTextBoxColumn"
        Me.ExttelDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExttelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ExttelDataGridViewTextBoxColumn.Width = 70
        '
        'CorreoDataGridViewTextBoxColumn
        '
        Me.CorreoDataGridViewTextBoxColumn.DataPropertyName = "correo"
        Me.CorreoDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.CorreoDataGridViewTextBoxColumn.Name = "CorreoDataGridViewTextBoxColumn"
        Me.CorreoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorreoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CorreoDataGridViewTextBoxColumn.Width = 200
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.ControlAsistenciaDataSet
        '
        'ControlAsistenciaDataSet
        '
        Me.ControlAsistenciaDataSet.DataSetName = "ControlAsistenciaDataSet"
        Me.ControlAsistenciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(79, 146)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(446, 30)
        Me.TxtBuscar.TabIndex = 19
        '
        'BtnAddDep
        '
        Me.BtnAddDep.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddDep.Location = New System.Drawing.Point(219, 107)
        Me.BtnAddDep.Name = "BtnAddDep"
        Me.BtnAddDep.Size = New System.Drawing.Size(306, 31)
        Me.BtnAddDep.TabIndex = 20
        Me.BtnAddDep.Text = "Asignar a un Cargo"
        Me.BtnAddDep.UseVisualStyleBackColor = True
        '
        'BtnSeeReport
        '
        Me.BtnSeeReport.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSeeReport.Location = New System.Drawing.Point(351, 581)
        Me.BtnSeeReport.Name = "BtnSeeReport"
        Me.BtnSeeReport.Size = New System.Drawing.Size(174, 31)
        Me.BtnSeeReport.TabIndex = 21
        Me.BtnSeeReport.Text = "Ver Reporte Completo"
        Me.BtnSeeReport.UseVisualStyleBackColor = True
        '
        'FrmSeeDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 618)
        Me.Controls.Add(Me.BtnSeeReport)
        Me.Controls.Add(Me.BtnAddDep)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvDepartamentos)
        Me.Controls.Add(Me.TxtDepSelct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmSeeDepartamento"
        Me.Text = "Control de Asistencias - Reporte de Departamentos"
        CType(Me.DgvDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlAsistenciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDepSelct As TextBox
    Friend WithEvents DgvDepartamentos As DataGridView
    Friend WithEvents ControlAsistenciaDataSet As ControlAsistenciaDataSet
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As ControlAsistenciaDataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents IddepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombredepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExttelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnAddDep As Button
    Friend WithEvents BtnSeeReport As Button
End Class
