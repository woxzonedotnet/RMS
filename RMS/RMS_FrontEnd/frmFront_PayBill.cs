using RMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_FrontEnd
{
    public partial class frmFront_PayBill : Form
    {
        #region Variable
        Control ctrl;
        #endregion

        #region Objects
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        #endregion
        public frmFront_PayBill()
        {
            InitializeComponent();
        }

        public frmFront_PayBill(Control control)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ctrl = control;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
