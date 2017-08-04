using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;
using BusinessObject;

namespace RMS.Forms.Inventory
{
    public partial class frmGoodsReceiveNote : Form
    {
        #region Objects
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsSubLocation cSubLocation = new clsSubLocation();
        clsSupplierMaster cSupplierMaster = new clsSupplierMaster();
        objItemMaster oItemMaster = new objItemMaster();
        clsItemMaster cItemMaster = new clsItemMaster();
        clsSetupSetting cSetupSetting = new clsSetupSetting();
        objGoodReceiveNote oGoodReceiveNote = new objGoodReceiveNote();
        clsGoodReceiveNote cGoodReceiveNote = new clsGoodReceiveNote();
        clsDocumentNumber cDocumentNumber = new clsDocumentNumber();
        objItemLocation oItemLocation = new objItemLocation();
        clsItemLocation cItemLocation = new clsItemLocation();
        objPurchaseOrder oPurchaseOrder = new objPurchaseOrder();
        clsPurchaseOrder cPurchaseOrder = new clsPurchaseOrder();
        clsSupplierMaster cSupplier = new clsSupplierMaster();
        #endregion

        #region Variable
        string Location = "";
        string Item = "";
        string DocumentCode = "GR";
        double unitPrice = 0;
        double TotalAmount = 0;
        double vat = 0;
        double discount = 0;
        double Value = 0;
        double NetAmount = 0;
        int result = 0;
        #endregion

        public frmGoodsReceiveNote()
        {
            InitializeComponent();
            Location = cGlobleVariable.LocationCode.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGoodsReceiveNote_Load(object sender, EventArgs e)
        {
            LoadDocumentNumber();
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(), cmbLocation, 2);
            cCommonMethods.loadComboRMS(cSupplierMaster.GetSupplierData(), cmbSupplier, 2);
        }

        public void LoadDocumentNumber()
        {
            this.txtGRNNumber.Text = cDocumentNumber.LoadDocNumber(cGlobleVariable.UniqID, DocumentCode, cGlobleVariable.LocationCode, cCommonMethods.DateYear());
        }

        #region Search Button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //LoadSearch();
        }
        
