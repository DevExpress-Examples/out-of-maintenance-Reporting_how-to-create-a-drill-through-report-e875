Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

' ...
Namespace DrillThroughReport

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As MasterReport = New MasterReport()
            Dim printTool As ReportPrintTool = New ReportPrintTool(report)
            printTool.ShowPreviewDialog()
        End Sub
    End Class
End Namespace
