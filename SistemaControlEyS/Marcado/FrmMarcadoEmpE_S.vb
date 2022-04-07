Public Class FrmMarcadoEmpE_S
    Private Sub BtnCerrarSesEmp_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesEmp.Click
        FrmEmpLogin_.Show()
        Me.Close()
    End Sub

    Private Sub BtnMarcar_Click(sender As Object, e As EventArgs) Handles BtnMarcar.Click
        MsgBox("Su marcación se ha registrado exitosamente!",
            MsgBoxStyle.Information, "Marcado de E/S")
        FrmEmpLogin_.Show()
        Me.Close()
    End Sub
End Class