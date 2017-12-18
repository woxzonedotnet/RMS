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
using BusinessObject;
using System.IO;
using System.Drawing.Imaging;

namespace RMS.Forms
{
    public partial class frmMenuDetails : Form
    {
        #region Variable
        Point lastClick;
        int result = 0;
        string Recipe = "";
        double total = 0;
        string strSubLocation = "";
        double TotalAmount;

        MemoryStream ms;
        byte[] photo_aray;
        string FileName;
        
        #endregion

        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsSubLocation cSubLocation = new clsSubLocation();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsMenuDepartment cMenuDepartment = new clsMenuDepartment();
        clsMenuCategory cMenuCategory = new clsMenuCategory();
        objMenuDetails oMenuDetails = new objMenuDetails();
        clsMenuDetails cMenuDetails = new clsMenuDetails();
        objMenuCategory oMenuCategory = new objMenuCategory();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        clsDocumentNumber cDocumentNumber = new clsDocumentNumber();
        clsRecipeDetails cRecipeDetails = new clsRecipeDetails();
        objRecipeDetails oRecipeDetails = new objRecipeDetails();
        objSubLocation oSubLocation = new objSubLocation();
        clsSetupSetting cSetupSetting = new clsSetupSetting();
        objSetupSetting oSetupSetting = new objSetupSetting();
        #endregion
        public frmMenuDetails()
        {
            InitializeComponent();
        }

