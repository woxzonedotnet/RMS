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
    public partial class frmIssuesNote : Form
    {

        int result = 0;

        #region Object
        objIssuesNote oIssuesNote = new objIssuesNote();
        clsIssuesNote cIssuesNote = new clsIssuesNote();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        #endregion

        #region InsertUpdate IssuesNote Data
        private int InsertUpdateData()
        {
            oIssuesNote.IssuesNumber = txtIssuesNumber.Text;
            oIssuesNote.LocationFrom = cmbLocationFrom.ToString();
            oIssuesNote.Date = dtpDate.ToString();
            oIssuesNote.Total = decimal.Parse (txtTotal.Text);


            return cIssuesNote.InsertUpdateData(oIssuesNote);
        }
        #endregion


        public frmIssuesNote()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oIssuesNote = cIssuesNote.GetissuesNoteData(txtIssuesNumber.Text);

                if (oIssuesNote.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Bank Card", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Data not Saved...!", "Bank Card", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Bank Card", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #region Clear Fields
        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtIssuesNumber.Enabled = true;
            this.cmbLocationFrom.Enabled = true;
            this.dtpDate.Enabled = false;
            this.txtTotal.Focus();
        }
        #endregion 

        #region Validate Bank Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtIssuesNumber.Text == "")
            {
                IssuesNote.SetError(txtIssuesNumber, "Please Enter Card Code");
                isValidate = false;
            }
            else
            {
                IssuesNote.SetError(txtIssuesNumber, "");

            }

            if (cmbLocationFrom.SelectedIndex == -1)
            {
                IssuesNote.SetError(cmbLocationFrom, "Please Enter Commision");
                isValidate = false;
            }
            else
            {
                IssuesNote.SetError(cmbLocationFrom, "");

            }

            if (dtpDate.Text == "")
            {
                IssuesNote.SetError(dtpDate, "Please Select Bank");
                isValidate = false;
            }
            else
            {
                IssuesNote.SetError(dtpDate, "");
            }

            if (txtTotal.Text == "")
            {
                IssuesNote.SetError(txtTotal, "Please Select Currency");
                isValidate = false;
            }
            else
            {
                IssuesNote.SetError(txtTotal, "");
            }

           
            return isValidate;
        }
        #endregion

    }
}
