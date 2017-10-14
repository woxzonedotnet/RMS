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
    public partial class frmFront_Steward : Form
    {
        #region Variable
        Control ctrl;
        #endregion
        public frmFront_Steward()
        {
            InitializeComponent();
        }

        public frmFront_Steward(Control control)
        {
            InitializeComponent();
            ctrl = control;
        }

        private void frmSteward_Load(object sender, EventArgs e)
        {

        }
    }
}
