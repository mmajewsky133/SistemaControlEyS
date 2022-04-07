Public Class FrmEmpLogin_

    Private user As String = "emp001"
    Private pw As String = "12345"
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        EvaluarUser()
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub TxtPwEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPwEmp.KeyPress
        If Asc(e.KeyChar()) = 13 Then
            EvaluarUser()
        End If
    End Sub

    Private Sub TxtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuario.KeyPress
        If Asc(e.KeyChar()) = 13 Then
            TxtPwEmp.Focus()
        End If
    End Sub

    Private Sub EvaluarUser()
        If (TxtUsuario.Text.Equals(user) And TxtPwEmp.Text.Equals(pw)) Then
            FrmMarcadoEmpE_S.Show()
            Me.Close()
        Else
            MsgBox("Usuario o contraseña incorrecta. Verifique sus credenciales",
                   MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class