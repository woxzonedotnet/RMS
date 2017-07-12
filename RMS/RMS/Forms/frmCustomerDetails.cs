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
        #endregion

        #region Variables
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
            cCommonMethods.ClearForm(this);
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

        #region Validate Customer Master Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtCustomerID.Text == "")
            {
                errCustomer.SetError(txtCustomerID, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errCustomer.SetError(txtCustomerID, "");

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
    }
}
