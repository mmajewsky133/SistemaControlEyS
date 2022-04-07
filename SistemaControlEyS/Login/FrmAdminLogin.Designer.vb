<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminLogin
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtUsuarioAdmin = New System.Windows.Forms.TextBox()
        Me.TxtPwAdmin = New System.Windows.Forms.TextBox()
        Me.BtnSalirAdmin = New System.Windows.Forms.Button()
        Me.BtnIngresarAdmin = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(228, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Acceso de Administradores"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ID Usuario: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(62, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "PIN: "
        '
        'TxtUsuarioAdmin
        '
        Me.TxtUsuarioAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuarioAdmin.Location = New System.Drawing.Point(118, 82)
        Me.TxtUsuarioAdmin.Name = "TxtUsuarioAdmin"
        Me.TxtUsuarioAdmin.Size = New System.Drawing.Size(198, 26)
        Me.TxtUsuarioAdmin.TabIndex = 3
        '
        'TxtPwAdmin
        '
        Me.TxtPwAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPwAdmin.Location = New System.Drawing.Point(118, 125)
        Me.TxtPwAdmin.Name = "TxtPwAdmin"
        Me.TxtPwAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPwAdmin.Size = New System.Drawing.Size(198, 26)
        Me.TxtPwAdmin.TabIndex = 4
        '
        'BtnSalirAdmin
        '
        Me.BtnSalirAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalirAdmin.Location = New System.Drawing.Point(220, 178)
        Me.BtnSalirAdmin.Name = "BtnSalirAdmin"
        Me.BtnSalirAdmin.Size = New System.Drawing.Size(96, 31)
        Me.BtnSalirAdmin.TabIndex = 5
        Me.BtnSalirAdmin.Text = "Salir"
        Me.BtnSalirAdmin.UseVisualStyleBackColor = True
        '
        'BtnIngresarAdmin
        '
        Me.BtnIngresarAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresarAdmin.Location = New System.Drawing.Point(92, 178)
        Me.BtnIngresarAdmin.Name = "BtnIngresarAdmin"
        Me.BtnIngresarAdmin.Size = New System.Drawing.Size(96, 31)
        Me.BtnIngresarAdmin.TabIndex = 6
        Me.BtnIngresarAdmin.Text = "Ingresar"
        Me.BtnIngresarAdmin.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemaControlEyS.My.Resources.Resources._747305
        Me.PictureBox2.Location = New System.Drawing.Point(347, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(188, 180)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'FrmAdminLogin
        '
        Me.ClientSize = New System.Drawing.Size(535, 228)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnIngresarAdmin)
        Me.Controls.Add(Me.BtnSalirAdmin)
        Me.Controls.Add(Me.TxtPwAdmin)
        Me.Controls.Add(Me.TxtUsuarioAdmin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FrmAdminLogin"
        Me.Text = "Control de Asistencia"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtPw As TextBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtUsuarioAdmin As TextBox
    Friend WithEvents TxtPwAdmin As TextBox
    Friend WithEvents BtnSalirAdmin As Button
    Friend WithEvents BtnIngresarAdmin As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
