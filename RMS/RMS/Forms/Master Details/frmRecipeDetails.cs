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

namespace RMS.Forms
{
    public partial class frmRecipeDetails : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsSubLocation cSubLocation = new clsSubLocation();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsOrderType cOrderType = new clsOrderType();
        clsItemMaster cItemMaster = new clsItemMaster();
        objItemMaster oItemMaster = new objItemMaster();
        objRecipeDetails oRecipeDetails = new objRecipeDetails();
        clsRecipeDetails cRecipeDetails = new clsRecipeDetails();
        objItemLocation oItemLocation = new objItemLocation();
        clsItemLocation cItemLocation = new clsItemLocation();
        #endregion

        #region Variable
        Point lastClick;
        string Item;
        double Total = 0;
        #endregion

        public frmRecipeDetails()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode), cmbLocation, 2);
            cCommonMethods.loadComboRMS(cOrderType.GetOrderType(cGlobleVariable.LocationCode), cmbOrderType, 2);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear() 
        {
            cCommonMethods.ClearForm(this);
            this.txtRecipeCost.Text = "";
        }

        private bool ValidateData() 
        {
            bool isValidate = true;

            if (txtRecipeCode.Text == "")
            {
                errRecipe.SetError(txtRecipeCode, "Please Enter Recipe Code");
                isValidate = false;
            }
            else
            {
                errRecipe.SetError(txtRecipeCode, "");

            }

            if (cmbOrderType.SelectedIndex == -1)
            {
                errRecipe.SetError(cmbOrderType, "Please Select Order Tyoe");
                isValidate = false;
            }
            else
            {
                errRecipe.SetError(cmbOrderType, "");
            }

            if (cmbLocation.SelectedIndex == -1)
            {
                errRecipe.SetError(cmbLocation, "Please Select Sub Location");
                isValidate = false;
            }
            else
            {
                errRecipe.SetError(cmbLocation, "");
            }

            return isValidate;
        }

        private void dgvItemDetails_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.dgvItemDetails.CurrentCell.OwningColumn.Name.Equals("clmTax_chk"))
            //    {
            //        dgvItemData.EndEdit();
            //        if ((this.dgvItemData.CurrentCell.Value != null) && this.dgvItemData.CurrentCell.Value.ToString().Equals("True"))
            //        {
            //            //tax calculate
            //            double taxPrecentage = Convert.ToDouble(cSetupSetting.GetSetupSettingData(cGlobleVariable.LocationCode).VAT);
            //            double totalTax = (total * taxPrecentage) / 100;
            //            this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value = totalTax;
            //            calculatAmounts();
            //        }
            //        else
            //        {
            //            this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value = "0.00";
            //            calculatAmounts();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
        }

        private void dgvItemDetails_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((e.KeyCode == Keys.Space) && this.dgvItemDetails.CurrentCell.OwningColumn.Name.Equals("clmItemCode"))
                {
                    if (ValidateData())
                    {
                        LoadItemDetails();
                    }
                }
            }
            catch (Exception ex) { }
        }

        #region Load Item Data
        public void LoadItemDetails()
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "a.fldItemCode";
            strFieldList[1] = "a.fldDescription";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Item Code";
            strHeaderList[1] = "Item Name";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 150;

            string strReturnString = "Item Code";
            string strWhere = "fldStatus LIKE '1' AND b.fldSubLocationCode='" + this.cmbLocation["fldSubLocationCode"].ToString() + "' and b.fldItemCode=a.fldItemCode";
            Item = cCommonMethods.BrowsData("tbl_ItemMaster a,tbl_ItemLocation b", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Item Details");
            if (Item != "")
            {
                LoadLocationDetails();
            }
        }
        #endregion


        #region Load Item Details
        private void LoadLocationDetails()
        {
            oItemMaster = cItemMaster.GetItemData(cGlobleVariable.LocationCode,Item);
            oItemLocation = cItemLocation.GetItemLocationData(this.cmbLocation["fldSubLocation"].ToString(), Item);

            int isExist = 0;
            int row = 0;
            for (int i = 0; i < dgvItemDetails.Rows.Count; i++)
            {
                if (dgvItemDetails.Rows[i].Cells[0].Value != null && Item == dgvItemDetails.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Item already Existed.");
                    this.dgvItemDetails.CurrentCell = this.dgvItemDetails.Rows[i].Cells[3];
                    isExist = -1;
                    break;
                }
                else
                {
                    isExist = 1;
                    row = i;
                }
            }

            if (isExist == 1)
            {
                this.dgvItemDetails.Rows.Add();
                this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clmItemCode"].Value = oItemMaster.ItemCode;
                this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clmDescription"].Value = oItemMaster.Description;
                this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clmUnit"].Value = oItemLocation.ShelfStock.ToString("N2");
                this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clmQuantity"].Value = "0.00";
                this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clmUnitPrice"].Value = oItemMaster.CostPrice.ToString("###,###.00");
                this.dgvItemDetails.CurrentCell = this.dgvItemDetails.Rows[row].Cells[3];
            }
        }
        #endregion

        private void dgvItemDetails_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            calculatAmounts();
        }

        private void calculatAmounts() 
        {
            try
            {
                double qtyPrice = Convert.ToDouble(this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex].Cells["clmUnitPrice"].Value);
                double qty = Convert.ToDouble(this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex].Cells["clmQuantity"].Value);
                this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex].Cells["clmTotalCost"].Value = (qtyPrice * qty).ToString("###,###.00");

                Total = 0;
                for (int i = 0; i < dgvItemDetails.Rows.Count; i++)
                {
                    if (this.dgvItemDetails.Rows[i].Cells["clmTotalCost"].Value != null)
                    {
                        Total += Convert.ToDouble(this.dgvItemDetails.Rows[i].Cells["clmTotalCost"].Value);
                    }
                }
                this.txtRecipeCost.Text = Total.ToString("###,###.00");
            }
            catch (Exception ex) { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                calculatAmounts();
                oRecipeDetails = cRecipeDetails.GetRecipeData(cGlobleVariable.LocationCode, this.txtRecipeCode.Text);

                if (oRecipeDetails.IsExists == false)
                {
                    if (InsertUpdateData() != -1)
                    {
                        //cDocumentNumber.DeleteDocumentNumber(cGlobleVariable.UniqID, DocumentCode, this.txtPONumber.Text);
                        MessageBox.Show("Successfully Saved...!", "Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.btnPrint.Enabled = true;
                        //EnableControls(false);
                        //this.txtVat.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Item Data Not Saved...!", "Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #region InsertUpdate Recipe Order Data
        private int InsertUpdateData()
        {
            oRecipeDetails.LocationCode = cGlobleVariable.LocationCode.ToString();
            oRecipeDetails.SubLocationCode = this.cmbLocation["fldSubLocationCode"].ToString();
            oRecipeDetails.RecipeCode = this.txtRecipeCode.Text;
            oRecipeDetails.RecipeName = this.txtFullDescription.Text;
            oRecipeDetails.OrderTypeCode = this.cmbOrderType["fldOrderTypeCode"].ToString();
            oRecipeDetails.RecipeCost = Convert.ToDouble(this.txtRecipeCost.Text);

            oRecipeDetails.dtRecipeDetails = DataGridToDataTable(dgvItemDetails, oRecipeDetails.RecipeCode);

            return cRecipeDetails.InsertUpdateData(oRecipeDetails);
        }
        #endregion

        public DataTable DataGridToDataTable(DataGridView dgv, string strRecipeCode)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("fldRecipeCode");
            dt.Columns.Add("fldItemCode");
            dt.Columns.Add("fldItemQty");
            dt.Columns.Add("fldUnitPrice");


            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                try
                {
                    dRow["fldRecipeCode"] = strRecipeCode;
                    dRow["fldItemCode"] = row.Cells["clmItemCode"].Value.ToString();
                    dRow["fldItemQty"] = row.Cells["clmQuantity"].Value.ToString();
                    dRow["fldUnitPrice"] = row.Cells["clmUnitPrice"].Value.ToString();
                    
                    dt.Rows.Add(dRow);
                }
                catch (Exception ex)
                {

                }

            }
            return dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        public void LoadSearch()
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "fldRecipeCode";
            strFieldList[1] = "fldRecipeName";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Recipe Code";
            strHeaderList[1] = "Recipe Name";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 100;
            iHeaderWidth[1] = 150;

            string strReturnString = "Recipe Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtRecipeCode.Text = cCommonMethods.BrowsData("tbl_RecipeHead", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Recipe");
            if (txtRecipeCode.Text != "")
            {
                LoadRecipeDetails();
            }
        }

        #region Load Recipe Details
        private void LoadRecipeDetails()
        {
            dgvItemDetails.Rows.Clear();
            oRecipeDetails = cRecipeDetails.GetRecipeData(cGlobleVariable.LocationCode, this.txtRecipeCode.Text);

            cmbLocation.SetText(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, oRecipeDetails.SubLocationCode).SubLocationName);
            cmbOrderType.SetText(cOrderType.GetOrderTypeByCode(oRecipeDetails.OrderTypeCode).OrderTypeName);

            txtRecipeCode.Text = oRecipeDetails.RecipeCode;
            txtFullDescription.Text = oRecipeDetails.RecipeName;
            txtRecipeCost.Text = oRecipeDetails.RecipeCost.ToString("###,###.00");


            for (int i = 0; i < oRecipeDetails.dtRecipeDetails.Rows.Count; i++)
            {
                oItemMaster = cItemMaster.GetItemData(cGlobleVariable.LocationCode, oRecipeDetails.dtRecipeDetails.Rows[i]["fldItemCode"].ToString());
                this.dgvItemDetails.Rows.Add();
                dgvItemDetails.Rows[i].Cells["clmItemCode"].Value = oRecipeDetails.dtRecipeDetails.Rows[i]["fldItemCode"].ToString();
                dgvItemDetails.Rows[i].Cells["clmDescription"].Value = oItemMaster.Description;
                dgvItemDetails.Rows[i].Cells["clmUnit"].Value = oItemLocation.ShelfStock;
                dgvItemDetails.Rows[i].Cells["clmQuantity"].Value = oRecipeDetails.dtRecipeDetails.Rows[i]["fldItemQty"].ToString();
                dgvItemDetails.Rows[i].Cells["clmUnitPrice"].Value = oRecipeDetails.dtRecipeDetails.Rows[i]["fldUnitPrice"].ToString();

                double qtyPrice = Convert.ToDouble(this.dgvItemDetails.Rows[i].Cells["clmUnitPrice"].Value);
                double qty = Convert.ToDouble(this.dgvItemDetails.Rows[i].Cells["clmQuantity"].Value);
                this.dgvItemDetails.Rows[i].Cells["clmTotalCost"].Value = (qtyPrice * qty).ToString("###,###.00");

                //calculatAmounts();
            }

            this.dgvItemDetails.Enabled = false;
            this.cmbLocation.Enabled = false;
            this.cmbOrderType.Enabled = false;
            this.txtRecipeCode.Enabled = false;
            this.txtFullDescription.ReadOnly = true;
            this.txtRecipeCost.ReadOnly = true;
            this.btnSave.Enabled = false;
        }
        #endregion

    }
}
