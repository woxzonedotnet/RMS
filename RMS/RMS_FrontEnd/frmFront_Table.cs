using BusinessLogic;
using BusinessObject;
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

namespace RMS_FrontEnd
{
    public partial class frmFront_Table : Form
    {
        #region Variable
        Control ctrl;
        #endregion

        #region Objects
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsSubLocation cSubLocation = new clsSubLocation();
        clsTableCategory cTableCategory = new clsTableCategory();
        objTableMaster oTableMaster = new objTableMaster();
        clsTableMaster cTableMaster = new clsTableMaster();
        #endregion

        public frmFront_Table()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmFront_Table(Control control)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ctrl = control;
            int screenHeight = System.Windows.Forms.SystemInformation.WorkingArea.Height;
            int screenWidth = System.Windows.Forms.SystemInformation.WorkingArea.Width;
        }

        private void frmFront_Table_Load(object sender, EventArgs e)
        {
            DataTable tableCategory = cTableCategory.GetTableCategoryData(cGlobleVariable.LocationCode);
            for (int i = 0; i < tableCategory.Rows.Count; i++)
            {
                MetroFramework.Controls.MetroTabPage tb = new MetroFramework.Controls.MetroTabPage();
                tb.Text = tableCategory.Rows[i]["fldTableCategoryName"].ToString();
                tb.Name = tableCategory.Rows[i]["fldTableCategoryCode"].ToString();
                loadTables(this,tb, tb.Name);
                tbTableCat.TabPages.Add(tb);
            }

            
        }

        public void loadTables(Control ctrlparent,Control tabPage,string tblCategoryCode)
        {
            DataTable tables = cTableMaster.GetTableMasterData(cGlobleVariable.LocationCode,tblCategoryCode);
            int x = 12;
            int y = 10;
            Point newLoc = new Point(x, y);

            for (int i = 0; i < tables.Rows.Count; i++)
            {
                Button b = new Button();
                b.Location = newLoc;
                b.Width = 180;
                b.Height = 80;
                b.FlatStyle = FlatStyle.Flat;
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                b.ForeColor = Color.White;
                b.BackColor = Color.FromArgb(250, 148, 18);
                b.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 131, 1);

                b.Name = tables.Rows[i]["fldTableCode"].ToString();
                string subLoc = cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, tables.Rows[i]["fldTableLocationCode"].ToString()).SubLocationName;
                b.Text = b.Name+"\n"+subLoc+"\n"+"Seats - "+tables.Rows[i]["fldTableSeats"].ToString();
                tabPage.Controls.Add(b);

                b.Click += delegate
                {
                    try
                    {
                        ctrl.Text = b.Name;
                        btnSelect.Enabled = true;
                    }
                    catch (Exception ex)
                    {

                    }
                };

                newLoc = new Point(x += 185, y);
            }
            //this.Height = newLoc.Y + 60;
            //pnlLayout.Height = this.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
