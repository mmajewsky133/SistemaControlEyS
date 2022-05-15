Public Class FrmMarcadoEyS

    Dim EoS As String = ""

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnMarcarE_Click(sender As Object, e As EventArgs) Handles BtnMarcarE.Click
        Me.LblComMarcado.Text = "[ A Marcar: Entrada ]"
        EoS = "E"
        VerfHora(EoS)
    End Sub

    Private Sub BtnMarcarS_Click(sender As Object, e As EventArgs) Handles BtnMarcarS.Click
        Me.LblComMarcado.Text = "[ A Marcar: Salida ]"
        EoS = "S"
        VerfHora(EoS)
    End Sub

    Sub VerfHora(ByVal EoS As String)

    End Sub

    Private Sub BtnMarcar_Click(sender As Object, e As EventArgs) Handles BtnMarcar.Click

    End Sub
End Class