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
        #endregion

        #region Variables
        int result;
        #endregion

        public frmDepartmentDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oDepartment = cDepartment.GetDepartmentData(cGlobleVariable.LocationCode, txtDepartmentCode.Text);

                if (oDepartment.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Sub Location", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data not Saved...!", "Sub Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Sub Location", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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
            return isValidate;
        }
        #endregion

        #region InsertUpdate Department Data
        private int InsertUpdateData()
        {
            
            oDepartment.LocationCode = cGlobleVariable.LocationCode.ToString();
            oDepartment.DepartmentCode = txtDepartmentCode.Text;
            oDepartment.DepartmentName = txtDepartmentName.Text;

            return cDepartment.InsertUpdateData(oDepartment);
        }
        #endregion
    }
}
