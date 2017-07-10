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

namespace RMS.Forms
{
    public partial class frmTableCategoryDetails : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        objTableCategory oTableCategory = new objTableCategory();
        clsTableCategory cTableCategory = new clsTableCategory();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        #endregion

        #region Variable
        int result = -1;
        Point lastClick;
        #endregion

        public frmTableCategoryDetails()
        {
            InitializeComponent();
            this.lblTableCategoryTitle.Text = this.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oTableCategory = cTableCategory.GetTableCategoryData(cGlobleVariable.LocationCode, this.txtTableCategoryCode.Text);

                if (oTableCategory.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Table Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Table Category Data Not Saved...!", "Table Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Table Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtTableCategoryCode.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
        }

        public bool ValidateData() 
        {
            bool isValidate = true;

            if (txtTableCategoryCode.Text == "")
            {
                errTableCategory.SetError(txtTableCategoryCode, "Please Enter Table Category Code");
                isValidate = false;
            }
            else
            {
                errTableCategory.SetError(txtTableCategoryCode, "");

            }

            if (txtTableCategoryName.Text == "")
            {
                errTableCategory.SetError(txtTableCategoryName, "Please Enter Description");
                isValidate = false;
            }
            else
            {
                errTableCategory.SetError(txtTableCategoryName, "");
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                errTableCategory.SetError(cmbStatus, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errTableCategory.SetError(cmbStatus, "");
            }

            return isValidate;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        #region InsertUpdate Department Data
        private int InsertUpdateData()
        {
            oTableCategory.LocationCode = cGlobleVariable.LocationCode.ToString();
            oTableCategory.TableCategoryCode = this.txtTableCategoryCode.Text;
            oTableCategory.TableCategoryName = this.txtTableCategoryName.Text;
            oTableCategory.Status = Convert.ToInt16(cmbStatus["fldStatusCode"]);

            return cTableCategory.InsertUpdateData(oTableCategory);
        }
        #endregion

        private void frmTableCategoryDetails_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
            this.btnUpdate.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }


        public void LoadSearch() 
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "fldTableCategoryCode";
            strFieldList[1] = "fldTableCategoryName";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Table Category Code";
            strHeaderList[1] = "Table Category Name";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 320;

            string strReturnString = "Table Category Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtTableCategoryCode.Text = cCommonMethods.BrowsData("tbl_TableCategoryMaster", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Table Category");
            if (txtTableCategoryCode.Text != "")
            {
                LoadTableCategory();
            }
        }

        public void LoadTableCategory() 
        {
            oTableCategory = cTableCategory.GetTableCategoryData(cGlobleVariable.LocationCode, this.txtTableCategoryCode.Text);

            txtTableCategoryName.Text = oTableCategory.TableCategoryName;


            cmbStatus.SetText(cStatusMaster.GetStatusByCode(oTableCategory.Status));

            this.txtTableCategoryName.Select();
            this.txtTableCategoryCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oTableCategory = cTableCategory.GetTableCategoryData(cGlobleVariable.LocationCode, this.txtTableCategoryCode.Text);

                if (oTableCategory.IsExists == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Table Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Table Category Data Not Update...!", "Table Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void txtTableCategoryCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).SelectionStart == 0)
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
                LoadSearch();
            }
        }
    }
}
