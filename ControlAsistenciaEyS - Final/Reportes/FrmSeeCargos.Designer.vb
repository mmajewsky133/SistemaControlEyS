<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeeCargos
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAddDep = New System.Windows.Forms.Button()
        Me.TxtEmpSelct = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAddRol = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Miriam CLM", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Reporte y Manejo de Cargos"
        '
        'BtnAddDep
        '
        Me.BtnAddDep.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddDep.Location = New System.Drawing.Point(196, 80)
        Me.BtnAddDep.Name = "BtnAddDep"
        Me.BtnAddDep.Size = New System.Drawing.Size(189, 31)
        Me.BtnAddDep.TabIndex = 16
        Me.BtnAddDep.Text = "Asignar Departamento"
        Me.BtnAddDep.UseVisualStyleBackColor = True
        '
        'TxtEmpSelct
        '
        Me.TxtEmpSelct.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtEmpSelct.Location = New System.Drawing.Point(16, 80)
        Me.TxtEmpSelct.Name = "TxtEmpSelct"
        Me.TxtEmpSelct.ReadOnly = True
        Me.TxtEmpSelct.Size = New System.Drawing.Size(174, 30)
        Me.TxtEmpSelct.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cargo Seleccionado:"
        '
        'BtnAddRol
        '
        Me.BtnAddRol.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.BtnAddRol.Location = New System.Drawing.Point(391, 80)
        Me.BtnAddRol.Name = "BtnAddRol"
        Me.BtnAddRol.Size = New System.Drawing.Size(174, 31)
        Me.BtnAddRol.TabIndex = 18
        Me.BtnAddRol.Text = "Asignar Empleado"
        Me.BtnAddRol.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(79, 127)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(666, 30)
        Me.TxtBuscar.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Miriam CLM", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Buscar:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(797, 257)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(791, 238)
        Me.DataGridView1.TabIndex = 0
        '
        'FrmSeeCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnAddRol)
        Me.Controls.Add(Me.BtnAddDep)
        Me.Controls.Add(Me.TxtEmpSelct)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmSeeCargos"
        Me.Text = "FrmSeeCargos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAddDep As Button
    Friend WithEvents TxtEmpSelct As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAddRol As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
