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
    public partial class frmRecipeDetailsRepot : Form
    {

        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsSubLocation cSubLocation = new clsSubLocation();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsOrderType cOrderType = new clsOrderType();
        objReportMaster oReportMaster = new objReportMaster();
        clsReportMaster cReportMaster = new clsReportMaster();
        #endregion


        public frmRecipeDetailsRepot()
        {
            InitializeComponent();
        }

        private void frmRecipeDetailsRepot_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode), cmbLocation, 2);
            cCommonMethods.loadComboRMS(cOrderType.GetOrderType(cGlobleVariable.LocationCode), cmbOrderType, 2);
        }

        private void chkOrderType_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkOrderType.Checked)
            {
                cmbOrderType.Enabled = false;


            }
            else
            {
                cmbOrderType.Enabled = true;
            }
        }

        private void chkLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkLocation.Checked)
            {
                cmbLocation.Enabled = false;


            }
            else
            {
                cmbLocation.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.chkOrderType.Checked == false && this.cmbOrderType.SelectedIndex <= -1 && this.chkLocation.Checked == false && this.cmbLocation.SelectedIndex <= -1)
            {
                MessageBox.Show("Please check the fields...!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (cmbOrderType.SelectedIndex > -1 && cmbLocation.SelectedIndex > -1)
                {
                    ReportViewer(16);
                }
                else if (cmbOrderType.SelectedIndex > -1 && chkLocation.Checked)
                {
                    ReportViewer(17);
                }
                else if (chkOrderType.Checked && cmbLocation.SelectedIndex > -1)
                {
                    ReportViewer(18);
                }
                else if (chkOrderType.Checked && chkLocation.Checked)
                {
                    ReportViewer(19);
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

            if (strReportID == 16)
            {
                arrParameter = new Object[(4), 2];

                arrParameter[0, 0] = "strCopyRight";
                arrParameter[0, 1] = cGlobleVariable.CopyRight;
                arrParameter[1, 0] = "strReportTitle";
                arrParameter[1, 1] = oReportMaster.ReportTitle;
                arrParameter[2, 0] = "strOrderType";
                arrParameter[2, 1] = cmbOrderType["fldOrderTypeCode"].ToString();
                arrParameter[3, 0] = "strLocation";
                arrParameter[3, 1] = cmbLocation["fldSubLocationCode"].ToString();

            }

            else if (strReportID == 17)
            {
                arrParameter = new Object[(3), 2];

                arrParameter[0, 0] = "strCopyRight";
                arrParameter[0, 1] = cGlobleVariable.CopyRight;
                arrParameter[1, 0] = "strReportTitle";
                arrParameter[1, 1] = oReportMaster.ReportTitle;
                arrParameter[2, 0] = "strOrderType";
                arrParameter[2, 1] = cmbOrderType["fldOrderTypeCode"].ToString();

            }
            else if (strReportID == 18)
            {
                arrParameter = new Object[(3), 2];

                arrParameter[0, 0] = "strCopyRight";
                arrParameter[0, 1] = cGlobleVariable.CopyRight;
                arrParameter[1, 0] = "strReportTitle";
                arrParameter[1, 1] = oReportMaster.ReportTitle;
                arrParameter[2, 0] = "strLocation";
                arrParameter[2, 1] = cmbLocation["fldSubLocationCode"].ToString();
                
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

            if (iReportID == 16)
            {
                if (oReportMaster.SelectedTable.ToString() != string.Empty)
                {
                    srtFormular += "{" + oReportMaster.SelectedTable + ".fldSubLocationCode}='" + this.cmbLocation["fldSubLocationCode"].ToString() + "' and {" + oReportMaster.SelectedTable + ".fldOrderTypeCode}='" + this.cmbOrderType["fldOrderTypeCode"].ToString() + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
                }
            }
            else if (iReportID == 17)
            {
                if (oReportMaster.SelectedTable.ToString() != string.Empty)
                {
                    srtFormular += "{" + oReportMaster.SelectedTable + ".fldOrderTypeCode}='" + this.cmbOrderType["fldOrderTypeCode"].ToString() + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
                }
            }
            else if (iReportID == 18)
            {
                if (oReportMaster.SelectedTable.ToString() != string.Empty)
                {
                    srtFormular += "{" + oReportMaster.SelectedTable + ".fldSubLocationCode}='" + this.cmbLocation["fldSubLocationCode"].ToString() + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
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

        }



     


    }
}
