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
    public partial class frmTableCategoryDetails : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        #endregion

        public frmTableCategoryDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
