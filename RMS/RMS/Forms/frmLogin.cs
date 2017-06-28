using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCloseX_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            RMS.Forms.frmMain Main = new Forms.frmMain();
            Main.Visible = true;
        }
    }
}
