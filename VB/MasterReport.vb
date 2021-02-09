Imports DevExpress.DataAccess.Sql.DataApi
Imports DevExpress.XtraReports.UI
Imports System.Drawing.Printing

Namespace DrillThroughReport
	Partial Public Class MasterReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel1_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles xrLabel1.BeforePrint
			DirectCast(sender, XRLabel).Tag = GetCurrentRow()
		End Sub

		Private Sub xrLabel1_PreviewClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrLabel1.PreviewClick
			Dim row As IRow = DirectCast(e.Brick.Value, IRow)
			Dim detailReport As New DetailReport()
			detailReport.Parameters("catId").Value = row("CategoryID")
			detailReport.Parameters("catName").Value = row("CategoryName")
			detailReport.ShowPreviewDialog()
		End Sub

		Private Sub xrLabel1_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrLabel1.PreviewMouseMove
			e.PreviewControl.Cursor = Cursors.Hand
		End Sub

	End Class
End Namespace