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
    public partial class frmSupplierDetails : Form
    {
        #region Objects
        clsSupplierMaster cSupplierMaster = new clsSupplierMaster();
        objSupplierMaster oSupplierMaster = new objSupplierMaster();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        clsSupplierCategory cSupplierCategory = new clsSupplierCategory();
        #endregion

        #region Variables
        int result=-1;
        Point lastClick;
        #endregion

        public frmSupplierDetails()
        {
            InitializeComponent();
            clear();
            this.lblTitle.Text = this.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oSupplierMaster = cSupplierMaster.GetSupplierData(cGlobleVariable.LocationCode, this.txtSupplierCode.Text);

                if (oSupplierMaster.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Supplier Master", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Supplier Category Data Not Saved...!", "Supplier Master", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Supplier Master", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        #region InsertUpdate SupplierCategory Data
        private int InsertUpdateData()
        {
            oSupplierMaster.LocationCode = cGlobleVariable.LocationCode;
            oSupplierMaster.SupplierCode = this.txtSupplierCode.Text;
            oSupplierMaster.SupplierName = this.txtSupplierName.Text;
            oSupplierMaster.ContactPerson = this.txtContactPerson.Text;
            oSupplierMaster.Address = this.txtAddress.Text;
            oSupplierMaster.TellephoneNo = this.txtTellephoneNo.Text;
            oSupplierMaster.Fax = this.txtFax.Text;
            oSupplierMaster.Email = this.txtEmail.Text;
            oSupplierMaster.SupplierCategoryCode = this.cmbSupplierCategory["fldSupplierCategoryCode"].ToString();
            oSupplierMaster.Discount = Convert.ToDouble(this.txtDiscount.Text);
            oSupplierMaster.Consignment = this.chkConsignment.Checked;
            oSupplierMaster.EnterdDate = this.dtpEnterdDate.Value;
            oSupplierMaster.CancelDate = this.dtpCancelDate.Value;
            oSupplierMaster.Status = Convert.ToInt16(this.cmbStatus["fldStatusCode"]);

            return cSupplierMaster.InsertUpdateData(oSupplierMaster);
        }
        #endregion

        public void clear()
        {
            cCommonMethods.ClearForm(this);

            this.txtSupplierCode.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
            this.txtSupplierCode.Focus();
        }

        #region Validate Supplier Master Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtSupplierCode.Text == "")
            {
                errSupplier.SetError(txtSupplierCode, "Please Enter Supplier Code");
                isValidate = false;
            }
            else
            {
                errSupplier.SetError(txtSupplierCode, "");
            }

            if (txtSupplierName.Text == "")
            {
                errSupplier.SetError(txtSupplierName, "Please Enter Supplier Name");
                isValidate = false;
            }
            else
            {
                errSupplier.SetError(txtSupplierName, "");
            }

            if (txtEmail.Text=="")
            {
                errSupplier.SetError(txtEmail, "Please Enter Telephone No");
                isValidate = false;
            }
            else
            {
                errSupplier.SetError(txtEmail, "");
            }

            if (cmbSupplierCategory.SelectedIndex == -1)
            {
                errSupplier.SetError(cmbSupplierCategory, "Please Select Supplier Category");
                isValidate = false;
            }
            else
            {
                errSupplier.SetError(cmbSupplierCategory, "");
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                errSupplier.SetError(cmbStatus, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errSupplier.SetError(cmbStatus, "");
            }

            return isValidate;
        }
        #endregion

        private void frmSupplierDetails_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
            cCommonMethods.loadComboRMS(cSupplierCategory.GetSupplierCategoryData(cGlobleVariable.LocationCode), cmbSupplierCategory, 2);
            clear();
        }

        private void chkConsignment_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkConsignment.Checked)
            {
                this.chkConsignment.Text = "Yes";
            }
            else 
            {
                this.chkConsignment.Text = "No";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
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
            txtSupplierCode.Text = cCommonMethods.BrowsData("tbl_SupplierMaster", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Supplier Master");
            if (txtSupplierCode.Text != "")
            {
                LoadSupplierCategoryDetails();
            }
        }

        #region Load Supplier Details
        private void LoadSupplierCategoryDetails()
        {
            oSupplierMaster = cSupplierMaster.GetSupplierData(cGlobleVariable.LocationCode, this.txtSupplierCode.Text);

            txtSupplierName.Text = oSupplierMaster.SupplierName;
            txtContactPerson.Text = oSupplierMaster.ContactPerson;
            txtAddress.Text = oSupplierMaster.Address;
            txtTellephoneNo.Text = oSupplierMaster.TellephoneNo;
            txtFax.Text = oSupplierMaster.Fax;
            txtEmail.Text = oSupplierMaster.Email;
            cmbSupplierCategory.SetText(cSupplierCategory.GetSupplierCategoryData(cGlobleVariable.LocationCode,oSupplierMaster.SupplierCategoryCode).Description);
            txtDiscount.Text = oSupplierMaster.Discount.ToString();

            if (oSupplierMaster.Consignment)
            {
                chkConsignment.Checked = true;
            }
            else 
            {
                chkConsignment.Checked = false;
            }

            dtpEnterdDate.Value = oSupplierMaster.EnterdDate;
            dtpCancelDate.Value = oSupplierMaster.CancelDate;

            cmbStatus.SetText(cStatusMaster.GetStatusByCode(oSupplierMaster.Status));

            this.txtSupplierName.Select();
            this.txtSupplierCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        private void txtSupplierCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                LoadSearch();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oSupplierMaster = cSupplierMaster.GetSupplierData(cGlobleVariable.LocationCode, this.txtSupplierCode.Text);

                if (oSupplierMaster.IsExists == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Supplier Master", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Supplier Data Not Update...!", "Supplier Master", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cmbSupplierCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
