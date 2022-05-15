Public Class FrmMainAdminMenu
    Private Sub FrmMainAdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ControlAsistenciaDataSet.Empleados' table. You can move, or remove it, as needed.
        Me.EmpleadosTableAdapter.Fill(Me.ControlAsistenciaDataSet.Empleados)

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        FrmAdminLogin.Show()
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ReporteDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeEmpleadosToolStripMenuItem.Click
        If (Not FrmSeeEmpleado.Visible) Then
            FrmSeeEmpleado.Show()
        Else
            FrmSeeEmpleado.Mostrar()
        End If
    End Sub

    Private Sub GestionDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeEmpleadosToolStripMenuItem.Click
        If (Not FrmAddEmpleado.Visible) Then
            FrmAddEmpleado.Show()
        Else
            FrmAddEmpleado.Mostrar()
        End If
    End Sub

    Private Sub SistemaEySToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SistemaEySToolStripMenuItem.Click
        FrmMarcadoEyS.Show()
    End Sub
End Class