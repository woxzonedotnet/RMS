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
    public partial class frmSetupSetting : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsMainLocation cMainLocation = new clsMainLocation();
        objSetupSetting oSetupSetting = new objSetupSetting();
        clsSetupSetting cSetupSetting = new clsSetupSetting();
        #endregion

        #region Variables
        Point lastClick;
        #endregion

        public frmSetupSetting()
        {
            InitializeComponent();
            lblTitle.Text = this.Text;
            cCommonMethods.loadComboRMS(cMainLocation.GetMainLocationDetails(),cmbMainLocation,2);
            clear();
        }

        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.cmbMainLocation.Enabled = true;
            this.btnSave.Enabled = true;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (InsertUpdateData() != -1)
                {
                    MessageBox.Show("Successfully Saved...!", "Setup Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("Data Not Saved...!", "Setup Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region InsertUpdate Setup Setting Data
        private int InsertUpdateData()
        {
            oSetupSetting.LocationCode = this.cmbMainLocation["fldLocationCode"].ToString();
            oSetupSetting.ServiceCharge = Convert.ToDecimal(this.txtServiceCharge.Text);
            oSetupSetting.VAT = Convert.ToDecimal(this.txtVat.Text);
            oSetupSetting.GuidCharge = Convert.ToDecimal(this.txtGuidCharge.Text);

            return cSetupSetting.InsertUpdateData(oSetupSetting);
        }
        #endregion

        #region Validate Setup Setting Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (cmbMainLocation.SelectedIndex < 0)
            {
                errSetupSetting.SetError(cmbMainLocation, "Please Select Main Location");
                isValidate = false;
            }
            else
            {
                errSetupSetting.SetError(cmbMainLocation, "");
            }

            return isValidate;
        }
        #endregion

        private void cmbMainLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSetupSettingDetails();
        }

        #region Load Department Details
        private void LoadSetupSettingDetails()
        {
            oSetupSetting = cSetupSetting.GetSetupSettingData(this.cmbMainLocation["fldLocationCode"].ToString());

            this.txtServiceCharge.Text = oSetupSetting.ServiceCharge.ToString();
            this.txtVat.Text = oSetupSetting.VAT.ToString();
            this.txtGuidCharge.Text = oSetupSetting.GuidCharge.ToString();

            this.txtServiceCharge.Select();
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
