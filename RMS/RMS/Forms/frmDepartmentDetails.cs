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

namespace RMS.Forms
{
    public partial class frmDepartmentDetails : Form
    {
        #region Objects
        clsDepartment cDepartment = new clsDepartment();
        objDepartment oDepartment = new objDepartment();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        #endregion

        #region Variables
        int result;
        Point lastClick;
        #endregion

        public frmDepartmentDetails()
        {
            InitializeComponent();
            this.lblDepartmentTitle.Text = this.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oDepartment = cDepartment.GetDepartmentData(cGlobleVariable.LocationCode, this.txtDepartmentCode.Text);

                if (oDepartment.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Department", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Department Data Not Saved...!", "Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void clear() 
        {
            cCommonMethods.ClearForm(this);
            this.txtDepartmentCode.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
        }

        #region Validate Department Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtDepartmentCode.Text == "")
            {
                errDepartment.SetError(txtDepartmentCode, "Please Enter Department Code");
                isValidate = false;
            }
            else
            {
                errDepartment.SetError(txtDepartmentCode, "");

            }

            if (txtDepartmentName.Text == "")
            {
                errDepartment.SetError(txtDepartmentName, "Please Enter Department Name");
                isValidate = false;
            }
            else
            {
                errDepartment.SetError(txtDepartmentName, "");
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                errDepartment.SetError(cmbStatus, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errDepartment.SetError(cmbStatus, "");
            }

            return isValidate;
        }
        #endregion

        #region InsertUpdate Department Data
        private int InsertUpdateData()
        {
            oDepartment.LocationCode = cGlobleVariable.LocationCode.ToString();
            oDepartment.DepartmentCode = txtDepartmentCode.Text;
            oDepartment.DepartmentName = txtDepartmentName.Text;
            oDepartment.Status = Convert.ToInt16(cmbStatus["fldStatusCode"]);

            return cDepartment.InsertUpdateData(oDepartment);
        }
        #endregion

        private void frmDepartmentDetails_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
            clear();
            this.btnUpdate.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "fldDepartmentCode";
            strFieldList[1] = "fldDepartmentName";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Department Code";
            strHeaderList[1] = "Department Name";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 320;

            string strReturnString = "Department Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtDepartmentCode.Text = cCommonMethods.BrowsData("tbl_DepartmentMaster", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Department");
            if (txtDepartmentCode.Text != "")
            {
                LoadDepartmentDetails();
            }
        }

        #region Load SubLocation Details
        private void LoadDepartmentDetails()
        {
            oDepartment = cDepartment.GetDepartmentData(cGlobleVariable.LocationCode, this.txtDepartmentCode.Text);

            txtDepartmentName.Text = oDepartment.DepartmentName;
           

            cmbStatus.SetText(cStatusMaster.GetStatusByCode(oDepartment.Status));

            this.txtDepartmentName.Select();
            this.txtDepartmentCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oDepartment = cDepartment.GetDepartmentData(cGlobleVariable.LocationCode, this.txtDepartmentCode.Text);

                if (oDepartment.IsExists == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Department", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Department Data Not Updated...!", "Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }
    }
}
