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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "fldSubLocationCode";
            strFieldList[1] = "fldSubLocationName";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Sub Location Code";
            strHeaderList[1] = "Sub Location Name";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 320;

            string strReturnString = "Sub Location Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtSubLocationCode.Text = cCommonMethods.BrowsData("tbl_SubLocation", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Sub Location Data");
            if (txtSubLocationCode.Text !="")
            {
                LoadSubLocationDetails();
            }
        }

        #region LoadCategoryData
        private void LoadSubLocationDetails()
        {
            oSubLocation = cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, this.txtSubLocationCode.Text);
           
            txtSubLocationName.Text = oSubLocation.SubLocationName;
            if (oSubLocation.IsOrderLocation == true)
            {
                chkIsOrderLocation.Checked = true;
            }
            else
            {
                chkIsOrderLocation.Checked = false;
            }

            if (oSubLocation.ShowInFrontEnd == true)
            {
                chkShowInFrontEnd.Checked = true;
            }
            else
            {
                chkShowInFrontEnd.Checked = false;
            }
            this.txtSubLocationName.Select();
            this.txtSubLocationCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
            this.btnDelete.Enabled = true;
        }
        #endregion

        public void clear() 
        {
            cCommonMethods.ClearForm(this);
            this.txtSubLocationCode.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void frmSubLocation_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oSubLocation = cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, txtSubLocationCode.Text);

                if (oSubLocation.IsExists == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Sub Location", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Data not Update...!", "Sub Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this record...?", "Sub Location Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                result = cSubLocation.DeleteLocationData(this.txtSubLocationCode.Text);
                if (result != -1)
                {
                    MessageBox.Show("Record Deleted...!", "Sub Location Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtSubLocationCode.Select();
                    clear();
                }
                else
                {
                    MessageBox.Show("Record Not Deleted...!", "Sub Location Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
