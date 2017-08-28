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

namespace RMS
{
    public partial class frmLogin : Form
    {
        #region Objects
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsUserLevel cUserLevel = new clsUserLevel();
        objUserMaster oUserMaster = new objUserMaster();
        clsUserMaster cUserMaster = new clsUserMaster();
        clsMainLocation cMainLocation = new clsMainLocation();
        #endregion

        #region Variables
        Point lastClick;
        #endregion

        public frmLogin()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oUserMaster = cUserMaster.GetUserData(cmbLocation["fldLocationCode"].ToString(),txtUserName.Text,txtPassword.Text);
                if (oUserMaster.UserLevel != null && oUserMaster.UserLevel != "")
                {
                    RMS.Forms.frmMain Main = new Forms.frmMain(oUserMaster.UserLevel);
                    
                    Main.Visible = true;
                    cGlobleVariable.LocationCode = oUserMaster.LocationCode;
                    cGlobleVariable.User = oUserMaster.UserCode;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password...", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                }
            }
            
        }

        #region Validate User Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtUserName.Text == "")
            {
                errL.SetError(txtUserName, "Please Enter User Name");
                isValidate = false;
            }
            else
            {
                errL.SetError(txtUserName, "");
            }

            if (txtPassword.Text == "")
            {
                errL.SetError(txtPassword, "Please Enter Password");
                isValidate = false;
            }
            else
            {
                errL.SetError(txtPassword, "");
            }

            if (cmbLocation.SelectedIndex < 0)
            {
                errL.SetError(cmbLocation, "Please Select Location");
                isValidate = false;
            }
            else
            {
                errL.SetError(cmbLocation, "");
            }


            return isValidate;
        }
        #endregion

        #region Form move
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
        #endregion

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cMainLocation.GetMainLocationDetails(), cmbLocation, 2);
        }
    }
}