        private void btBackColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorBacground.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                pnlMenuButton.BackColor = colorBacground.Color;
            }
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorForground.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                lblMenuButtonName.ForeColor = colorForground.Color;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmMenuDetails_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode), cmbLocation, 2);
            cCommonMethods.loadComboRMS(cSubLocation.GetPrinterLocation(cGlobleVariable.LocationCode), cmbPrintLocation, 2);
            cCommonMethods.loadComboRMS(cMenuDepartment.GetMenuDepartmentData(cGlobleVariable.LocationCode), cmbMenuDepartment, 2);
            //cCommonMethods.loadComboRMS(cMenuCategory.GetMenuCategoryData(cGlobleVariable.LocationCode), cmbMenuCategory, 3);
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);

            //cmbMenuCategory        
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        public void loadComboRMS(DataTable dtFillData, RMS.ColumnComboBox objFillComb, int ViewColumn)
        {
            objFillComb.Data = dtFillData;
            objFillComb.ViewColumn = ViewColumn;

            for (int i = 0; i < dtFillData.Columns.Count; i++)
            {
                objFillComb.Columns[i].Display = false;
            }
            objFillComb.Columns[ViewColumn].Display = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        public void LoadSearch()
        {
            string[] strFieldList = new string[5];
            strFieldList[0] = "fldMenuCode";
            strFieldList[1] = "fldDescription";
            strFieldList[2] = "fldDescriptionBill";
            strFieldList[3] = "fldSellingPrice";
            strFieldList[4] = "fldTimeToPrepare";


            string[] strHeaderList = new string[5];
            strHeaderList[0] = "Menu Details Code";
            strHeaderList[1] = "Description";
            strHeaderList[2] = "Description Bill";
            strHeaderList[3] = "SellingPrice";
            strHeaderList[4] = "Time To Prepare";

            int[] iHeaderWidth = new int[5];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 150;
            iHeaderWidth[2] = 200;
            iHeaderWidth[3] = 200;
            iHeaderWidth[4] = 200;

            string strReturnString = "Menu Details Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtMenuCode.Text = cCommonMethods.BrowsData("tbl_MenuDetails", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Menu Details");
            if (txtMenuCode.Text != "")
            {
                LoadMenuDetails();
            }
        }

        #region Load Menu Details
        private void LoadMenuDetails()
        {
            //dgvItemData.Rows.Clear();
            oMenuDetails = cMenuDetails.GetMenuData(cGlobleVariable.LocationCode, this.txtMenuCode.Text);
            //

            txtDescription.Text = oMenuDetails.FullDescription;
            txtDiscriptionOnBill.Text = oMenuDetails.BillDescription;
            cmbLocation.SetText(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, oMenuDetails.SubLocationCode).SubLocationName);
            cmbPrintLocation.SetText(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, oMenuDetails.SubLocationCode).SubLocationName);
            cmbMenuDepartment.SetText(cMenuDepartment.GetMenuDepartmentData(cGlobleVariable.LocationCode, oMenuDetails.MenuDepartmentCode).MenuDepartmentName);
            cmbMenuCategory.SetText(cMenuCategory.GetMenuCategoryData(cGlobleVariable.LocationCode, oMenuCategory.MenuDepartmentCode, oMenuCategory.MenuCategoryCode).MenuCategoryName);
            if (oMenuDetails.ServiceCharge != null)
            {
                chkServiceCharge.Checked = true;

            }

            txtSellingPrice.Text = oMenuDetails.SellingPrice.ToString("###,###.00");
            txtPackingCharge.Text = oMenuDetails.PackingCharges.ToString("###,###.00");
            txtPrepareTime.Text = oMenuDetails.TimeToPrepare.ToString();

            txtTotalMenuCost.Text = oMenuDetails.TotalCost.ToString();

            //dtpDate.Value = oPurchaseOrder.Date;
            //txtPurchase.Text = oPurchaseOrder.Purchase.ToString("###,###.00");

            //if (oPurchaseOrder.VAT != 0)
            //{
            //    chkVat.Checked = true;
            //    this.txtVat.Text = oPurchaseOrder.VAT.ToString("###,###.00");
            //}

            //this.txtNetAmount.Text = oPurchaseOrder.NetAmount.ToString("###,###.00");
            //this.txtRemark.Text = oPurchaseOrder.Remarks;

            /////////////////////////////////////////////////////////////////////////////////////////////////////
            //    for (int i = 0; i < oMenuDetails.dtMenuList.Rows.Count; i++)
            //    {
            //        this.dgvRecipe.Rows.Add();
            //        dgvRecipe.Rows[i].Cells["clmRecipeCode"].Value = oPurchaseOrder.dtItemList.Rows[i]["fldItemCode"].ToString();
            //        dgvRecipe.Rows[i].Cells["clmRecipeDescription"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode, oPurchaseOrder.dtItemList.Rows[i]["fldItemCode"].ToString()).Description;
            //        dgvRecipe.Rows[i].Cells["clmUnit"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode, oPurchaseOrder.dtItemList.Rows[i]["fldItemCode"].ToString()).Unit;

            //        dgvRecipe.Rows[i].Cells["clmUnitPrice"].Value = oPurchaseOrder.dtItemList.Rows[i]["fldUnitPrice"].ToString();
            //        dgvRecipe.Rows[i].Cells["clmQuantity"].Value = oPurchaseOrder.dtItemList.Rows[i]["fldQuantity"].ToString();

            //        double a = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i][4].ToString());
            //        if (a > 0)
            //        {
            //            dgvRecipe.Rows[i].Cells["clmTax_chk"].Value = true;
            //        }

            //        dgvItemData.Rows[i].Cells["clmTaxAmount"].Value = oPurchaseOrder.dtItemList.Rows[i]["fldTaxAmount"].ToString();

            //        double qty = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i]["fldQuantity"]);
            //        double UnitPrice = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i]["fldUnitPrice"]);
            //        double TaxAmount = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i]["fldTaxAmount"]);
            //        dgvItemData.Rows[i].Cells["clmTotalAmount"].Value = ((qty * UnitPrice) + TaxAmount);
            //        calculatAmounts();
            //    }

            //    this.dgvItemData.Enabled = false;
            //    this.chkVat.Enabled = false;
            //    this.cmbLocation.Enabled = false;
            //    this.cmbSupplier.Enabled = false;
            //    this.dtpDate.Enabled = false;
            //    this.txtVat.ReadOnly = true;
            //    this.txtRemark.ReadOnly = true;
            //    this.btnSave.Enabled = false;
            //    this.btnPrint.Enabled = true;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oMenuDetails = cMenuDetails.GetMenuData(cGlobleVariable.LocationCode, this.txtMenuCode.Text);

                if (oMenuDetails.IsExists == false)
                {   
                    result = InsertUpdateData();
                    if (result == -5)
                    {   
                        MessageBox.Show("Data Not Changed...!", "Supplier Return Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result != -1)
                    {

                        MessageBox.Show("Successfully Saved...!", "Supplier Return Note", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Item Data Not Saved...!", "Supplier Return Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Supplier Return Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #region InsertUpdate MenuDetauls
        private int InsertUpdateData()
        {
            oMenuDetails.LocationCode = cGlobleVariable.LocationCode;
            oMenuDetails.MenuCode = this.txtMenuCode.Text;
            oMenuDetails.FullDescription = this.txtDescription.Text;
            oMenuDetails.BillDescription = this.txtDiscriptionOnBill.Text;
            oMenuDetails.SubLocationCode = this.cmbLocation["fldSubLocationCode"].ToString();
            oMenuDetails.PrintLocationCode = this.cmbPrintLocation["fldSubLocationCode"].ToString();
            oMenuDetails.MenuDepartmentCode = this.cmbMenuDepartment["fldMenuDepartmentCode"].ToString();
            oMenuDetails.MenuCategoryCode = this.cmbMenuCategory["fldMenuCategoryCode"].ToString();
            oMenuDetails.SellingPrice = Convert.ToDouble(this.txtSellingPrice.Text);
            oMenuDetails.PackingCharges = Convert.ToDouble(this.txtPackingCharge.Text);
            oMenuDetails.TimeToPrepare = Convert.ToInt32(this.txtPrepareTime.Text);
            oMenuDetails.ButtonBackground = pnlMenuButton.BackColor.ToArgb().ToString("x");
            oMenuDetails.ButtonForground = lblMenuButtonName.ForeColor.ToArgb().ToString("x");
            oMenuDetails.photo_aray = ImageBoxToArray();
            oMenuDetails.FileName = this.txtMenuCode.Text;
            oMenuDetails.ButtonName = txtButtonName.Text;
            oMenuDetails.FontName = MenuButtonFont.Font.Name;
            oMenuDetails.FontSize = MenuButtonFont.Font.Size;
            oMenuDetails.FontStyle = MenuButtonFont.Font.Style.ToString();
            if (chkServiceCharge.Checked == true)
            {
                oMenuDetails.ServiceCharge = true;
            }
            else
            {
                oMenuDetails.ServiceCharge = false;
            }
            oMenuDetails.TotalCost = Convert.ToDouble(this.txtTotalMenuCost.Text);
            oMenuDetails.Status = Convert.ToInt32(this.cmbStatus["fldStatusCode"].ToString());

            oMenuDetails.dtRecipeDetails = RecipeDataGridToDataTable(dgvRecipe, oMenuDetails.MenuCode);
            oMenuDetails.dtLocation = LocationDataGridToDataTable(dgvLocation, oMenuDetails.MenuCode);
            if (oMenuDetails.dtRecipeDetails.Rows.Count == 0 && oMenuDetails.dtLocation.Rows.Count == 0)
            {
                return -5;
            }
            else
            {
                return cMenuDetails.InsertUpdateData(oMenuDetails);
            }

        }
        #endregion

        #region Validate Menu Data
        //private bool ValidateData()
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtMenuCode.Text == "")
            {
                errSRN.SetError(txtMenuCode, "Please Enter Menu Code");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(txtMenuCode, "");
            }

            if (txtDescription.Text == "")
            {
                errSRN.SetError(txtDescription, "Please Enter Description");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(txtDescription, "");
            }

            if (txtDiscriptionOnBill.Text == "")
            {
                errSRN.SetError(txtDiscriptionOnBill, "Please Enter Description");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(txtDiscriptionOnBill, "");
            }

            if (cmbLocation.SelectedIndex == -1)
            {
                errSRN.SetError(cmbLocation, "Please Select Location");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(cmbLocation, "");
            }

            if (cmbPrintLocation.SelectedIndex == -1)
            {
                errSRN.SetError(cmbPrintLocation, "Please Select Location");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(cmbPrintLocation, "");
            }

            if (cmbMenuCategory.SelectedIndex == -1)
            {
                errSRN.SetError(cmbMenuCategory, "Please Select Location");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(cmbMenuCategory, "");
            }

            if (cmbMenuDepartment.SelectedIndex == -1)
            {
                errSRN.SetError(cmbMenuDepartment, "Please Select Supplier");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(cmbMenuDepartment, "");
            }

            if (cmbMenuDepartment.SelectedIndex == -1)
            {
                errSRN.SetError(cmbMenuDepartment, "Please Select Supplier");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(cmbMenuDepartment, "");
            }

            if (txtSellingPrice.Text == "")
            {
                errSRN.SetError(txtSellingPrice, "Please Enter Description");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(txtSellingPrice, "");
            }

            if (txtPackingCharge.Text == "")
            {
                errSRN.SetError(txtPackingCharge, "Please Enter Description");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(txtPackingCharge, "");
            }

            if (txtPrepareTime.Text == "")
            {
                errSRN.SetError(txtPrepareTime, "Please Enter Description");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(txtPrepareTime, "");
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                errSRN.SetError(cmbStatus, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(cmbStatus, "");
            }

            return isValidate;
        }
        #endregion

        public DataTable RecipeDataGridToDataTable(DataGridView dgv, string strMenuCode)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("fldMenuCode");
            dt.Columns.Add("fldRecipeCode");
            dt.Columns.Add("fldUnitPrice");
            dt.Columns.Add("fldQuantity");


            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                try
                {
                    dRow["fldMenuCode"] = strMenuCode;
                    dRow["fldRecipeCode"] = row.Cells["clmRecipeCode"].Value.ToString();
                    dRow["fldUnitPrice"] = row.Cells["clmUnitPrice"].Value.ToString();
                    dRow["fldQuantity"] = row.Cells["clmQuantity"].Value.ToString();

                    dt.Rows.Add(dRow);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }

            }
            return dt;
        }

        public DataTable LocationDataGridToDataTable(DataGridView dgv, string strMenuCode)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("fldMenuCode");
            dt.Columns.Add("fldSubLocationCode");
            dt.Columns.Add("fldSalePrice");
            dt.Columns.Add("fldServiceChargePresentage");


            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                try
                {
                    dRow["fldMenuCode"] = strMenuCode;
                    dRow["fldSubLocationCode"] = row.Cells["clmLocationCode"].Value.ToString();
                    dRow["fldSalePrice"] = row.Cells["clmSalePrice"].Value.ToString();
                    dRow["fldServiceChargePresentage"] = row.Cells["clmServiceChargePresentage"].Value.ToString();

                    dt.Rows.Add(dRow);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }

            }
            return dt;
        }

        private void dgvRecipe_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.KeyCode == Keys.Space) && this.dgvRecipe.CurrentCell.OwningColumn.Name.Equals("clmRecipeCode"))
                {
                    if (ValidateData())
                    {
                        LoadRecipDetails();
                    }
                }
            }
            catch (Exception ex) 
            {

            }
        }


        #region Load Item Data
        public void LoadRecipDetails()
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "a.fldRecipeCode";
            strFieldList[1] = "a.fldRecipeName";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Recipe Code";
            strHeaderList[1] = "Recipe Name";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 150;

            string strReturnString = "Recipe Code";
            string strWhere = "a.fldSubLocationCode='" + this.cmbLocation["fldSubLocationCode"].ToString() + "' and b.fldRecipeCode=a.fldRecipeCode";
            Recipe = cCommonMethods.BrowsData("tbl_RecipeHead a,tbl_RecipeDetails b", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Recipe Code");
            if (Recipe != "")
            {
                LoadRecipeDetails();
            }
        }
        #endregion

        #region Load Recipe Details
        private void LoadRecipeDetails()
        {
            oRecipeDetails = cRecipeDetails.GetRecipeData(cGlobleVariable.LocationCode, Recipe);


            int isExist = 0;
            for (int i = 0; i < dgvRecipe.Rows.Count; i++)
            {
                if (dgvRecipe.Rows[i].Cells[0].Value != null && Recipe == dgvRecipe.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("The Selected Menu existed.");
                    this.dgvRecipe.CurrentCell = this.dgvRecipe.Rows[i].Cells[2];
                    isExist = -1;
                    break;
                }
                else
                {
                    isExist = 1;
                }
            }
            if (isExist == 1)
            {
                this.dgvRecipe.Rows.Add();
                this.dgvRecipe.Rows[this.dgvRecipe.CurrentCell.RowIndex - 1].Cells["clmRecipeCode"].Value = oRecipeDetails.RecipeCode;
                this.dgvRecipe.Rows[this.dgvRecipe.CurrentCell.RowIndex - 1].Cells["clmRecipeDescription"].Value = oRecipeDetails.RecipeName;
                this.dgvRecipe.Rows[this.dgvRecipe.CurrentCell.RowIndex - 1].Cells["clmUnitPrice"].Value = oRecipeDetails.RecipeCost;
                this.dgvRecipe.Rows[this.dgvRecipe.CurrentCell.RowIndex - 1].Cells["clmTotalCost"].Value = "0.00";

            }
        }
        #endregion

        private void dgvRecipe_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            // calculatAmounts();
            try
            {

                dgvRecipe.EndEdit();
                if ((this.dgvRecipe.CurrentCell.Value != null))
                {
                    //tax calculate
                    calculatAmounts();
                    caltotal();
                }
                else
                {
                    // this.dgvRecipe.Rows[this.dgvRecipe.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value = "0.00";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void calculatAmounts()
        {
            try
            {
                double qty = Convert.ToDouble(this.dgvRecipe.Rows[this.dgvRecipe.CurrentCell.RowIndex].Cells["clmQuantity"].Value);
                double price = Convert.ToDouble(this.dgvRecipe.Rows[this.dgvRecipe.CurrentCell.RowIndex].Cells["clmUnitPrice"].Value);
                // double tax = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value);
                total = (qty * price);
                this.dgvRecipe.Rows[this.dgvRecipe.CurrentCell.RowIndex].Cells["clmTotalCost"].Value = total.ToString("###,###.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvRecipe_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //try
            //{
            //   
            //        dgvRecipe.EndEdit();
            //        if ((this.dgvRecipe.CurrentCell.Value != null))
            //        {
            //            //tax calculate
            //            calculatAmounts();
            //            caltotal();
            //        }
            //        else
            //        {
            //           // this.dgvRecipe.Rows[this.dgvRecipe.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value = "0.00";
            //        }
            //   
            //
            //
            //}
            //catch (Exception ex)
            //{
            //
            //}
        }
        public void taxCalculate()
        {
            //double UnitPrice = Convert.ToDouble(cSetupSetting.GetSetupSettingData(cGlobleVariable.LocationCode).VAT);
            //double totalTax = (Value * taxPrecentage) / 100;
            //this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value = Math.Round(totalTax, 2);
        }

        private void dgvRecipe_Leave(object sender, EventArgs e)
        {
            try
            {
                //if (this.dgvRecipe.CurrentCell.OwningColumn.Name.Equals("clmTax_chk"))
                //{
                    dgvRecipe.EndEdit();
                    if ((this.dgvRecipe.CurrentCell.Value != null))
                    {
                        //tax calculate
                        calculatAmounts();
                    }
                    else
                    {
                       // this.dgvRecipe.Rows[this.dgvRecipe.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value = "0.00";
                    }
                //}
            }
            catch (Exception ex)
            {
                
            }

        }

        private void dgvLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) && this.dgvLocation.CurrentCell.OwningColumn.Name.Equals("clmLocationCode"))
            {
                LoadLocation();
            }
        }

        #region LoadLocation
        public void LoadLocation()
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "fldSubLocationCode";
            strFieldList[1] = "fldSubLocationName";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Location Code";
            strHeaderList[1] = "Location Name";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 150;

            string strReturnString = "Location Code";
            string strWhere = "fldActiveStatus LIKE '1'";
            strSubLocation = cCommonMethods.BrowsData("tbl_SubLocation", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Sub Location Details");
            if (strSubLocation != "")
            {
                LoadLocationDetails();
            }
        }
        #endregion

        #region Load Location Details
        private void LoadLocationDetails()
        {
            oSubLocation = cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, strSubLocation);
            oSetupSetting = cSetupSetting.GetSetupSettingData(cGlobleVariable.LocationCode);

            int isExist = 0;
            for (int i = 0; i < dgvLocation.Rows.Count; i++)
            {
                if (dgvLocation.Rows[i].Cells[0].Value != null && strSubLocation == dgvLocation.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("The Selected Location already existed.");
                    isExist = -1;
                    break;
                }
                else
                {
                    isExist = 1;
                }
            }
            if (isExist == 1)
            {
                this.dgvLocation.Rows.Add();
                this.dgvLocation.Rows[this.dgvLocation.CurrentCell.RowIndex - 1].Cells["clmLocationCode"].Value = oSubLocation.SubLocationCode;
                this.dgvLocation.Rows[this.dgvLocation.CurrentCell.RowIndex - 1].Cells["clmLocation"].Value = oSubLocation.SubLocationName;
                this.dgvLocation.Rows[this.dgvLocation.CurrentCell.RowIndex - 1].Cells["clmSalePrice"].Value = txtSellingPrice.Text;
                this.dgvLocation.Rows[this.dgvLocation.CurrentCell.RowIndex - 1].Cells["clmServiceChargePresentage"].Value = oSetupSetting.ServiceCharge;

            }
        }
        #endregion

        #region get Total
        public void caltotal()
        {
            try
            {
                TotalAmount = 0;
               
                

                for (int i = 0; i < dgvRecipe.Rows.Count; i++)
                    {
                        try
                        {
                            string tempTotal = this.dgvRecipe.Rows[i].Cells["clmTotalCost"].Value.ToString();
                           // bool tempSelect = Convert.ToBoolean(dgvRecipe.Rows[i].Cells["clmSelectItem"].Value);

                            if (tempTotal != null )
                            {
                                TotalAmount += Convert.ToDouble(this.dgvRecipe.Rows[i].Cells["clmTotalCost"].Value);
                            }
                        }
                        catch (Exception ex)
                        {

                        }

                    }

                //if (chkServiceCharge.Checked == true)
                //{
                //    double servicecharg = Convert.ToDouble( this.dgvRecipe.Rows[this.dgvRecipe.CurrentCell.RowIndex - 1].Cells["clmServiceChargePresentage"].Value);
                //    TotalAmount += TotalAmount * servicecharg;
                //    this.txtTotalMenuCost.Text = Math.Round(TotalAmount, 2).ToString();
                //}
                //else 
                //{
                    this.txtTotalMenuCost.Text = Math.Round(TotalAmount, 2).ToString();
                //}
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion 


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnImageBrowse_Click(object sender, EventArgs e)
        {   
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picMenuButton.Image = new Bitmap(open.FileName);
                picMenuButton.SizeMode = PictureBoxSizeMode.StretchImage;
                // image file path  
                txtImageLocation.Text = open.FileName;
                FileName = open.FileName;
            }
        }

        private void btnImageFont_Click(object sender, EventArgs e)
        {
            MenuButtonFont.ShowDialog();
            lblMenuButtonName.Font = MenuButtonFont.Font;
        }

        private void txtButtonName_TextChanged(object sender, EventArgs e)
        {
            lblMenuButtonName.Text = txtButtonName.Text;
        }

        private void cmbMenuDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMenuCategory.ClearItems();
            cCommonMethods.loadComboRMS(cMenuCategory.GetMenuCategoryData(cGlobleVariable.LocationCode,cmbMenuDepartment["fldMenuDepartmentCode"].ToString()), cmbMenuCategory, 3);
        }

        #region Image Functions
        public byte[] ImageBoxToArray()
        {
            byte[] imgArray;

            MemoryStream ms = new MemoryStream();
            picMenuButton.Image.Save(ms, ImageFormat.Png);
            imgArray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(imgArray, 0, imgArray.Length);

            return imgArray;
        }

        public void ArrayToImageBox(byte[] imgArray)
        {
            MemoryStream ms = new MemoryStream(imgArray);
            picMenuButton.Image = Image.FromStream(ms);
            picMenuButton.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        #endregion

        #region Color Function
        public Color[] convertToColorArray(string[] colorList)
        {
            Color[] color = new Color[colorList.Length];
            for (int j = 0; j < colorList.Length; j++)
            {
                var splitString = colorList[j].Split(',');
                int red, green, blue;
                red = int.Parse(splitString[0]);
                green = int.Parse(splitString[1]);
                blue = int.Parse(splitString[2]);

                color[j] = Color.FromArgb(red, green, blue);
            }
            return color;
        }

        public Color convertToColorArray(string strcolor)
        {
            Color color = new Color();

            var splitString = strcolor.Split(',');
            int red, green, blue;
            red = int.Parse(splitString[0]);
            green = int.Parse(splitString[1]);
            blue = int.Parse(splitString[2]);
            color = Color.FromArgb(red, green, blue);

            return color;
        }

        public string colorToString(Color color)
        {
            string strColor = color.ToString();

            return strColor;
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

    }

    
}
