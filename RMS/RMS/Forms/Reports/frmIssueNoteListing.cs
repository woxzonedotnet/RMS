using BusinessLogic;
using BusinessObject;
using Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.Forms.Reports
{
    public partial class frmIssueNoteListing : Form
    {

        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsSubLocation cSubLocation = new clsSubLocation();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsOrderType cOrderType = new clsOrderType();
        objReportMaster oReportMaster = new objReportMaster();
        clsReportMaster cReportMaster = new clsReportMaster();
        #endregion

        #region Variables
        Point lastClick;
        #endregion

        public frmIssueNoteListing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportViewer(20);
        }

        private void ReportViewer(int strReportID)
        {


            System.Object[,] arrParameter;
            oReportMaster = cReportMaster.GetReports(strReportID);

            if (strReportID == 20)
            {
                arrParameter = new Object[(4), 2];

                arrParameter[0, 0] = "strCopyRight";
                arrParameter[0, 1] = cGlobleVariable.CopyRight;
                arrParameter[1, 0] = "strReportTitle";
                arrParameter[1, 1] = oReportMaster.ReportTitle;
                arrParameter[2, 0] = "strFrom";
                arrParameter[2, 1] = dtpDateFrom.Value.Date.ToString("yyyy-MM-dd");
                arrParameter[3, 0] = "strto";
                arrParameter[3, 1] = dtpDateTo.Value.Date.ToString("yyyy-MM-dd");

            }
            else
            {
                arrParameter = new Object[(2), 2];

                arrParameter[0, 0] = "strCopyRight";
                arrParameter[0, 1] = cGlobleVariable.CopyRight;
                arrParameter[1, 0] = "strReportTitle";
                arrParameter[1, 1] = oReportMaster.ReportTitle;

            }

            
            frmReportViewer frmReportViever = new frmReportViewer(strReportID, cGlobleVariable.LocationCode, SelectionFormularValues(strReportID), arrParameter);
            frmReportViever.Show();


        }

        #region SelectionFormularValues
        private string SelectionFormularValues(int iReportID)
        {
            string srtFormular = string.Empty;

            if (iReportID == 20)
            {
                if (oReportMaster.SelectedTable.ToString() != string.Empty)
                {
                    srtFormular += "{" + oReportMaster.SelectedTable + ".fldIssueDate}='" + this.dtpDateFrom.Value.Date.ToString("yyyy-MM-dd") + "' and {" + oReportMaster.SelectedTable + ".fldIssueDate}='" + this.dtpDateTo.Value.Date.ToString("yyyy-MM-dd") + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
                }
            }
            

            //else 
            //{
            //    if (oReportMaster.SelectedTable.ToString() != string.Empty)
            //    {
            //        srtFormular += "{" + oReportMaster.SelectedTable + ".fldSupplierCategoryCode}='" + this.cmbSupplierCategory["fldSupplierCategoryCode"].ToString() + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
            //    }
            //}

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

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


    }
}
