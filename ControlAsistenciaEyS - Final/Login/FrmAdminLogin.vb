Public Class FrmAdminLogin

    Dim admin As New BDAsistenciasEySDataSetTableAdapters.adminTableAdapter

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        FrmMarcadoEyS.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs)
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

        Dim user As String = TxtUsuarioAdmin.Text
        Dim pw As String = TxtPwAdmin.Text


        If (user.Equals("admin") And pw.Equals("123")) Then
            FrmMainAdminMenu.Show()
            Me.Hide()
            Me.TxtUsuarioAdmin.Clear()
            Me.TxtPwAdmin.Clear()
        Else
            Try
                Dim dtcreds As DataTable = admin.VerAlgo(user, pw)

                'If (dtcreds IsNot Nothing AndAlso dtcreds.Rows.Count > 0) Then
                If (dtcreds.Rows.Count() <= 0) Then
                    MsgBox("Usuario o contraseña incorrecta. Verifique sus credenciales", MsgBoxStyle.Critical, "Error")
                Else
                    MsgBox("Bienvenido administrador " & user, MsgBoxStyle.Information, "Bienvenido")
                    FrmMainAdminMenu.Show()
                    Me.Hide()
                    Me.TxtUsuarioAdmin.Clear()
                    Me.TxtPwAdmin.Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        End If




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
    End Sub

    Private Sub FrmAdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not FrmMarcadoEyS.Visible) Then
            FrmMarcadoEyS.Show()
            Me.Dispose()
        Else
            FrmMarcadoEyS.Mostrar()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PBIngresar.Click
        EvaluarUser()
    End Sub
End Class
