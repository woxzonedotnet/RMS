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
    public partial class frmMenuCategoryDetails : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        clsMenuDepartment cMenuDepartment = new clsMenuDepartment();
        objMenuCategory oMenuCategory = new objMenuCategory();
        clsMenuCategory cMenuCategory = new clsMenuCategory();
        #endregion

        #region Variables
        Point lastClick;
        #endregion

        public frmMenuCategoryDetails()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
            cCommonMethods.loadComboRMS(cMenuDepartment.GetMenuDepartmentData(cGlobleVariable.LocationCode), cmbMenuDepartment, 2);
            clear();
        }

        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtMenuCategoryCode.Enabled = true;
            this.cmbMenuDepartment.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
            this.txtMenuCategoryCode.Focus();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oMenuCategory = cMenuCategory.GetMenuCategoryData(cGlobleVariable.LocationCode, this.cmbMenuDepartment["fldMenuDepartmentCode"].ToString(),this.txtMenuCategoryCode.Text);

                if (oMenuCategory.IsExists == false)
                {
                    if (InsertUpdateData() != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Menu Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Data Not Saved...!", "Menu Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Menu Department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #region InsertUpdate Menu Category
        private int InsertUpdateData()
        {
            oMenuCategory.LocationCode = cGlobleVariable.LocationCode.ToString();
            oMenuCategory.MenuDepartmentCode = this.cmbMenuDepartment["fldMenuDepartmentCode"].ToString();
            oMenuCategory.MenuCategoryCode = this.txtMenuCategoryCode.Text;
            oMenuCategory.MenuCategoryName = this.txtMenuCategoryName.Text;
            oMenuCategory.Status = Convert.ToInt16(cmbStatus["fldStatusCode"]);

            return cMenuCategory.InsertUpdateData(oMenuCategory);
        }
        #endregion

        #region Validate Menu Category Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (cmbMenuDepartment.SelectedIndex < 0)
            {
                errMenuCategory.SetError(cmbMenuDepartment, "Please Select Menu Category Code");
                isValidate = false;
            }
            else
            {
                errMenuCategory.SetError(cmbMenuDepartment, "");

            }

            if (txtMenuCategoryCode.Text == "")
            {
                errMenuCategory.SetError(txtMenuCategoryCode, "Please Enter Menu Category Code");
                isValidate = false;
            }
            else
            {
                errMenuCategory.SetError(txtMenuCategoryCode, "");
            }

            if (txtMenuCategoryName.Text == "")
            {
                errMenuCategory.SetError(txtMenuCategoryName, "Please Enter Menu Category Name");
                isValidate = false;
            }
            else
            {
                errMenuCategory.SetError(txtMenuCategoryName, "");
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                errMenuCategory.SetError(cmbStatus, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errMenuCategory.SetError(cmbStatus, "");
            }

            return isValidate;
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        public void LoadSearch()
        {
            if (this.cmbMenuDepartment.SelectedIndex > -1)
            {
                string[] strFieldList = new string[2];
                strFieldList[0] = "fldMenuCategoryCode";
                strFieldList[1] = "fldMenuCategoryName";

                string[] strHeaderList = new string[2];
                strHeaderList[0] = "Menu Category Code";
                strHeaderList[1] = "Menu Category Name";

                int[] iHeaderWidth = new int[2];
                iHeaderWidth[0] = 150;
                iHeaderWidth[1] = 320;

                string strReturnString = "Menu Category Code";
                string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "' and fldMenuDepartmentCode='"+ this.cmbMenuDepartment["fldMenuDepartmentCode"] +"'";
                txtMenuCategoryCode.Text = cCommonMethods.BrowsData("tbl_MenuCategory", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Menu Department");
                if (txtMenuCategoryCode.Text != "")
                {
                    LoadMenuCategoryDetails();
                }
            }
            else 
            {
                MessageBox.Show("Please Select Menu Department First");
            }
        }

        #region Load Menu Category Details
        private void LoadMenuCategoryDetails()
        {
            oMenuCategory = cMenuCategory.GetMenuCategoryData(cGlobleVariable.LocationCode, this.cmbMenuDepartment["fldMenuDepartmentCode"].ToString(),this.txtMenuCategoryCode.Text);

            txtMenuCategoryName.Text = oMenuCategory.MenuCategoryName;

            cmbStatus.SetText(cStatusMaster.GetStatusByCode(oMenuCategory.Status));

            this.txtMenuCategoryName.Select();
            this.cmbMenuDepartment.Enabled = false;
            this.txtMenuCategoryCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }
        #endregion

        private void txtMenuCategoryCode_KeyDown(object sender, KeyEventArgs e)
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
                oMenuCategory = cMenuCategory.GetMenuCategoryData(cGlobleVariable.LocationCode, this.cmbMenuDepartment["fldMenuDepartmentCode"].ToString(), this.txtMenuCategoryCode.Text);

                if (oMenuCategory.IsExists == true)
                {
                    if (InsertUpdateData() != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Menu Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Data Not Update...!", "Menu Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmMenuCategoryDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
