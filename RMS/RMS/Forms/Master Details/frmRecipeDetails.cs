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
        clsRecipeDetails cRecipeDetails = new clsRecipeDetails();
        clsItemMaster cItemMaster = new clsItemMaster();
        objItemMaster oItemMaster = new objItemMaster(); 
        #endregion

        #region Variable
        string ItemCode;
        #endregion
        public frmRecipeDetails()
        {
            InitializeComponent();
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode), cmbLocation, 2);
            cCommonMethods.loadComboRMS(cRecipeDetails.GetOrderTypeData(), cmbOrderType,2);
        } 

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void frmRecipeDetails_Load(object sender, EventArgs e)
        {

        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           cCommonMethods.ClearForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {   
            if (e.KeyCode == Keys.Space)
            {
                MessageBox.Show("Hello World!!");
            }
        }

        public void LoadSearch()
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "fldItemCode";
            strFieldList[1] = "fldDescription";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Item Code";
            strHeaderList[1] = "Description";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 320;

            string strReturnString = "Item Code";
            string strWhere = "fldStatus LIKE '%'";
            ItemCode = cCommonMethods.BrowsData("tbl_ItemMaster", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Item Code");
            if (ItemCode != "")
            {
                LoadItemDetails();
            }


        }


        public void LoadItemDetails()
        {
            oItemMaster = cItemMaster.GetItemData(ItemCode);

            for (int j = 0; dgvItemDetails.RowCount > j; j++)
            {
                if (dgvItemDetails.Rows[j].Cells[0].Value == oItemMaster.ItemCode)
                {
                    MessageBox.Show("The Item is already exist..!", "Attenction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                }

                else
                {
                    this.dgvItemDetails.Rows.Add();
                    this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clsItemCode"].Value = oItemMaster.ItemCode;
                    this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clsDescription"].Value = oItemMaster.Description;
                    this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clsUnit"].Value = oItemMaster.Unit;
                    this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clsItemCode"].Value = oItemMaster.CostPrice;
                    this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clmQuantity"].Value = "0.00";
                    this.dgvItemDetails.Rows[this.dgvItemDetails.CurrentCell.RowIndex - 1].Cells["clmTotalCost"].Value = "0.00";
                }
            }
           


           
        }

    }
}
