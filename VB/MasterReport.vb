Imports System.Data
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

' ...
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
            Dim detailReport As DetailReport = New DetailReport()
            detailReport.catId.Value = CInt(CType(e.Brick.Value, DataRowView).Row("CategoryID"))
            detailReport.catName.Value = CType(e.Brick.Value, DataRowView).Row("CategoryName").ToString()
            detailReport.ShowPreviewDialog()
        End Sub

        Private Sub xrLabel1_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewMouseEventArgs)
            e.PreviewControl.Cursor = Cursors.Hand
        End Sub
    End Class
End Namespace
