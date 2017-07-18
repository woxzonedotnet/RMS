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
    public partial class frmCustomerDetails : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        objCustomerMaster oCustomerMaster = new objCustomerMaster();
        clsCustomerMaster cCustomerMaster = new clsCustomerMaster();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        #endregion

        #region Variables
        int result=-1;
        Point lastClick;
        #endregion

        public frmCustomerDetails()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oCustomerMaster = cCustomerMaster.GetCustomerData(cGlobleVariable.LocationCode, this.txtCustomerCode.Text);

                if (oCustomerMaster.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Customer Data Not Saved...!", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #region InsertUpdate Department Data
        private int InsertUpdateData()
        {
            oCustomerMaster.LocationCode = cGlobleVariable.LocationCode.ToString();
            oCustomerMaster.CustomerCode=this.txtCustomerCode.Text;
            oCustomerMaster.CustomerName=this.txtCustomerName.Text;
            oCustomerMaster.CustomerAddress=this.txtCustomerAddress.Text;
            oCustomerMaster.ContactNo=this.txtContactNo.Text;
            oCustomerMaster.Email=this.txtEmail.Text;
            oCustomerMaster.CreditLimit=Convert.ToDouble(this.txtCreditLimit.Text);
            oCustomerMaster.Discount = Convert.ToDouble(this.txtDiscount.Text);
            oCustomerMaster.VatNo = this.txtVatNo.Text;
            oCustomerMaster.IsServiceCharge = this.chkServiceCharge.Checked;
            oCustomerMaster.IsCreditCustomer = this.chkCreditCustomer.Checked;
            oCustomerMaster.IsComplementary = this.chkComplementry.Checked;

            return cCustomerMaster.InsertUpdateData(oCustomerMaster);
        }
        #endregion


        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtCustomerCode.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
        }

        #region Validate Customer Master Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtCustomerCode.Text == "")
            {
                errCustomer.SetError(txtCustomerCode, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errCustomer.SetError(txtCustomerCode, "");

            }

            if (txtCustomerName.Text == "")
            {
                errCustomer.SetError(txtCustomerName, "Please Enter Customer Name");
                isValidate = false;
            }
            else
            {
                errCustomer.SetError(txtCustomerName, "");
            }

            if (txtContactNo.Text == "")
            {
                errCustomer.SetError(txtContactNo, "Please Enter Customer Contact no");
                isValidate = false;
            }
            else
            {
                errCustomer.SetError(txtContactNo, "");
            }
            return isValidate;
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oCustomerMaster = cCustomerMaster.GetCustomerData(cGlobleVariable.LocationCode, this.txtCustomerCode.Text);

                if (oCustomerMaster.IsExists == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Customer Data Not Update...!", "Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void LoadSearch()
        {
            string[] strFieldList = new string[4];
            strFieldList[0] = "fldCustomerCode";
            strFieldList[1] = "fldCustomerName";
            strFieldList[2] = "fldContactNo";
            strFieldList[3] = "fldEmail";

            string[] strHeaderList = new string[4];
            strHeaderList[0] = "Customer Code";
            strHeaderList[1] = "Customer Name";
            strHeaderList[2] = "Contact No";
            strHeaderList[3] = "Email";

            int[] iHeaderWidth = new int[4];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 320;
            iHeaderWidth[2] = 150;
            iHeaderWidth[3] = 150;

            string strReturnString = "Customer Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtCustomerCode.Text = cCommonMethods.BrowsData("tbl_CustomerMaster", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Customer Details");
            if (txtCustomerCode.Text != "")
            {
                LoadDepartmentDetails();
            }
        }

        #region Load Department Details
        private void LoadDepartmentDetails()
        {
            oCustomerMaster = cCustomerMaster.GetCustomerData(cGlobleVariable.LocationCode, this.txtCustomerCode.Text);

            txtCustomerName.Text = oCustomerMaster.CustomerName;
            txtCustomerAddress.Text = oCustomerMaster.CustomerAddress;
            txtContactNo.Text = oCustomerMaster.ContactNo;
            txtEmail.Text = oCustomerMaster.Email;
            txtCreditLimit.Text = oCustomerMaster.CreditLimit.ToString();
            txtDiscount.Text = oCustomerMaster.Discount.ToString();
            txtVatNo.Text = oCustomerMaster.VatNo;

            if (oCustomerMaster.IsServiceCharge) 
            {
                chkServiceCharge.Checked = true;
            }

            if (oCustomerMaster.IsCreditCustomer)
            {
                chkCreditCustomer.Checked = true;
            }

            if (oCustomerMaster.IsComplementary)
            {
                chkComplementry.Checked = true;
            }

            this.txtCustomerName.Select();
            this.txtCustomerCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }
        #endregion


        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void txtCustomerCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                LoadSearch();
            }
        }
    }
}
