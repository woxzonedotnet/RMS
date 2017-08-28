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

namespace RMS.Forms.Security
{
    public partial class frmUserLevel : Form
    {
        #region Objects
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        clsDocumentNumber cDocumentNumber = new clsDocumentNumber();
        objDocumentNumber oDocumentNumber = new objDocumentNumber();
        objUserLevel oUserLevel = new objUserLevel();
        clsUserLevel cUserLevel = new clsUserLevel();
        #endregion

        #region Variables
        Point lastClick;
        string DocumentCode = "UL";
        int result = 0;
        #endregion
        public frmUserLevel()
        {
            InitializeComponent();
        }

        private void frmUserLevel_Load(object sender, EventArgs e)
        {
            LoadDocumentNumber();
            this.btnUpdate.Enabled = false;
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbActiveState, 1);
            LoadDataGrid();
        }

        public void LoadDocumentNumber()
        {
            this.txtUserLevelCode.Text = cDocumentNumber.LoadDocNumber(cGlobleVariable.UniqID, DocumentCode, cGlobleVariable.LocationCode, cCommonMethods.DateYear());
        }

        public void LoadDataGrid()
        {
            DataTable dtRollList = cUserLevel.getDefaultRolls();
            dgvRoleList.Rows.Clear();
            for (int i = 0; i < dtRollList.Rows.Count; i++)
            {
                this.dgvRoleList.Rows.Add();
                dgvRoleList.Rows[i].Cells["clmUserRole"].Value = dtRollList.Rows[i]["fldRollName"].ToString();
                dgvRoleList.Rows[i].Cells["clmControlName"].Value = dtRollList.Rows[i]["fldControlName"].ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region Form Move

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }
        
        #endregion

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvRoleList.Rows.Count; i++)
            {
                if (dgvRoleList.Rows[i].Cells["clmUserRole"].Value != null)
                {
                    dgvRoleList.Rows[i].Cells["clmRoleState"].Value = true;
                }
                
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvRoleList.Rows.Count; i++)
            {
                if (dgvRoleList.Rows[i].Cells["clmUserRole"].Value != null)
                {
                    dgvRoleList.Rows[i].Cells["clmRoleState"].Value = false;
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oUserLevel = cUserLevel.GetUserLevelData(cGlobleVariable.LocationCode,txtUserLevelCode.Text);

                if (oUserLevel.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result == -5)
                    {
                        MessageBox.Show("Data Not Changed...!", "User Level", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result != -1)
                    {

                        cDocumentNumber.DeleteDocumentNumber(cGlobleVariable.UniqID, DocumentCode, this.txtUserLevelCode.Text);
                        MessageBox.Show("Successfully Saved...!", "User Level", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnUpdate.Enabled = true;
                        this.btnSave.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Item Data Not Saved...!", "User Level", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "User Level", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #region Validate User Level Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtUserLevel.Text == "")
            {
                errUL.SetError(txtUserLevel, "Please Enter User Level");
                isValidate = false;
            }
            else
            {
                errUL.SetError(txtUserLevel, "");
            }

            if (cmbActiveState.SelectedIndex < 0)
            {
                errUL.SetError(cmbActiveState, "Please Select Active State");
                isValidate = false;
            }
            else
            {
                errUL.SetError(cmbActiveState, "");
            }

            return isValidate;
        }
        #endregion

        #region InsertUpdate User Level Data
        private int InsertUpdateData()
        {
            oUserLevel.LocationCode = cGlobleVariable.LocationCode;
            oUserLevel.UserLevelCode = this.txtUserLevelCode.Text;
            oUserLevel.UserLevel = this.txtUserLevel.Text;
            oUserLevel.Status = Convert.ToInt16(cmbActiveState["fldStatusCode"]);

            oUserLevel.dtItemList = DataGridToDataTable(dgvRoleList, oUserLevel.UserLevelCode);
            if (oUserLevel.dtItemList.Rows.Count == 0)
            {
                return -5;
            }
            else
            {
                return cUserLevel.InsertUpdateData(oUserLevel);
            }
        }
        #endregion

        #region DataGrid To DataTable
        public DataTable DataGridToDataTable(DataGridView dgv, string strULCode)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("fldUserLevelCode");
            dt.Columns.Add("fldControlName");
            dt.Columns.Add("fldControlStatus");

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                try
                {
                    dRow["fldUserLevelCode"] = strULCode;
                    dRow["fldControlName"] = row.Cells["clmControlName"].Value.ToString();
                    dRow["fldControlStatus"] = row.Cells["clmRoleState"].Value.ToString();

                    if (Convert.ToBoolean(row.Cells["clmRoleState"].Value))
                    {
                        dt.Rows.Add(dRow);
                    }
                }
                catch (Exception ex)
                {

                }

            }
            return dt;
        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        #region Search User Level Details
        public void LoadSearch()
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "fldUserLevelCode";
            strFieldList[1] = "fldUserLevel";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "User Level Code";
            strHeaderList[1] = "User Level";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 100;
            iHeaderWidth[1] = 150;

            string strReturnString = "User Level Code";
            string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "'";
            txtUserLevelCode.Text = cCommonMethods.BrowsData("tbl_UserLevelHeader", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "User Level");
            if (txtUserLevelCode.Text != "")
            {
                LoadUserLevelDetails();
            }
        }
        #endregion

        #region Load User Level Details
        private void LoadUserLevelDetails()
        {
            oUserLevel = cUserLevel.GetUserLevelData(cGlobleVariable.LocationCode, this.txtUserLevelCode.Text);

            txtUserLevel.Text = oUserLevel.UserLevel;
            cmbActiveState.SetText(cStatusMaster.GetStatusByCode(oUserLevel.Status));
            if (!oUserLevel.Changeable)
            {
                cmbActiveState.Enabled = false;
                if (txtUserLevel.Text.Equals("Woxzone Admin"))
                {
                    dgvRoleList.ReadOnly = true;
                    btnClearAll.Enabled = false;
                    btnSelectAll.Enabled = false;
                    txtUserLevel.Enabled = false;

                }
            }
            else
            {
                cmbActiveState.Enabled = true;
                dgvRoleList.ReadOnly = false;
                btnClearAll.Enabled = true;
                btnSelectAll.Enabled = true;
                txtUserLevel.Enabled = true;
            }
            LoadDataGrid();
                for (int i = 0; i < oUserLevel.dtItemList.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvRoleList.Rows.Count; j++)
                    {
                        try
                        {
                        if (dgvRoleList.Rows[j].Cells["clmControlName"].Value.ToString().Equals(oUserLevel.dtItemList.Rows[i]["fldControlName"].ToString()))
                        {
                            dgvRoleList.Rows[j].Cells["clmRoleState"].Value = Convert.ToBoolean(oUserLevel.dtItemList.Rows[i]["fldControlStatus"].ToString());
                        }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            

            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        #region Clear
        public void clear()
        {
            cCommonMethods.ClearForm(this);
            LoadDocumentNumber();
            LoadDataGrid();
            this.txtUserLevelCode.ReadOnly = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oUserLevel = cUserLevel.GetUserLevelData(cGlobleVariable.LocationCode, txtUserLevelCode.Text);

                if (oUserLevel.IsExists == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Data not Update...!", "Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
