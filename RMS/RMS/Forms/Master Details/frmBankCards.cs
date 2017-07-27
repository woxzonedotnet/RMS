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

namespace RMS.Forms
{
    public partial class frmBankCards : Form
    {
        #region Object
        objBankCards oBankCards = new objBankCards();
        clsBankCards cBankCards = new clsBankCards();
        clsBankDetails cBankDetails = new clsBankDetails();
        clsBankCardType cBankCardType = new clsBankCardType();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        clsCurrencyMaster cCurrencyMaster = new clsCurrencyMaster();
        #endregion

        #region Variables
        int result;
        Point lastClick;
        #endregion

        public frmBankCards()
        {
            InitializeComponent();
            this.lblTitle.Text = this.Text;
            this.txtCardCode.Focus();
        }

        #region Validate Bank Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtCardCode.Text == "")
            {
                errBankCard.SetError(txtCardCode, "Please Enter Card Code");
                isValidate = false;
            }
            else
            {
                errBankCard.SetError(txtCardCode, "");

            }

            if (txtCommision.Text == "")
            {
                errBankCard.SetError(txtCommision, "Please Enter Commision");
                isValidate = false;
            }
            else
            {
                errBankCard.SetError(txtCommision, "");

            }

            if (cmbBankName.SelectedIndex == -1)
            {
                errBankCard.SetError(cmbBankName, "Please Select Bank");
                isValidate = false;
            }
            else
            {
                errBankCard.SetError(cmbBankName, "");
            }

            if (cmbCardType.SelectedIndex == -1)
            {
                errBankCard.SetError(cmbCardType, "Please Select Card Type");
                isValidate = false;
            }
            else
            {
                errBankCard.SetError(cmbCardType, "");
            }

            if (cmbCurrency.SelectedIndex == -1)
            {
                errBankCard.SetError(cmbCurrency, "Please Select Currency");
                isValidate = false;
            }
            else
            {
                errBankCard.SetError(cmbCurrency, "");
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                errBankCard.SetError(cmbStatus, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errBankCard.SetError(cmbStatus, "");
            }
            return isValidate;
        }
        #endregion

        #region Clear
        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtCardCode.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
            this.txtCardCode.Focus();
        }
        #endregion

        #region InsertUpdate BankCard Data
        private int InsertUpdateData()
        {
            oBankCards.CardCode = txtCardCode.Text;
            oBankCards.BankCode = cmbBankName["fldBankCode"].ToString();
            oBankCards.CardType = cmbCardType["fldCardTypeCode"].ToString();
            oBankCards.Currency = cmbCurrency["fldCurrencyCode"].ToString();
            oBankCards.Commision = Convert.ToDouble(txtCommision.Text);
            oBankCards.Status = Convert.ToInt16(cmbStatus["fldStatusCode"]);

            return cBankCards.InsertUpdateData(oBankCards);
        }
        #endregion

        #region Load Bank Cards
        private void LoadBankCards()
        {
            oBankCards = cBankCards.GetBankCardData(txtCardCode.Text);
            cmbBankName.SetText(cBankDetails.GetBankName(oBankCards.BankCode));
            cmbCardType.SetText(cBankCardType.GetBankCardTypeByCode(oBankCards.CardType));
            cmbCurrency.SetText(cCurrencyMaster.GetCurrencyByCode(oBankCards.Currency));
            txtCommision.Text = oBankCards.Commision.ToString();
            cmbStatus.SetText(cStatusMaster.GetStatusByCode(oBankCards.Status));

            this.cmbBankName.Select();
            this.txtCardCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }
        #endregion

        private void frmBankCards_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
            cCommonMethods.loadComboRMS(cBankDetails.GetBankData(), cmbBankName, 1);
            cCommonMethods.loadComboRMS(cBankCardType.GetBankCardType(), cmbCardType, 1);
            cCommonMethods.loadComboRMS(cCurrencyMaster.GetCurrencyDetails(), cmbCurrency, 1);
            clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
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

            string strReturnString = "Card Code";
            string strWhere = "fldStatus LIKE '%'";
            txtCardCode.Text = cCommonMethods.BrowsData("tbl_BankCardMaster", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Card Code");
            if (txtCardCode.Text != "")
            {
                LoadBankCards();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oBankCards = cBankCards.GetBankCardData(txtCardCode.Text);

                if (oBankCards.IsExists == false)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oBankCards = cBankCards.GetBankCardData(txtCardCode.Text);

                if (oBankCards.IsExists == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Bank Card", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Data not Update...!", "Bank Card", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void txtCardCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) 
            {
                LoadSearch();
            }
        }

        private void cmbBankName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
