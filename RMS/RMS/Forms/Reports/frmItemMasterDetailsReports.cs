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
    public partial class frmItemMasterDetailsReports : Form
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
        clsDepartment cDepartment = new clsDepartment();
        clsCategoryMaster cCategoryMaster = new clsCategoryMaster();
        clsSupplierCategory cSupplierCategory = new clsSupplierCategory();
        #endregion

        #region Variables
        Point lastClick;
        #endregion

        public frmItemMasterDetailsReports()
        {
            InitializeComponent();
            cCommonMethods.loadComboRMS(cDepartment.GetDepartment(), cmbDepartment, 2);
            cCommonMethods.loadComboRMS(cCategoryMaster.GetCategory(), cmbCategory, 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.chkDepartment.Checked == false && this.cmbDepartment.SelectedIndex <= -1 && this.chkDepartment.Checked == false && this.cmbCategory.SelectedIndex <= -1)
            {
                MessageBox.Show("Please check the fields...!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (cmbDepartment.SelectedIndex > -1 && cmbCategory.SelectedIndex > -1)
                {
                    ReportViewer(6);
                }
                else if (cmbDepartment.SelectedIndex > -1 && chkCategory.Checked)
                {
                ReportViewer(7);
            }
                else if (chkDepartment.Checked && cmbCategory.SelectedIndex > -1)
            {
                    ReportViewer(8);
                }
                else if (chkDepartment.Checked && chkCategory.Checked)
                {
                    ReportViewer(9);
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

            if (strReportID == 6)
            {
                arrParameter = new Object[(4), 2];

                arrParameter[0, 0] = "strCopyRight";
                arrParameter[0, 1] = cGlobleVariable.CopyRight;
                arrParameter[1, 0] = "strReportTitle";
                arrParameter[1, 1] = oReportMaster.ReportTitle;
                arrParameter[2, 0] = "strDepartment";
                arrParameter[2, 1] = cmbCategory["fldDepartmentCode"].ToString();
                arrParameter[3, 0] = "strCategory";
                arrParameter[3, 1] = cmbCategory["fldCategoryCode"].ToString();
                
            }

            else if (strReportID == 7)
            {
            arrParameter = new Object[(3), 2];

            arrParameter[0, 0] = "strCopyRight";
            arrParameter[0, 1] = cGlobleVariable.CopyRight;
            arrParameter[1, 0] = "strReportTitle";
            arrParameter[1, 1] = oReportMaster.ReportTitle;
            arrParameter[2, 0] = "strDepartment";
            arrParameter[2, 1] = cmbDepartment["fldDepartmentCode"].ToString();
    
            }
            else if (strReportID == 8)
            {
                arrParameter = new Object[(3), 2];

                arrParameter[0, 0] = "strCopyRight";
                arrParameter[0, 1] = cGlobleVariable.CopyRight;
                arrParameter[1, 0] = "strReportTitle";
                arrParameter[1, 1] = oReportMaster.ReportTitle;
                arrParameter[2, 0] = "strCategory";
                arrParameter[2, 1] = cmbCategory["fldCategoryCode"].ToString();

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

            if (iReportID == 6)
            {
                if (oReportMaster.SelectedTable.ToString() != string.Empty)
                {
                    srtFormular += "{" + oReportMaster.SelectedTable + ".fldDepartmentCode}='" + this.cmbDepartment["fldDepartmentCode"].ToString() + "' and {" + oReportMaster.SelectedTable + ".fldCategoryCode}='" + this.cmbCategory["fldCategoryCode"].ToString() + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
                }
            }
            else if (iReportID == 7)
            {
                if (oReportMaster.SelectedTable.ToString() != string.Empty)
                {
                    srtFormular += "{" + oReportMaster.SelectedTable + ".fldDepartmentCode}='" + this.cmbDepartment["fldDepartmentCode"].ToString() + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
                }
            }
            else if (iReportID == 8)
            {
                if (oReportMaster.SelectedTable.ToString() != string.Empty)
                {
                    srtFormular += "{" + oReportMaster.SelectedTable + ".fldCategoryCode}='" + this.cmbCategory["fldCategoryCode"].ToString() + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
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

        private void chkDepartment_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkDepartment.Checked)
            {
               cmbDepartment.Enabled = false;


            }
            else
            {
                cmbDepartment.Enabled = true;
            }

        }

        private void chkCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkCategory.Checked)
            {
               cmbCategory.Enabled = false;

            }
            else
            {
                cmbCategory.Enabled = true;
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = -1;
            cCommonMethods.loadComboRMS(cCategoryMaster.GetCategoryDataByDepartment(cGlobleVariable.LocationCode,this.cmbDepartment["fldDepartmentCode"].ToString()), cmbCategory, 3);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
