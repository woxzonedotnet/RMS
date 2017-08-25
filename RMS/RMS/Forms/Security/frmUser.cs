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
        clsUserLevel cUserLevel = new clsUserLevel();
        #endregion

        #region Variables
        Point lastClick;
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
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbActiveState, 1);
            cCommonMethods.loadComboRMS(cUserLevel.GetUserLevelData(), cmbUserLevel, 2);
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
        
    }
}
