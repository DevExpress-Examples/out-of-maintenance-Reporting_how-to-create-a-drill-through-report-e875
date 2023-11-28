Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports Drill_through_example
' ...

Namespace DrillThroughReport
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReportCategories()
			Dim printTool As New ReportPrintTool(report)
			printTool.ShowPreviewDialog()
		End Sub
	End Class
End Namespace