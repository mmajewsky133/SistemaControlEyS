Public Class FrmMainAdminMenu
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        FrmVistaPrevia.Show()
    End Sub

    Private Sub ManejoDeCargoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManejoDeCargosToolStripMenuItem.Click
        FrmCargos.Show()
    End Sub

    Private Sub ControlDeAsistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeAsistenciaToolStripMenuItem.Click
        FrmEmpLogin_.Show()
    End Sub
End Class
