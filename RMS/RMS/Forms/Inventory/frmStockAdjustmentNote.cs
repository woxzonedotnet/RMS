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
using Reports;


namespace RMS.Forms.Inventory
{
    public partial class frmStockAdjustmentNote : Form
    {
        #region Variables
        Point lastClick;
        string DocumentCode = "SA";
        string ItemCode = "";
        #endregion

        #region Objects
        clsStockAdjustmentNote cStockAdjustmentNote = new clsStockAdjustmentNote();
        objStockAdjustmentNote oStockAdjustmentNote = new objStockAdjustmentNote();
        objItemMaster oItemMaster = new objItemMaster();
        objItemLocation oItemLocation = new objItemLocation();
        clsItemMaster cItemMaster = new clsItemMaster();
        clsItemLocation cItemLocation = new clsItemLocation();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsDocumentNumber cDocumentNumber = new clsDocumentNumber();
        objDocumentNumber oDocumentNumber = new objDocumentNumber();
        clsSubLocation cSubLocation = new clsSubLocation();
        objReportMaster oReportMaster = new objReportMaster();
        clsReportMaster cReportMaster = new clsReportMaster();
        #endregion

        #region Constructor
        public frmStockAdjustmentNote()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
            clear();
            LoadDocumentNumber();
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode), cmbLocation, 2);
        }
        #endregion
        
        #region InsertUpdate SAN Data
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData()) 
            {
                calculatAmounts();
                oStockAdjustmentNote = cStockAdjustmentNote.GetStockAdjustmentNoteData(cGlobleVariable.LocationCode,this.txtSANNumber.Text);

                if (oStockAdjustmentNote.IsExists == false)
                {
                    if (InsertUpdateData() != -1)
                    {
                        cDocumentNumber.DeleteDocumentNumber(cGlobleVariable.UniqID, DocumentCode, this.txtSANNumber.Text);
                        MessageBox.Show("Successfully Saved...!", "Stock Ajustment Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnPrint.Enabled = true;
                        this.btnSave.Enabled = false;
                        //EnableControls(false);
                    }
                    else
                    {
                        MessageBox.Show("Item Data Not Saved...!", "Transfer Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Transfer Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        
        private int InsertUpdateData()
        {
            oStockAdjustmentNote.LocationCode = cGlobleVariable.LocationCode;
            oStockAdjustmentNote.SANNumber = this.txtSANNumber.Text;
            oStockAdjustmentNote.SubLocation = this.cmbLocation["fldSubLocationCode"].ToString();
            oStockAdjustmentNote.Date = this.dtpDate.Value;
            oStockAdjustmentNote.TotalCost = Convert.ToDouble(this.txtTotalCost.Text);
            oStockAdjustmentNote.User = cGlobleVariable.User;

            oStockAdjustmentNote.dtItemData = DataGridToDataTable(dgvItem, this.txtSANNumber.Text);

            return cStockAdjustmentNote.InsertUpdateData(oStockAdjustmentNote);
        }

        public DataTable DataGridToDataTable(DataGridView dgv, string strSANNo)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("fldSANNo");
            dt.Columns.Add("fldItemCode");
            dt.Columns.Add("fldPhyQty");
            dt.Columns.Add("fldSysStock");
            dt.Columns.Add("fldCost");
            dt.Columns.Add("fldTotalCost");

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                try
                {
                    dRow["fldSANNo"] = strSANNo;
                    dRow["fldItemCode"] = row.Cells["clmItemCode"].Value.ToString();
                    dRow["fldPhyQty"] = Convert.ToDouble(row.Cells["clmPhyQty"].Value);
                    dRow["fldSysStock"] = Convert.ToDouble(row.Cells["clmSysStock"].Value);
                    dRow["fldCost"] = Convert.ToDouble(row.Cells["clmCost"].Value);
                    dRow["fldTotalCost"] = Convert.ToDouble(row.Cells["clmTotalCost"].Value);
                    dt.Rows.Add(dRow);
                }
                catch (Exception ex)
                {

                }
            }
            return dt;
        }
        #endregion

        #region Validate Data
        private bool ValidateData()
        {
            bool isValidate = true;


            if (cmbLocation.SelectedIndex == -1)
            {
                errStockAdjusment.SetError(cmbLocation, "Please Select Location");
                isValidate = false;
            }
            else
            {
                errStockAdjusment.SetError(cmbLocation, "");
            }
            
            if (this.dgvItem.Rows.Count <= 1)
            {
                errStockAdjusment.SetError(dgvItem, "Please Select Location");
                isValidate = false;
            }
            else
            {
                errStockAdjusment.SetError(dgvItem, "");
            }
            return isValidate;
        }
        #endregion

        #region Clear
        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtTotalCost.Text = "0.0";
            this.btnSave.Enabled = true;
            this.btnPrint.Enabled = false;
            this.cmbLocation.Enabled = true;
            LoadDocumentNumber();
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region Form Move
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        #endregion

        #region Load Document Number
        public void LoadDocumentNumber()
        {
            this.txtSANNumber.Text = cDocumentNumber.LoadDocNumber(cGlobleVariable.UniqID, DocumentCode, cGlobleVariable.LocationCode, cCommonMethods.DateYear());
        }
        #endregion

        private void frmStockAdjustmentNote_Load(object sender, EventArgs e)
        {   
            clear();
            LoadDocumentNumber();
        }

        #region Load Item Data to Grid View
        private void dgvItem_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) && this.dgvItem.CurrentCell.OwningColumn.Name.Equals("clmItemCode"))
            {
                if (this.cmbLocation.SelectedIndex > -1)
                {
                    errStockAdjusment.SetError(cmbLocation, "");
                    this.cmbLocation.Enabled = false;
                    LoadItemDetails();
                }
                else 
                {
                    errStockAdjusment.SetError(cmbLocation,"Select Location Code");
                }
            }
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
            string strWhere = "b.fldSubLocationCode='" + this.cmbLocation["fldSubLocationCode"].ToString() + "' and b.fldItemCode=a.fldItemCode";
            ItemCode = cCommonMethods.BrowsData("tbl_ItemMaster a,tbl_ItemLocation b", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Item Details - '" + this.cmbLocation["fldSubLocationName"].ToString() + "'");
            if (ItemCode != "")
            {
                LoadLocationDetails();
            }
        }

        private void LoadLocationDetails()
        {
            oItemMaster = cItemMaster.GetItemData(cGlobleVariable.LocationCode, ItemCode);

            int isExist = 0;
            int row = 0;
            for (int i = 0; i < dgvItem.Rows.Count; i++)
            {
                if (dgvItem.Rows[i].Cells[0].Value != null && ItemCode == dgvItem.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Item already Existed.");
                    this.dgvItem.CurrentCell = this.dgvItem.Rows[i].Cells["clmPhyQty"];
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
                this.dgvItem.Rows.Add();
                this.dgvItem.Rows[this.dgvItem.CurrentCell.RowIndex - 1].Cells["clmItemCode"].Value = oItemMaster.ItemCode;
                this.dgvItem.Rows[this.dgvItem.CurrentCell.RowIndex - 1].Cells["clmDescription"].Value = oItemMaster.Description;
                this.dgvItem.Rows[this.dgvItem.CurrentCell.RowIndex - 1].Cells["clmSysStock"].Value = cItemLocation.GetItemLocationData(cGlobleVariable.LocationCode, this.cmbLocation["fldSubLocationCode"].ToString(), ItemCode).ShelfStock;
                this.dgvItem.Rows[this.dgvItem.CurrentCell.RowIndex - 1].Cells["clmCost"].Value = oItemMaster.CostPrice;
                this.dgvItem.CurrentCell = this.dgvItem.Rows[row].Cells["clmPhyQty"];
            }
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        #region Calculation
        private void dgvItem_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            calculatAmounts();
        }

        public void calculatAmounts()
        {
            try
            {
                double qty = Convert.ToDouble(this.dgvItem.Rows[this.dgvItem.CurrentCell.RowIndex].Cells["clmPhyQty"].Value);
                double price = Convert.ToDouble(this.dgvItem.Rows[this.dgvItem.CurrentCell.RowIndex].Cells["clmCost"].Value);
                double total = (qty * price);

                this.dgvItem.Rows[this.dgvItem.CurrentCell.RowIndex].Cells["clmTotalCost"].Value = total.ToString("###,###.00");

                double NetTotal = 0;
                for (int i = 0; i < dgvItem.Rows.Count; i++)
                {
                    if (this.dgvItem.Rows[i].Cells["clmTotalCost"].Value != null)
                    {
                        NetTotal += Convert.ToDouble(this.dgvItem.Rows[i].Cells["clmTotalCost"].Value);
                    }
                }

                this.txtTotalCost.Text = NetTotal.ToString("###,###.00");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Report Section
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportViewer(3);
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
                srtFormular += "{" + oReportMaster.SelectedTable + ".fldSANNo}='" + this.txtSANNumber.Text + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
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
    }
}

