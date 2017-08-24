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
    public partial class frmTransferNote : Form
    {
        #region Object
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsSubLocation cSubLocation = new clsSubLocation();
        clsDocumentNumber cDocumentNumber = new clsDocumentNumber();
        objTransferNote oTransferNote = new objTransferNote();
        clsTransferNote cTransferNote = new clsTransferNote();
        clsItemMaster cItemMaster = new clsItemMaster();
        objItemMaster oItemMaster = new objItemMaster();
        objReportMaster oReportMaster = new objReportMaster();
        clsReportMaster cReportMaster = new clsReportMaster();
        #endregion

        #region Variables
        Point lastClick;
        string DocumentCode = "TN";
        string ItemCode = null;
        double total=0;
        #endregion

        public frmTransferNote()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
            LoadDocumentNumber();
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(), cmbLocation, 2);
        }

        public void LoadDocumentNumber()
        {
            this.txtTransferNumber.Text = cDocumentNumber.LoadDocNumber(cGlobleVariable.UniqID, DocumentCode, cGlobleVariable.LocationCode, cCommonMethods.DateYear());
        }

        #region Insert Data To Database
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                //calculatAmounts();
                oTransferNote = cTransferNote.GetTransferNoteData(cGlobleVariable.LocationCode, this.txtTransferNumber.Text);
                
                if (oTransferNote.IsExists == false)
                {
                    if (InsertUpdateData() != -1)
                    {

                        cDocumentNumber.DeleteDocumentNumber(cGlobleVariable.UniqID, DocumentCode, this.txtTransferNumber.Text);
                        MessageBox.Show("Successfully Saved...!", "Transfer Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnPrint.Enabled = true;
                        EnableControls(false);
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
            oTransferNote.LocationCode = cGlobleVariable.LocationCode.ToString();
            oTransferNote.TransferNumber = this.txtTransferNumber.Text;
            oTransferNote.FromSubLocation = this.cmbLocation["fldSubLocationCode"].ToString();
            oTransferNote.TransferDate = this.dtpDate.Value;
            oTransferNote.TransferValue = Convert.ToDouble(this.txtTotal.Text);
            oTransferNote.User = cGlobleVariable.User;

            oTransferNote.dtTransferNote = DataGridToDataTable(dgvItemData, oTransferNote.TransferNumber);

            return cTransferNote.InsertUpdateData(oTransferNote);
        }

        public DataTable DataGridToDataTable(DataGridView dgv, string strTransferNumber)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("fldTransferNumber");
            dt.Columns.Add("fldItemCode");
            dt.Columns.Add("fldQty");
            dt.Columns.Add("fldUnitCost");
            dt.Columns.Add("fldItemTotalCost");


            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                try
                {
                    dRow["fldTransferNumber"] = strTransferNumber;
                    dRow["fldItemCode"] = row.Cells["clmItemCode"].Value.ToString();
                    dRow["fldQty"] = row.Cells["clmQuantity"].Value.ToString();
                    dRow["fldUnitCost"] = row.Cells["clmCostPrice"].Value.ToString();
                    dRow["fldItemTotalCost"] = Convert.ToDouble(row.Cells["clmValue"].Value);
                    dt.Rows.Add(dRow);
                }
                catch (Exception ex){}
            }
            return dt;
        }
        #endregion

        #region Validate Form Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtTransferNumber.Text == "")
            {
                errIssue.SetError(txtTransferNumber, "Please Enter Transfer Number");
                isValidate = false;
            }
            else
            {
                errIssue.SetError(txtTransferNumber, "");
            }

            if (cmbLocation.SelectedIndex < 0)
            {
                errIssue.SetError(cmbLocation, "Please Select From Location");
                isValidate = false;
            }
            else
            {
                errIssue.SetError(cmbLocation, "");
            }

            //if (dgvItemData.RowCount > -1)
            //{
            //    errIssue.SetError(dgvItemData, "Please Fill Data Grid");
            //    isValidate = false;
            //}
            //else
            //{
            //    errIssue.SetError(dgvItemData, "");
            //}

            return isValidate;
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region Form Move
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        public void LoadSearch()
        {
            string[] strFieldList = new string[3];
            strFieldList[0] = "fldTransferNumber";
            strFieldList[1] = "fldFromLocationCode";
            strFieldList[2] = "fldTransferDate";

            string[] strHeaderList = new string[3];
            strHeaderList[0] = "Transfer Code";
            strHeaderList[1] = "Location Code";
            strHeaderList[2] = "Transfer Date";

            int[] iHeaderWidth = new int[3];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 100;
            iHeaderWidth[2] = 150;

            string strReturnString = "Transfer Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtTransferNumber.Text = cCommonMethods.BrowsData("tbl_TransferHeader", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Transfer");
            if (txtTransferNumber.Text != "")
            {
                LoadTransferDetails();
            }
        }

        #region Load Transfer Details
        private void LoadTransferDetails()
        {
            dgvItemData.Rows.Clear();
            oTransferNote = cTransferNote.GetTransferNoteData(cGlobleVariable.LocationCode, this.txtTransferNumber.Text);

            cmbLocation.SetText(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, oTransferNote.FromSubLocation).SubLocationName);
            dtpDate.Value = oTransferNote.TransferDate;
            txtTotal.Text = oTransferNote.TransferValue.ToString("###,###.00");


            for (int i = 0; i < oTransferNote.dtTransferNote.Rows.Count; i++)
            {
                this.dgvItemData.Rows.Add();
                dgvItemData.Rows[i].Cells["clmItemCode"].Value = oTransferNote.dtTransferNote.Rows[i]["fldItemCode"].ToString();
                dgvItemData.Rows[i].Cells["clmDescription"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode, oTransferNote.dtTransferNote.Rows[i]["fldItemCode"].ToString()).Description;
                dgvItemData.Rows[i].Cells["clmUnit"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode, oTransferNote.dtTransferNote.Rows[i]["fldItemCode"].ToString()).Unit;

                dgvItemData.Rows[i].Cells["clmCostPrice"].Value = oTransferNote.dtTransferNote.Rows[i]["fldUnitCost"].ToString();
                dgvItemData.Rows[i].Cells["clmQuantity"].Value = oTransferNote.dtTransferNote.Rows[i]["fldQty"].ToString();

                double qty = Convert.ToDouble(oTransferNote.dtTransferNote.Rows[i]["fldQty"]);
                double UnitPrice = Convert.ToDouble(oTransferNote.dtTransferNote.Rows[i]["fldUnitCost"]);
                dgvItemData.Rows[i].Cells["clmValue"].Value = ((qty * UnitPrice));
                calculatAmounts();
            }

            EnableControls(false);
            this.btnPrint.Enabled = true;
        }
        #endregion

        private void frmTransferNote_Load(object sender, EventArgs e)
        {
            LoadDocumentNumber();
            Clear();
        }

        #region Clear Data
        private void Clear()
        {
            cCommonMethods.ClearForm(this);
            EnableControls(true);
            this.btnPrint.Enabled = false;
            this.btnSave.Enabled = true;
            this.cmbLocation.Enabled = true;
            LoadDocumentNumber();
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvItemData_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) && this.dgvItemData.CurrentCell.OwningColumn.Name.Equals("clmItemCode"))
            {
                if (ValidateData())
                {
                        LoadItemDetails();
                }
            }
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
            ItemCode = cCommonMethods.BrowsData("tbl_ItemMaster a,tbl_ItemLocation b", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Item Details");
            if (ItemCode != "")
            {
                LoadLocationDetails();
            }
        }
        #endregion

        #region Load Item Details
        private void LoadLocationDetails()
        {
            oItemMaster = cItemMaster.GetItemData(cGlobleVariable.LocationCode, ItemCode);

            int isExist = 0;
            int row = 0;
            for (int i = 0; i < dgvItemData.Rows.Count; i++)
            {
                if (dgvItemData.Rows[i].Cells["clmItemCode"].Value != null && ItemCode == dgvItemData.Rows[i].Cells["clmItemCode"].Value.ToString())
                {
                    MessageBox.Show("Item already Existed.");
                    this.dgvItemData.CurrentCell = this.dgvItemData.Rows[i].Cells["clmQuantity"];
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
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmDescription"].Value = oItemMaster.Description;
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmUnit"].Value = oItemMaster.Unit;
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmCostPrice"].Value = oItemMaster.CostPrice;
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmQuantity"].Value = "0.00";
                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex - 1].Cells["clmValue"].Value = "0.00";
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
                double price = Convert.ToDouble(this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmCostPrice"].Value);
                total = (qty * price);

                this.dgvItemData.Rows[this.dgvItemData.CurrentCell.RowIndex].Cells["clmValue"].Value = total.ToString("###,###.00");

                double NetTotal = 0;
                for (int i = 0; i < dgvItemData.Rows.Count; i++)
                {
                    if (this.dgvItemData.Rows[i].Cells["clmValue"].Value != null)
                    {
                        NetTotal += Convert.ToDouble(this.dgvItemData.Rows[i].Cells["clmValue"].Value);
                    }
                }

                this.txtTotal.Text = NetTotal.ToString("###,###.00");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        public void EnableControls(bool Command)
        {
            bool result;
            if (Command)
            {
                result = true;
                this.txtTotal.ReadOnly = false;
                this.txtTransferNumber.ReadOnly = false;
            }
            else
            {
                result = false;
                this.txtTotal.ReadOnly = true;
                this.txtTransferNumber.ReadOnly = true;
            }

            this.btnSave.Enabled = result;
            this.dgvItemData.Enabled = result;
            this.cmbLocation.Enabled = result;
            this.dtpDate.Enabled = result;
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportViewer(15);
        }

        private void ReportViewer(int strReportID)
        {
            System.Object[,] arrParameter;
            oReportMaster = cReportMaster.GetReports(strReportID);

            arrParameter = new Object[(3), 2];

            arrParameter[0, 0] = "strCopyRight";
            arrParameter[0, 1] = cGlobleVariable.CopyRight;
            arrParameter[1, 0] = "strReportTitle";
            arrParameter[1, 1] = oReportMaster.ReportTitle;
            arrParameter[2, 0] = "strFromLocation";
            arrParameter[2, 1] = this.cmbLocation["fldSubLocationName"];
           

            frmReportViewer frmReportViever = new frmReportViewer(strReportID, cGlobleVariable.LocationCode, SelectionFormularValues(strReportID), arrParameter);
            frmReportViever.Show();
        }

          private string SelectionFormularValues(int iReportID)
        {
            string srtFormular = string.Empty;

            if (oReportMaster.SelectedTable.ToString() != string.Empty)
            {
                srtFormular += "{" + oReportMaster.SelectedTable + ".fldTransferNumber}='" + this.txtTransferNumber.Text + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
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
       

    }
}
