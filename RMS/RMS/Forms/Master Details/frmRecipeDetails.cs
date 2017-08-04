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

        #region Constructors
        public frmRecipeDetails()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode), cmbLocation, 2);
            cCommonMethods.loadComboRMS(cOrderType.GetOrderType(cGlobleVariable.LocationCode), cmbOrderType, 2);
        }
        #endregion

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

        #region Clear
        private void Clear() 
        {
            cCommonMethods.ClearForm(this);
            this.txtRecipeCost.Text = "0.0";
            this.dgvItemDetails.Enabled = true;
            this.cmbLocation.Enabled = true;
            this.cmbOrderType.Enabled = true;
            this.txtRecipeCode.Enabled = true;
            this.txtFullDescription.ReadOnly = false;
            this.btnSave.Enabled = true;
        }
        #endregion

        #region Validate Form Data
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
        #endregion

        #region Load Item Data to Grid View
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


        private void LoadLocationDetails()
        {
            oItemMaster = cItemMaster.GetItemData(cGlobleVariable.LocationCode,Item);

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
                this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clmUnit"].Value = cItemLocation.GetItemLocationData(cGlobleVariable.LocationCode,this.cmbLocation["fldSubLocationCode"].ToString(),Item).ShelfStock;
                this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clmQuantity"].Value = "0.00";
                this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clmUnitPrice"].Value = oItemMaster.CostPrice.ToString("###,###.00");
                this.dgvItemDetails.CurrentCell = this.dgvItemDetails.Rows[row].Cells[3];
            }
        }
        #endregion

        #region Calculate Grid View Data
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
        #endregion

        #region InsertUpdate Recipe Order Data
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
                        MessageBox.Show("Successfully Saved...!", "Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
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
                    dRow["fldUnitPrice"] = Convert.ToDouble(row.Cells["clmUnitPrice"].Value);
                    dt.Rows.Add(dRow);
                }
                catch (Exception ex){}
            }
            return dt;
        }
        #endregion

        #region Search Recipe Details
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
        #endregion

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
                this.dgvItemDetails.Rows.Add();
                dgvItemDetails.Rows[i].Cells["clmItemCode"].Value = oRecipeDetails.dtRecipeDetails.Rows[i]["fldItemCode"].ToString();
                dgvItemDetails.Rows[i].Cells["clmDescription"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode, oRecipeDetails.dtRecipeDetails.Rows[i]["fldItemCode"].ToString()).Description;
                dgvItemDetails.Rows[i].Cells["clmUnit"].Value = cItemLocation.GetItemLocationData(cGlobleVariable.LocationCode, this.cmbLocation["fldSubLocationCode"].ToString(), Item).ShelfStock;
                dgvItemDetails.Rows[i].Cells["clmQuantity"].Value = oRecipeDetails.dtRecipeDetails.Rows[i]["fldItemQty"].ToString();
                dgvItemDetails.Rows[i].Cells["clmUnitPrice"].Value = oRecipeDetails.dtRecipeDetails.Rows[i]["fldUnitPrice"].ToString();

                double qtyPrice = Convert.ToDouble(this.dgvItemDetails.Rows[i].Cells["clmUnitPrice"].Value);
                double qty = Convert.ToDouble(this.dgvItemDetails.Rows[i].Cells["clmQuantity"].Value);
                this.dgvItemDetails.Rows[i].Cells["clmTotalCost"].Value = (qtyPrice * qty).ToString("###,###.00");
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
