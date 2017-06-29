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
    public partial class frmMain : Form
    {
        #region Variables
        MdiClient ctlMDI;
        #endregion


        public frmMain()
        {
            InitializeComponent();
            menuStripMain.Renderer = new MyRenderer();
        }

        class MyRenderer : ToolStripProfessionalRenderer // MenuStrip Render Function
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        class MyColors : ProfessionalColorTable //MenuStrip Color Changes
        {
            public override Color MenuItemSelected
            {

                get { return Color.FromArgb(3,102,214); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(255,255,255); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(255,255,255); }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void supplierCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSupplierCategory open = Application.OpenForms["frmSupplierCategory"] as frmSupplierCategory;
                if (open == null)
                {
                    frmSupplierCategory childSupplierCategory = new frmSupplierCategory();
                    childSupplierCategory.MdiParent = this;
                    childSupplierCategory.Show();
                }
                else
                {
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }

        private void supplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSupplierDetails open = Application.OpenForms["frmSupplierDetails"] as frmSupplierDetails;
                if (open == null)
                {
                    frmSupplierDetails childSupplierDetails = new frmSupplierDetails();
                    childSupplierDetails.MdiParent = this;
                    childSupplierDetails.Show();
                }
                else
                {
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void locationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSubLocation open = Application.OpenForms["frmSubLocation"] as frmSubLocation;
                if (open == null)
                {
                    frmSubLocation childSubLocation = new frmSubLocation();
                    childSubLocation.MdiParent = this;
                    childSubLocation.Show();
                }
                else
                {
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        open.Activate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
