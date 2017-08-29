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
using System.Management;
using BusinessObject;
using Reports;

namespace RMS.Forms.Reports
{
    public partial class frmSupplierDetailReport : Form
    {

        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsSubLocation cSubLocation = new clsSubLocation();
        clsDocumentNumber cDocumentNumber = new clsDocumentNumber();
        objDocumentNumber oDocumentNumber = new objDocumentNumber();
        objItemMaster oItemMaster = new objItemMaster();
        clsItemMaster cItemMaster = new clsItemMaster();
        objItemLocation oItemLocation = new objItemLocation();
        clsItemLocation cItemLocation = new clsItemLocation();
        objTransferNote oTransferNote = new objTransferNote();
        clsTransferNote cTransferNote = new clsTransferNote();
        objReportMaster oReportMaster = new objReportMaster();
        clsReportMaster cReportMaster = new clsReportMaster();
        clsSupplierCategory cSupplierCategory = new clsSupplierCategory();
        #endregion

        #region Variables
        Point lastClick;
        #endregion

        public frmSupplierDetailReport()
        {
            InitializeComponent();
            cCommonMethods.loadComboRMS(cSupplierCategory.GetSupplierCategory(), cmbSupplierCategory, 2);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.chkCategory.Checked == false && Convert.ToInt32(cmbSupplierCategory.SelectedIndex) == -1)
            {
                MessageBox.Show("Please select a category...!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (chkCategory.Checked)
            {
                ReportViewer(5);
            }
            else 
            {
                if (cmbSupplierCategory.SelectedIndex > -1)
                {
                    ReportViewer(4);
                }
            }
            
        }

        private void ReportViewer(int strReportID)
        {
           

            System.Object[,] arrParameter;
            oReportMaster = cReportMaster.GetReports(strReportID);

            if (strReportID == 4)
            {
                arrParameter = new Object[(3), 2];

                arrParameter[0, 0] = "strCopyRight";
                arrParameter[0, 1] = cGlobleVariable.CopyRight;
                arrParameter[1, 0] = "strReportTitle";
                arrParameter[1, 1] = oReportMaster.ReportTitle;
                arrParameter[2, 0] = "strSupplierCategoryCode";
                arrParameter[2, 1] = cmbSupplierCategory["fldSupplierCategoryCode"].ToString();
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

            if (iReportID == 4)
            {
                if (oReportMaster.SelectedTable.ToString() != string.Empty)
                {
                    srtFormular += "{" + oReportMaster.SelectedTable + ".fldSupplierCategoryCode}='" + this.cmbSupplierCategory["fldSupplierCategoryCode"].ToString() + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkCategory.Checked)
            {
                cmbSupplierCategory.Enabled = false;
                
            }
            else
            {
                cmbSupplierCategory.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region Form Move
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        #endregion


    }
}
