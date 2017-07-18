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
    public partial class frmBankDetails : Form
    {
        #region Object
        objBankDetails oBankDetails = new objBankDetails();
        clsBankDetails cBankDetails = new clsBankDetails();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsStatusMaster cStatusMaster = new clsStatusMaster(); 
        #endregion

        #region Variables
        int result;
        Point lastClick;
        #endregion

        public frmBankDetails()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
        }



        private void txtDepartmentCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBankDetails_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
            clear();
        }

        private void lblDepartmentName_Click(object sender, EventArgs e)
        {

        }

        #region InsertUpdate Bank Data
        private int InsertUpdateData()
        {
            oBankDetails.BankCode = txtBankCode.Text;
            oBankDetails.BankName = txtBankName.Text;
            oBankDetails.Status = Convert.ToInt16(cmbStatus["fldStatusCode"]);

            return cBankDetails.InsertUpdateData(oBankDetails);
        }
        #endregion


        #region Validate Bank Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtBankCode.Text == "")
            {
                errBank.SetError(txtBankCode, "Please Enter Bank Code");
                isValidate = false;
            }
            else
            {
                errBank.SetError(txtBankCode, "");

            }

            if (txtBankName.Text == "")
            {
                errBank.SetError(txtBankName, "Please Enter Bank Name");
                isValidate = false;
            }
            else
            {
                errBank.SetError(txtBankName, "");

            }

            if (cmbStatus.SelectedIndex == -1)
            {
                errBank.SetError(cmbStatus, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errBank.SetError(cmbStatus, "");
            }
            return isValidate;
        }
        #endregion

        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtBankCode.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oBankDetails = cBankDetails.GetBankData(txtBankCode.Text);

                if (oBankDetails.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Data not Saved...!", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oBankDetails = cBankDetails.GetBankData(txtBankCode.Text);

                if (oBankDetails.IsExists == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Data not Update...!", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }


        public void LoadSearch() 
        {
             string[] strFieldList = new string[2];
            strFieldList[0] = "fldBankCode";
            strFieldList[1] = "fldBankName";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Bank Code";
            strHeaderList[1] = "Bank Name";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 320;

            string strReturnString = "Bank Code";
            string strWhere = "fldStatus LIKE '%'";
            txtBankCode.Text = cCommonMethods.BrowsData("tbl_BankMaster", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Bank Code");
            if (txtBankCode.Text != "")
            {
                LoadBankDetails();
            }
        }

        #region Load Bank Details
        private void LoadBankDetails()
        {
            oBankDetails = cBankDetails.GetBankData(txtBankCode.Text);

            txtBankName.Text = oBankDetails.BankName;
            
            cmbStatus.SetText(cStatusMaster.GetStatusByCode(oBankDetails.Status));

            this.txtBankName.Select();
            this.txtBankCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }
        #endregion

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

        private void txtBankCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                LoadSearch();
            }
        }
    }
}
