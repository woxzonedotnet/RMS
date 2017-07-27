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
        objSetupSetting oSetupSetting = new objSetupSetting();
        clsSetupSetting cSetupSetting = new clsSetupSetting();
        #endregion

        #region Variable
        string Item="";
        double Total =0;
        double NetAmount = 0;
        double vat = 0;
        string Location = "";
        string DocumentCode = "PO";
        int result = 0;
        double total = 0;
        Point lastClick;
        #endregion


        public frmPurchaseOrder()
        {
            InitializeComponent();
            clear();
            this.lblTitle.Text = this.Text;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) && this.dgvItemData.CurrentCell.OwningColumn.Name.Equals("clmItemCode"))
            {
                if (ValidateData())
                {
                    LoadItemDetails();
            }
        }
        }


        #region LoadLocation
        public void LoadItemDetails()
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

        #region Load Item Details
        private void LoadLocationDetails()
        {
            oItemMaster = cItemMaster.GetItemData(Item);

            int isExist = 0;
            int row = 0;
            for (int i = 0; i < dgvItemData.Rows.Count; i++)
            {
                if (dgvItemData.Rows[i].Cells[0].Value != null && Item == dgvItemData.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Item already Existed.");
                    this.dgvItemData.CurrentCell = this.dgvItemData.Rows[i].Cells[3];
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
                this.dgvItemData.Rows.Add();
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmItemCode"].Value = oItemMaster.ItemCode;
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmItemDescription"].Value = oItemMaster.Description;
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmUnitPrice"].Value = oItemMaster.CostPrice;
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmQuantity"].Value = "0.00";
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmTaxAmount"].Value = "0.00";
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmTotalAmount"].Value = "0.00";
                this.dgvItemData.CurrentCell = this.dgvItemData.Rows[row].Cells[3];
            }
        }
        #endregion

        

        private void dgvItemData_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            calculatAmounts();
        }
        
        public void calculatAmounts()
        {
            try
            {
            double qty = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmQuantity"].Value);
            double price = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmUnitPrice"].Value);
            double tax = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value);
            total = (qty * price);
            if ((this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTax_chk"].Value != null) && this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTax_chk"].Value.ToString().Equals("True"))
            {
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTotalAmount"].Value = total + tax;
            }
            else
            {
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTotalAmount"].Value = total;
            }


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
            catch (Exception ex) 
            {
                //MessageBox.Show(ex.Message);
            }
            
        }

        private void chkVat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVat.Checked == true)
            {
                txtVat.Enabled = true;
            }
            else
            {
                this.txtVat.Text = "0.0";
                txtVat.Enabled = false;
            }
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            calculatAmounts();
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            LoadDocumentNumber();
            cCommonMethods.loadComboRMS(cSupplier.GetSupplierData(cGlobleVariable.LocationCode), cmbSupplier, 2);
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode), cmbLocation, 2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        #region Clear
        public void clear()
        {
            cCommonMethods.ClearForm(this);
            LoadDocumentNumber();
            this.dgvItemData.Enabled = true;
            this.cmbLocation.Enabled = true;
            this.cmbSupplier.Enabled = true;
            this.txtRemark.Enabled = true;
            this.dtpDate.Enabled = true;
            this.chkVat.Enabled = true;
            this.txtPONumber.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnPrint.Enabled = false;
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oPurchaseOrder = cPurchaseOrder.GetPurchaseOrderData(cGlobleVariable.LocationCode, this.txtPONumber.Text);

                if (oPurchaseOrder.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        cDocumentNumber.DeleteDocumentNumber(cGlobleVariable.UniqID,DocumentCode,this.txtPONumber.Text);
                        MessageBox.Show("Successfully Saved...!", "Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnPrint.Enabled = true;
                        this.btnSave.Enabled = false;
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

            if (cmbLocation.SelectedIndex < 0)
            {
                errPO.SetError(cmbLocation, "Please Select Location");
                isValidate = false;
            }
            else
            {
                errPO.SetError(cmbLocation, "");
            }

            if (cmbSupplier.SelectedIndex < 0)
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

            oPurchaseOrder.dtItemList = DataGridToDataTable(dgvItemData,oPurchaseOrder.LocationCode,oPurchaseOrder.PurchaseOrderCode);
            
            return cPurchaseOrder.InsertUpdateData(oPurchaseOrder);
        }
        #endregion
        public DataTable DataGridToDataTable(DataGridView dgv,string strLocationCode, string strPOCode)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("fldLocationCode");
            dt.Columns.Add("fldPOCode");
            dt.Columns.Add("fldItemCode");
            dt.Columns.Add("fldUnitPrice");
            dt.Columns.Add("fldQuantity");
            dt.Columns.Add("fldTaxAmount");


            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                try
                {
                    dRow[0] = strLocationCode;
                    dRow[1] = strPOCode;
                    dRow[2] = row.Cells[0].Value.ToString();
                    dRow[3] = row.Cells[2].Value.ToString();
                    dRow[4] = row.Cells[3].Value.ToString();
                    dRow[5] = row.Cells[5].Value.ToString();
                    dt.Rows.Add(dRow);
                }catch(Exception ex)
                {

                }
                
            }
            return dt;
        }

        public void LoadDocumentNumber()
        {
            this.txtPONumber.Text = cDocumentNumber.LoadDocNumber(cGlobleVariable.UniqID, DocumentCode, cGlobleVariable.LocationCode, cCommonMethods.DateYear());
        }

        private void dgvItemData_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvItemData.CurrentCell.OwningColumn.Name.Equals("clmTax_chk"))
                {
                    dgvItemData.EndEdit();
                    if ((this.dgvItemData.CurrentCell.Value != null) && this.dgvItemData.CurrentCell.Value.ToString().Equals("True"))
                    {
                        //tax calculate
                       double taxPrecentage = Convert.ToDouble(cSetupSetting.GetSetupSettingData(cGlobleVariable.LocationCode).VAT);
                       double totalTax = (total * taxPrecentage) / 100;
                       this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value = totalTax; 
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
            }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }
       
        public void LoadSearch()
        {
            string[] strFieldList = new string[4];
            strFieldList[0] = "fldPOCode";
            strFieldList[1] = "fldSupplierCode";
            strFieldList[2] = "fldDate";
            strFieldList[3] = "fldRemarks";

            string[] strHeaderList = new string[4];
            strHeaderList[0] = "Purchase Order Code";
            strHeaderList[1] = "Supplier Code";
            strHeaderList[2] = "Purchase Order Date";
            strHeaderList[3] = "Remarks";

            int[] iHeaderWidth = new int[4];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 320;
            iHeaderWidth[2] = 320;
            iHeaderWidth[3] = 320;

            string strReturnString = "Purchase Order Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtPONumber.Text = cCommonMethods.BrowsData("tbl_PODetails", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Purchase Order");
            if (txtPONumber.Text != "")
            {
                LoadPurchaseOrderDetails();
            }
        }

        #region Load Purchase Order Details
        private void LoadPurchaseOrderDetails()
        {
            dgvItemData.Rows.Clear();
            oPurchaseOrder = cPurchaseOrder.GetPurchaseOrderData(cGlobleVariable.LocationCode, this.txtPONumber.Text);

            cmbLocation.SetText(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, oPurchaseOrder.SubLocationCode).SubLocationName);
            cmbSupplier.SetText(cSupplier.GetSupplierDataBySupplierCode(cGlobleVariable.LocationCode, oPurchaseOrder.SupplierCode));

            dtpDate.Value = oPurchaseOrder.Date;
            txtPurchase.Text = oPurchaseOrder.Purchase.ToString();

            if (oPurchaseOrder.VAT > 0) 
            {
                chkVat.Checked = true;
                this.txtVat.Text = oPurchaseOrder.VAT.ToString();
            }

            this.txtNetAmount.Text = oPurchaseOrder.NetAmount.ToString();
            this.txtRemark.Text = oPurchaseOrder.Remarks;

            for (int i = 0; i < oPurchaseOrder.dtItemList.Rows.Count; i++)
            {
                this.dgvItemData.Rows.Add();
                dgvItemData.Rows[i].Cells["clmItemCode"].Value = oPurchaseOrder.dtItemList.Rows[i][2].ToString();
                dgvItemData.Rows[i].Cells["clmItemDescription"].Value = cItemMaster.GetItemData(oPurchaseOrder.dtItemList.Rows[i][2].ToString()).Description;
                dgvItemData.Rows[i].Cells["clmUnitPrice"].Value = oPurchaseOrder.dtItemList.Rows[i][4].ToString();
                dgvItemData.Rows[i].Cells["clmQuantity"].Value = oPurchaseOrder.dtItemList.Rows[i][3].ToString();

                double a = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i][5].ToString());
                if (a > 0)
                {
                    dgvItemData.Rows[i].Cells["clmTax_chk"].Value = true;
                }

                dgvItemData.Rows[i].Cells["clmTaxAmount"].Value = oPurchaseOrder.dtItemList.Rows[i][5].ToString();

                double qty = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i][3]);
                double UnitPrice = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i][4]);
                double TaxAmount = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i][5]);
                dgvItemData.Rows[i].Cells["clmTotalAmount"].Value = ((qty * UnitPrice) + TaxAmount);
                calculatAmounts();
            }

            this.dgvItemData.Enabled = false;
            this.chkVat.Enabled = false;
            this.cmbLocation.Enabled = false;
            this.cmbSupplier.Enabled = false;
            this.dtpDate.Enabled = false;
            this.txtVat.Enabled = false;
            this.txtRemark.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnPrint.Enabled = true;
        }
        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
