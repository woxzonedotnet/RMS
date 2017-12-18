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
using RMS;

namespace RMS_FrontEnd
{
    public partial class frmFront_Steward : Form
    {
        #region Variable
        Control ctrl;
        #endregion

        #region Objects
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        objSteward oSteward = new objSteward();
        clsSteward cSteward = new clsSteward();
        #endregion
        public frmFront_Steward()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frmFront_Steward(Control control)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ctrl = control;
            int screenHeight = System.Windows.Forms.SystemInformation.WorkingArea.Height;
            int screenWidth = System.Windows.Forms.SystemInformation.WorkingArea.Width;
        }

        private void frmSteward_Load(object sender, EventArgs e)
        {
            DataTable  stewards = cSteward.GetStewardData(cGlobleVariable.LocationCode);
            int x = 5;
            int y = 5;
            int noOfStewards = stewards.Rows.Count;
            int stewardCount = 0;
            Point newLoc = new Point(x, y);
            //Panel pnlLayout = new Panel();
            //pnlLayout.Location = new Point(0, 0);
            //pnlLayout.Width = this.Width;
            //pnlLayout.Height = this.Height;
            //pnlLayout.BackColor = Color.White;
            //this.Controls.Add(pnlLayout);

            for (int j = 0; j < (noOfStewards / 3); j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Button b = new Button();
                    b.Location = newLoc;
                    b.Width = 160;
                    b.Height = 47;
                    b.FlatStyle = FlatStyle.Flat;
                    b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                    b.ForeColor = Color.White;
                    b.BackColor = Color.FromArgb(250, 148, 18);
                    b.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 131, 1);

                    b.Name = stewards.Rows[stewardCount]["fldStewardCode"].ToString();
                    b.Text = stewards.Rows[stewardCount]["fldStewardName"].ToString();
                    pnlStewardList.Controls.Add(b);

                    stewardCount++;

                    b.Click += delegate
                    {
                        try
                        {
                            ctrl.Text = b.Name;
                            //this.Dispose();
                        }
                        catch (Exception ex)
                        {

                        }
                    };

                    newLoc = new Point(x+=170, y);
                }

                newLoc = new Point(x=5, y += 50);
            }

                

                //for (int i = 0; i < stewards.Rows.Count; i++)
                //{
                //    Button b = new Button();
                //    b.Location = newLoc;
                //    b.Width = 160;
                //    b.Height = 47;
                //    b.FlatStyle = FlatStyle.Flat;
                //    b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                //    b.ForeColor = Color.White;
                //    b.BackColor = Color.FromArgb(250, 148, 18);
                //    b.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 131, 1);

                //    b.Name = stewards.Rows[i]["fldStewardCode"].ToString();
                //    b.Text = stewards.Rows[i]["fldStewardName"].ToString();
                //    pnlStewardList.Controls.Add(b);

                //    b.Click += delegate
                //    {
                //        try
                //        {
                //            ctrl.Text = b.Name;
                //            this.Dispose();
                //        }
                //        catch (Exception ex)
                //        {

                //        }
                //    };

                //    newLoc = new Point(x, y += 50);
                //}
            //this.Height = newLoc.Y + 60;
            //pnlStewardList.Height = this.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
