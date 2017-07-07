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
    public partial class frmCategoryMasterDetails : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        clsCategoryMaster cCategoryMaster = new clsCategoryMaster();
        clsDepartment cDepartment = new clsDepartment();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        objCategoryMaster oCategoryMaster = new objCategoryMaster();
        #endregion

        #region variables
        int result = -1;
        Point lastClick;
        #endregion

        public frmCategoryMasterDetails()
        {
            InitializeComponent();
            this.lblCategoryTitle.Text = this.Text;
        }

        private void frmCategoryMasterDetails_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cDepartment.GetDepartmentData(cGlobleVariable.LocationCode), cmbDepartmentName, 2);
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
            this.btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oCategoryMaster = cCategoryMaster.GetCategoryData(cGlobleVariable.LocationCode, this.txtCategoryCode.Text);

                if (oCategoryMaster.IsExistCategory == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Category Data Not Saved...!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.cmbDepartmentName.Enabled = true;
            this.txtCategoryCode.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
        }

        #region Validate Category Master Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (cmbDepartmentName.SelectedIndex==-1)
            {
                errCategory.SetError(cmbDepartmentName, "Please Select Department Name");
                isValidate = false;
            }
            else
            {
                errCategory.SetError(cmbDepartmentName, "");
            }

            if (txtCategoryCode.Text == "")
            {
                errCategory.SetError(txtCategoryCode, "Please Enter Category Code");
                isValidate = false;
            }
            else
            {
                errCategory.SetError(txtCategoryCode, "");
            }

            if (txtCategoryName.Text=="")
            {
                errCategory.SetError(txtCategoryName, "Please Enter Category Name");
                isValidate = false;
            }
            else
            {
                errCategory.SetError(txtCategoryName, "");
            }

            if (cmbStatus.SelectedIndex==-1)
            {
                errCategory.SetError(cmbStatus, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errCategory.SetError(cmbStatus, "");
            }

            return isValidate;
        }
        #endregion


        #region InsertUpdate Category Data
        private int InsertUpdateData()
        {
            oCategoryMaster.LocationCode = cGlobleVariable.LocationCode.ToString();
            oCategoryMaster.DepartmentCode = cmbDepartmentName["fldDepartmentCode"].ToString();
            oCategoryMaster.CategoryCode = txtCategoryCode.Text;
            oCategoryMaster.CategoryName = txtCategoryName.Text;
            oCategoryMaster.Status = Convert.ToInt16(cmbStatus["fldStatusCode"]);

            return cCategoryMaster.InsertUpdateData(oCategoryMaster);
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oCategoryMaster = cCategoryMaster.GetCategoryData(cGlobleVariable.LocationCode, this.txtCategoryCode.Text);

                if (oCategoryMaster.IsExistCategory == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Category Data Not Update...!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbDepartmentName.SelectedIndex != -1)
            {
                string[] strFieldList = new string[2];
                strFieldList[0] = "fldCategoryCode";
                strFieldList[1] = "fldCategoryName";

                string[] strHeaderList = new string[2];
                strHeaderList[0] = "Category Code";
                strHeaderList[1] = "Category Name";

                int[] iHeaderWidth = new int[2];
                iHeaderWidth[0] = 150;
                iHeaderWidth[1] = 320;

                string strReturnString = "Category Code";
                string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "' and fldDepartmentCode='" + this.cmbDepartmentName["fldDepartmentCode"].ToString() + "'";
                txtCategoryCode.Text = cCommonMethods.BrowsData("tbl_CategoryMaster", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Category");
                if (txtCategoryCode.Text != "")
                {
                    LoadDepartmentDetails();
                }
            }
            else 
            {
                MessageBox.Show("Please Select Department Name First");
            }
        }

        #region Load Category Details
        private void LoadDepartmentDetails()
        {
            oCategoryMaster = cCategoryMaster.GetCategoryData(cGlobleVariable.LocationCode, this.txtCategoryCode.Text);

            this.txtCategoryName.Text = oCategoryMaster.CategoryName;


            cmbStatus.SetText(cStatusMaster.GetStatusByCode(oCategoryMaster.Status));

            this.txtCategoryName.Select();
            this.cmbDepartmentName.Enabled = false;
            this.txtCategoryCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
