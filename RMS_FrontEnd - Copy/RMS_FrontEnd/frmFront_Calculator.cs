using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_FrontEnd
{
    public partial class frmFront_Calculator : Form
    {
        #region Variable
        Control ctrl;

        string value1 = "";
        string value2 = "";

        double valOne = 0;
        double valTwo = 0;

        char Operator=' ';
        #endregion
        public frmFront_Calculator()
        {
            InitializeComponent();
        }

        public frmFront_Calculator(Control contol)
        {
            InitializeComponent();
            ctrl = contol;
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            btnMul.Enabled = false;
            btnDiv.Enabled = false;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtMainValue.Text = "";
            value2 = value2 + "9";
            txtMainValue.Text = value2;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtMainValue.Text = "";
            value2 = value2 + "8";
            txtMainValue.Text = value2;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtMainValue.Text = "";
            value2 = value2 + "7";
            txtMainValue.Text = value2;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtMainValue.Text = "";
            value2 = value2 + "6";
            txtMainValue.Text = value2;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtMainValue.Text = "";
            value2 = value2 + "5";
            txtMainValue.Text = value2;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtMainValue.Text = "";
            value2 = value2 + "4";
            txtMainValue.Text = value2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtMainValue.Text = "";
            value2 = value2 + "3";
            txtMainValue.Text = value2;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtMainValue.Text = "";
            value2 = value2 + "2";
            txtMainValue.Text = value2;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtMainValue.Text = "";
            value2 = value2 + "1";
            txtMainValue.Text = value2;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtMainValue.Text = "";
            value2 = value2 + "0";
            txtMainValue.Text = value2;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtMainValue.Text = "";
            value2 = value2 + "00";
            txtMainValue.Text = value2;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtMainValue.Text = "";
            value2 = value2 + ".";
            txtMainValue.Text = value2;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if ((txtSubValue.Text != "" && txtSubValue.Text != null) && (txtMainValue.Text != "" && txtMainValue.Text != null))
            {
                string lastDigit = txtSubValue.Text.Substring(txtSubValue.Text.Length-1);
                if (lastDigit == "+" || lastDigit == "-" || lastDigit == "*" || lastDigit == "/")
                {
                    string valTemp = txtSubValue.Text.Substring(0, txtSubValue.Text.Length - 1);
                    txtSubValue.Text = valTemp + "+";
                }
                else
                {
                    txtSubValue.Text = txtSubValue.Text + txtMainValue.Text + "+";
                }
                
            }
            else
            {
                txtSubValue.Text = txtMainValue.Text + "+";
            }

            if (value2 != "" && value2 != null)
            {
                valTwo = Convert.ToDouble(value2);
                valOne = cal(valOne, valTwo, Operator);
                txtMainValue.Text = valOne.ToString();
            }
            
            
            value2 = "";
            Operator = '+';
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if ((txtSubValue.Text != "" && txtSubValue.Text != null) && (txtMainValue.Text != "" && txtMainValue.Text != null))
            {
                string lastDigit = txtSubValue.Text.Substring(txtSubValue.Text.Length - 1);
                if (lastDigit == "+" || lastDigit == "-" || lastDigit == "*" || lastDigit == "/")
                {
                    string valTemp = txtSubValue.Text.Substring(0, txtSubValue.Text.Length - 1);
                    txtSubValue.Text = valTemp + "-";
                }
                else
                {
                    txtSubValue.Text = txtSubValue.Text + txtMainValue.Text + "-";
                }

            }
            else
            {
                txtSubValue.Text = txtMainValue.Text + "-";
            }

            if (value2 != "" && value2 != null)
            {
                valTwo = Convert.ToDouble(value2);
                valOne = cal(valOne, valTwo, Operator);
                txtMainValue.Text = valOne.ToString();
            }


            value2 = "";
            Operator = '-';
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if ((txtSubValue.Text != "" && txtSubValue.Text != null) && (txtMainValue.Text != "" && txtMainValue.Text != null))
            {
                string lastDigit = txtSubValue.Text.Substring(txtSubValue.Text.Length - 1);
                if (lastDigit == "+" || lastDigit == "-" || lastDigit == "*" || lastDigit == "/")
                {
                    string valTemp = txtSubValue.Text.Substring(0, txtSubValue.Text.Length - 1);
                    txtSubValue.Text = valTemp + "*";
                }
                else
                {
                    txtSubValue.Text = txtSubValue.Text + txtMainValue.Text + "*";
                }

            }
            else
            {
                txtSubValue.Text = txtMainValue.Text + "*";
            }

            if (value2 != "" && value2 != null)
            {
                valTwo = Convert.ToDouble(value2);
                valOne = cal(valOne, valTwo, Operator);
                txtMainValue.Text = valOne.ToString();
            }


            value2 = "";
            Operator = '*';
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if ((txtSubValue.Text != "" && txtSubValue.Text != null) && (txtMainValue.Text != "" && txtMainValue.Text != null))
            {
                string lastDigit = txtSubValue.Text.Substring(txtSubValue.Text.Length - 1);
                if (lastDigit == "+" || lastDigit == "-" || lastDigit == "*" || lastDigit == "/")
                {
                    string valTemp = txtSubValue.Text.Substring(0, txtSubValue.Text.Length - 1);
                    txtSubValue.Text = valTemp + "/";
                }
                else
                {
                    txtSubValue.Text = txtSubValue.Text + txtMainValue.Text + "/";
                }

            }
            else
            {
                txtSubValue.Text = txtMainValue.Text + "/";
            }

            if (value2 != "" && value2 != null)
            {
                valTwo = Convert.ToDouble(value2);
                valOne = cal(valOne, valTwo, Operator);
                txtMainValue.Text = valOne.ToString();
            }


            value2 = "";
            Operator = '/';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if ((txtMainValue.Text != null && txtMainValue.Text != "") || (txtSubValue.Text != null && txtSubValue.Text != ""))
            {
                txtMainValue.Text = "";
                txtSubValue.Text = "";
                value2 = "";
            }
            else
            {
                this.Dispose();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (Operator != null && Operator != ' ')
            {
                if (value2 != "" && value2 != null)
                {
                    valTwo = Convert.ToDouble(value2);
                    valOne = cal(valOne, valTwo, Operator);
                    txtMainValue.Text = valOne.ToString();
                }

                txtSubValue.Text = "";
                valTwo = 0;
                valOne = 0;
                Operator = ' ';
                value2 = "";
            }
            else
            {
                ctrl.Text = txtMainValue.Text;
            }
        }

        public double cal(double valueOne,double valueTwo,char input)
        {
            double Result = 0;
            if (valueOne == 0)
            {
                Result = valueTwo;
                valueOne = valueTwo;
            }
            else
            {
                switch (input)
                {
                    case '+':
                        {
                            Result = valueOne + valueTwo;
                        }
                        break;
                    case '-':
                        {
                            Result = valueOne - valueTwo;
                        }
                        break;
                    case '*':
                        {
                            Result = valueOne * valueTwo;
                        }
                        break;
                    case '/':
                        {
                            Result = valueOne / valueTwo;
                        }
                        break;
                    default:
                        {

                        }
                        break;
                }
            }
            
            return Result;
        }
    }
}
