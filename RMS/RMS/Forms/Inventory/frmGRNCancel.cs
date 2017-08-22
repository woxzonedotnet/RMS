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
    public partial class frmGRNCancel : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsSubLocation cSubLocation = new clsSubLocation();
        clsSupplierMaster cSupplierMaster = new clsSupplierMaster();
        clsDocumentNumber cDocumentNumber = new clsDocumentNumber();
        objDocumentNumber oDocumentNumber = new objDocumentNumber();
        clsGoodReceiveNote cGoodReceiveNote = new clsGoodReceiveNote();
        objGoodReceiveNote oGoodReceiveNote = new objGoodReceiveNote();
        clsItemMaster cItemMaster = new clsItemMaster();
        clsItemLocation cItemLocation = new clsItemLocation();
        objReportMaster oReportMaster = new objReportMaster();
        clsReportMaster cReportMaster = new clsReportMaster();
        
        #endregion

        #region Variables
        Point lastClick;
        string DocumentCode = "CGRN";
        #endregion

        public frmGRNCancel()
        {
            InitializeComponent();
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode), cmbLocation, 2);
            cCommonMethods.loadComboRMS(cSupplierMaster.GetSupplierData(cGlobleVariable.LocationCode), cmbSupplier, 2);
            LoadDocumentNumber();
            clear();
        }

        public void LoadDocumentNumber()
        {
            this.txtGRNCancelNo.Text = cDocumentNumber.LoadDocNumber(cGlobleVariable.UniqID, DocumentCode, cGlobleVariable.LocationCode, cCommonMethods.DateYear());
        }
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

        #region Clear
        private void clear() 
        {
            cCommonMethods.ClearForm(this);
            this.txtGrossTotal.Text = "0.00";
            this.txtVatAmount.Text = "0.00";
            this.txtDiscount.Text = "0.00";
            this.txtNetAmount.Text = "0.00";
            this.btnPrint.Enabled = false;
            this.btnGRNCancel.Enabled = true;
            LoadDocumentNumber();
        }
        #endregion
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void frmGRNCancel_Load(object sender, EventArgs e)
        {
            LoadDocumentNumber();
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
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'AND fldIsCancelGRN=0";
            txtGRNNo.Text = cCommonMethods.BrowsData("tbl_GRNDetails", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Good Recieve Code");
            if (txtGRNNo.Text != "")
            {
                LoadGRNDetails();
            }
        }
        #endregion

        #region Load GRN Details
        private void LoadGRNDetails()
        {
            dgvItemData.Rows.Clear();
            oGoodReceiveNote = cGoodReceiveNote.GetGoodReceiveNoteData(cGlobleVariable.LocationCode, this.txtGRNNo.Text);

            cmbLocation.SetText(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, oGoodReceiveNote.SubLocationCode).SubLocationName);
            cmbSupplier.SetText(cSupplierMaster.GetSupplierData(cGlobleVariable.LocationCode, oGoodReceiveNote.SupplierCode).SupplierName);

            dtpDate.Value = oGoodReceiveNote.Date;
            txtInvoiceNo.Text = oGoodReceiveNote.InvoiceNo;
            txtGrossTotal.Text = oGoodReceiveNote.GRNValue.ToString("###,###.00");

            if (oGoodReceiveNote.VATPresentage != 0)
            {
                this.txtVatAmount.Text = oGoodReceiveNote.VATAmount.ToString("###,###.00");
            }
            this.txtDiscount.Text = oGoodReceiveNote.Discount.ToString("###,###.00");
            this.txtNetAmount.Text = oGoodReceiveNote.NetAmount.ToString("###,###.00");


            for (int i = 0; i < oGoodReceiveNote.dtItemList.Rows.Count; i++)
            {
                this.dgvItemData.Rows.Add();
                dgvItemData.Rows[i].Cells["clmItemCode"].Value = oGoodReceiveNote.dtItemList.Rows[i]["fldItemCode"].ToString();
                dgvItemData.Rows[i].Cells["clmDescription"].Value = cItemMaster.GetItemData(cGlobleVariable.LocationCode, oGoodReceiveNote.dtItemList.Rows[i]["fldItemCode"].ToString()).Description;
                //dgvItemData.Rows[i].Cells["clmUnit"].Value = cItemLocation.GetItemLocationData(cGlobleVariable.LocationCode, this.cmbLocation["fldSubLocationCode"].ToString(), oGoodReceiveNote.dtItemList.Rows[i]["fldItemCode"].ToString()).ShelfStock;
                dgvItemData.Rows[i].Cells["clmUnitPrice"].Value = oGoodReceiveNote.dtItemList.Rows[i]["fldUnitPrice"].ToString();
                dgvItemData.Rows[i].Cells["clmQty"].Value = oGoodReceiveNote.dtItemList.Rows[i]["fldQuantity"].ToString();



                dgvItemData.Rows[i].Cells["clmTaxAmount"].Value = oGoodReceiveNote.dtItemList.Rows[i]["fldTaxAmount"].ToString();

                double qty = Convert.ToDouble(oGoodReceiveNote.dtItemList.Rows[i]["fldQuantity"]);
                double UnitPrice = Convert.ToDouble(oGoodReceiveNote.dtItemList.Rows[i]["fldUnitPrice"]);
                //dgvItemData.Rows[i].Cells["clmValue"].Value = qty * UnitPrice;
                double TaxAmount = Convert.ToDouble(oGoodReceiveNote.dtItemList.Rows[i]["fldTaxAmount"]);
                dgvItemData.Rows[i].Cells["clmTotal"].Value = ((qty * UnitPrice) + TaxAmount);
                //calculatAmounts();
            }

            this.btnPrint.Enabled = false;
        }
        #endregion

        private void btnGRNCancel_Click(object sender, EventArgs e)
        {
            if (txtGRNNo.Text != null) 
            {
                oGoodReceiveNote = cGoodReceiveNote.GetGoodReceiveNoteData(cGlobleVariable.LocationCode, this.txtGRNNo.Text);

                if (oGoodReceiveNote.IsExists == true)
                {
                    if (InsertUpdateData()!=-1)
                    {
                        cDocumentNumber.DeleteDocumentNumber(cGlobleVariable.UniqID, DocumentCode, this.txtGRNCancelNo.Text);
                        MessageBox.Show("Successfully Saved...!", "GRN Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnGRNCancel.Enabled = false;
                        this.btnPrint.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Not Saved...!", "GRN Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #region DataGrid To DataTable
        public DataTable DataGridToDataTable(DataGridView dgv, string strGRNCode)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("fldGRNCode");
            dt.Columns.Add("fldItemCode");
            dt.Columns.Add("fldQuantity");


            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                try
                {
                    dRow["fldGRNCode"] = strGRNCode;
                    dRow["fldItemCode"] = row.Cells["clmItemCode"].Value.ToString();
                    dRow["fldQuantity"] = row.Cells["clmQty"].Value.ToString();
                    dt.Rows.Add(dRow);
                }
                catch (Exception ex){}
            }
            return dt;
        }
        #endregion

        #region InsertUpdate Good Receive Note Data
        private int InsertUpdateData()
        {
            oGoodReceiveNote.GRNCode = this.txtGRNNo.Text;
            oGoodReceiveNote.GRNCancelCode = this.txtGRNCancelNo.Text;

            oGoodReceiveNote.dtItemList = DataGridToDataTable(dgvItemData, oGoodReceiveNote.GRNCode);

            return cGoodReceiveNote.InsertUpdateGRNCancel(oGoodReceiveNote);
        }
        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportViewer(14);
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
                srtFormular += "{" + oReportMaster.SelectedTable + ".fldCancelGRNNo}='" + this.txtGRNCancelNo.Text + "'"; // +"' AND {tbl_daily_in_out_details.fldAttendanceDate}=#" + Convert.ToDateTime(dFromDate).ToString("yyyy-MM-dd") + "# TO #" + Convert.ToDateTime(dToDate).ToString("yyyy-MM-dd") + "# ";
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
