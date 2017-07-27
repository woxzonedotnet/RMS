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


namespace RMS.Forms.Inventory
{
    public partial class frmStockAdjustmentNote : Form
    {
        #region
        int result;
        #endregion

        #region Objects
        clsStockAdjustmentNote cStockAdjustmentNote = new clsStockAdjustmentNote();
        objStockAdjustmentNote oStockAdjustmentNote = new objStockAdjustmentNote();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
    #endregion



        public frmStockAdjustmentNote()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oStockAdjustmentNote = cStockAdjustmentNote.GetStockAdjustmentNote(txtSANNumber.Text);

                if (oStockAdjustmentNote.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Bank Card", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Data not Saved...!", "Bank Card", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Bank Card", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #region InsertUpdate BankCard Data
        private int InsertUpdateData()
        {
            oStockAdjustmentNote.SANNumber = txtSANNumber.Text;
            oStockAdjustmentNote.Location = cmbLocation["fldBankCode"].ToString();
            oStockAdjustmentNote.Date = DateTime.Parse(dtpDate.ToString());
            oStockAdjustmentNote.TotalCost =decimal.Parse(txtTotalCost.Text);

            return cStockAdjustmentNote.InsertUpdateData(oStockAdjustmentNote);

        }
        #endregion
             #region Validate Bank Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtSANNumber.Text == "")
            {
                errStockAdjusment.SetError(txtSANNumber, "Please Enter Card Code");
                isValidate = false;
            }
            else
            {
                errStockAdjusment.SetError(txtSANNumber, "");

            }

            if (cmbLocation.SelectedIndex == -1)
            {
                errStockAdjusment.SetError(cmbLocation, "Please Select Bank");
                isValidate = false;
            }
            else
            {
                errStockAdjusment.SetError(cmbLocation, "");
            }

            if (dtpDate.Text == null)
            {
                errStockAdjusment.SetError(dtpDate, "Please Select Card Type");
                isValidate = false;
            }
            else
            {
                errStockAdjusment.SetError(dtpDate, "");
            }

            if (txtTotalCost.Text== null)
            {
                errStockAdjusment.SetError(txtTotalCost, "Please Select Currency");
                isValidate = false;
            }
            else
            {
                errStockAdjusment.SetError(txtTotalCost, "");
            }

           
            return isValidate;
        }
        #endregion
               #region Clear
        public void clear()
        {
            //cCommonMethods.ClearForm(this);
            //this.txtCardCode.Enabled = true;
            //this.btnSave.Enabled = true;
            //this.btnUpdate.Enabled = false;
            //this.txtCardCode.Focus();
        }
        #endregion
        private void txtTotalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmStockAdjustmentNote_Load(object sender, EventArgs e)
        {

        }
        }
}

