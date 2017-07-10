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
    public partial class frmSupplierCategory : Form
    {
        #region Objects
        objSupplierCategory oSupplierCategory = new objSupplierCategory();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        #endregion

        #region Variables
        Point lastClick;
        #endregion

        public frmSupplierCategory()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
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

        private void frmSupplierCategory_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
