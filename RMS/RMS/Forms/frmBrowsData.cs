using BusinessLogic;
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
    public partial class frmBrowsData : Form
    {
        #region Objects
        clsBrowsData cBrowsData = new clsBrowsData();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        #endregion

        #region Variables
        private string strTable = "";
        private string[] strFieldS;
        private string[] strHeading;
        private int[] iHeaderFieldWidth;
        private string strWhere_Clause = "";
        private string strSearchFiled = "";
        private string strReturnFieldName = "";
        private DataTable dtBroesDataTable;
        Point lastClick;
        #endregion

        #region Constructors
        public frmBrowsData(DataTable dtBroesData, string strTableName, string[] strFieldList, string[] strHeadingList, int[] iHeaderWidth, string strReturnField, string header)
        {
            InitializeComponent();

            strTable = strTableName;
            strFieldS = strFieldList;
            strHeading = strHeadingList;
            iHeaderFieldWidth = iHeaderWidth;
            strReturnFieldName = strReturnField;
            dtBroesDataTable = dtBroesData;
            this.Text = header;
            SetGridSettings();
        }

        public frmBrowsData(DataTable dtBroesData, string strTableName, string[] strFieldList, string[] strHeadingList, int[] iHeaderWidth, string strReturnField, string Where_Clause, string header)
        {
            InitializeComponent();

            strTable = strTableName;
            strFieldS = strFieldList;
            strHeading = strHeadingList;
            iHeaderFieldWidth = iHeaderWidth;
            strReturnFieldName = strReturnField;
            dtBroesDataTable = dtBroesData;
            strWhere_Clause = Where_Clause;
            this.Text = header;
            SetGridSettings();
        }
        #endregion

        #region SetGridSettings
        private void SetGridSettings()
        {
            int counter = -120;
            int counter1 = -120;
            int fKey = 0;
            for (int i = 0; i < strHeading.Length; i++)
            {
                counter += 150;
                fKey++;


                string strFKey = " (F" + fKey + ")";
                RadioButton ctrlRadioButton = new RadioButton();

                ctrlRadioButton.Name = strFieldS[i].ToString();
                ctrlRadioButton.Text = strHeading[i].ToString() + strFKey;
                ctrlRadioButton.AutoSize = true;

                if (i > 2)
                {
                    counter1 += 150;
                    ctrlRadioButton.Location = new Point(counter1, 70);
                }
                else
                {
                    ctrlRadioButton.Location = new Point(counter, 50);
                }
                ctrlRadioButton.ForeColor = Color.Black;

                ctrlRadioButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ctrlRadioButton.BackColor = System.Drawing.Color.Transparent;
                ctrlRadioButton.Click += new System.EventHandler(this.ctrlRadioButton_Click);
                this.Controls.Add(ctrlRadioButton);

                dtBroesDataTable.Columns[i].ColumnName = strHeading[i];

                if (i == 0)
                {
                    ctrlRadioButton.Checked = true;
                    strSearchFiled = ctrlRadioButton.Name.ToString();
                }
            }

            dgvDataView.DataSource = dtBroesDataTable;
            dgvDataView.RowHeadersVisible = false;

            for (int i = 0; i < dtBroesDataTable.Columns.Count; i++)
            {
                dgvDataView.Columns[i].Width = iHeaderFieldWidth[i];
            }
        }
        #endregion

        #region RadioButton Click
        private void ctrlRadioButton_Click(object sender, System.EventArgs e)
        {
            RadioButton CurrentRadio = (RadioButton)sender;

            strSearchFiled = CurrentRadio.Name.ToString();
            txtSearchBox.Focus();

        }
        #endregion

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string strWhereString = "";

            if (strWhere_Clause == "")
            {
                strWhereString = strSearchFiled + " LIKE '" + txtSearchBox.Text + "%'";
            }
            else
            {
                strWhereString = strWhere_Clause + " AND " + strSearchFiled + " LIKE '" + txtSearchBox.Text + "%'";
            }

            DataTable dtBrowsData = cBrowsData.BrowsData(strTable, strFieldS, strWhereString);

            for (int i = 0; i < strHeading.Length; i++)
            {
                dtBrowsData.Columns[i].ColumnName = strHeading[i];
            }

            dgvDataView.DataSource = dtBrowsData;

            for (int i = 0; i < dtBrowsData.Columns.Count; i++)
            {
                dgvDataView.Columns[i].Width = iHeaderFieldWidth[i];
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            cGlobleVariable.BrowsDataValue = "";
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cGlobleVariable.BrowsDataValue == "")
            {
                MessageBox.Show("Please Click on grid before click Select Button.", "Search data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
        }

        private void dgvDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                cGlobleVariable.BrowsDataValue = dgvDataView.Rows[e.RowIndex].Cells[strReturnFieldName].Value.ToString();
            }
        }

        private void dgvDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                cGlobleVariable.BrowsDataValue = dgvDataView.Rows[e.RowIndex].Cells[strReturnFieldName].Value.ToString();
                this.Close();
            }
        }

        private void dgvDataView_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (System.Windows.Forms.Control ctrControl in this.Controls)
            {
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    int iFKeyStartID = ((System.Windows.Forms.RadioButton)ctrControl).Text.IndexOf("(") + 1;
                    int iLengthOfRadioTest = ((System.Windows.Forms.RadioButton)ctrControl).Text.Length - 1;
                    int fKeyLwngth = iLengthOfRadioTest - iFKeyStartID;
                    string strFKey = ((System.Windows.Forms.RadioButton)ctrControl).Text.Substring(iFKeyStartID, fKeyLwngth);

                    if (strFKey == e.KeyCode.ToString())
                    {
                        ((System.Windows.Forms.RadioButton)ctrControl).Checked = true;
                        strSearchFiled = ((System.Windows.Forms.RadioButton)ctrControl).Name.ToString();
                        txtSearchBox.Focus();
                    }
                }

            }
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
            {
                if (dgvDataView.Rows.Count > 1)
                {
                    dgvDataView.Focus();
                }
            }
        }


    }
}
