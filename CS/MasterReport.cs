using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace DrillThroughReport {
    public partial class MasterReport : DevExpress.XtraReports.UI.XtraReport {
        public MasterReport() {
            InitializeComponent();
        }

        private void xrLabel1_BeforePrint(object sender, PrintEventArgs e) {
            ((XRLabel)sender).Tag = GetCurrentRow();
        }

        private void xrLabel1_PreviewClick(object sender, PreviewMouseEventArgs e) {
            DetailReport detailReport = new DetailReport();
            detailReport.catId.Value = (int)((DataRowView)e.Brick.Value).Row["CategoryID"];
            detailReport.catName.Value = ((DataRowView)e.Brick.Value).Row["CategoryName"].ToString();
            detailReport.ShowPreviewDialog();
        }

        private void xrLabel1_PreviewMouseMove(object sender, PreviewMouseEventArgs e) {
            e.PreviewControl.Cursor = Cursors.Hand;
        }

    }
}