        public void LoadSearch()
        {
            string[] strFieldList = new string[3];
            strFieldList[0] = "fldCardCode";
            strFieldList[1] = "fldBankCode";
            strFieldList[2] = "fldCardTypeCode";

            string[] strHeaderList = new string[3];
            strHeaderList[0] = "Card Code";
            strHeaderList[1] = "Bank Code";
            strHeaderList[2] = "Card Type Code";

            int[] iHeaderWidth = new int[3];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 150;
            iHeaderWidth[2] = 320;

            string strReturnString = "GRN Number";
            string strWhere = "fldStatus LIKE '%'";
            txtGRNNumber.Text = cCommonMethods.BrowsData("tbl_GRNDetails", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "fldGRNCode");
            if (txtGRNNumber.Text != "")
            {
               // LoadGRNNumber();
            }
        }
        #endregion

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) && this.dgvItemData.CurrentCell.OwningColumn.Name.Equals("clmItemCode"))
            {

                if (ValidateData())
                {
                    LoadItem();
                    if (dgvItemData.RowCount != 0)
                    {
                        cmbLocation.Enabled = false;
                        cmbSupplier.Enabled = false;
                    }
                }

            }
        }

        #region LoadItem
        public void LoadItem()
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
            Item = cCommonMethods.BrowsData("tbl_ItemMaster a,tbl_ItemLocation b", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Item Code");
            if (Item != "")
            {
                LoadItemDetails();
            }
        }
        #endregion

        #region Load Item Details
        private void LoadItemDetails()
        {
            oItemMaster = cItemMaster.GetItemData(cGlobleVariable.LocationCode,Item);
            oItemLocation = cItemLocation.GetItemLocationData(cGlobleVariable.LocationCode,this.cmbLocation["fldSubLocationCode"].ToString(), Item);

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
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmUnit"].Value = oItemLocation.ShelfStock;
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmUnitPrice"].Value = oItemMaster.CostPrice;
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmQuantity"].Value = "0.00";
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmValue"].Value = "0.00";
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmTaxAmount"].Value = "0.00";
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmTotalAmount"].Value = "0.00";
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
                Value = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmValue"].Value);
                double tax = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value);
                unitPrice = (Value / qty);
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmUnitPrice"].Value = Math.Round(unitPrice,2);
                if ((this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTax_chk"].Value != null) && this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTax_chk"].Value.ToString().Equals("True"))
                {
                    this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTotalAmount"].Value = Math.Round(Value + tax,2);
                }
                else
                {
                    this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTotalAmount"].Value = Math.Round(Value,2);
                }


                TotalAmount = 0;
                for (int i = 0; i < dgvItemData.Rows.Count; i++)
                {
                    if (this.dgvItemData.Rows[i].Cells["clmTotalAmount"].Value != null)
                    {
                        TotalAmount += Convert.ToDouble(this.dgvItemData.Rows[i].Cells["clmTotalAmount"].Value);
                    }
                }
                this.txtGRNValue.Text = Math.Round(TotalAmount,2).ToString();
                if (txtVatPrecentage.Enabled == true)
                {
                    //VAT
                    if (txtVatPrecentage.Text != "")
                    {
                        vat = (double.Parse(txtGRNValue.Text)) * (double.Parse(txtVatPrecentage.Text) / 100);
                        txtVatAmount.Text = Math.Round(vat,2).ToString();
                        NetAmount = (TotalAmount + vat);
                        txtNetAmount.Text = Math.Round(NetAmount,2).ToString();
                    }
                    //discount
                    if (txtDiscount.Text != "")
                    {
                        
                        discount = Convert.ToDouble(txtDiscount.Text);
                        NetAmount = (NetAmount - discount);
                        if (NetAmount >= 0)
                        {
                            txtNetAmount.Text = Math.Round(NetAmount,2).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Net Amount Can't be Nagetive..");
                        }
                    }
                }
                else
                {
                    txtNetAmount.Text = Math.Round(TotalAmount,2).ToString();
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void chkVat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVat.Checked == true)
            {
                txtVatPrecentage.Enabled = true;
            }
            else
            {
                txtVatPrecentage.Enabled = false;
            }
        }

        private void txtVatPrecentage_TextChanged(object sender, EventArgs e)
        {
            calculatAmounts();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            calculatAmounts();
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
                        double totalTax = (Value * taxPrecentage) / 100;
                        this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value = Math.Round(totalTax,2);
                        calculatAmounts();
                    }
                    else
                    {
                        this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value = "0.00";
                        calculatAmounts();
                    }
                }

                if (this.dgvItemData.CurrentCell.OwningColumn.Name.Equals("clmSelectItem"))
                {
                    dgvItemData.EndEdit();
                    if ((this.dgvItemData.CurrentCell.Value != null) && this.dgvItemData.CurrentCell.Value.ToString().Equals("True"))
                    {
                        dgvItemData.CurrentCell.Style.BackColor = Color.LightGreen;
                        dgvItemData.CurrentRow.Cells["clmItemCode"].Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        dgvItemData.CurrentCell.Style.BackColor = Color.White;
                        dgvItemData.CurrentRow.Cells["clmItemCode"].Style.BackColor = Color.White;
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oGoodReceiveNote = cGoodReceiveNote.GetGoodReceiveNoteData(cGlobleVariable.LocationCode, this.txtGRNNumber.Text);

                if (oGoodReceiveNote.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cDocumentNumber.DeleteDocumentNumber(cGlobleVariable.UniqID, DocumentCode, txtGRNNumber.Text);
                        EnableControls(false);
                        this.btnPrint.Enabled = true;
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

            if (txtGRNNumber.Text == "")
            {
                errGRN.SetError(txtGRNNumber, "Please Enter Goods Recieve Code");
                isValidate = false;
            }
            else
            {
                errGRN.SetError(txtGRNNumber, "");
            }


            if (txtInvoiceNo.Text == "")
            {
                errGRN.SetError(txtInvoiceNo, "Please Enter Invoice No");
                isValidate = false;
            }
            else
            {
                errGRN.SetError(txtInvoiceNo, "");
            }




            if (cmbLocation.SelectedIndex == -1)
            {
                errGRN.SetError(cmbLocation, "Please Select Location");
                isValidate = false;
            }
            else
            {
                errGRN.SetError(cmbLocation, "");
            }

            if (cmbSupplier.SelectedIndex == -1)
            {
                errGRN.SetError(cmbSupplier, "Please Select Supplier");
                isValidate = false;
            }
            else
            {
                errGRN.SetError(cmbSupplier, "");
            }


            if (dtpDate.Value > DateTime.Now)
            {
                errGRN.SetError(dtpDate, "Please Select Valid Date");
                isValidate = false;
            }
            else
            {
                errGRN.SetError(dtpDate, "");
            }

            return isValidate;
        }
        #endregion

        public DataTable DataGridToDataTable(DataGridView dgv,string strGRNCode)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("fldGRNCode");
            dt.Columns.Add("fldItemCode");
            dt.Columns.Add("fldUnitPrice");
            dt.Columns.Add("fldQuantity");
            dt.Columns.Add("fldValue");
            dt.Columns.Add("fldTaxAmount");


            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                try
                {
                    dRow[0] = strGRNCode;
                    dRow[1] = row.Cells[0].Value.ToString();
                    dRow[2] = row.Cells[3].Value.ToString();
                    dRow[3] = row.Cells[4].Value.ToString();
                    dRow[4] = row.Cells[5].Value.ToString();
                    dRow[5] = row.Cells[7].Value.ToString();
                    dt.Rows.Add(dRow);
                }
                catch (Exception ex)
                {

                }

            }
            return dt;
        }
        
        #region InsertUpdate Good Receive Note Data
        private int InsertUpdateData()
        {
            oGoodReceiveNote.LocationCode = cGlobleVariable.LocationCode;
            oGoodReceiveNote.GRNCode = this.txtGRNNumber.Text;
            oGoodReceiveNote.SubLocationCode = this.cmbLocation["fldSubLocationCode"].ToString();
            oGoodReceiveNote.SupplierCode = this.cmbSupplier["fldSupplierCode"].ToString();
            oGoodReceiveNote.Date = this.dtpDate.Value;
            oGoodReceiveNote.InvoiceNo = this.txtInvoiceNo.Text;
            oGoodReceiveNote.GRNValue = Convert.ToDouble(this.txtGRNValue.Text);
            oGoodReceiveNote.VATPresentage = Convert.ToDouble(this.txtVatPrecentage.Text);
            oGoodReceiveNote.VATAmount = Convert.ToDouble(this.txtVatAmount.Text);
            oGoodReceiveNote.Discount = Convert.ToDouble(this.txtDiscount.Text);
            oGoodReceiveNote.NetAmount = Convert.ToDouble(this.txtNetAmount.Text);

            oGoodReceiveNote.dtItemList = DataGridToDataTable(dgvItemData, oGoodReceiveNote.GRNCode);

            return cGoodReceiveNote.InsertUpdateData(oGoodReceiveNote);
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvItemData_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvItemData.RowCount == 1)
            {
                cmbLocation.Enabled = true;
                cmbSupplier.Enabled = true;
            }
        }

        private void chkPONumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPONumber.Checked == true)
            {
                txtPONumber.Enabled = true;
                btnPOSesrch.Enabled = true;
                dgvItemData.Rows.Clear();
                dgvItemData.Columns["clmOrderQuantity"].Visible = true;
                dgvItemData.Columns["clmSelectItem"].Visible = true;
                dgvItemData.Columns["clmItemCode"].ReadOnly = false;
                cmbLocation.Enabled = false;
                cmbSupplier.Enabled = false;

            }
            else
            {
                dgvItemData.Rows.Clear();
                txtPONumber.Clear();
                txtPONumber.Enabled = false;
                btnPOSesrch.Enabled = false;
                cmbLocation.Enabled = true;
                cmbLocation.SetText("");
                cmbSupplier.Enabled = true;
                cmbSupplier.SetText("");
                dgvItemData.Columns["clmOrderQuantity"].Visible = false;
                dgvItemData.Columns["clmSelectItem"].Visible = false;
                dgvItemData.Columns["clmItemCode"].ReadOnly = true;
            }
        }

        private void btnPOSesrch_Click(object sender, EventArgs e)
        {
            LoadPOSearch();
        }

        public void LoadPOSearch()
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
            iHeaderWidth[1] = 100;
            iHeaderWidth[2] = 150;
            iHeaderWidth[3] = 200;

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
            oPurchaseOrder = cPurchaseOrder.GetPurchaseOrderData(cGlobleVariable.LocationCode, this.txtPONumber.Text);

            cmbLocation.SetText(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, oPurchaseOrder.SubLocationCode).SubLocationName);
            cmbSupplier.SetText(cSupplier.GetSupplierData(cGlobleVariable.LocationCode, oPurchaseOrder.SupplierCode).SupplierName);


            for (int i = 0; i < oPurchaseOrder.dtItemList.Rows.Count; i++)
            {
                this.dgvItemData.Rows.Add();
                dgvItemData.Rows[i].Cells["clmItemCode"].Value = oPurchaseOrder.dtItemList.Rows[i]["fldItemCode"].ToString();
                dgvItemData.Rows[i].Cells["clmItemDescription"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode, oPurchaseOrder.dtItemList.Rows[i]["fldItemCode"].ToString()).Description;
                dgvItemData.Rows[i].Cells["clmUnit"].Value = cItemLocation.GetItemLocationData(cGlobleVariable.LocationCode,oPurchaseOrder.dtItemList.Rows[i]["fldItemCode"].ToString()).ShelfStock;
                dgvItemData.Rows[i].Cells["clmQuantity"].Value = cItemLocation.GetItemLocationData(cGlobleVariable.LocationCode, oPurchaseOrder.dtItemList.Rows[i]["fldItemCode"].ToString()).ShelfStock;
                dgvItemData.Rows[i].Cells["clmUnitPrice"].Value = oPurchaseOrder.dtItemList.Rows[i]["fldUnitPrice"].ToString();
                dgvItemData.Rows[i].Cells["clmOrderQuantity"].Value = oPurchaseOrder.dtItemList.Rows[i]["fldQuantity"].ToString();

                double a = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i][4].ToString());
                if (a > 0)
                {
                    dgvItemData.Rows[i].Cells["clmTax_chk"].Value = true;
                }

                dgvItemData.Rows[i].Cells["clmTaxAmount"].Value = oPurchaseOrder.dtItemList.Rows[i]["fldTaxAmount"].ToString();

                double qty = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i]["fldQuantity"]);
                double UnitPrice = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i]["fldUnitPrice"]);
                double TaxAmount = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i]["fldTaxAmount"]);
                dgvItemData.Rows[i].Cells["clmTotalAmount"].Value = ((qty * UnitPrice) + TaxAmount);
                //calculatAmounts();
            }

            //this.dgvItemData.Enabled = false;
            //this.chkVat.Enabled = false;
            //this.dtpDate.Enabled = false;
            //this.btnSave.Enabled = false;
            //this.btnPrint.Enabled = true;
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        #region Clear
        public void clear()
        {
            cCommonMethods.ClearForm(this);
            LoadDocumentNumber();
            EnableControls(true);
            this.btnPrint.Enabled = false;
            this.btnPOSesrch.Enabled = false;
        }
        #endregion

        #region Disable Component
        public void EnableControls(bool Command)
        {
            bool result;
            if (Command)
            {
                result = true;
                this.txtGRNNumber.ReadOnly = false;
                this.txtPONumber.ReadOnly = true;
                this.txtInvoiceNo.ReadOnly = false;
                this.txtGRNValue.ReadOnly = false;
                this.txtVatPrecentage.ReadOnly = false;
                this.txtVatAmount.ReadOnly = false;
                this.txtDiscount.ReadOnly = false;
                this.txtNetAmount.ReadOnly = false;
            }
            else
            {
                result = false;
                this.txtGRNNumber.ReadOnly = true;
                this.txtPONumber.ReadOnly = true;
                this.txtInvoiceNo.ReadOnly = true;
                this.txtGRNValue.ReadOnly = true;
                this.txtVatPrecentage.ReadOnly = true;
                this.txtVatAmount.ReadOnly = true;
                this.txtDiscount.ReadOnly = true;
                this.txtNetAmount.ReadOnly = true;
            }

            this.btnSave.Enabled = result;
            this.btnPOSesrch.Enabled = result;
            this.chkPONumber.Enabled = result;
            this.dgvItemData.Enabled = result;
            this.cmbLocation.Enabled = result;
            this.cmbSupplier.Enabled = result;
            this.dtpDate.Enabled = result;
            this.chkVat.Enabled = result;

        }
        #endregion
    }
}
