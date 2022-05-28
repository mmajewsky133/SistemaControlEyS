Imports System.Data.SqlClient

Public Class FrmMarcadoEyS

    Dim empleado As New BDAsistenciasEySDataSetTableAdapters.empleadoTableAdapter
    Dim idEmp As Integer

    Dim EoS As String = ""

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnMarcarE_Click(sender As Object, e As EventArgs) Handles BtnEntrada.Click
        BtnSalida.Visible = True
    End Sub

    Private Sub BtnMarcarS_Click(sender As Object, e As EventArgs) Handles BtnSalida.Click
        BtnEntrada.Visible = True
        BtnSalida.Visible = False

    End Sub

    Sub VerfHora(ByVal EoS As String)

    End Sub

    Sub Mostrar()
        Me.Focus()
    End Sub

    Sub llenarGrid()
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
        Me.RegistroAsistenciaTableAdapter.Fill(Me.BDAsistenciasEySDataSet.registroAsistencia)
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
                    'DgvRegistro aqui tambien.
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

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub PAdmin_DoubleClick(sender As Object, e As EventArgs) Handles PAdmin.DoubleClick
        FrmAdminLogin.Show()
        Me.Hide()
    End Sub
End Class