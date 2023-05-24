Imports DevExpress.DataAccess.Sql.DataApi
Imports DevExpress.XtraReports.UI
Imports System.Drawing.Printing
Imports System.Windows.Forms

Namespace DrillThroughReport

    Public Partial Class MasterReport
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub xrLabel1_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs)
            CType(sender, XRLabel).Tag = GetCurrentRow()
        End Sub

        Private Sub xrLabel1_PreviewClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs)
            Dim row As IRow = CType(e.Brick.Value, IRow)
            Dim detailReport As DetailReport = New DetailReport()
            detailReport.Parameters("catId").Value = row("CategoryID")
            detailReport.Parameters("catName").Value = row("CategoryName")
            detailReport.ShowPreviewDialog()
        End Sub

        Private Sub xrLabel1_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewMouseEventArgs)
            e.PreviewControl.Cursor = Cursors.Hand
        End Sub
    End Class
End Namespace
