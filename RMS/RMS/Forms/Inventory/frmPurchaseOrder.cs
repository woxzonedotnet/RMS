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

namespace RMS.Forms.Inventory
{
    public partial class frmPurchaseOrder : Form
    {

        #region objects
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        objItemMaster oItemMaster = new objItemMaster();
        clsItemMaster cItemMaster = new clsItemMaster();
        clsSupplierMaster cSupplier = new clsSupplierMaster();
        clsSubLocation cSubLocation = new clsSubLocation();
        objPurchaseOrder oPurchaseOrder = new objPurchaseOrder();
        clsPurchaseOrder cPurchaseOrder = new clsPurchaseOrder();
        clsDocumentNumber cDocumentNumber = new clsDocumentNumber();
        objDocumentNumber oDocumentNumber = new objDocumentNumber();
        #endregion

        #region Variable
        string Item="";
        double Total =0;
        double NetAmount = 0;
        double vat = 0;
        string Location = "";
        string DocumentCode = "PO";
        #endregion


        public frmPurchaseOrder()
        {
            InitializeComponent();
            Location = cGlobleVariable.LocationCode.ToString();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) && this.dgvItemData.CurrentCell.OwningColumn.Name.Equals("clmItemCode"))
            {
                LoadLocation();
            }
        }


        #region LoadLocation
        public void LoadLocation()
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "fldItemCode";
            strFieldList[1] = "fldDescription";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Item Code";
            strHeaderList[1] = "Item Name";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 150;

            string strReturnString = "Item Code";
            string strWhere = "fldStatus LIKE '1'";
            Item = cCommonMethods.BrowsData("tbl_ItemMaster", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Item Code");
            if (Item != "")
            {
                LoadLocationDetails();
            }
        }
        #endregion

        #region Load Location Details
        private void LoadLocationDetails()
        {
            oItemMaster = cItemMaster.GetItemData(Item);

            int isExist = 0;
            for (int i = 0; i < dgvItemData.Rows.Count; i++)
            {
                if (dgvItemData.Rows[i].Cells[0].Value != null && Item == dgvItemData.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("The Selected Item already existed.");
                    this.dgvItemData.CurrentCell = this.dgvItemData.Rows[i].Cells[2];
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
                this.dgvItemData.Rows.Add();
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmItemCode"].Value = oItemMaster.ItemCode;
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmItemDescription"].Value = oItemMaster.Description;
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmUnitPrice"].Value = oItemMaster.CostPrice;
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmQuantity"].Value = "0.00";
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmTaxAmount"].Value = "0.00";
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmTotalAmount"].Value = "0.00";
            }
        }
        #endregion

        

        private void dgvItemData_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            double qty = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmQuantity"].Value);
            double price = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmUnitPrice"].Value);
            double tax = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value);
            double total = (qty * price) - tax;
            this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTotalAmount"].Value = total;
            calculatNetAmount();
        }
        
        public void calculatNetAmount()
        {
            Total = 0;
            for (int i = 0; i < dgvItemData.Rows.Count; i++)
            {
                if (this.dgvItemData.Rows[i].Cells["clmTotalAmount"].Value != null)
                {
                    Total += Convert.ToDouble(this.dgvItemData.Rows[i].Cells["clmTotalAmount"].Value);
                }
            }
            this.txtPurchase.Text = Total.ToString();
            if (txtVat.Enabled == true)
            {
                if (txtVat.Text != "")
                {
                    vat = double.Parse(txtVat.Text);
                    NetAmount = (Total + vat);
                    txtNetAmount.Text = NetAmount.ToString();
                }
                else
                {
                    NetAmount = Total;
                    txtNetAmount.Text = NetAmount.ToString();
                }
            }
            else
            {
                txtNetAmount.Text = Total.ToString();
            }
            
        }

        private void dgvItemData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void chkVat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVat.Checked == true)
            {
                txtVat.Enabled = true;
            }
            else
            {
                txtVat.Enabled = false;
            }
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            calculatNetAmount();
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            LoadDocumentNumber();
            cCommonMethods.loadComboRMS(cSupplier.GetSupplierData(Location), cmbSupplier, 2);
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(Location), cmbLocation, 2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        #region Clear
        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtPONumber.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnPrint.Enabled = true;
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (ValidateData())
            //{
            //    oItemMaster = cItemMaster.GetItemData(cGlobleVariable.LocationCode, this.txtItemCode.Text);

            //    if (oItemMaster.IsExists == false)
            //    {
            //        result = InsertUpdateData();
            //        if (result != -1)
            //        {
            //            MessageBox.Show("Successfully Saved...!", "Item Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            clear();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Item Data Not Saved...!", "Item Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Record already exist...!", "Item Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
        }

        #region Validate Purchase Order Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtPONumber.Text == "")
            {
                errPO.SetError(txtPONumber, "Please Enter Purchase Order Code");
                isValidate = false;
            }
            else
            {
                errPO.SetError(txtPONumber, "");

            }

            



            if (cmbLocation.SelectedIndex == -1)
            {
                errPO.SetError(cmbLocation, "Please Select Location");
                isValidate = false;
            }
            else
            {
                errPO.SetError(cmbLocation, "");
            }

            if (cmbSupplier.SelectedIndex == -1)
            {
                errPO.SetError(cmbSupplier, "Please Select Supplier");
                isValidate = false;
            }
            else
            {
                errPO.SetError(cmbSupplier, "");
            }


            return isValidate;
        }
        #endregion

        #region InsertUpdate Purchase Order Data
        private int InsertUpdateData()
        {
            oPurchaseOrder.LocationCode = cGlobleVariable.LocationCode.ToString();
            oPurchaseOrder.PurchaseOrderCode = this.txtPONumber.Text;
            oPurchaseOrder.SubLocationCode = this.cmbLocation["fldSubLocationCode"].ToString();
            oPurchaseOrder.SupplierCode = this.cmbSupplier["fldSupplierCode"].ToString();
            oPurchaseOrder.Date = this.dtpDate.Value;
            oPurchaseOrder.Purchase = Convert.ToDouble(this.txtPurchase.Text);
            oPurchaseOrder.VAT = Convert.ToDouble(this.txtVat.Text);
            oPurchaseOrder.NetAmount = Convert.ToDouble(this.txtNetAmount.Text);
            oPurchaseOrder.Remarks = this.txtRemark.Text;

            oPurchaseOrder.dtItemList = (DataTable)dgvItemData.DataSource;
            return cItemMaster.InsertUpdateData(oItemMaster);
        }
        #endregion


        public void LoadDocumentNumber()
        {
            cDocumentNumber.LoadDocNumber(cGlobleVariable.UniqID, DocumentCode, cGlobleVariable.LocationCode, cCommonMethods.DateYear());
            oDocumentNumber = cDocumentNumber.GetDocumentNumberData(cGlobleVariable.UniqID, DocumentCode);

            if (oDocumentNumber.IsExists)
            {
                this.txtPONumber.Text = oDocumentNumber.DocumentNo;
            }
            else
            {
                cDocumentNumber.DocumentNo(DocumentCode, cGlobleVariable.LocationCode, cCommonMethods.DateYear());
            }
        }
    }
}
