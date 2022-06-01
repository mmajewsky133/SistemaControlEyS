Imports System.Data.SqlClient

Public Class FrmMarcadoEyS

    Dim empleado As New BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter
    Dim asistencia As New BDAsistenciasEySDataSetTableAdapters.registroAsistenciaTableAdapter

    Dim adaptadorRegEmp As New BDAsistenciasEySDataSetTableAdapters.DatosRegEmpTableAdapter
    Dim tablaRegEmp As New BDAsistenciasEySDataSet.DatosRegEmpDataTable

    Dim fechaDeHoy As String 'date
    Dim horaDeEntrada As String 'time(0)
    Dim horaDeSalida As String 'time(0)
    Dim idEmp As Integer = 0
    Dim cedula As String

    'Dim EoS As String = ""


    Private Sub BtnMarcarE_Click(sender As Object, e As EventArgs) Handles BtnEntrada.Click
        If (idEmp.Equals(0)) Then
            MsgBox("No hay ningun empleado seleccionado", MsgBoxStyle.Critical, "Error")
        Else
            BtnSalida.Visible = True
            fechaDeHoy = DateTime.Now.ToString("yyyy-MM-dd")
            horaDeEntrada = lblHora.Text.ToString
            MsgBox(fechaDeHoy & " " & horaDeEntrada, MsgBoxStyle.Information, "Bienvenido xd")
        End If

        'La cedula y el ID del empleado se recolecta en el evento de doble clic del DgvEmpleado
    End Sub

    Private Sub BtnMarcarS_Click(sender As Object, e As EventArgs) Handles BtnSalida.Click
        BtnEntrada.Visible = True
        BtnSalida.Visible = False

        horaDeSalida = lblHora.Text.ToString

        'Validar que no sea posible cambiar el id de asistencia una vez registrada la entrada con algo tipo...
        'If (idGrabadoEmp =! idEmp) entonces no es posible guardar esta asistencia, ya que el id del empleado fue modificado

        If (idEmp.Equals(0)) Then
            MsgBox("No hay ningun empleado seleccionado", MsgBoxStyle.Critical, "Error")
        Else
            MsgBox(fechaDeHoy & " " & horaDeEntrada, MsgBoxStyle.Information, "Adioooos")
            Try
                asistencia.GrabarAsistencia(fechaDeHoy, horaDeEntrada, horaDeSalida, idEmp, cedula)
                llenarGrid()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        End If
    End Sub

    Sub Mostrar()
        Me.Focus()
    End Sub

    Sub llenarGrid()
        adaptadorRegEmp.Fill(tablaRegEmp)
        DgvAsistencia.DataSource = tablaRegEmp

        DgvAsistencia.Columns.Item("ID Reg").Visible = False
        DgvAsistencia.Columns.Item("ID Emp").Visible = False

        If (TxtCedula.Text.Equals("")) Then
            DgvEmpleado.Columns.Item(0).Visible = False
            DgvEmpleado.Columns.Item(1).Visible = False
            DgvEmpleado.Columns.Item(2).Visible = False
            DgvEmpleado.Columns.Item(3).Visible = False
        Else
            DgvEmpleado.DataSource = empleado.GetData
            DgvEmpleado.Refresh()
        End If

        'GBEmpleado.Text = "Registros guardados: " + DgvEmpleado.Rows.Count.ToString
    End Sub

    Private Sub FrmMarcadoEyS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.empleado' table. You can move, or remove it, as needed.
        Me.EmpleadoTableAdapter.Fill(Me.BDAsistenciasEySDataSet.empleado)
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.registroAsistencia' table. You can move, or remove it, as needed.
        'Me.RegistroAsistenciaTableAdapter.Fill(Me.BDAsistenciasEySDataSet.registroAsistencia)
        'Me.EmpleadoTableAdapter.Fill(Me.BDAsistenciasEySDataSet.empleado)
        llenarGrid()
        BtnSalida.Visible = False

        Contador.Enabled = True
    End Sub

    Private Sub Contador_Tick(sender As Object, e As EventArgs) Handles Contador.Tick
        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub TxtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCedula.KeyPress
        If Asc(e.KeyChar()) = 13 Then
            If (TxtCedula.Text.Equals("")) Then
                llenarGrid()
                GPEmpleado.Text = "Empleado"
            Else
                llenarGrid()
                DgvEmpleado.Columns.Item(0).Visible = False
                DgvEmpleado.Columns.Item(1).Visible = True
                DgvEmpleado.Columns.Item(2).Visible = True
                DgvEmpleado.Columns.Item(3).Visible = True
                Try
                    Dim dato As String = TxtCedula.Text & "%"
                    DgvEmpleado.DataSource = empleado.BuscarCedula(dato)
                    'DgvRegistro aqui tambien copiando este mismo metodo ^.
                    DgvEmpleado.Refresh()
                    GPEmpleado.Text = "Referencias similares: " & DgvEmpleado.Rows.Count.ToString - 1
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                End Try
            End If
        End If
    End Sub

    Private Sub DgvEmpleado_DoubleClick(sender As Object, e As EventArgs) Handles DgvEmpleado.DoubleClick
        Try
            Dim fila As Integer = DgvEmpleado.CurrentRow.Index

            idEmp = DgvEmpleado.Item(0, fila).Value
            TxtCedula.Text = DgvEmpleado.Item(3, fila).Value

            cedula = TxtCedula.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub PAdmin_DoubleClick(sender As Object, e As EventArgs) Handles PAdmin.DoubleClick
        FrmAdminLogin.Show()
        Me.Hide()
    End Sub

    Private Sub TxtCedula_TextChanged(sender As Object, e As EventArgs) Handles TxtCedula.TextChanged
        If (TxtCedula.Text.Equals("")) Then
            llenarGrid()
            GPEmpleado.Text = "Empleado"
        Else
            llenarGrid()
            DgvEmpleado.Columns.Item(0).Visible = False
            DgvEmpleado.Columns.Item(1).Visible = True
            DgvEmpleado.Columns.Item(2).Visible = True
            DgvEmpleado.Columns.Item(3).Visible = True
            Try
                Dim dato As String = TxtCedula.Text & "%"
                DgvEmpleado.DataSource = empleado.BuscarCedula(dato)
                'DgvRegistro aqui tambien copiando este mismo metodo ^.
                DgvEmpleado.Refresh()
                GPEmpleado.Text = "Referencias similares: " & DgvEmpleado.Rows.Count.ToString - 1
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        End If
    End Sub

    Private Sub lblHora_Click(sender As Object, e As EventArgs) Handles lblHora.Click

    End Sub

    Private Sub lblCed_Click(sender As Object, e As EventArgs) Handles lblCed.Click

    End Sub

    Private Sub LblWarningMarcar_Click(sender As Object, e As EventArgs) Handles LblWarningMarcar.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub
End Class