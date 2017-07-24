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

namespace RMS.Forms.Inventory
{
    public partial class frmTransferNote : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsSubLocation cSubLocation = new clsSubLocation();
        #endregion

        #region Variables
        Point lastClick;
        #endregion

        public frmTransferNote()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode), cmbLocationFrom, 2);
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode), cmbLocationTo, 2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
           lastClick = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) && this.dgvTransferNote.CurrentCell.OwningColumn.Name.Equals("clmItemCode"))
            {
                LoadItemDetails();
            }
        }

        #region Load Item Details
        private void LoadItemDetails()
        {
            //oDepartment = cDepartment.GetDepartmentData(cGlobleVariable.LocationCode, this.txtDepartmentCode.Text);

            //txtDepartmentName.Text = oDepartment.DepartmentName;


            //cmbStatus.SetText(cStatusMaster.GetStatusByCode(oDepartment.Status));

            this.dgvTransferNote.Select();
            this.btnSave.Enabled = false;
            this.btnPrint.Enabled = true;
        }
        #endregion
    }
}
