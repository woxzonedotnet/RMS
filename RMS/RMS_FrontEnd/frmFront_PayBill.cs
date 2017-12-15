using RMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using BusinessLogic;
using System.Text.RegularExpressions;

namespace RMS_FrontEnd
{
    public partial class frmFront_PayBill : Form
    {
        #region Variable
        Control ctrl;
        #endregion

        #region Objects
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        objBankDetails oBankDetails = new objBankDetails();
        clsBankDetails cBankDetails = new clsBankDetails();
        objBankCardType oBankCardType = new objBankCardType();
        clsBankCardType cBankCardType = new clsBankCardType();
        objFrontPayBill oFrontPayBill = new objFrontPayBill();
        #endregion
        public frmFront_PayBill()
        {
            InitializeComponent();
        }

        public frmFront_PayBill(Control control)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ctrl = control;
            this.txtHeadTotal.Text = ctrl.Text;
            this.txtHeadBalance.Text = "-"+ctrl.Text;
        }

        private void frmFront_PayBill_Load(object sender, EventArgs e)
        {
            DataTable banks = cBankDetails.GetBankData();
            cmbCardBank.DataSource = banks;
            cmbCardBank.DisplayMember = "fldBankName";
            cmbChequeBank.DataSource = banks;
            cmbChequeBank.DisplayMember = "fldBankName";

            DataTable cardType = cBankCardType.GetBankCardType();
            cmbCardType.DataSource = cardType;
            cmbCardType.DisplayMember = "fldCardTypeName";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void txtCashPayment_DoubleClick(object sender, EventArgs e)
        {
            frmFront_Calculator Calculator = new frmFront_Calculator(this.txtCashPayment);
            Calculator.ShowDialog();
        }

        private void txtChequePayment_DoubleClick(object sender, EventArgs e)
        {
            frmFront_Calculator Calculator = new frmFront_Calculator(this.txtChequePayment);
            Calculator.ShowDialog();
        }

        private void txtCardPayment_DoubleClick(object sender, EventArgs e)
        {
            frmFront_Calculator Calculator = new frmFront_Calculator(this.txtCardPayment);
            Calculator.ShowDialog();
        }

        private void txtCardNumber_DoubleClick(object sender, EventArgs e)
        {
            frmFront_Calculator Calculator = new frmFront_Calculator(this.txtCardNumber);
            Calculator.ShowDialog();
        }

        private void txtChequeNumber_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void txtCashBalance_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void billCalculation()
        {
            //if (dgvPayMethod.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dgvPayMethod.Rows.Count; i++)
            //    {
            //        if (dgvPayMethod.Rows[i].Cells["clmType"].Value == "Cash")
            //        {
            //            txtCashPayment.Text = dgvPayMethod.Rows[i].Cells["clmAmount"].Value.ToString();
            //            CashEnable(false);
            //        }
            //        else if (dgvPayMethod.Rows[i].Cells["clmType"].Value == "Card")
            //        {
            //            txtCardPayment.Text = dgvPayMethod.Rows[i].Cells["clmAmount"].Value.ToString();
            //            CardEnable(false);
            //        }
            //        else if (dgvPayMethod.Rows[i].Cells["clmType"].Value == "Cheque")
            //        {
            //            txtChequePayment.Text = dgvPayMethod.Rows[i].Cells["clmAmount"].Value.ToString();
            //            ChequeEnable(false);
            //        }
            //    }
            //}
        }
        private void txtHeadBalance_TextChanged(object sender, EventArgs e)
                {
                    double balance = Convert.ToDouble(txtHeadBalance.Text);
                    if (balance >= 0)
                    {
                        //Green
                        txtHeadBalance.ForeColor = Color.FromArgb(77, 130, 0);
                        btnComplete.Enabled = true;
                        lblHeadBalance.Text = "Balance Amount";
                    }
                    else
                    {
                        //Red
                        txtHeadBalance.ForeColor = Color.FromArgb(225, 18, 2);
                        btnComplete.Enabled = false;
                        lblHeadBalance.Text = "Available Amount";
                    }
                }

        #region Cash
        public void CashEnable(bool value)
        {
            txtCashPayment.Enabled = value;
            btnCashPay.Enabled = value;
        }

        private void btnCashPay_Click(object sender, EventArgs e)
        {
            if (txtCashPayment.Text != "0.00" && txtCashPayment.Text != null && btnCashPay.Enabled == true)
            {
                oFrontPayBill.CashAmount = Convert.ToDouble(txtCashPayment.Text);
                dgvPayMethod.Rows.Add("Cash", oFrontPayBill.CashAmount);
                txtHeadBalance.Text = txtCashBalance.Text;
                CashEnable(false);
            }
            else
            {
                MessageBox.Show("Please Enter the Amount!");
            }
            if (Convert.ToDouble(txtCashBalance.Text) >= 0)
            {
                CardEnable(false);
                ChequeEnable(false);
            }
            else
            {
                CardEnable(true);
                ChequeEnable(true);
            }

        }

        private void txtCashPayment_TextChanged(object sender, EventArgs e)
        {
            double available = Convert.ToDouble(txtHeadBalance.Text);
            double cash = Convert.ToDouble(txtCashPayment.Text);
            txtCashBalance.Text = (available + cash).ToString();
        }


        #endregion

        #region Card
        public void CardEnable(bool value)
        {
            txtCardPayment.Enabled = value;
            cmbCardBank.Enabled = value;
            cmbCardType.Enabled = value;
            txtCardNumber.Enabled = value;
            btnCardPay.Enabled = value;
        }

        private void txtCardPayment_TextChanged(object sender, EventArgs e)
        {
            double available = Convert.ToDouble(txtHeadBalance.Text);
            double cash = Convert.ToDouble(txtCardPayment.Text);
            txtCardBalance.Text = (available + cash).ToString();
        }

        private void btnCardPay_Click(object sender, EventArgs e)
        {
            if (cmbCardBank.SelectedValue != null && cmbCardType.SelectedValue != null && txtCardNumber.Text != "")
            {
                if (txtCardPayment.Text != "0.00" && txtCardPayment.Text != null && btnCardPay.Enabled == true)
                {
                    oFrontPayBill.CardBank = cmbCardBank.SelectedValue.ToString();
                    oFrontPayBill.CardType = cmbCardType.SelectedValue.ToString();
                    oFrontPayBill.CardNumber = txtCardNumber.Text;
                    oFrontPayBill.CardAmount = Convert.ToDouble(txtCardPayment.Text);
                    dgvPayMethod.Rows.Add("Card", oFrontPayBill.CardAmount);
                    txtHeadBalance.Text = txtCardBalance.Text;
                    CardEnable(false);
                }
                else
                {
                    MessageBox.Show("Please Enter the Amount!");
                }
            }
            else
            {
                MessageBox.Show("Please Fill the Card Details");
            }
            if (Convert.ToDouble(txtCardBalance.Text) >= 0)
            {
                CashEnable(false);
                ChequeEnable(false);
            }
            else
            {
                CashEnable(true);
                ChequeEnable(true);
            }
        }

        private void txtCardNumber_Validated(object sender, EventArgs e)
        {
            string number = Regex.Match(txtCardNumber.Text, @"\d+").Value;
            if (number.Length == 15)
            {
                txtCardNumber.Text = number.Substring(0, 4) + "-" + number.Substring(4, 6) + "-" + number.Substring(9, 5);
            }
            else
            {
                var numberParts = SplitIntoParts(number, 4);
                txtCardNumber.Text = string.Join("-", numberParts);
            }

            if (!ValidateCreditCard(txtCardNumber.Text))
            {
                txtCardNumber.Clear();
                MessageBox.Show(null, "Invalid Card Number!", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txtCardPayment.Text=((-1) * Convert.ToDouble(txtHeadBalance.Text)).ToString();
            }
        }

        public static List<string> SplitIntoParts(string s, int partLength)
        {
            var list = new List<string>();

            if (!string.IsNullOrEmpty(s) && partLength > 0)
            {
                for (var i = 0; i < s.Length; i += partLength)
                {
                    list.Add(s.Substring(i, Math.Min(partLength, s.Length - i)));
                }
            }

            return list;
        }
        public bool ValidateCreditCard(string creditCardNumber)
        {
            //Strip any non-numeric values
            creditCardNumber = Regex.Replace(creditCardNumber, @"[^\d]", "");

            //Build your Regular Expression
            Regex expression = new Regex(@"^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$");

            //Return if it was a match or not
            return expression.IsMatch(creditCardNumber);
        }

        #endregion

        #region Cheque
        public void ChequeEnable(bool value)
        {
            cmbChequeBank.Enabled = value;
            txtChequeNumber.Enabled = value;
            dtChequeDate.Enabled = value;
            txtChequePayment.Enabled = value;
            btnChequePay.Enabled = value;
        }

        private void txtChequePayment_TextChanged(object sender, EventArgs e)
        {
            double available = Convert.ToDouble(txtHeadBalance.Text);
            double cash = Convert.ToDouble(txtChequePayment.Text);
            txtChequeBalance.Text = (available + cash).ToString();
        }

        private void btnChequePay_Click(object sender, EventArgs e)
        {
            if (cmbChequeBank.SelectedValue != null && txtChequeNumber.Text != "" && dtChequeDate.Value != null)
            {
                if (txtChequePayment.Text != "0.00" && txtChequePayment.Text != null && btnChequePay.Enabled == true)
                {
                    oFrontPayBill.ChequeBank = cmbChequeBank.SelectedValue.ToString();
                    oFrontPayBill.ChequeNumber = txtChequeNumber.Text;
                    oFrontPayBill.ChequeDate = dtChequeDate.Value;
                    oFrontPayBill.ChequeAmount = Convert.ToDouble(txtChequePayment.Text);
                    dgvPayMethod.Rows.Add("Cheque", oFrontPayBill.ChequeAmount);
                    txtHeadBalance.Text = txtChequeBalance.Text;
                    ChequeEnable(false);
                }
                else
                {
                    MessageBox.Show("Please Enter the Amount!");
                }
            }
            else
            {
                MessageBox.Show("Please Fill the Cheque Details");
            }
            if (Convert.ToDouble(txtChequeBalance.Text) >= 0)
            {
                CashEnable(false);
                CardEnable(false);
            }
            else
            {
                CashEnable(true);
                CardEnable(true);
            }
        }

        private void txtChequeNumber_Validated(object sender, EventArgs e)
        {
            txtChequePayment.Text = ((-1) * Convert.ToDouble(txtHeadBalance.Text)).ToString();
        }
        #endregion

        private void tbTableCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbTableCat.SelectedTab.Name == "tbCash" && btnCashPay.Enabled == true)
            {
                txtCashPayment.Text = "0.00";
            }
            else if (tbTableCat.SelectedTab.Name == "tbCheque" && btnChequePay.Enabled == true)
            {
                txtChequePayment.Text = "0.00";
            }
            else if (tbTableCat.SelectedTab.Name == "tbCreditCard" && btnCardPay.Enabled == true)
            {
                txtCardPayment.Text = "0.00";
            }
        }

