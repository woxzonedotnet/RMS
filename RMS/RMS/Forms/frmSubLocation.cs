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
    public partial class frmSubLocation : Form
    {
        #region Objects
        clsSubLocation cSubLocation = new clsSubLocation();
        objSubLocation oSubLocation = new objSubLocation();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        #endregion

        #region Variables
        int result;
        #endregion

        public frmSubLocation()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oSubLocation = cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode,txtSubLocationCode.Text);

                if (oSubLocation.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Sub Location", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
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

        #region Validate Sub Location Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtSubLocationCode.Text == "")
            {
                errSubLocation.SetError(txtSubLocationCode, "Please Enter Location Code");
                isValidate = false;
            }
            else
            {
                errSubLocation.SetError(txtSubLocationCode, "");

            }

            if (txtSubLocationName.Text == "")
            {
                errSubLocation.SetError(txtSubLocationName, "Please Enter Location Name");
                isValidate = false;
            }
            else
            {
                errSubLocation.SetError(txtSubLocationName, "");

            }
            return isValidate;
        }
        #endregion

        #region InsertUpdate SubLocation Data
        private int InsertUpdateData()
        {
            oSubLocation.LocationCode = cGlobleVariable.LocationCode.ToString();
            oSubLocation.SubLocationCode = txtSubLocationCode.Text.ToString();
            oSubLocation.SubLocationName = txtSubLocationName.Text.ToString();
            oSubLocation.ShowInFrontEnd = chkShowInFrontEnd.Checked;
            oSubLocation.IsOrderLocation = chkIsOrderLocation.Checked;

            return cSubLocation.InsertUpdateData(oSubLocation);
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
