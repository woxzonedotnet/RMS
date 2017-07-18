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
    public partial class frmMenuDepartment : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        objMenuDepartment oMenuDepartment = new objMenuDepartment();
        clsMenuDepartment cMenuDepartment = new clsMenuDepartment();
        #endregion

        #region Variables
        Point lastClick;
        #endregion

        public frmMenuDepartment()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void frmMenuDepartment_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oMenuDepartment = cMenuDepartment.GetMenuDepartmentData(cGlobleVariable.LocationCode, this.txtMenuDepartmentCode.Text);

                if (oMenuDepartment.IsExists == false)
                {
                    if (InsertUpdateData() != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Menu Department", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Menu Department Data Not Saved...!", "Menu Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Menu Department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtMenuDepartmentCode.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
            this.txtMenuDepartmentCode.Focus();
        }

        #region Validate Menu Department Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtMenuDepartmentCode.Text == "")
            {
                errMenuDepartment.SetError(txtMenuDepartmentCode, "Please Enter Menu Department Code");
                isValidate = false;
            }
            else
            {
                errMenuDepartment.SetError(txtMenuDepartmentCode, "");

            }

            if (txtMenuDepartmentName.Text == "")
            {
                errMenuDepartment.SetError(txtMenuDepartmentName, "Please Enter Menu Department Name");
                isValidate = false;
            }
            else
            {
                errMenuDepartment.SetError(txtMenuDepartmentName, "");
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                errMenuDepartment.SetError(cmbStatus, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errMenuDepartment.SetError(cmbStatus, "");
            }

            return isValidate;
        }
        #endregion

        #region InsertUpdate Department Data
        private int InsertUpdateData()
        {
            oMenuDepartment.LocationCode = cGlobleVariable.LocationCode.ToString();
            oMenuDepartment.MenuDepartmentCode = txtMenuDepartmentCode.Text;
            oMenuDepartment.MenuDepartmentName = txtMenuDepartmentName.Text;
            oMenuDepartment.Status = Convert.ToInt16(cmbStatus["fldStatusCode"]);

            return cMenuDepartment.InsertUpdateData(oMenuDepartment);
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        public void LoadSearch()
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "fldMenuDepartmentCode";
            strFieldList[1] = "fldMenuDepartmentName";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Menu Department Code";
            strHeaderList[1] = "Menu Department Name";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 320;

            string strReturnString = "Menu Department Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtMenuDepartmentCode.Text = cCommonMethods.BrowsData("tbl_MenuDepartment", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Menu Department");
            if (txtMenuDepartmentCode.Text != "")
            {
                LoadMenuDepartmentDetails();
            }
        }

        #region Load Menu Department Details
        private void LoadMenuDepartmentDetails()
        {
            oMenuDepartment = cMenuDepartment.GetMenuDepartmentData(cGlobleVariable.LocationCode, this.txtMenuDepartmentCode.Text);

            txtMenuDepartmentName.Text = oMenuDepartment.MenuDepartmentName;

            cmbStatus.SetText(cStatusMaster.GetStatusByCode(oMenuDepartment.Status));

            this.txtMenuDepartmentName.Select();
            this.txtMenuDepartmentCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }
        #endregion

        private void txtMenuDepartmentCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                LoadSearch();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oMenuDepartment = cMenuDepartment.GetMenuDepartmentData(cGlobleVariable.LocationCode, this.txtMenuDepartmentCode.Text);

                if (oMenuDepartment.IsExists == true)
                {
                    if (InsertUpdateData() != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Menu Department", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Menu Department Data Not Update...!", "Menu Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
