using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.Forms
{
    public partial class frmMenuDetails : Form
    {
        #region Variable
        Point lastClick;
        #endregion

        #region Objects

        #endregion
        public frmMenuDetails()
        {
            InitializeComponent();
        }

        private void btBackColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorBacground.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                btnSample.BackColor = colorBacground.Color;
            }
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorForground.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                btnSample.ForeColor = colorForground.Color;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmMenuDetails_Load(object sender, EventArgs e)
        {

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

    }
}
