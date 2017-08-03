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
using System.Management;
using BusinessObject;
using Reports;

namespace RMS.Forms.Inventory
{
    public partial class frmTransferNote : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsSubLocation cSubLocation = new clsSubLocation();
        clsDocumentNumber cDocumentNumber = new clsDocumentNumber();
        objDocumentNumber oDocumentNumber = new objDocumentNumber();
        objItemMaster oItemMaster = new objItemMaster();
        clsItemMaster cItemMaster = new clsItemMaster();
        objItemLocation oItemLocation = new objItemLocation();
        clsItemLocation cItemLocation = new clsItemLocation();
        objTransferNote oTransferNote = new objTransferNote();
        clsTransferNote cTransferNote = new clsTransferNote();
        objReportMaster oReportMaster = new objReportMaster();
        clsReportMaster cReportMaster = new clsReportMaster();
        #endregion

        #region Variables
        Point lastClick;
        string DocumentCode = "TN";
        string ItemCode = null;
        double total = 0;
        #endregion

        public frmTransferNote()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode), cmbLocationFrom, 2);
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode), cmbLocationTo, 2);
            Clear();
        }

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

        #region Validate
        private bool ValidateData() 
        {
            bool isValidate = true;

            if (txtIssuesNumber.Text == "")
            {
                errTransferNote.SetError(txtIssuesNumber, "Please Enter Issue Number");
                isValidate = false;
            }
            else
            {
                errTransferNote.SetError(txtIssuesNumber, "");
            }

            if (cmbLocationFrom.SelectedIndex < 0)
            {
                errTransferNote.SetError(cmbLocationFrom, "Please Select From Location");
                isValidate = false;
            }
            else
            {
                errTransferNote.SetError(cmbLocationFrom, "");
            }

            if (cmbLocationTo.SelectedIndex < 0)
            {
                errTransferNote.SetError(cmbLocationTo, "Please Select To Location");
                isValidate = false;
            }
            else
            {
                errTransferNote.SetError(cmbLocationTo, "");
            }


            return isValidate;
        }
        #endregion

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) && this.dgvTransferNote.CurrentCell.OwningColumn.Name.Equals("clmItemCode"))
            {
                if (ValidateData())
                {
                    if (this.cmbLocationFrom["fldSubLocationCode"].ToString() != this.cmbLocationTo["fldSubLocationCode"].ToString())
                    {
                        LoadItemDetails();
                    }
                    else 
                    {
                        MessageBox.Show("Please Select Different Location");
                    }
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
            string strWhere = "b.fldSubLocationCode='" + this.cmbLocationFrom["fldSubLocationCode"].ToString() + "' and b.fldItemCode=a.fldItemCode";
            ItemCode = cCommonMethods.BrowsData("tbl_ItemMaster a,tbl_ItemLocation b", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Item Details - '"+ this.cmbLocationTo["fldSubLocationName"].ToString()+"'");
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
            oItemLocation = cItemLocation.GetItemLocationData(cGlobleVariable.LocationCode,this.cmbLocationFrom["fldSubLocationCode"].ToString(), ItemCode);

            int isExist = 0;
            int row = 0;
            for (int i = 0; i < dgvTransferNote.Rows.Count; i++)
            {
                if (dgvTransferNote.Rows[i].Cells[0].Value != null && ItemCode == dgvTransferNote.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Item already Existed.");
                    this.dgvTransferNote.CurrentCell = this.dgvTransferNote.Rows[i].Cells["clmQuantity"];
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
                this.dgvTransferNote.Rows.Add();
                this.dgvTransferNote.Rows[this.dgvTransferNote.CurrentCell.RowIndex - 1].Cells["clmItemCode"].Value = oItemMaster.ItemCode;
                this.dgvTransferNote.Rows[this.dgvTransferNote.CurrentCell.RowIndex - 1].Cells["clmDescription"].Value = oItemMaster.Description;
                this.dgvTransferNote.Rows[this.dgvTransferNote.CurrentCell.RowIndex - 1].Cells["clmUnit"].Value = oItemLocation.ShelfStock;
                this.dgvTransferNote.Rows[this.dgvTransferNote.CurrentCell.RowIndex - 1].Cells["clmCostPrice"].Value = oItemMaster.CostPrice;
                this.dgvTransferNote.CurrentCell = this.dgvTransferNote.Rows[row].Cells["clmQuantity"];
            }
        }
        #endregion



        private void frmTransferNote_Load(object sender, EventArgs e)
        {
            LoadDocumentNumber();
        }

        public void LoadDocumentNumber() 
        {
            cDocumentNumber.LoadDocNumber(cGlobleVariable.UniqID, DocumentCode, cGlobleVariable.LocationCode, cCommonMethods.DateYear());
            oDocumentNumber = cDocumentNumber.GetDocumentNumberData(cGlobleVariable.UniqID, DocumentCode);

            if (oDocumentNumber.IsExists)
            {
                this.txtIssuesNumber.Text = oDocumentNumber.DocumentNo;
            }
            else
            {
                cDocumentNumber.DocumentNo(DocumentCode, cGlobleVariable.LocationCode, cCommonMethods.DateYear());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                calculatAmounts();
                oTransferNote = cTransferNote.GetTransferNoteData(cGlobleVariable.LocationCode, this.txtIssuesNumber.Text);

                if (oTransferNote.IsExists == false)
                {
                    if (InsertUpdateData() != -1)
                    {

                        cDocumentNumber.DeleteDocumentNumber(cGlobleVariable.UniqID, DocumentCode, this.txtIssuesNumber.Text);
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

        #region InsertUpdate TransferNote Order Data
        private int InsertUpdateData()
        {
            oTransferNote.LocationCode = cGlobleVariable.LocationCode.ToString();
            oTransferNote.IssueNumber = this.txtIssuesNumber.Text;
            oTransferNote.FromSubLocation = this.cmbLocationFrom["fldSubLocationCode"].ToString();
            oTransferNote.ToSubLocation = this.cmbLocationTo["fldSubLocationCode"].ToString();
            oTransferNote.IssueDate = this.dtpDate.Value;
            oTransferNote.IssueValue = Convert.ToDouble(this.txtTotal.Text);
            oTransferNote.User = cGlobleVariable.User;

            oTransferNote.dtTransferNote = DataGridToDataTable(dgvTransferNote, oTransferNote.IssueNumber);

            return cTransferNote.InsertUpdateData(oTransferNote);
        }
        #endregion

        public DataTable DataGridToDataTable(DataGridView dgv, string strIssueNumber)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("fldIssueNumber");
            dt.Columns.Add("fldItemCode");
            dt.Columns.Add("fldQty");
            dt.Columns.Add("fldUnitCost");
            dt.Columns.Add("fldItemTotalCost");


            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                try
                {
                    dRow["fldIssueNumber"] = strIssueNumber;
                    dRow["fldItemCode"] = row.Cells["clmItemCode"].Value.ToString();
                    dRow["fldQty"] = row.Cells["clmQuantity"].Value.ToString();
                    dRow["fldUnitCost"] = row.Cells["clmCostPrice"].Value.ToString();
                    dRow["fldItemTotalCost"] =Convert.ToDouble(row.Cells["clmValue"].Value);
                    dt.Rows.Add(dRow);
                }
                catch (Exception ex)
                {

                }
            }
            return dt;
        }


        public void EnableControls(bool Command)
        {
            bool result;
            if (Command)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            this.btnSave.Enabled = result;
            this.dgvTransferNote.Enabled = result;
            this.cmbLocationFrom.Enabled = result;
            this.cmbLocationTo.Enabled = result;
            this.dtpDate.Enabled = result;
        }

        private void Clear() 
        {
            cCommonMethods.ClearForm(this);
            this.btnPrint.Enabled = false;
            this.btnSave.Enabled = true;
            this.cmbLocationFrom.Enabled = true;
            this.cmbLocationTo.Enabled = false;
            LoadDocumentNumber();
            EnableControls(true);
            this.btnPrint.Enabled = false;
        }

        private void cmbLocationTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbLocationTo.SelectedIndex >= 0)
            {
                this.cmbLocationFrom.Enabled = false;
            }
        }

        private void cmbLocationFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbLocationFrom.SelectedIndex >= 0)
            {
                this.cmbLocationTo.Enabled = true;
            }
        }

        private void dgvTransferNote_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            calculatAmounts();
        }

        public void calculatAmounts()
        {
            try
            {
                double qty = Convert.ToDouble(this.dgvTransferNote.Rows[this.dgvTransferNote.CurrentCell.RowIndex].Cells["clmQuantity"].Value);
                double price = Convert.ToDouble(this.dgvTransferNote.Rows[this.dgvTransferNote.CurrentCell.RowIndex].Cells["clmCostPrice"].Value);
                total = (qty * price);

                this.dgvTransferNote.Rows[this.dgvTransferNote.CurrentCell.RowIndex].Cells["clmValue"].Value = total.ToString("###,###.00");

                double NetTotal = 0;
                for (int i = 0; i < dgvTransferNote.Rows.Count; i++)
                {
                    if (this.dgvTransferNote.Rows[i].Cells["clmValue"].Value != null)
                    {
                        NetTotal += Convert.ToDouble(this.dgvTransferNote.Rows[i].Cells["clmValue"].Value);
                    }
                }

                this.txtTotal.Text = NetTotal.ToString("###,###.00");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        #region Report Section
        private void ReportViewer(string strReportID, string strReportName)
        {
            System.Object[,] arrParameter;
            int iReportID = Convert.ToInt16(strReportID);


            arrParameter = new Object[(7), 2];

            //arrParameter[0, 0] = "strCompanyName";
            //arrParameter[0, 1] = cGlobleVariable.CompanyName;
            //arrParameter[1, 0] = "strAddress";
            //arrParameter[1, 1] = cGlobleVariable.Address_1 + "," + cGlobleVariable.Address_2 + "," + cGlobleVariable.Address_3;
            //arrParameter[2, 0] = "strCustomerTelFax";
            //arrParameter[2, 1] = "Tel : " + cGlobleVariable.CustomerTel + " Fax :" + cGlobleVariable.CustomerFAX;
            //arrParameter[3, 0] = "strCustomerEMAIL";
            //arrParameter[3, 1] = "E - Mail : " + cGlobleVariable.CustomerEmail;
            //arrParameter[4, 0] = "strCustomerWEB";
            //arrParameter[4, 1] = "Web : " + cGlobleVariable.CustomerWeb;
            arrParameter[5, 0] = "strCopyRight";
            arrParameter[5, 1] = cGlobleVariable.CopyRight;
            arrParameter[6, 0] = "strReportTitle";
            arrParameter[6, 1] = strReportName;

            frmReportViewer frmReportViever = new frmReportViewer(iReportID, cGlobleVariable.LocationCode, SelectionFormularValues(iReportID), arrParameter);
            frmReportViever.Show();
        }

        private string SelectionFormularValues(int iReportID)
        {
            string srtFormular = string.Empty;

            oReportMaster = cReportMaster.GetReports(iReportID);

            if (oReportMaster.SelectedTable.ToString() != string.Empty)
            {
                srtFormular += "{" + oReportMaster.SelectedTable + ".fldIssueNumber}='" + this.txtIssuesNumber.Text + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
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
