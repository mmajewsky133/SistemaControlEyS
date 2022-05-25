Public Class FrmMarcadoEyS

    Dim EoS As String = ""

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnMarcarE_Click(sender As Object, e As EventArgs) Handles BtnMarcarE.Click
        Dim Tiempo As DateTime? = Now
        Dim Time As DateTime? = Nothing

        Me.LblComMarcado.Text = Tiempo
        '[ A Marcar: Entrada ]"
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

    Private Sub FrmMarcadoEyS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDAsistenciasEySDataSet.registroAsistencia' table. You can move, or remove it, as needed.
        Me.RegistroAsistenciaTableAdapter.Fill(Me.BDAsistenciasEySDataSet.registroAsistencia)

    End Sub
End Class