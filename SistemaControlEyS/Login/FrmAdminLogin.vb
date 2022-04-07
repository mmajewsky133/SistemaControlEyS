Public Class FrmAdminLogin

    Private user As String = "admin"
    Private pw As String = "123"

    Private Sub BtnIngresarAdmin_Click(sender As Object, e As EventArgs) Handles BtnIngresarAdmin.Click
        EvaluarUser()
    End Sub

    Private Sub TxtPwAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPwAdmin.KeyPress
        If Asc(e.KeyChar()) = 13 Then
            EvaluarUser()
        End If
    End Sub

    Private Sub TxtUsuarioAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuarioAdmin.KeyPress
        If Asc(e.KeyChar()) = 13 Then
            TxtPwAdmin.Focus()
        End If
    End Sub

    Private Sub EvaluarUser()
        If (TxtUsuarioAdmin.Text.Equals(user) And TxtPwAdmin.Text.Equals(pw)) Then
            FrmMainAdminMenu.Show()
            Me.Close()
        Else
            MsgBox("Usuario o contraseña incorrecta. Verifique sus credenciales",
                   MsgBoxStyle.Critical, "Error")
        End If
    End Sub

End Class