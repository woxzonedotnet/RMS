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
using Reports;

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
        objReportMaster oReportMaster = new objReportMaster();
        clsReportMaster cReportMaster = new clsReportMaster();
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
        Point lastClick;
        #endregion

        public frmGoodsReceiveNote()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
            Location = cGlobleVariable.LocationCode.ToString();
        }

        private void frmGoodsReceiveNote_Load(object sender, EventArgs e)
        {
            clear();
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
            LoadSearch();
        }
        
        public void LoadSearch()
        {
            string[] strFieldList = new string[3];
            strFieldList[0] = "fldGRNCode";
            strFieldList[1] = "fldSupplierCode";
            strFieldList[2] = "fldDate";

            string[] strHeaderList = new string[3];
            strHeaderList[0] = "Good Recieve Code";
            strHeaderList[1] = "Supplier Code";
            strHeaderList[2] = "Good Recieve Date";

            int[] iHeaderWidth = new int[3];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 100;
            iHeaderWidth[2] = 150;

            string strReturnString = "Good Recieve Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtGRNNumber.Text = cCommonMethods.BrowsData("tbl_GRNDetails", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Good Recieve Code");
            if (txtGRNNumber.Text != "")
            {
                LoadGRNDetails();
            }
        }
        #endregion

        #region Load GRN Details
        private void LoadGRNDetails()
        {
            dgvItemData.Rows.Clear();
            oGoodReceiveNote = cGoodReceiveNote.GetGoodReceiveNoteData(cGlobleVariable.LocationCode, this.txtGRNNumber.Text);

            cmbLocation.SetText(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, oGoodReceiveNote.SubLocationCode).SubLocationName);
            cmbSupplier.SetText(cSupplier.GetSupplierData(cGlobleVariable.LocationCode, oGoodReceiveNote.SupplierCode).SupplierName);

            dtpDate.Value = oGoodReceiveNote.Date;
            txtInvoiceNo.Text = oGoodReceiveNote.InvoiceNo;
            txtGRNValue.Text = oGoodReceiveNote.GRNValue.ToString("###,###.00");

            if (oGoodReceiveNote.VATPresentage != 0)
            {
                chkVat.Checked = true;
                this.txtVatPrecentage.Text = oGoodReceiveNote.VATPresentage.ToString();
                this.txtVatAmount.Text = oGoodReceiveNote.VATAmount.ToString();
            }
            this.txtDiscount.Text = oGoodReceiveNote.Discount.ToString();
            this.txtNetAmount.Text = oGoodReceiveNote.NetAmount.ToString();


            for (int i = 0; i < oGoodReceiveNote.dtItemList.Rows.Count; i++)
            {
                this.dgvItemData.Rows.Add();
                dgvItemData.Rows[i].Cells["clmItemCode"].Value = oGoodReceiveNote.dtItemList.Rows[i]["fldItemCode"].ToString();
                dgvItemData.Rows[i].Cells["clmItemDescription"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode, oGoodReceiveNote.dtItemList.Rows[i]["fldItemCode"].ToString()).Description;
                dgvItemData.Rows[i].Cells["clmUnit"].Value = cItemLocation.GetItemLocationData(cGlobleVariable.LocationCode, this.cmbLocation["fldSubLocationCode"].ToString(), oGoodReceiveNote.dtItemList.Rows[i]["fldItemCode"].ToString()).ShelfStock;
                dgvItemData.Rows[i].Cells["clmUnitPrice"].Value = oGoodReceiveNote.dtItemList.Rows[i]["fldUnitPrice"].ToString();
                dgvItemData.Rows[i].Cells["clmQuantity"].Value = oGoodReceiveNote.dtItemList.Rows[i]["fldQuantity"].ToString();

                double a = Convert.ToDouble(oGoodReceiveNote.dtItemList.Rows[i]["fldTaxAmount"].ToString());
                if (a > 0)
                {
                    dgvItemData.Rows[i].Cells["clmTax_chk"].Value = true;
                }

                dgvItemData.Rows[i].Cells["clmTaxAmount"].Value = oGoodReceiveNote.dtItemList.Rows[i]["fldTaxAmount"].ToString();

                double qty = Convert.ToDouble(oGoodReceiveNote.dtItemList.Rows[i]["fldQuantity"]);
                double UnitPrice = Convert.ToDouble(oGoodReceiveNote.dtItemList.Rows[i]["fldUnitPrice"]);
                dgvItemData.Rows[i].Cells["clmValue"].Value = qty * UnitPrice;
                double TaxAmount = Convert.ToDouble(oGoodReceiveNote.dtItemList.Rows[i]["fldTaxAmount"]);
                dgvItemData.Rows[i].Cells["clmTotalAmount"].Value = ((qty * UnitPrice) + TaxAmount);
                //calculatAmounts();
            }

            EnableControls(false);
            this.btnPrint.Enabled = true;
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
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmUnit"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode, Item).Unit;
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
            if (chkPONumber.Checked == true)
            {
                calculatPOAmounts();
            }
            else
            {
                calculatAmounts();
            }
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

        public void calculatPOAmounts()
        {
            try
            {
                double qty = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmQuantity"].Value);
                Value = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmValue"].Value);
                double tax = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value);
                unitPrice = (Value / qty);
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmUnitPrice"].Value = Math.Round(unitPrice, 2);
                if ((this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTax_chk"].Value != null) && this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTax_chk"].Value.ToString().Equals("True"))
                {
                    this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTotalAmount"].Value = Math.Round(Value + tax, 2);
                }
                else
                {
                    this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTotalAmount"].Value = Math.Round(Value, 2);
                }


                TotalAmount = 0;

                if (this.chkPONumber.Checked == true)
                {
                    for (int i = 0; i < dgvItemData.Rows.Count; i++)
                    {
                        try
                        {
                            string tempTotal = this.dgvItemData.Rows[i].Cells["clmTotalAmount"].Value.ToString();
                            bool tempSelect = Convert.ToBoolean(dgvItemData.Rows[i].Cells["clmSelectItem"].Value);
                            
                            if (tempTotal != null && tempSelect)
                            {
                                TotalAmount += Convert.ToDouble(this.dgvItemData.Rows[i].Cells["clmTotalAmount"].Value);
                            }
                        }catch(Exception ex)
                        {

                        }
                        
                    }
                }

                this.txtGRNValue.Text = Math.Round(TotalAmount, 2).ToString();
                if (txtVatPrecentage.Enabled == true)
                {
                    //VAT
                    if (txtVatPrecentage.Text != "")
                    {
                        vat = (double.Parse(txtGRNValue.Text)) * (double.Parse(txtVatPrecentage.Text) / 100);
                        txtVatAmount.Text = Math.Round(vat, 2).ToString();
                        NetAmount = (TotalAmount + vat);
                        txtNetAmount.Text = Math.Round(NetAmount, 2).ToString();
                    }
                    //discount
                    if (txtDiscount.Text != "")
                    {

                        discount = Convert.ToDouble(txtDiscount.Text);
                        NetAmount = (NetAmount - discount);
                        if (NetAmount >= 0)
                        {
                            txtNetAmount.Text = Math.Round(NetAmount, 2).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Net Amount Can't be Nagetive..");
                        }
                    }
                }
                else
                {
                    txtNetAmount.Text = Math.Round(TotalAmount, 2).ToString();
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
            if (chkPONumber.Checked == true)
            {
                calculatPOAmounts();
            }
            else
            {
                calculatAmounts();
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (chkPONumber.Checked == true)
            {
                calculatPOAmounts();
            }
            else
            {
                calculatAmounts();
            }
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
                        taxCalculate();
                    }
                    else
                    {
                        this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value = "0.00";
                    }
                }

                if (this.dgvItemData.CurrentCell.OwningColumn.Name.Equals("clmSelectItem"))
                {
                    dgvItemData.EndEdit();
                    if ((this.dgvItemData.CurrentCell.Value != null) && this.dgvItemData.CurrentCell.Value.ToString().Equals("True"))
                    {
                        dgvItemData.CurrentCell.Style.BackColor = Color.LightGreen;
                        dgvItemData.CurrentRow.Cells["clmItemCode"].Style.BackColor = Color.LightGreen;
                        dgvItemData.CurrentRow.Cells["clmQuantity"].Style.BackColor = Color.LightGreen;
                        dgvItemData.CurrentRow.Cells["clmValue"].Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        dgvItemData.CurrentCell.Style.BackColor = Color.White;
                        dgvItemData.CurrentRow.Cells["clmItemCode"].Style.BackColor = Color.White;
                        dgvItemData.CurrentRow.Cells["clmQuantity"].Style.BackColor = Color.White;
                        dgvItemData.CurrentRow.Cells["clmValue"].Style.BackColor = Color.White;
                    }

                }
                if (chkPONumber.Checked == true)
                {
                    calculatPOAmounts();
                }
                else
                {
                    calculatAmounts();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void taxCalculate()
        {
            double taxPrecentage = Convert.ToDouble(cSetupSetting.GetSetupSettingData(cGlobleVariable.LocationCode).VAT);
            double totalTax = (Value * taxPrecentage) / 100;
            this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value = Math.Round(totalTax, 2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oGoodReceiveNote = cGoodReceiveNote.GetGoodReceiveNoteData(cGlobleVariable.LocationCode, this.txtGRNNumber.Text);

                if (oGoodReceiveNote.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result == -5)
                    {
                        MessageBox.Show("Data Not Changed...!", "GRN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result != -1)
                    {

                        MessageBox.Show("Successfully Saved...!", "GRN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cDocumentNumber.DeleteDocumentNumber(cGlobleVariable.UniqID, DocumentCode, txtGRNNumber.Text);
                        EnableControls(false);
                        this.btnPrint.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Item Data Not Saved...!", "GRN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "GRN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        #region DataGrid To DataTable
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
                    dRow["fldGRNCode"] = strGRNCode;
                    dRow["fldItemCode"] = row.Cells["clmItemCode"].Value.ToString();
                    dRow["fldUnitPrice"] = row.Cells["clmUnitPrice"].Value.ToString();
                    dRow["fldQuantity"] = row.Cells["clmQuantity"].Value.ToString();
                    dRow["fldValue"] = row.Cells["clmValue"].Value.ToString();
                    dRow["fldTaxAmount"] = row.Cells["clmTaxAmount"].Value.ToString();

                    if (this.chkPONumber.Checked)
                    {
                        if (Convert.ToBoolean(row.Cells["clmSelectItem"].Value))
                        {
                            dt.Rows.Add(dRow);
                        }
                    }
                    else
                    {
                        dt.Rows.Add(dRow);
                    }
                    
                    
                }
                catch (Exception ex)
                {
                    
                }

            }
            return dt;
        }

        #endregion

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

            oGoodReceiveNote.POCode = this.txtPONumber.Text;

            oGoodReceiveNote.dtItemList = DataGridToDataTable(dgvItemData, oGoodReceiveNote.GRNCode);
            if (oGoodReceiveNote.dtItemList.Rows.Count == 0)
            {
                return -5;
            }
            else
            {
                return cGoodReceiveNote.InsertUpdateData(oGoodReceiveNote);
            }
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

        #region Purchase Order Search
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
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "' AND fldRecived = 0";
            txtPONumber.Text = cCommonMethods.BrowsData("tbl_PODetails", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Purchase Order");
            if (txtPONumber.Text != "")
            {
                LoadPurchaseOrderDetails();
            }
        }
        #endregion

        #region Load Purchase Order Details
        private void LoadPurchaseOrderDetails()
        {
            oPurchaseOrder = cPurchaseOrder.GetPurchaseOrderData(cGlobleVariable.LocationCode, this.txtPONumber.Text);

            cmbLocation.SetText(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, oPurchaseOrder.SubLocationCode).SubLocationName);
            cmbSupplier.SetText(cSupplier.GetSupplierData(cGlobleVariable.LocationCode, oPurchaseOrder.SupplierCode).SupplierName);

            this.dgvItemData.Rows.Clear();

            for (int i = 0; i < oPurchaseOrder.dtItemList.Rows.Count; i++)
            {
                if (!Convert.ToBoolean(oPurchaseOrder.dtItemList.Rows[i]["fldRecived"]))
                {
                    this.dgvItemData.Rows.Add();
                    dgvItemData.Rows[i].Cells["clmItemCode"].Value = oPurchaseOrder.dtItemList.Rows[i]["fldItemCode"].ToString();
                    dgvItemData.Rows[i].Cells["clmItemDescription"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode, oPurchaseOrder.dtItemList.Rows[i]["fldItemCode"].ToString()).Description;
                    dgvItemData.Rows[i].Cells["clmUnit"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode,oPurchaseOrder.dtItemList.Rows[i]["fldItemCode"].ToString()).Unit;
                    dgvItemData.Rows[i].Cells["clmUnitPrice"].Value = oPurchaseOrder.dtItemList.Rows[i]["fldUnitPrice"].ToString();
                    dgvItemData.Rows[i].Cells["clmOrderQuantity"].Value = oPurchaseOrder.dtItemList.Rows[i]["fldQuantity"].ToString();
                    dgvItemData.Rows[i].Cells["clmQuantity"].Value = oPurchaseOrder.dtItemList.Rows[i]["fldQuantity"].ToString();

                    double a = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i]["fldTaxAmount"].ToString());
                    if (a > 0)
                    {
                        dgvItemData.Rows[i].Cells["clmTax_chk"].Value = true;
                    }

                    dgvItemData.Rows[i].Cells["clmTaxAmount"].Value = oPurchaseOrder.dtItemList.Rows[i]["fldTaxAmount"].ToString();

                    double qty = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i]["fldQuantity"]);
                    double UnitPrice = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i]["fldUnitPrice"]);
                    double TaxAmount = Convert.ToDouble(oPurchaseOrder.dtItemList.Rows[i]["fldTaxAmount"]);
                    dgvItemData.Rows[i].Cells["clmTotalAmount"].Value = ((qty * UnitPrice) + TaxAmount);

                }
                //calculatAmounts();
            }

            #region Empty Row Cleaner
            try
            {
                for (int i = 0; i < dgvItemData.Rows.Count; i++)
                {
                    //MessageBox.Show(dgvItemData.Rows[i].Cells["clmItemCode"].Value.ToString());
                    if (dgvItemData.Rows[i].Cells["clmItemCode"].Value == null)
                    {
                        dgvItemData.Rows.RemoveAt(i);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            #endregion

            this.cmbLocation.Enabled = false;
            this.cmbSupplier.Enabled = false;
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
            this.txtDiscount.Text = "0";
            this.txtVatPrecentage.Text = "0";
            this.txtVatAmount.Text = "0";
            LoadDocumentNumber();
            this.txtGRNNumber.ReadOnly = true;
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

        #region Report Section
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportViewer(11);
        }

        private void ReportViewer(int strReportID)
        {
            System.Object[,] arrParameter;
            oReportMaster = cReportMaster.GetReports(strReportID);

            arrParameter = new Object[(2), 2];

            arrParameter[0, 0] = "strCopyRight";
            arrParameter[0, 1] = cGlobleVariable.CopyRight;
            arrParameter[1, 0] = "strReportTitle";
            arrParameter[1, 1] = oReportMaster.ReportTitle;

            frmReportViewer frmReportViever = new frmReportViewer(strReportID, cGlobleVariable.LocationCode, SelectionFormularValues(strReportID), arrParameter);
            frmReportViever.Show();
        }

        private string SelectionFormularValues(int iReportID)
        {
            string srtFormular = string.Empty;

            if (oReportMaster.SelectedTable.ToString() != string.Empty)
            {
                srtFormular += "{" + oReportMaster.SelectedTable + ".fldGRNCode}='" + this.txtGRNNumber.Text + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
            }

            if (oReportMaster.SelectionFormular.ToString() != string.Empty)
            {
                srtFormular += " AND " + oReportMaster.SelectionFormular + " OR ";
            }
            else
            {
                srtFormular += " OR ";
            }

            if (srtFormular != string.Empty)
            {
                if (srtFormular.Substring(srtFormular.Length - 3, 2) == "OR")
                {
                    int n = srtFormular.LastIndexOf("OR");

                    srtFormular = srtFormular.Substring(0, n - 1);
                }
            }

            if (srtFormular != string.Empty)
            {
                if (srtFormular.Substring(srtFormular.Length - 3, 3) == "AND")
                {
                    int n = srtFormular.LastIndexOf("AND");

                    srtFormular = srtFormular.Substring(0, n - 1);
                }
            }
            return srtFormular;
        }
        #endregion

        private void dgvItemData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (chkPONumber.Checked == true && dgvItemData.CurrentRow.Cells["clmTax_chk"].Value.ToString().Equals("True"))
                {
                    taxCalculate();
                    //calculatPOAmounts();
                }
            }
            catch (Exception ex)
            {

            }
        }

        #region From Move
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
        #endregion

        private void frmGoodsReceiveNote_Activated(object sender, EventArgs e)
        {
            //this.panel3.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void frmGoodsReceiveNote_Deactivate(object sender, EventArgs e)
        {
            //this.panel3.BackColor = Color.FromArgb(36, 41, 46);
        }
    }
}
