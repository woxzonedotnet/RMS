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
    public partial class frmKeyBoard : Form
    {
        #region Variable
        Boolean shiftKey = false;
        Boolean capsKey = false;
        TextBox txtKeyEntry;
        #endregion
        public frmKeyBoard()
        {
            InitializeComponent();
            txtKeyEntry = txtKeyEntryIn;
        }

        public frmKeyBoard(TextBox textBoxEx)
        {
            InitializeComponent();
            txtKeyEntry = textBoxEx;
        }
        private void txtKeyEntry_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == (Keys.Control | Keys.N)) MessageBox.Show("e");
            Console.WriteLine(e.KeyCode.ToString());
        }

        private void frmKeyBoard_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtKeyEntry;
        }

        private void btnLShift_Click(object sender, EventArgs e)
        {
            if (!shiftKey)
            {
                btnLShift.BackColor = Color.FromArgb(4, 114, 210);
                btnRShift.BackColor = Color.FromArgb(4, 114, 210);
                shiftKey = true;

            }
            else
            {
                btnLShift.BackColor = Color.FromArgb(10, 178, 244);
                btnRShift.BackColor = Color.FromArgb(10, 178, 244);
                shiftKey = false;
            }
            shiftKeyChange(shiftKey);
        }

        private void shiftKeyChange(Boolean keyState)
        {
            string andSign = Convert.ToString('&');
            if (keyState)
            {
                btn1.Text = "!";
                btn2.Text = "@";
                btn3.Text = "#";
                btn4.Text = "$";
                btn5.Text = "%";
                btn6.Text = "^";
                btn7.Text = "&&";
                btn8.Text = "*";
                btn9.Text = "(";
                btn0.Text = ")";

                btnA.Text = "A";
                btnB.Text = "B";
                btnC.Text = "C";
                btnD.Text = "D";
                btnE.Text = "E";
                btnF.Text = "F";
                btnG.Text = "G";
                btnH.Text = "H";
                btnI.Text = "I";
                btnJ.Text = "J";
                btnK.Text = "K";
                btnL.Text = "L";
                btnM.Text = "M";
                btnN.Text = "N";
                btnO.Text = "O";
                btnP.Text = "P";
                btnQ.Text = "Q";
                btnR.Text = "R";
                btnS.Text = "S";
                btnT.Text = "T";
                btnU.Text = "U";
                btnV.Text = "V";
                btnW.Text = "W";
                btnX.Text = "X";
                btnY.Text = "Y";
                btnZ.Text = "Z";

                btnTilde.Text = "~";
                btnMinus.Text = "_";
                btnEqual.Text = "+";
                btnOpenBracket.Text = "{";
                btnCloseBracket.Text = "}";
                btnDoubleDot.Text = ":";
                btnColan.Text = "\"";
                btnBackSlash.Text = "|";
                btnDot.Text = "<";
                btnComma.Text = ">";
                btnForwardSlash.Text = "?";
            }
            else
            {
                btn1.Text = "1";
                btn2.Text = "2";
                btn3.Text = "3";
                btn4.Text = "4";
                btn5.Text = "5";
                btn6.Text = "6";
                btn7.Text = "7";
                btn8.Text = "8";
                btn9.Text = "9";
                btn0.Text = "0";

                btnA.Text = "a";
                btnB.Text = "b";
                btnC.Text = "c";
                btnD.Text = "d";
                btnE.Text = "e";
                btnF.Text = "f";
                btnG.Text = "g";
                btnH.Text = "h";
                btnI.Text = "i";
                btnJ.Text = "j";
                btnK.Text = "k";
                btnL.Text = "l";
                btnM.Text = "m";
                btnN.Text = "n";
                btnO.Text = "o";
                btnP.Text = "p";
                btnQ.Text = "q";
                btnR.Text = "r";
                btnS.Text = "s";
                btnT.Text = "t";
                btnU.Text = "u";
                btnV.Text = "v";
                btnW.Text = "w";
                btnX.Text = "x";
                btnY.Text = "y";
                btnZ.Text = "z";

                btnTilde.Text = "`";
                btnMinus.Text = "-";
                btnEqual.Text = "=";
                btnOpenBracket.Text = "[";
                btnCloseBracket.Text = "]";
                btnDoubleDot.Text = ";";
                btnColan.Text = "'";
                btnBackSlash.Text = @"\";
                btnDot.Text = ",";
                btnComma.Text = ".";
                btnForwardSlash.Text = "/";
            }
        }

        private void btnRShift_Click(object sender, EventArgs e)
        {
            if (!shiftKey)
            {
                btnLShift.BackColor = Color.FromArgb(4, 114, 210);
                btnRShift.BackColor = Color.FromArgb(4, 114, 210);
                shiftKey = true;

            }
            else
            {
                btnLShift.BackColor = Color.FromArgb(10, 178, 244);
                btnRShift.BackColor = Color.FromArgb(10, 178, 244);
                shiftKey = false;
            }
            shiftKeyChange(shiftKey);
        }

        private void btnCaps_Click(object sender, EventArgs e)
        {
            if (!capsKey)
            {
                btnCaps.BackColor = Color.FromArgb(4, 114, 210);
                capsKey = true;

            }
            else
            {
                btnCaps.BackColor = Color.FromArgb(10, 178, 244);
                capsKey = false;
            }
            shiftKeyChange(capsKey);
        }

        private void finalTextBuild()
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btn1.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btn2.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btn3.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btn4.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btn5.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btn6.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btn7.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btn8.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btn9.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btn0.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnQ.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnW.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnE.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnR.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnT.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnY.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnU.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnI.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnO.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnP.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnA.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnS.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnD.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnF.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnG.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnH.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnJ.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnK.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnL.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnZ.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnX.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnC.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnV.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnB.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnN.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnM.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnTilde_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnTilde.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnMinus.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnEqual.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnOpenBracket_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnOpenBracket.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnCloseBracket_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnCloseBracket.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnDoubleDot_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnDoubleDot.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnColan_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnColan.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnBackSlash_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnBackSlash.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnDot.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnComma.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnForwardSlash_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + btnForwardSlash.Text;
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + " ";
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + "    ";
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            txtKeyEntry.Text = txtKeyEntry.Text + "\n";
            txtKeyEntry.Focus();
            txtKeyEntry.DeselectAll();
            txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            try
            {
                string keyVal = txtKeyEntry.Text.Substring(0, txtKeyEntry.TextLength - 1);
                txtKeyEntry.Text = keyVal;
                txtKeyEntry.Focus();
                txtKeyEntry.DeselectAll();
                txtKeyEntry.SelectionStart = txtKeyEntry.Text.Length;
            }
            catch (Exception ex)
            {

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
