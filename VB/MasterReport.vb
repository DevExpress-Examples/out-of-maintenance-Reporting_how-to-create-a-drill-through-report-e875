Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
' ...

Namespace DrillThroughReport
	Partial Public Class MasterReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel1_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles xrLabel1.BeforePrint
			CType(sender, XRLabel).Tag = GetCurrentRow()
		End Sub

		Private Sub xrLabel1_PreviewClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrLabel1.PreviewClick
			Dim detailReport As New DetailReport()
			detailReport.catId.Value = CInt(Fix((CType(e.Brick.Value, DataRowView)).Row("CategoryID")))
			detailReport.catName.Value = (CType(e.Brick.Value, DataRowView)).Row("CategoryName").ToString()
			detailReport.ShowPreviewDialog()
		End Sub

		Private Sub xrLabel1_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrLabel1.PreviewMouseMove
			Cursor.Current = Cursors.Hand
		End Sub

	End Class
End Namespace
