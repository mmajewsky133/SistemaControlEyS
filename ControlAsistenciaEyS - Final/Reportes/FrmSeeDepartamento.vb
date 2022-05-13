Public Class FrmSeeDepartamento
    Private Sub FrmSeeDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ControlAsistenciaDataSet.Departamento' table. You can move, or remove it, as needed.
        Me.DepartamentoTableAdapter.Fill(Me.ControlAsistenciaDataSet.Departamento)
    End Sub
End Class