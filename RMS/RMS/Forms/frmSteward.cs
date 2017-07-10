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
    public partial class frmSteward : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsSteward cSteward = new clsSteward();
        objSteward oSteward = new objSteward();
        clsStatusMaster cStatusMaster = new clsStatusMaster(); 
        #endregion

        #region Variables
        int result = -1;
        Point lastClick;
        #endregion

        public frmSteward()
        {
            InitializeComponent();
            this.lblStewardTitle.Text = this.Text;
        }

        private void frmSteward_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
            this.btnUpdate.Enabled = false;
        }

        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtStewardCode.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oSteward = cSteward.GetStewardData(cGlobleVariable.LocationCode, this.txtStewardCode.Text);

                if (oSteward.IsExits == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Steward", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Steward Data Not Saved...!", "Steward", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Steward", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #region Validate Steward Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtStewardCode.Text == "")
            {
                errSteward.SetError(txtStewardCode, "Please Enter Steward Code");
                isValidate = false;
            }
            else
            {
                errSteward.SetError(txtStewardCode, "");
            }

            if (txtStewardName.Text == "")
            {
                errSteward.SetError(txtStewardName, "Please Enter Steward Name");
                isValidate = false;
            }
            else
            {
                errSteward.SetError(txtStewardName, "");
            }

            if (txtPassword.Text == "")
            {
                errSteward.SetError(txtPassword, "Please Enter Password");
                isValidate = false;
            }
            else
            {
                errSteward.SetError(txtPassword, "");
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                errSteward.SetError(cmbStatus, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errSteward.SetError(cmbStatus, "");
            }

            return isValidate;
        }
        #endregion

        #region InsertUpdate Steward Data
        private int InsertUpdateData()
        {
            oSteward.LocationCode = cGlobleVariable.LocationCode.ToString();
            oSteward.StewardCode = this.txtStewardCode.Text;
            oSteward.StewardName = this.txtStewardName.Text;
            oSteward.Password = this.txtPassword.Text;
            oSteward.Status = Convert.ToInt16(cmbStatus["fldStatusCode"]);

            return cSteward.InsertUpdateData(oSteward);
        }
        #endregion

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
            strFieldList[0] = "fldStewardCode";
            strFieldList[1] = "fldStewardName";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Steward Code";
            strHeaderList[1] = "Steward Name";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 320;

            string strReturnString = "Steward Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtStewardCode.Text = cCommonMethods.BrowsData("tbl_Steward", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Steward");
            if (txtStewardCode.Text != "")
            {
                LoadStewardDetails();
            }
        }

        public void LoadStewardDetails() 
        {
            oSteward = cSteward.GetStewardData(cGlobleVariable.LocationCode, this.txtStewardCode.Text);

            this.txtStewardName.Text = oSteward.StewardName;
            this.txtPassword.Text = oSteward.Password;
            
            cmbStatus.SetText(cStatusMaster.GetStatusByCode(oSteward.Status));

            this.txtStewardName.Select();
            this.txtStewardCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oSteward = cSteward.GetStewardData(cGlobleVariable.LocationCode, this.txtStewardCode.Text);

                if (oSteward.IsExits == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Steward", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Steward Data Not Update...!", "Steward", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void txtStewardCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                LoadSearch();
            }
        }
    }
}
