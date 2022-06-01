Public Class FrmOpciones

    Dim admin As New BDAsistenciasEySDataSetTableAdapters.adminTableAdapter
    Dim idAdmin As New Integer
    Sub Mostrar()
        Me.Focus()
    End Sub

    Sub llenarGrid()
        DgvAdmin.DataSource = admin.GetData
        DgvAdmin.Refresh()
        GBAdmin.Text = "Administradores registrados: " + DgvAdmin.Rows.Count.ToString

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            If (String.IsNullOrEmpty(TxtNombre.Text)) Then
                MsgBox("El campo de nombre no puede quedar vacio", MsgBoxStyle.Critical, "ERROR")
                TxtNombre.Focus()
                Exit Sub
            End If
            If (String.IsNullOrEmpty(TxtApellidos.Text)) Then
                MsgBox("Los apellidos requieren ser ingresados", MsgBoxStyle.Critical, "ERROR")
                TxtApellidos.Focus()
                Exit Sub
            End If
            If (String.IsNullOrEmpty(TxtUsuario.Text)) Then
                MsgBox("Se requiere crear un usuario para el administrador", MsgBoxStyle.Critical, "ERROR")
                TxtUsuario.Focus()
                Exit Sub
            End If
            If (String.IsNullOrEmpty(TxtPin.Text)) Then
                MsgBox("Se requiere una contraseña para el usuario", MsgBoxStyle.Critical, "ERROR")
                TxtPin.Focus()
                Exit Sub
            End If

            Dim nombres As String = TxtNombre.Text
            Dim apellidos As String = TxtApellidos.Text
            Dim usuario As String = TxtUsuario.Text
            Dim pin As String = TxtPin.Text

            admin.InsertarAdmin(nombres, apellidos, usuario, pin, 1)
            llenarGrid()
            MsgBox("Se ha registrado el administrador dentro de la base de datos", MsgBoxStyle.Information, "Opciones de administrador")
        Catch ex As Exception
            MsgBox("Un campo vacío, datos no guardados", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub FrmOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.BDAsistenciasEySDataSet.admin)

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim resp As VariantType
            resp = MsgBox("¿Desea eliminar este cargo?", vbQuestion + vbYesNo)
            If (resp = vbYes) Then
                admin.EliminarAdmin(idAdmin)
                llenarGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub DgvAdmin_DoubleClick(sender As Object, e As EventArgs) Handles DgvAdmin.DoubleClick
        Try
            Dim fila As Integer = DgvAdmin.CurrentRow.Index

            idAdmin = DgvAdmin.Item(0, fila).Value
            TxtNombre.Text = DgvAdmin.Item(1, fila).Value
            TxtApellidos.Text = DgvAdmin.Item(2, fila).Value
            TxtUsuario.Text = DgvAdmin.Item(3, fila).Value
            TxtPin.Text = DgvAdmin.Item(4, fila).Value

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If (String.IsNullOrEmpty(TxtUsuario.Text)) Then
            MsgBox("Ingrese el usuario a editar", MsgBoxStyle.Critical, "ERROR")
            TxtUsuario.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(TxtPin.Text)) Then
            MsgBox("El PIN debe existir", MsgBoxStyle.Critical, "ERROR")
            TxtPin.Focus()
            Exit Sub
        End If

        Dim usuario As String = TxtUsuario.Text.Trim
        Dim pin As String = TxtPin.Text.Trim

        admin.ActualizarAdmin(usuario, pin, 2, idAdmin)

        llenarGrid()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If (txtBuscar.Text.Equals("")) Then
            llenarGrid()
        Else
            Try
                Dim dato As String = txtBuscar.Text & "%"
                DgvAdmin.DataSource = admin.BuscarAdmin(dato)
                DgvAdmin.Refresh()
                GBAdmin.Text = "Administradores similares: " & DgvAdmin.Rows.Count.ToString
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        End If
    End Sub
End Class