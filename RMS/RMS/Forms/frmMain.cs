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
        #region Object
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        #endregion

        #region Variables
        MdiClient ctlMDI;
        #endregion

        public frmMain()
        {
            InitializeComponent();
            menuStripMain.Renderer = new MyRenderer();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    //MessageBox.Show(exc.Message);
                }
            }
            cCommonMethods.UniqID();
        }

        #region MenuStrip Design
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
            public override Color MenuItemBorder
            {
                get { return Color.FromArgb(255,255,255); }
            }
            
        }
        #endregion

        #region Master File ToolStripMenuItem
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

        private void tableCategoryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTableCategoryDetails open = Application.OpenForms["frmTableCategoryDetails"] as frmTableCategoryDetails;
                if (open == null)
                {
                    frmTableCategoryDetails childTableCategoryDetails = new frmTableCategoryDetails();
                    childTableCategoryDetails.MdiParent = this;
                    childTableCategoryDetails.Show();
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

        private void itemDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmItemDetails open = Application.OpenForms["frmItemDetails"] as frmItemDetails;
                if (open == null)
                {
                    frmItemDetails childItemDetails = new frmItemDetails();
                    childItemDetails.MdiParent = this;
                    childItemDetails.Show();
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

        private void departmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmDepartmentDetails open = Application.OpenForms["frmDepartmentDetails"] as frmDepartmentDetails;
                if (open == null)
                {
                    frmDepartmentDetails childDepartmentDetails = new frmDepartmentDetails();
                    childDepartmentDetails.MdiParent = this;
                    childDepartmentDetails.Show();
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

        private void categoryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCategoryMasterDetails open = Application.OpenForms["frmCategoryMasterDetails"] as frmCategoryMasterDetails;
                if (open == null)
                {
                    frmCategoryMasterDetails childCategoryMasterDetails = new frmCategoryMasterDetails();
                    childCategoryMasterDetails.MdiParent = this;
                    childCategoryMasterDetails.Show();
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

        private void addStewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSteward open = Application.OpenForms["frmSteward"] as frmSteward;
                if (open == null)
                {
                    frmSteward childSteward = new frmSteward();
                    childSteward.MdiParent = this;
                    childSteward.Show();
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

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomerDetails open = Application.OpenForms["frmCustomerDetails"] as frmCustomerDetails;
                if (open == null)
                {
                    frmCustomerDetails childCustomerDetails = new frmCustomerDetails();
                    childCustomerDetails.MdiParent = this;
                    childCustomerDetails.Show();
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

        private void menuDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenuDepartment open = Application.OpenForms["frmMenuDepartment"] as frmMenuDepartment;
                if (open == null)
                {
                    frmMenuDepartment childMenuDepartment = new frmMenuDepartment();
                    childMenuDepartment.MdiParent = this;
                    childMenuDepartment.Show();
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

        private void menuCategoryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenuCategoryDetails open = Application.OpenForms["frmMenuCategoryDetails"] as frmMenuCategoryDetails;
                if (open == null)
                {
                    frmMenuCategoryDetails childMenuCategoryDetails = new frmMenuCategoryDetails();
                    childMenuCategoryDetails.MdiParent = this;
                    childMenuCategoryDetails.Show();
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

        private void menuDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenuDetails open = Application.OpenForms["frmMenuDetails"] as frmMenuDetails;
                if (open == null)
                {
                    frmMenuDetails childMenuDetails = new frmMenuDetails();
                    childMenuDetails.MdiParent = this;
                    childMenuDetails.Show();
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

        private void bankCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBankCards open = Application.OpenForms["frmBankCards"] as frmBankCards;
                if (open == null)
                {
                    frmBankCards childBankCards = new frmBankCards();
                    childBankCards.MdiParent = this;
                    childBankCards.Show();
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

        private void setupSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSetupSetting open = Application.OpenForms["frmSetupSetting"] as frmSetupSetting;
                if (open == null)
                {
                    frmSetupSetting childSetupSetting = new frmSetupSetting();
                    childSetupSetting.MdiParent = this;
                    childSetupSetting.Show();
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

        private void recipeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmRecipeDetails open = Application.OpenForms["frmRecipeDetails"] as frmRecipeDetails;
                if (open == null)
                {
                    frmRecipeDetails childRecipeDetails = new frmRecipeDetails();
                    childRecipeDetails.MdiParent = this;
                    childRecipeDetails.Show();
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

        private void tableDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTableDetails open = Application.OpenForms["frmTableDetails"] as frmTableDetails;
                if (open == null)
                {
                    frmTableDetails childTableDetails = new frmTableDetails();
                    childTableDetails.MdiParent = this;
                    childTableDetails.Show();
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

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBankDetails open = Application.OpenForms["frmBankDetails"] as frmBankDetails;
                if (open == null)
                {
                    frmBankDetails childBankDetails = new frmBankDetails();
                    childBankDetails.MdiParent = this;
                    childBankDetails.Show();
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

        #endregion
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void aaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory.frmPurchaseOrder open = Application.OpenForms["frmPurchaseOrder"] as Inventory.frmPurchaseOrder;
                if (open == null)
                {
                    Inventory.frmPurchaseOrder childPurchaseOrder = new Inventory.frmPurchaseOrder();
                    childPurchaseOrder.MdiParent = this;
                    childPurchaseOrder.Show();
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

        private void transferNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory.frmIssueNote open = Application.OpenForms["frmTransferNote"] as Inventory.frmIssueNote;
                if (open == null)
                {
                    Inventory.frmIssueNote childTransferNote = new Inventory.frmIssueNote();
                    childTransferNote.MdiParent = this;
                    childTransferNote.Show();
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

        private void goodsReciveNoteGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory.frmGoodsReceiveNote open = Application.OpenForms["frmGoodsReceiveNote"] as Inventory.frmGoodsReceiveNote;
                if (open == null)
                {
                    Inventory.frmGoodsReceiveNote childTransferNote = new Inventory.frmGoodsReceiveNote();
                    childTransferNote.MdiParent = this;
                    childTransferNote.Show();
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

        private void supplierReturnNoteSRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory.frmSupplierReturnNote open = Application.OpenForms["frmSupplierReturnNote"] as Inventory.frmSupplierReturnNote;
                if (open == null)
                {
                    Inventory.frmSupplierReturnNote childSupplierReturnNote = new Inventory.frmSupplierReturnNote();
                    childSupplierReturnNote.MdiParent = this;
                    childSupplierReturnNote.Show();
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

        private void stockAjestmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory.frmStockAdjustmentNote open = Application.OpenForms["frmStockAdjustmentNote"] as Inventory.frmStockAdjustmentNote;
                if (open == null)
                {
                    Inventory.frmStockAdjustmentNote childStockAdjustmentNote = new Inventory.frmStockAdjustmentNote();
                    childStockAdjustmentNote.MdiParent = this;
                    childStockAdjustmentNote.Show();
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

        private void gRNCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory.frmGRNCancel open = Application.OpenForms["frmGRNCancel"] as Inventory.frmGRNCancel;
                if (open == null)
                {
                    Inventory.frmGRNCancel childGRNCancel = new Inventory.frmGRNCancel();
                    childGRNCancel.MdiParent = this;
                    childGRNCancel.Show();
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

        private void issuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory.frmTransferNote open = Application.OpenForms["frmIssuesNote"] as Inventory.frmTransferNote;
                if (open == null)
                {
                    Inventory.frmTransferNote childIssuesNote = new Inventory.frmTransferNote();
                    childIssuesNote.MdiParent = this;
                    childIssuesNote.Show();
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

        private void stockInitializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Inventory.frmStockInitialize open = Application.OpenForms["frmStockInitialize"] as Inventory.frmStockInitialize;
                if (open == null)
                {
                    Inventory.frmStockInitialize childfrmStockInitialize = new Inventory.frmStockInitialize();
                    childfrmStockInitialize.MdiParent = this;
                    childfrmStockInitialize.Show();
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

        private void supplierDetailsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Reports.frmSupplierDetailReport open = Application.OpenForms["frmSupplierDetailReport"] as Reports.frmSupplierDetailReport;
                if (open == null)
                {
                    Reports.frmSupplierDetailReport childfrmStockInitialize = new Reports.frmSupplierDetailReport();
                    childfrmStockInitialize.MdiParent = this;
                    childfrmStockInitialize.Show();
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

        private void itemDetailsReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Reports.frmItemMasterDetailsReports open = Application.OpenForms["frmItemMasterDetailsReports"] as Reports.frmItemMasterDetailsReports;
                if (open == null)
                {
                    Reports.frmItemMasterDetailsReports childfrmStockInitialize = new Reports.frmItemMasterDetailsReports();
                    childfrmStockInitialize.MdiParent = this;
                    childfrmStockInitialize.Show();
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
