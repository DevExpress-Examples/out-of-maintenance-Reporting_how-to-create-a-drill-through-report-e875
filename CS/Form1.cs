using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Drill_through_example;
// ...

namespace DrillThroughReport {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReportCategories report = new XtraReportCategories();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }
    }
}