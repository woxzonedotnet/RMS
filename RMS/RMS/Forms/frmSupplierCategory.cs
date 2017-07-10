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

namespace RMS.Forms
{
    public partial class frmSupplierCategory : Form
    {
        #region Objects
        objSupplierCategory oSupplierCategory = new objSupplierCategory();
        clsSupplierCategory cSupplierCategory = new clsSupplierCategory();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        #endregion

        #region Variables
        int result;
        Point lastClick;
        #endregion

        public frmSupplierCategory()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmSupplierCategory_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
            this.btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oSupplierCategory = cSupplierCategory.GetSupplierCategoryData(cGlobleVariable.LocationCode, this.txtSupplierCategoryCode.Text);

                if (oSupplierCategory.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Supplier Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Supplier Category Data Not Saved...!", "Supplier Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Supplier Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #region InsertUpdate SupplierCategory Data
        private int InsertUpdateData()
        {
            oSupplierCategory.LocationCode = cGlobleVariable.LocationCode.ToString();
            oSupplierCategory.SupplierCode = txtSupplierCategoryCode.Text;
            oSupplierCategory.Description = txtDescription.Text;
            oSupplierCategory.Status = Convert.ToInt16(cmbStatus["fldStatusCode"]);

            return cSupplierCategory.InsertUpdateData(oSupplierCategory);
        }
        #endregion


        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtSupplierCategoryCode.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
        }

        #region Validate Supplier Category Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtSupplierCategoryCode.Text == "")
            {
                errSupplierCategory.SetError(txtSupplierCategoryCode, "Please Enter Supplier Category Code");
                isValidate = false;
            }
            else
            {
                errSupplierCategory.SetError(txtSupplierCategoryCode, "");
            }

            if (txtDescription.Text == "")
            {
                errSupplierCategory.SetError(txtDescription, "Please Enter Description");
                isValidate = false;
            }
            else
            {
                errSupplierCategory.SetError(txtDescription, "");
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                errSupplierCategory.SetError(cmbStatus, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errSupplierCategory.SetError(cmbStatus, "");
            }

            return isValidate;
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "fldSupplierCategoryCode";
            strFieldList[1] = "fldDescription";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Supplier Category Code";
            strHeaderList[1] = "Description";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 320;

            string strReturnString = "Supplier Category Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtSupplierCategoryCode.Text = cCommonMethods.BrowsData("tbl_SupplierCategory", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Supplier Category");
            if (txtSupplierCategoryCode.Text != "")
            {
                LoadSupplierCategoryDetails();
            }
        }

        #region Load SubLocation Details
        private void LoadSupplierCategoryDetails()
        {
            oSupplierCategory = cSupplierCategory.GetSupplierCategoryData(cGlobleVariable.LocationCode, this.txtSupplierCategoryCode.Text);

            txtDescription.Text = oSupplierCategory.Description;


            cmbStatus.SetText(cStatusMaster.GetStatusByCode(oSupplierCategory.Status));

            this.txtDescription.Select();
            this.txtSupplierCategoryCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oSupplierCategory = cSupplierCategory.GetSupplierCategoryData(cGlobleVariable.LocationCode, this.txtSupplierCategoryCode.Text);

                if (oSupplierCategory.IsExists == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Supplier Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Supplier Category Data Not Update...!", "Supplier Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
