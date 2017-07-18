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
    public partial class frmTableDetails : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        clsTableCategory cTableCategory = new clsTableCategory();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsSubLocation cSubLocation = new clsSubLocation();
        objTableMaster oTableMaster = new objTableMaster();
        clsTableMaster cTableMaster = new clsTableMaster();
        #endregion

        #region Variable
        int result = -1;
        Point lastClick;
        #endregion

        public frmTableDetails()
        {
            InitializeComponent();
            this.lblFormTitle.Text = this.Text;
        }

        private void frmTableDetails_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(),cmbStatus,1);
            cCommonMethods.loadComboRMS(cTableCategory.GetTableCategoryData(cGlobleVariable.LocationCode),cmbTableCategory,2);
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode),cmbTableLocation,2);
            this.btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oTableMaster = cTableMaster.GetTableMasterData(cGlobleVariable.LocationCode, this.cmbTableCategory["fldTableCategoryCode"].ToString(),this.txtTableCode.Text);

                if (oTableMaster.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Table Category Data Not Saved...!", "Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #region InsertUpdate TableMaster Data
        private int InsertUpdateData()
        {
            oTableMaster.LocationCode = cGlobleVariable.LocationCode.ToString();
            oTableMaster.TableCategoryCode = this.cmbTableCategory["fldTableCategoryCode"].ToString();
            oTableMaster.TableCode = this.txtTableCode.Text;
            oTableMaster.SubLocationCode = this.cmbTableLocation["fldSubLocationCode"].ToString();
            oTableMaster.TableSeats = Convert.ToInt16(this.nudNoOfSeats.Value);
            oTableMaster.TableStatus = Convert.ToInt16(cmbStatus["fldStatusCode"]);

            return cTableMaster.InsertUpdateData(oTableMaster);
        }
        #endregion

        public bool ValidateData()
        {
            bool isValidate = true;

            if (cmbTableCategory.SelectedIndex == -1)
            {
                errTable.SetError(cmbTableCategory, "Please Select Table Category");
                isValidate = false;
            }
            else
            {
                errTable.SetError(cmbTableCategory, "");

            }

            if (txtTableCode.Text == "")
            {
                errTable.SetError(txtTableCode, "Please Enter Table No");
                isValidate = false;
            }
            else
            {
                errTable.SetError(txtTableCode, "");
            }

            if (cmbTableLocation.SelectedIndex == -1)
            {
                errTable.SetError(cmbTableLocation, "Please Select Table Location");
                isValidate = false;
            }
            else
            {
                errTable.SetError(cmbTableLocation, "");
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                errTable.SetError(cmbStatus, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errTable.SetError(cmbStatus, "");
            }

            return isValidate;
        }

        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtTableCode.Enabled = true;
            this.cmbTableCategory.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }


        public void LoadSearch() 
        {
            if (cmbTableCategory.SelectedIndex != -1)
            {
                string[] strFieldList = new string[2];
                strFieldList[0] = "fldTableCode";
                strFieldList[1] = "fldTableSeats";

                string[] strHeaderList = new string[2];
                strHeaderList[0] = "Table Code";
                strHeaderList[1] = "Table Seats";

                int[] iHeaderWidth = new int[2];
                iHeaderWidth[0] = 150;
                iHeaderWidth[1] = 320;

                string strReturnString = "Table Code";
                string strWhere = "fldLocationCode= '" + cGlobleVariable.LocationCode + "' and fldTableCategoryCode='" + cmbTableCategory["fldTableCategoryCode"] + "'";
                txtTableCode.Text = cCommonMethods.BrowsData("tbl_TableMaster", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Table Master");
                if (txtTableCode.Text != "")
                {
                    LoadTableMaster();
                }
            }
            else
            {
                MessageBox.Show("Please Select Table Category");
            }
        }

        public void LoadTableMaster()
        {
            oTableMaster = cTableMaster.GetTableMasterData(cGlobleVariable.LocationCode, this.cmbTableCategory["fldTableCategoryCode"].ToString(),this.txtTableCode.Text);
            
            cmbTableLocation.SetText(cSubLocation.GetSubLocationData(cGlobleVariable.LocationCode, oTableMaster.SubLocationCode).SubLocationName);
            cmbStatus.SetText(cStatusMaster.GetStatusByCode(oTableMaster.TableStatus));
            nudNoOfSeats.Value = oTableMaster.TableSeats;

            this.cmbTableCategory.Enabled = false;
            this.txtTableCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oTableMaster = cTableMaster.GetTableMasterData(cGlobleVariable.LocationCode, this.cmbTableCategory["fldTableCategoryCode"].ToString(), this.txtTableCode.Text);

                if (oTableMaster.IsExists == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Table Category Data Not Update...!", "Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtTableCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                LoadSearch();
            }
        }
    }
}