Public Class FrmAdminLogin

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        EvaluarUser()
    End Sub

    Private Sub TxtUsuarioAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuarioAdmin.KeyPress
        If Asc(e.KeyChar()) = 13 Then
            TxtPwAdmin.Focus()
        End If
    End Sub

    Private Sub TxtPwAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPwAdmin.KeyPress
        If Asc(e.KeyChar()) = 13 Then
            EvaluarUser()
        End If
    End Sub

    Private Sub EvaluarUser()
        'Dim user As String = TxtUsuarioAdmin.Text
        'Dim pw As String = TxtPwAdmin.Text

        'Dim dtadmin As New Login

        'If Not dtadmin.VerificarCreds(user, pw) Then
        'MsgBox("Usuario o contraseña incorrecta. Verifique sus credenciales",
        'MsgBoxStyle.Critical, "Error")
        'Me.TxtUsuarioAdmin.Focus()
        'Else
        'FrmMainAdminMenu.Show()
        'TxtUsuarioAdmin.Clear()
        'TxtPwAdmin.Clear()
        'Me.Hide()
        'End If

        FrmMainAdminMenu.Show()
        TxtUsuarioAdmin.Clear()
        TxtPwAdmin.Clear()
        Me.Hide()

    End Sub
End Class
