using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DrillThroughReport
{
    public partial class MasterReport : DevExpress.XtraReports.UI.XtraReport {
        public MasterReport() {
            InitializeComponent();
        }

        private void xrLabel1_BeforePrint(object sender, PrintEventArgs e) {
            ((XRLabel)sender).Tag = GetCurrentRow();
        }

        private void xrLabel1_PreviewClick(object sender, PreviewMouseEventArgs e) {
            IRow row = (IRow)e.Brick.Value;
            DetailReport detailReport = new DetailReport();
            detailReport.Parameters["catId"].Value = row["CategoryID"];
            detailReport.Parameters["catName"].Value = row["CategoryName"];
            detailReport.ShowPreviewDialog();
        }

        private void xrLabel1_PreviewMouseMove(object sender, PreviewMouseEventArgs e) {
            e.PreviewControl.Cursor = Cursors.Hand;
        }

    }
}