Public Class RptDisplay
    Private Sub RptDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class