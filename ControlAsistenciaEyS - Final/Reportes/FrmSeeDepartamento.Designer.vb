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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDAsistenciasEySDataSet = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnAddDep = New System.Windows.Forms.Button()
        Me.BtnSeeReport = New System.Windows.Forms.Button()
        Me.DepartamentoTableAdapter = New ControlAsistenciaEyS___Final.BDAsistenciasEySDataSetTableAdapters.departamentoTableAdapter()
        CType(Me.DgvDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(490, 31)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Reporte y Manejo de Departamentos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 29)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Departamento Seleccionado:"
        '
        'TxtDepSelct
        '
        Me.TxtDepSelct.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtDepSelct.Location = New System.Drawing.Point(16, 132)
        Me.TxtDepSelct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDepSelct.Name = "TxtDepSelct"
        Me.TxtDepSelct.ReadOnly = True
        Me.TxtDepSelct.Size = New System.Drawing.Size(267, 34)
        Me.TxtDepSelct.TabIndex = 16
        '
        'DgvDepartamentos
        '
        Me.DgvDepartamentos.AllowUserToAddRows = False
        Me.DgvDepartamentos.AllowUserToDeleteRows = False
        Me.DgvDepartamentos.AutoGenerateColumns = False
        Me.DgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDepartamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DgvDepartamentos.DataSource = Me.DepartamentoBindingSource
        Me.DgvDepartamentos.Location = New System.Drawing.Point(16, 224)
        Me.DgvDepartamentos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DgvDepartamentos.Name = "DgvDepartamentos"
        Me.DgvDepartamentos.ReadOnly = True
        Me.DgvDepartamentos.RowHeadersWidth = 51
        Me.DgvDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDepartamentos.Size = New System.Drawing.Size(684, 484)
        Me.DgvDepartamentos.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idDep"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombreDep"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Departamento"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "extTel"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Extension de Telefono"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "correo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Correo"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "departamento"
        Me.DepartamentoBindingSource.DataSource = Me.BDAsistenciasEySDataSetBindingSource
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 183)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 29)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(105, 180)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(593, 34)
        Me.TxtBuscar.TabIndex = 19
        '
        'BtnAddDep
        '
        Me.BtnAddDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddDep.Location = New System.Drawing.Point(292, 132)
        Me.BtnAddDep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAddDep.Name = "BtnAddDep"
        Me.BtnAddDep.Size = New System.Drawing.Size(408, 38)
        Me.BtnAddDep.TabIndex = 20
        Me.BtnAddDep.Text = "Asignar a un Cargo"
        Me.BtnAddDep.UseVisualStyleBackColor = True
        '
        'BtnSeeReport
        '
        Me.BtnSeeReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnSeeReport.Location = New System.Drawing.Point(468, 715)
        Me.BtnSeeReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSeeReport.Name = "BtnSeeReport"
        Me.BtnSeeReport.Size = New System.Drawing.Size(232, 38)
        Me.BtnSeeReport.TabIndex = 21
        Me.BtnSeeReport.Text = "Ver Reporte Completo"
        Me.BtnSeeReport.UseVisualStyleBackColor = True
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'FrmSeeDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 761)
        Me.Controls.Add(Me.BtnSeeReport)
        Me.Controls.Add(Me.BtnAddDep)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvDepartamentos)
        Me.Controls.Add(Me.TxtDepSelct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmSeeDepartamento"
        Me.Text = "Control de Asistencias - Reporte de Departamentos"
        CType(Me.DgvDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDAsistenciasEySDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDepSelct As TextBox
    Friend WithEvents DgvDepartamentos As DataGridView
    Friend WithEvents IddepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombredepDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExttelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CorreoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnAddDep As Button
    Friend WithEvents BtnSeeReport As Button
    Friend WithEvents BDAsistenciasEySDataSetBindingSource As BindingSource
    Friend WithEvents BDAsistenciasEySDataSet As BDAsistenciasEySDataSet
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As BDAsistenciasEySDataSetTableAdapters.departamentoTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
