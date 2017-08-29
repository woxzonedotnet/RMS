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

namespace RMS.Forms.Security
{
    public partial class frmUser : Form
    {
        #region Objects
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        clsDocumentNumber cDocumentNumber = new clsDocumentNumber();
        objDocumentNumber oDocumentNumber = new objDocumentNumber();
        clsUserLevel cUserLevel = new clsUserLevel();
        objUserMaster oUserMaster = new objUserMaster();
        clsUserMaster cUserMaster = new clsUserMaster();
        clsMainLocation cMainLocation = new clsMainLocation();
        #endregion

        #region Variables
        Point lastClick;
        string DocumentCode = "U";
        int result = 0;
        bool save;
        bool update;
        #endregion

        public frmUser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            LoadDocumentNumber();
            this.btnUpdate.Enabled = false;
            save = btnSave.Enabled;
            update = btnUpdate.Enabled;
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbActiveState, 1);
            cCommonMethods.loadComboRMS(cUserLevel.GetActiveUserLevelData(), cmbUserLevel, 2);
            cCommonMethods.loadComboRMS(cMainLocation.GetMainLocationDetails(), cmbLocation, 2);
        }

        public void LoadDocumentNumber()
        {
            this.txtUserCode.Text = cDocumentNumber.LoadDocNumber(cGlobleVariable.UniqID, DocumentCode, cGlobleVariable.LocationCode, cCommonMethods.DateYear());
        }

        #region Form Move
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        #region Clear
        public void clear()
        {
            cCommonMethods.ClearForm(this);
            LoadDocumentNumber();
            this.txtUserCode.ReadOnly = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oUserMaster = cUserMaster.GetUserData(cGlobleVariable.LocationCode, txtUserCode.Text);

                if (oUserMaster.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result == -5)
                    {
                        MessageBox.Show("Data Not Changed...!", "User Master", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result != -1)
                    {

                        cDocumentNumber.DeleteDocumentNumber(cGlobleVariable.UniqID, DocumentCode, this.txtUserCode.Text);
                        MessageBox.Show("Successfully Saved...!", "User Master", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnUpdate.Enabled = true;
                        this.btnSave.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Item Data Not Saved...!", "User Master", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Record already exist...!", "User Master", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #region Validate User Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtUserName.Text == "")
            {
                errU.SetError(txtUserName, "Please Enter User Name");
                isValidate = false;
            }
            else
            {
                errU.SetError(txtUserName, "");
            }

            if (txtPassword.Text == "")
            {
                errU.SetError(txtPassword, "Please Enter Password");
                isValidate = false;
            }
            else
            {
                errU.SetError(txtPassword, "");
            }

            if (txtConfirmPassword.Text == "")
            {
                errU.SetError(txtConfirmPassword, "Please Enter Confirm Password");
                isValidate = false;
            }
            else
            {
                errU.SetError(txtConfirmPassword, "");
            }

            if (cmbLocation.SelectedIndex < 0)
            {
                errU.SetError(cmbLocation, "Please Select Location");
                isValidate = false;
            }
            else
            {
                errU.SetError(cmbLocation, "");
            }

            if (cmbUserLevel.SelectedIndex < 0)
            {
                errU.SetError(cmbUserLevel, "Please Select User Level");
                isValidate = false;
            }
            else
            {
                errU.SetError(cmbUserLevel, "");
            }

            if (cmbActiveState.SelectedIndex < 0)
            {
                errU.SetError(cmbActiveState, "Please Select Active State");
                isValidate = false;
            }
            else
            {
                errU.SetError(cmbActiveState, "");
            }

            return isValidate;
        }
        #endregion

        #region InsertUpdate User Data
        private int InsertUpdateData()
        {
            oUserMaster.LocationCode = cmbLocation["fldLocationCode"].ToString();
            oUserMaster.UserCode = this.txtUserCode.Text;
            oUserMaster.UserName = this.txtUserName.Text;
            oUserMaster.Password = this.txtPassword.Text;
            oUserMaster.UserLevel = cmbUserLevel["fldUserLevelCode"].ToString();
            oUserMaster.Status = Convert.ToInt16(cmbActiveState["fldStatusCode"]);

            return cUserMaster.InsertUpdateData(oUserMaster);
        }
        #endregion

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errU.SetError(txtConfirmPassword, "Password and Confirm Password Should be Same");
                save = btnSave.Enabled;
                update = btnUpdate.Enabled;
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                errU.SetError(txtConfirmPassword, "");
                btnSave.Enabled = save;
                btnUpdate.Enabled = update;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        #region Search User Level Details
        public void LoadSearch()
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "fldUserCode";
            strFieldList[1] = "fldUserName";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "User Code";
            strHeaderList[1] = "User Name";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 100;
            iHeaderWidth[1] = 150;

            string strReturnString = "User Code";
            string strWhere = "fldLocationCode LIKE '%'";
            txtUserCode.Text = cCommonMethods.BrowsData("tbl_UserMaster", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "User Code");
            if (txtUserCode.Text != "")
            {
                LoadUserDetails();
            }
        }
        #endregion

        #region Load User Details
        private void LoadUserDetails()
        {
            oUserMaster = cUserMaster.GetUserData(oUserMaster.LocationCode, this.txtUserCode.Text);

            txtUserName.Text = oUserMaster.UserName;
            txtPassword.Text = oUserMaster.Password;
            txtConfirmPassword.Text = oUserMaster.Password;
            cmbLocation.SetText(cMainLocation.GetMainLocationData(oUserMaster.LocationCode).MainLocationName);
            cmbUserLevel.SetText(cUserLevel.GetUserLevelData(oUserMaster.LocationCode, oUserMaster.UserLevel).UserLevel);
            cmbActiveState.SetText(cStatusMaster.GetStatusByCode(oUserMaster.Status));
            
            if (!oUserMaster.Changeable)
            {
                cmbActiveState.Enabled = false;
                cmbUserLevel.Enabled = false;
            }
            else
            {
                cmbActiveState.Enabled = true;
                cmbUserLevel.Enabled = true;
            }


            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oUserMaster = cUserMaster.GetUserData(cGlobleVariable.LocationCode, txtUserCode.Text);

                if (oUserMaster.IsExists == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Data not Update...!", "User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
