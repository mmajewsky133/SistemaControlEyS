﻿Imports Microsoft.Reporting.WinForms

Module GlobalRequests
    Sub VerReporte(ByVal tbl As DataTable, ByVal nombreDs As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDs, tbl)
            With RptDisplay
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = "..\..\Reportes\" + nombreRpt
                .ReportViewer1.Refresh()
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al mostrar reporte")
        End Try
    End Sub
End Module
