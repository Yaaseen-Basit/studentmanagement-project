Imports System.Data
Imports System.Data.SqlClient
Imports System
Imports CrystalDecisions
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.CrystalReports.Design
Imports CrystalDecisions.Windows.Forms





Public Class frmcryreport

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        Try

        
        Dim cryRpt As New ReportDocument

        cryRpt.Load(Application.StartupPath + "\" + "RPTstud.rpt")

        CrystalReportViewer1.ReportSource = cryRpt
        'CrystalReportViewer1.SelectionFormula = " {stud.rollno}=" & frmstudentinfo.txtrollno.Text & 
        'OR {City_Master.City_Name}='" + frmCityMaster_G.txtCityName.Text + "'"
        CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex)

        End Try



    End Sub
End Class