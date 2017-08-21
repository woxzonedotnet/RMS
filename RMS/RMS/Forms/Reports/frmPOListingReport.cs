using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessObject;
using Reports;

namespace RMS.Forms.Reports
{
    public partial class frmPOListingReport : Form
    {
        #region Objects
        clsReportMaster cReportMaster = new clsReportMaster();
        objReportMaster oReportMaster = new objReportMaster();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        #endregion

        #region Variables
        Point lastClick;
        #endregion


        public frmPOListingReport()
        {
            InitializeComponent();
        }

        #region Form Move
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region Report
        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportViewer(12);
        }

        private void ReportViewer(int strReportID)
        {
            System.Object[,] arrParameter;
            oReportMaster = cReportMaster.GetReports(strReportID);

            arrParameter = new Object[(4), 2];

            arrParameter[0, 0] = "strCopyRight";
            arrParameter[0, 1] = cGlobleVariable.CopyRight;
            arrParameter[1, 0] = "strReportTitle";
            arrParameter[1, 1] = oReportMaster.ReportTitle;
            arrParameter[2, 0] = "strFromDate";
            arrParameter[2, 1] = this.dtpFrom.Value;
            arrParameter[3, 0] = "strToDate";
            arrParameter[3, 1] = this.dtpTo.Value;

            frmReportViewer frmReportViever = new frmReportViewer(strReportID, cGlobleVariable.LocationCode, SelectionFormularValues(strReportID), arrParameter);
            frmReportViever.Show();
        }

         private string SelectionFormularValues(int iReportID)
        {
            string srtFormular = string.Empty;

            if (oReportMaster.SelectedTable.ToString() != string.Empty)
            {
                srtFormular += "{" + oReportMaster.SelectedTable + ".fldDate}=#" + Convert.ToDateTime(dtpFrom.Value).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dtpTo.Value).ToString("yyyy-MM-dd") + "# ";
            }

            if (oReportMaster.SelectionFormular.ToString() != string.Empty)
            {
                srtFormular += " AND " + oReportMaster.SelectionFormular + " OR ";
            }
            else
            {
                srtFormular += " OR ";
            }

            if (srtFormular != string.Empty)
            {
                if (srtFormular.Substring(srtFormular.Length - 3, 2) == "OR")
                {
                    int n = srtFormular.LastIndexOf("OR");

                    srtFormular = srtFormular.Substring(0, n - 1);
                }
            }

            if (srtFormular != string.Empty)
            {
                if (srtFormular.Substring(srtFormular.Length - 3, 3) == "AND")
                {
                    int n = srtFormular.LastIndexOf("AND");

                    srtFormular = srtFormular.Substring(0, n - 1);
                }
            }
            return srtFormular;
        }
        #endregion
    }
}
