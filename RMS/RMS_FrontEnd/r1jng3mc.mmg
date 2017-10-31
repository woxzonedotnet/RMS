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
            this.txtHeadTotal.Text = ctrl.Text;
            this.txtHeadBalance.Text = ctrl.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCashPayment_DoubleClick(object sender, EventArgs e)
        {
            frmFront_Calculator Calculator = new frmFront_Calculator(this.txtCashPayment);
            Calculator.Show();
        }

        private void txtChequePayment_DoubleClick(object sender, EventArgs e)
        {
            frmFront_Calculator Calculator = new frmFront_Calculator(this.txtChequePayment);
            Calculator.Show();
        }

        private void txtCardPayment_DoubleClick(object sender, EventArgs e)
        {
            frmFront_Calculator Calculator = new frmFront_Calculator(this.txtCardPayment);
            Calculator.Show();
        }

        private void txtHeadBalance_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtHeadBalance.Text) == 0)
            {
                txtHeadBalance.ForeColor = Color.FromArgb(77, 130, 0);
            }
        }

        private void txtCashBalance_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void billCalculation()
        {
            if (dgvPayMethod.Rows.Count > 0) { 

}
        }
        
    }
}
