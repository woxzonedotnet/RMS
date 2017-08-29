using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using BusinessLogic;
using Reports;

namespace RMS.Forms.Reports
{
    public partial class frmGRNListingReport : Form
    {
        #region Object
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        objSupplierMaster oSupplierMaster = new objSupplierMaster();
        clsSupplierMaster cSupplierMaster = new clsSupplierMaster();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        objReportMaster oReportMaster = new objReportMaster();
        clsReportMaster cReportMaster = new clsReportMaster();
        #endregion

        #region Variables
        public string suppliercode;
        Point lastClick;
        #endregion
        public frmGRNListingReport()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        public void LoadSearch()
        {
            string[] strFieldList = new string[3];
            strFieldList[0] = "fldSupplierCode";
            strFieldList[1] = "fldSupplierName";
            strFieldList[2] = "fldContactPerson";

            string[] strHeaderList = new string[3];
            strHeaderList[0] = "Supplier Code";
            strHeaderList[1] = "Supplier Name";
            strHeaderList[2] = "Contact Person";

            int[] iHeaderWidth = new int[3];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 320;
            iHeaderWidth[2] = 150;

            string strReturnString = "Supplier Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtSupplier.Text = cCommonMethods.BrowsData("tbl_SupplierMaster", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Supplier Master");
            if (txtSupplier.Text != "")
            {
                LoadSupplierCategoryDetails();
            }
        }

        #region Load Supplier Details
        private void LoadSupplierCategoryDetails()
        {
            oSupplierMaster = cSupplierMaster.GetSupplierData(cGlobleVariable.LocationCode, this.txtSupplier.Text);

            txtSupplier.Text = oSupplierMaster.SupplierName;
            suppliercode = oSupplierMaster.SupplierCode;

           
        }
        #endregion

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked == true)
            {
                txtSupplier.Enabled = false;
                txtSupplier.Clear();
            }
            else
            {
                txtSupplier.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.chkAll.Checked == false && this.txtSupplier.Equals(null))
            {
                MessageBox.Show("Please check the fields...!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (chkAll.Checked == false )
                {
                    ReportViewer(21);
                }
                else if (chkAll.Checked == true) 
                {
                    ReportViewer(22);
                }
                
                else
                {
                    MessageBox.Show("Please check the fields...!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }


        private void ReportViewer(int strReportID)
        {


            System.Object[,] arrParameter;
            oReportMaster = cReportMaster.GetReports(strReportID);

            if (strReportID == 21)
            {
                arrParameter = new Object[(5), 2];

                arrParameter[0, 0] = "strCopyRight";
                arrParameter[0, 1] = cGlobleVariable.CopyRight;
                arrParameter[1, 0] = "strReportTitle";
                arrParameter[1, 1] = oReportMaster.ReportTitle;
                arrParameter[2, 0] = "strFrom";
                arrParameter[2, 1] = dtpFrom.Value.Date.ToString("yyyy-MM-dd");
                arrParameter[3, 0] = "strto";
                arrParameter[3, 1] = dtpTo.Value.Date.ToString("yyyy-MM-dd");
                arrParameter[4, 0] = "strsupplier";
                arrParameter[4, 1] = txtSupplier.Text;

            }
            else if (strReportID == 22)
            {
                arrParameter = new Object[(4), 2];

                arrParameter[0, 0] = "strCopyRight";
                arrParameter[0, 1] = cGlobleVariable.CopyRight;
                arrParameter[1, 0] = "strReportTitle";
                arrParameter[1, 1] = oReportMaster.ReportTitle;
                arrParameter[2, 0] = "strFrom";
                arrParameter[2, 1] = dtpFrom.Value.Date.ToString("yyyy-MM-dd");
                arrParameter[3, 0] = "strto";
                arrParameter[3, 1] = dtpTo.Value.Date.ToString("yyyy-MM-dd");

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

            if (iReportID == 21)
            {
                if (oReportMaster.SelectedTable.ToString() != string.Empty)
                {
                    srtFormular += "{" + oReportMaster.SelectedTable + ".fldDate}='" + this.dtpFrom.Value.Date.ToString("yyyy-MM-dd") + "' and {" + oReportMaster.SelectedTable + ".fldDate}='" + this.dtpTo.Value.Date.ToString("yyyy-MM-dd") + "'and {" + oReportMaster.SelectedTable + ".fldSupplierCode}='" + suppliercode + "' "; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
                }
            }
            else if (iReportID == 22)
            {
                if (oReportMaster.SelectedTable.ToString() != string.Empty)
                {
                    srtFormular += "{" + oReportMaster.SelectedTable + ".fldDate}='" + this.dtpFrom.Value.Date.ToString("yyyy-MM-dd") + "' and {" + oReportMaster.SelectedTable + ".fldDate}='" + this.dtpTo.Value.Date.ToString("yyyy-MM-dd") + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
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

    }
}
