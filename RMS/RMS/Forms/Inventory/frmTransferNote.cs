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
    public partial class frmTransferNote : Form
    {
        #region Object
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsSubLocation cSubLocation = new clsSubLocation();
        clsDocumentNumber cDocumentNumber = new clsDocumentNumber();
        objTransferNote oTransferNote = new objTransferNote();
        clsTransferNote cTransferNote = new clsTransferNote();
        #endregion

        #region Variables
        Point lastClick;
        string DocumentCode = "TN";
        #endregion

        public frmTransferNote()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
            LoadDocumentNumber();
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(), cmbLocationFrom, 2);
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
            oTransferNote.LocationCode = cGlobleVariable.LocationCode.ToString();
            oTransferNote.TransferNumber = this.txtTransferNumber.Text;
            oTransferNote.FromSubLocation = this.cmbLocationFrom["fldSubLocationCode"].ToString();
            oTransferNote.TransferDate = this.dtpDate.Value;
            oTransferNote.TransferValue = Convert.ToDouble(this.txtTotal.Text);
            oTransferNote.User = cGlobleVariable.User;

            oTransferNote.dtTransferNote = DataGridToDataTable(dgvItem, oTransferNote.TransferNumber);

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

            if (cmbLocationFrom.SelectedIndex < 0)
            {
                errIssue.SetError(cmbLocationFrom, "Please Select From Location");
                isValidate = false;
            }
            else
            {
                errIssue.SetError(cmbLocationFrom, "");
            }

            if (dgvItem.RowCount > -1)
            {
                errIssue.SetError(dgvItem, "Please Fill Data Grid");
                isValidate = false;
            }
            else
            {
                errIssue.SetError(dgvItem, "");
            }

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

    }
}
