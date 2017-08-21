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
    public partial class frmSupplierReturnNote : Form
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
        objReportMaster oReportMaster = new objReportMaster();
        clsReportMaster cReportMaster = new clsReportMaster();
        objSupplierReturnNote oSupplierReturnNote = new objSupplierReturnNote();
        clsSupplierReturnNote cSupplierReturnNote = new clsSupplierReturnNote();
        #endregion

        #region Variable
        string Location = "";
        string Item = "";
        string DocumentCode = "SR";
        double unitPrice = 0;
        double TotalAmount = 0;
        double vat = 0;
        double discount = 0;
        double Value = 0;
        double NetAmount = 0;
        int result = 0;
        Point lastClick;
        #endregion
        public frmSupplierReturnNote()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
            Location = cGlobleVariable.LocationCode.ToString();
        }

        private void frmSupplierReturnNote_Load(object sender, EventArgs e)
        {
            clear();
            LoadDocumentNumber();
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(), cmbLocation, 2);
            cCommonMethods.loadComboRMS(cSupplierMaster.GetSupplierData(), cmbSupplier, 2);
            
        }

        public void LoadDocumentNumber()
        {
            this.txtSRNNumber.Text = cDocumentNumber.LoadDocNumber(cGlobleVariable.UniqID, DocumentCode, cGlobleVariable.LocationCode, cCommonMethods.DateYear());
        }

        #region Clear
        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtDiscount.Text = "0";
            this.txtVatPrecentage.Text = "0";
            this.txtVatAmount.Text = "0";
            LoadDocumentNumber();
            EnableControls(true);
            this.btnPrint.Enabled = false;
            this.btnGRNSesrch.Enabled = false;
        }
        #endregion

        #region Disable Component
        public void EnableControls(bool Command)
        {
            bool result;
            if (Command)
            {
                result = true;
                this.txtSRNNumber.ReadOnly = false;
                this.txtGRNNumber.ReadOnly = false;
                this.txtInvoiceNo.Enabled = false;
                this.txtSRNValue.ReadOnly = false;
                this.txtVatPrecentage.ReadOnly = false;
                this.txtVatAmount.ReadOnly = false;
                this.txtDiscount.ReadOnly = false;
                this.txtNetAmount.ReadOnly = false;
            }
            else
            {
                result = false;
                this.txtSRNNumber.ReadOnly = true;
                this.txtGRNNumber.ReadOnly = true;
                this.txtInvoiceNo.ReadOnly = true;
                this.txtSRNValue.ReadOnly = true;
                this.txtVatPrecentage.ReadOnly = true;
                this.txtVatAmount.ReadOnly = true;
                this.txtDiscount.ReadOnly = true;
                this.txtNetAmount.ReadOnly = true;
            }

            this.btnSave.Enabled = result;
            this.dgvItemData.Enabled = result;
            this.cmbLocation.Enabled = result;
            this.cmbSupplier.Enabled = result;
            this.dtpDate.Enabled = result;
            this.chkVat.Enabled = result;

        }
        #endregion

        private void chkGRNNumber_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkGRNNumber.Checked == true)
            {
                
                txtGRNNumber.Enabled = true;
                btnGRNSesrch.Enabled = true;
                this.txtDiscount.Text = "0";
                this.txtVatPrecentage.Text = "0";
                this.txtVatAmount.Text = "0";
                dgvItemData.Rows.Clear();
                cmbLocation.Enabled = false;
                cmbSupplier.Enabled = false;
                txtInvoiceNo.Enabled = false;
                txtSRNValue.Enabled = false;
                chkVat.Enabled = false;
                txtVatPrecentage.Enabled = false;
                txtVatAmount.Enabled = false;
                txtDiscount.Enabled = false;
                txtNetAmount.Enabled = false;
                dgvItemData.Columns["clmSelectItem"].Visible = true;
                dgvItemData.Columns["clmItemCode"].ReadOnly = false;
                
                

            }
            else
            {
                dgvItemData.Rows.Clear();
                txtGRNNumber.Clear();
                txtGRNNumber.Enabled = false;
                btnGRNSesrch.Enabled = false;
                cmbLocation.Enabled = true;
                cmbLocation.SetText("");
                cmbSupplier.Enabled = true;
                cmbSupplier.SetText("");
                txtInvoiceNo.Enabled = false;
                txtSRNValue.Enabled = true;
                chkVat.Enabled = true;
                txtVatAmount.Enabled = true;
                txtDiscount.Enabled = true;
                txtNetAmount.Enabled = true;
                dgvItemData.Columns["clmSelectItem"].Visible = false;
                dgvItemData.Columns["clmItemCode"].ReadOnly = true;
                clear();
            }
        }

        #region GRN Search
        private void btnGRNSesrch_Click(object sender, EventArgs e)
        {
            LoadGRNSearch();
        }
        public void LoadGRNSearch()
        {
            string[] strFieldList = new string[4];
            strFieldList[0] = "fldGRNCode";
            strFieldList[1] = "fldSupplierCode";
            strFieldList[2] = "fldDate";
            strFieldList[3] = "fldInvoiceNo";

            string[] strHeaderList = new string[4];
            strHeaderList[0] = "Good Recieve Code";
            strHeaderList[1] = "Supplier Code";
            strHeaderList[2] = "Good Recieve Date";
            strHeaderList[3] = "Invoice No";

            int[] iHeaderWidth = new int[4];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 100;
            iHeaderWidth[2] = 150;
            iHeaderWidth[3] = 150;

            string strReturnString = "Good Recieve Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'AND fldIsCancelGRN = 0";
            txtGRNNumber.Text = cCommonMethods.BrowsData("tbl_GRNDetails", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Good Recieve Code");
            if (txtGRNNumber.Text != "")
            {
                LoadGRNDetails();
            }
        }

        #region Load GRN Details
        private void LoadGRNDetails()
        {
            dgvItemData.Rows.Clear();
            oGoodReceiveNote = cGoodReceiveNote.GetGoodReceiveNoteData(cGlobleVariable.LocationCode, this.txtGRNNumber.Text);

            cmbLocation.SetText(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, oGoodReceiveNote.SubLocationCode).SubLocationName);
            cmbSupplier.SetText(cSupplierMaster.GetSupplierData(cGlobleVariable.LocationCode, oGoodReceiveNote.SupplierCode).SupplierName);

            //dtpDate.Value = oGoodReceiveNote.Date;
            txtInvoiceNo.Text = oGoodReceiveNote.InvoiceNo;
            txtSRNValue.Text = oGoodReceiveNote.GRNValue.ToString("###,###.00");

            if (oGoodReceiveNote.VATPresentage != 0)
            {
                chkVat.Checked = true;
                this.txtVatPrecentage.Text = oGoodReceiveNote.VATPresentage.ToString();
                this.txtVatAmount.Text = oGoodReceiveNote.VATAmount.ToString();
            }
            else
            {
                chkVat.Checked = false;
                this.txtVatPrecentage.Text = "0.00";
                this.txtVatAmount.Text = "0.00";
            }
            this.txtDiscount.Text = oGoodReceiveNote.Discount.ToString();
            this.txtNetAmount.Text = oGoodReceiveNote.NetAmount.ToString();


            for (int i = 0; i < oGoodReceiveNote.dtItemList.Rows.Count; i++)
            {
                this.dgvItemData.Rows.Add();

                double GRNqty = Convert.ToDouble(oGoodReceiveNote.dtItemList.Rows[i]["fldQuantity"]);
                double returnQty = Convert.ToDouble(oGoodReceiveNote.dtItemList.Rows[i]["fldReturnQty"]);
                double qty = GRNqty - returnQty;

                if (qty > 0)
                {
                    dgvItemData.Rows[i].Cells["clmSelectItem"].Value = true;
                    dgvItemData.Rows[i].Cells["clmSelectItem"].Style.BackColor = Color.LightGreen;
                    dgvItemData.Rows[i].Cells["clmItemCode"].Style.BackColor = Color.LightGreen;
                    dgvItemData.Rows[i].Cells["clmQuantity"].Style.BackColor = Color.LightGreen;
                    dgvItemData.Rows[i].Cells["clmValue"].Style.BackColor = Color.LightGreen;
                    dgvItemData.Rows[i].Cells["clmItemCode"].Value = oGoodReceiveNote.dtItemList.Rows[i]["fldItemCode"].ToString();
                    dgvItemData.Rows[i].Cells["clmItemDescription"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode, oGoodReceiveNote.dtItemList.Rows[i]["fldItemCode"].ToString()).Description;
                    dgvItemData.Rows[i].Cells["clmUnit"].Value = cItemLocation.GetItemLocationData(cGlobleVariable.LocationCode, this.cmbLocation["fldSubLocationCode"].ToString(), oGoodReceiveNote.dtItemList.Rows[i]["fldItemCode"].ToString()).ShelfStock;
                    dgvItemData.Rows[i].Cells["clmUnitPrice"].Value = oGoodReceiveNote.dtItemList.Rows[i]["fldUnitPrice"].ToString();

                    dgvItemData.Rows[i].Cells["clmQuantity"].Value = qty;

                    double a = Convert.ToDouble(oGoodReceiveNote.dtItemList.Rows[i]["fldTaxAmount"].ToString());
                    if (a > 0)
                    {
                        dgvItemData.Rows[i].Cells["clmTax_chk"].Value = true;
                    }

                    dgvItemData.Rows[i].Cells["clmTaxAmount"].Value = oGoodReceiveNote.dtItemList.Rows[i]["fldTaxAmount"].ToString();

                    double UnitPrice = Convert.ToDouble(oGoodReceiveNote.dtItemList.Rows[i]["fldUnitPrice"]);
                    dgvItemData.Rows[i].Cells["clmValue"].Value = qty * UnitPrice;
                    double TaxAmount = Convert.ToDouble(oGoodReceiveNote.dtItemList.Rows[i]["fldTaxAmount"]);
                    dgvItemData.Rows[i].Cells["clmTotalAmount"].Value = ((qty * UnitPrice) + TaxAmount);
                }
                else
                {
                    txtVatPrecentage.Text = "0.00";
                    txtVatAmount.Text = "0.00";
                    txtDiscount.Text = "0.00";

                }

                
            }
            EnableControls(false);
            dgvItemData.Enabled = true;
            dtpDate.Enabled = true;
            btnSave.Enabled = true;

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

            if (chkGRNNumber.Checked == true)
            {
                calculatGRNAmounts();
            }
            else
            {
                calculatAmounts();
            }
        }
        #endregion
        #endregion


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
                        //this.dgvItemData.CurrentCell = this.dgvItemData.Rows[].Cells[3];
                    }
                    else
                    {
                        dgvItemData.CurrentCell.Style.BackColor = Color.White;
                        dgvItemData.CurrentRow.Cells["clmItemCode"].Style.BackColor = Color.LightPink;
                        dgvItemData.CurrentRow.Cells["clmQuantity"].Style.BackColor = Color.LightPink;
                        dgvItemData.CurrentRow.Cells["clmValue"].Style.BackColor = Color.LightPink;
                    }
                }

                if (chkGRNNumber.Checked == true)
                {
                    calculatGRNAmounts();
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



        private void dgvItemData_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (chkGRNNumber.Checked == true)
            {
                calculatGRNAmounts();
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
                double UnitPrice = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmUnitPrice"].Value);
                double tax = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value);
                Value = (UnitPrice * qty);
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmValue"].Value = Math.Round(Value, 2);

                if ((this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTax_chk"].Value != null) && this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTax_chk"].Value.ToString().Equals("True"))
                {
                    this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTotalAmount"].Value = Math.Round(Value + tax, 2);
                }
                else
                {
                    this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTotalAmount"].Value = Math.Round(Value, 2);
                }


                TotalAmount = 0;
                for (int i = 0; i < dgvItemData.Rows.Count; i++)
                {
                    if (this.dgvItemData.Rows[i].Cells["clmTotalAmount"].Value != null)
                    {
                        TotalAmount += Convert.ToDouble(this.dgvItemData.Rows[i].Cells["clmTotalAmount"].Value);
                    }
                }


                this.txtSRNValue.Text = Math.Round(TotalAmount, 2).ToString();
                if (txtVatPrecentage.Enabled == true)
                {
                    //VAT
                    if (txtVatPrecentage.Text != "")
                    {
                        vat = (double.Parse(txtSRNValue.Text)) * (double.Parse(txtVatPrecentage.Text) / 100);
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

        public void calculatGRNAmounts()
        {
            try
            {
                double qty = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmQuantity"].Value);
                double UnitPrice = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmUnitPrice"].Value);
                double tax = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTaxAmount"].Value);
                Value = (UnitPrice * qty);
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmValue"].Value = Math.Round(Value, 2);

                if ((this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTax_chk"].Value != null) && this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTax_chk"].Value.ToString().Equals("True"))
                {
                    this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTotalAmount"].Value = Math.Round(Value + tax, 2);
                }
                else
                {
                    this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmTotalAmount"].Value = Math.Round(Value, 2);
                }


                TotalAmount = 0;

                if (this.chkGRNNumber.Checked == true)
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
                        }
                        catch (Exception ex)
                        {

                        }

                    }
                }

                this.txtSRNValue.Text = Math.Round(TotalAmount, 2).ToString();
                if (txtVatPrecentage.Enabled == true)
                {
                    //VAT
                    if (txtVatPrecentage.Text != "")
                    {
                        vat = (double.Parse(txtSRNValue.Text)) * (double.Parse(txtVatPrecentage.Text) / 100);
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

        private void dgvItemData_KeyDown(object sender, KeyEventArgs e)
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
            oItemMaster = cItemMaster.GetItemData(cGlobleVariable.LocationCode, Item);
            oItemLocation = cItemLocation.GetItemLocationData(cGlobleVariable.LocationCode, this.cmbLocation["fldSubLocationCode"].ToString(), Item);

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

        #region Validate Purchase Order Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtSRNNumber.Text == "")
            {
                errSRN.SetError(txtSRNNumber, "Please Enter Goods Recieve Code");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(txtSRNNumber, "");
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

            if (cmbSupplier.SelectedIndex == -1)
            {
                errSRN.SetError(cmbSupplier, "Please Select Supplier");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(cmbSupplier, "");
            }


            if (dtpDate.Value > DateTime.Now)
            {
                errSRN.SetError(dtpDate, "Please Select Valid Date");
                isValidate = false;
            }
            else
            {
                errSRN.SetError(dtpDate, "");
            }

            return isValidate;
        }
        #endregion

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtVatPrecentage_TextChanged(object sender, EventArgs e)
        {
            if (chkGRNNumber.Checked == true)
            {
                calculatGRNAmounts();
            }
            else
            {
                calculatAmounts();
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (chkGRNNumber.Checked == true)
            {
                calculatGRNAmounts();
            }
            else
            {
                calculatAmounts();
            }
        }

        private void dgvItemData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvItemData.CurrentRow.Cells["clmTax_chk"].Value.ToString().Equals("True"))
                {
                    taxCalculate();
                    //calculatPOAmounts();
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
                oSupplierReturnNote = cSupplierReturnNote.GetSupplierReturnNoteData(cGlobleVariable.LocationCode, this.txtSRNNumber.Text);

                if (oSupplierReturnNote.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result == -5)
                    {
                        MessageBox.Show("Data Not Changed...!", "Supplier Return Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result != -1)
                    {

                        MessageBox.Show("Successfully Saved...!", "Supplier Return Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cDocumentNumber.DeleteDocumentNumber(cGlobleVariable.UniqID, DocumentCode, txtSRNNumber.Text);
                        EnableControls(false);
                        this.btnPrint.Enabled = true;
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

        #region DataGrid To DataTable
        public DataTable DataGridToDataTable(DataGridView dgv, string strSRNCode)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("fldSRNCode");
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
                    dRow["fldSRNCode"] = strSRNCode;
                    dRow["fldItemCode"] = row.Cells["clmItemCode"].Value.ToString();
                    dRow["fldUnitPrice"] = row.Cells["clmUnitPrice"].Value.ToString();
                    dRow["fldQuantity"] = row.Cells["clmQuantity"].Value.ToString();
                    dRow["fldValue"] = row.Cells["clmValue"].Value.ToString();
                    dRow["fldTaxAmount"] = row.Cells["clmTaxAmount"].Value.ToString();

                    if (this.chkGRNNumber.Checked)
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

        #region InsertUpdate Supplier Return Note Data
        private int InsertUpdateData()
        {
            oSupplierReturnNote.LocationCode = cGlobleVariable.LocationCode;
            oSupplierReturnNote.SRNCode = this.txtSRNNumber.Text;
            oSupplierReturnNote.SubLocationCode = this.cmbLocation["fldSubLocationCode"].ToString();
            oSupplierReturnNote.SupplierCode = this.cmbSupplier["fldSupplierCode"].ToString();
            oSupplierReturnNote.Date = this.dtpDate.Value;
            oSupplierReturnNote.InvoiceNo = this.txtInvoiceNo.Text;
            oSupplierReturnNote.SRNValue = Convert.ToDouble(this.txtSRNValue.Text);
            oSupplierReturnNote.VATPresentage = Convert.ToDouble(this.txtVatPrecentage.Text);
            oSupplierReturnNote.VATAmount = Convert.ToDouble(this.txtVatAmount.Text);
            oSupplierReturnNote.Discount = Convert.ToDouble(this.txtDiscount.Text);
            oSupplierReturnNote.NetAmount = Convert.ToDouble(this.txtNetAmount.Text);

            oSupplierReturnNote.GRNCode = this.txtGRNNumber.Text;

            oSupplierReturnNote.dtItemList = DataGridToDataTable(dgvItemData, oSupplierReturnNote.SRNCode);
            if (oSupplierReturnNote.dtItemList.Rows.Count == 0)
            {
                return -5;
            }
            else
            {
                return cSupplierReturnNote.InsertUpdateData(oSupplierReturnNote);
            }

        }
        #endregion

        private void btnSRNSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        public void LoadSearch()
        {
            string[] strFieldList = new string[3];
            strFieldList[0] = "fldSRNCode";
            strFieldList[1] = "fldSupplierCode";
            strFieldList[2] = "fldDate";

            string[] strHeaderList = new string[3];
            strHeaderList[0] = "Supplier Return Code";
            strHeaderList[1] = "Supplier Code";
            strHeaderList[2] = "Supplier Return Date";

            int[] iHeaderWidth = new int[3];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 100;
            iHeaderWidth[2] = 150;

            string strReturnString = "Supplier Return Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtSRNNumber.Text = cCommonMethods.BrowsData("tbl_SRNDetails", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Supplier Return Code");
            if (txtSRNNumber.Text != "")
            {
                LoadSRNDetails();
            }
        }

        #region Load SRN Details
        private void LoadSRNDetails()
        {
            dgvItemData.Rows.Clear();
            oSupplierReturnNote = cSupplierReturnNote.GetSupplierReturnNoteData(cGlobleVariable.LocationCode, this.txtSRNNumber.Text);

            cmbLocation.SetText(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, oSupplierReturnNote.SubLocationCode).SubLocationName);
            cmbSupplier.SetText(cSupplierMaster.GetSupplierData(cGlobleVariable.LocationCode, oSupplierReturnNote.SupplierCode).SupplierName);

            dtpDate.Value = oSupplierReturnNote.Date;
            txtInvoiceNo.Text = oSupplierReturnNote.InvoiceNo;
            txtSRNValue.Text = oSupplierReturnNote.SRNValue.ToString("###,###.00");
            txtGRNNumber.Text = oSupplierReturnNote.GRNCode;

            if (oSupplierReturnNote.VATPresentage != 0)
            {
                chkVat.Checked = true;
                this.txtVatPrecentage.Text = oSupplierReturnNote.VATPresentage.ToString();
                this.txtVatAmount.Text = oSupplierReturnNote.VATAmount.ToString();
            }
            this.txtDiscount.Text = oSupplierReturnNote.Discount.ToString();
            this.txtNetAmount.Text = oSupplierReturnNote.NetAmount.ToString();



            for (int i = 0; i < oSupplierReturnNote.dtItemList.Rows.Count; i++)
            {
                this.dgvItemData.Rows.Add();
                dgvItemData.Rows[i].Cells["clmItemCode"].Value = oSupplierReturnNote.dtItemList.Rows[i]["fldItemCode"].ToString();
                dgvItemData.Rows[i].Cells["clmItemDescription"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode, oSupplierReturnNote.dtItemList.Rows[i]["fldItemCode"].ToString()).Description;
                dgvItemData.Rows[i].Cells["clmUnit"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode, oSupplierReturnNote.dtItemList.Rows[i]["fldItemCode"].ToString()).Unit;
                dgvItemData.Rows[i].Cells["clmUnitPrice"].Value = oSupplierReturnNote.dtItemList.Rows[i]["fldUnitPrice"].ToString();
                dgvItemData.Rows[i].Cells["clmQuantity"].Value = oSupplierReturnNote.dtItemList.Rows[i]["fldQuantity"].ToString();

                double a = Convert.ToDouble(oSupplierReturnNote.dtItemList.Rows[i]["fldTaxAmount"].ToString());
                if (a > 0)
                {
                    dgvItemData.Rows[i].Cells["clmTax_chk"].Value = true;
                }

                dgvItemData.Rows[i].Cells["clmTaxAmount"].Value = oSupplierReturnNote.dtItemList.Rows[i]["fldTaxAmount"].ToString();

                double qty = Convert.ToDouble(oSupplierReturnNote.dtItemList.Rows[i]["fldQuantity"]);
                double UnitPrice = Convert.ToDouble(oSupplierReturnNote.dtItemList.Rows[i]["fldUnitPrice"]);
                dgvItemData.Rows[i].Cells["clmValue"].Value = qty * UnitPrice;
                double TaxAmount = Convert.ToDouble(oSupplierReturnNote.dtItemList.Rows[i]["fldTaxAmount"]);
                dgvItemData.Rows[i].Cells["clmTotalAmount"].Value = ((qty * UnitPrice) + TaxAmount);
            }

            EnableControls(false);
            this.btnPrint.Enabled = true;
            this.chkGRNNumber.Enabled = false;
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region From Move
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }
        #endregion
    }
}