        private void dgvPayMethod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPayMethod.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0 && dgvPayMethod.Columns[e.ColumnIndex].Name == "clmStatus")
            {
                string type = dgvPayMethod.Rows[e.RowIndex].Cells["clmType"].Value.ToString();
                double amount = Convert.ToDouble(dgvPayMethod.Rows[e.RowIndex].Cells["clmAmount"].Value.ToString());
                dgvPayMethod.Rows.RemoveAt(e.RowIndex);
                switch (type)
                {
                    case "Cash" :
                        CashEnable(true);
                        txtCashPayment.Text = "0.00";
                        txtCashBalance.Text = "0.00";
                        double balValue = Convert.ToDouble(txtHeadBalance.Text);
                        balValue = balValue + ((-1) * (amount));
                        txtHeadBalance.Text = balValue.ToString();
                        break;

                    case "Card":
                        CardEnable(true);
                        cmbCardBank.Text = "";
                        cmbCardType.Text = "";
                        txtCardNumber.Text = "";
                        txtCardPayment.Text = "0.00";
                        txtCardBalance.Text = "0.00";
                        balValue = Convert.ToDouble(txtHeadBalance.Text);
                        balValue = balValue + ((-1) * (amount));
                        txtHeadBalance.Text = balValue.ToString();
                        break;

                    case "Cheque":
                        ChequeEnable(true);
                        cmbChequeBank.Text = "";
                        txtChequeNumber.Text = "";
                        dtChequeDate.Value = DateTime.Now;
                        txtChequePayment.Text = "0.00";
                        txtChequeBalance.Text = "0.00";
                        balValue = Convert.ToDouble(txtHeadBalance.Text);
                        balValue = balValue + ((-1) * (amount));
                        txtHeadBalance.Text = balValue.ToString();
                        break;
                }
            }
        }

        private void txtChequeNumber_Click(object sender, EventArgs e)
        {
            frmFront_Calculator Calculator = new frmFront_Calculator(this.txtChequeNumber);
            Calculator.ShowDialog();
        }

        

        

        

        


        

        


        

        

        

        


        
    }
}
