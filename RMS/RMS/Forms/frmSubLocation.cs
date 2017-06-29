using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.Forms
{
    public partial class frmSubLocation : Form
    {
        public frmSubLocation()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                
            }
        }

        #region Validate Catagory Master Data
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
    }
}
