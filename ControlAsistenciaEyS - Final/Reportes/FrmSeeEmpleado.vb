Public Class FrmSeeEmpleado
    Private Sub FrmSeeEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ControlAsistenciaDataSet.Empleados' table. You can move, or remove it, as needed.
        Me.EmpleadosTableAdapter.Fill(Me.ControlAsistenciaDataSet.Empleados)

    End Sub
    Sub Mostrar()
        Me.Focus()
    End Sub

End Class