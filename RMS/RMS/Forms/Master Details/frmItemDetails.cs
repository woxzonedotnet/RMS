﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessObject;

namespace RMS.Forms
{
    public partial class frmItemDetails : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        objItemMaster oItemMaster = new objItemMaster();
        clsItemMaster cItemMaster = new clsItemMaster();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        clsDepartment cDepartment = new clsDepartment();
        clsCategoryMaster cCategory = new clsCategoryMaster();
        clsSupplierMaster cSupplier = new clsSupplierMaster();
        //clsSubCategory cSubCategory = new clsSubCategory();
        clsMenuCategory cMenuCategory = new clsMenuCategory();
        clsCapacityType cCapacityType = new clsCapacityType();
        objSubLocation oSubLocation = new objSubLocation();
        clsSubLocation cSubLocation = new clsSubLocation();
        
        #endregion

        #region Variables
        int result = -1;
        Point lastClick;
        string Location="";
        string SubLocation = "";
        #endregion


        public frmItemDetails()
        {
            InitializeComponent();
            Location = cGlobleVariable.LocationCode.ToString();
        }

        private void lblActiveStatus_Click(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oItemMaster = cItemMaster.GetItemData(cGlobleVariable.LocationCode, this.txtItemCode.Text);

                if (oItemMaster.IsExists == false)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Saved...!", "Item Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Item Data Not Saved...!", "Item Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Record already exist...!", "Item Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmItemDetails_Load(object sender, EventArgs e)
        {
            
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
            cCommonMethods.loadComboRMS(cDepartment.GetDepartmentData(Location), cmbDepartment, 2);
            cCommonMethods.loadComboRMS(cSupplier.GetSupplierData(Location), cmbSupplier, 2);
            cCommonMethods.loadComboRMS(cMenuCategory.GetMenuCategoryData(Location), cmbMCategory, 3);
            cCommonMethods.loadComboRMS(cCapacityType.GetCapacityData(), cmbCapacityType, 1);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DepartmentCode = cmbDepartment["fldDepartmentCode"].ToString();
            cmbCategory.ClearItems();
            cCommonMethods.loadComboRMS(cCategory.GetCategoryDataByDepartment(Location, DepartmentCode), cmbCategory, 3);
            
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                oItemMaster = cItemMaster.GetItemData(cGlobleVariable.LocationCode, this.txtItemCode.Text);

                if (oItemMaster.IsExists == true)
                {
                    result = InsertUpdateData();
                    if (result != -1)
                    {
                        MessageBox.Show("Successfully Updated...!", "Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Data not Update...!", "Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) && this.dgvLocationData.CurrentCell.OwningColumn.Name.Equals("clmLocationCode"))
            {
                LoadLocation();
            }
        }

        #region Clear
        public void clear()
        {
            cCommonMethods.ClearForm(this);
            this.txtItemCode.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnUpdate.Enabled = false;
        }
        #endregion

        #region Validate Item Master Data
        private bool ValidateData()
        {
            bool isValidate = true;

            if (txtItemCode.Text == "")
            {
                errItem.SetError(txtItemCode, "Please Enter Item Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtItemCode, "");

            }

            if (txtBarCode.Text == "")
            {
                errItem.SetError(txtBarCode, "Please BarCode");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtBarCode, "");

            }

            if (txtUnit.Text == "")
            {
                errItem.SetError(txtUnit, "Please Enter No of Unit");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtUnit, "");

            }

            if (txtPackageSize.Text == "")
            {
                errItem.SetError(txtPackageSize, "Please Enter Package Size");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtPackageSize, "");
            }

            if (txtDescription.Text == "")
            {
                errItem.SetError(txtDescription, "Please Enter Description");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtDescription, "");
            }

            if (txtMinimumGP.Text == "")
            {
                errItem.SetError(txtMinimumGP, "Please Enter Minimum GP");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtMinimumGP, "");
            }

            if (txtCapacity.Text == "")
            {
                errItem.SetError(txtCapacity, "Please Enter Capacity");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtCapacity, "");
            }

            if (txtCost.Text == "")
            {
                errItem.SetError(txtCost, "Please Enter Item Cost");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtCost, "");
            }

            if (txtWholeSale.Text == "")
            {
                errItem.SetError(txtWholeSale, "Please Enter Whole Sale Price");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtWholeSale, "");
            }

            if (txtSelling.Text == "")
            {
                errItem.SetError(txtSelling, "Please Enter Selling Price");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtSelling, "");
            }

            if (txtROL.Text == "")
            {
                errItem.SetError(txtROL, "Please Enter Re Order Level");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtROL, "");
            }

            if (txtROQ.Text == "")
            {
                errItem.SetError(txtROQ, "Please Enter Re Order Quantity");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtROQ, "");
            }

            if (txtMax.Text == "")
            {
                errItem.SetError(txtMax, "Please Enter Re Order Max");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtMax, "");
            }



            if (cmbConsignm.SelectedIndex == -1)
            {
                errItem.SetError(cmbConsignm, "Please Select Consignm");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbConsignm, "");
            }

            if (cmbDepartment.SelectedIndex == -1)
            {
                errItem.SetError(cmbDepartment, "Please Select Department");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbDepartment, "");
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                errItem.SetError(cmbCategory, "Please Select Category");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbCategory, "");
            }

            if (cmbSupplier.SelectedIndex == -1)
            {
                errItem.SetError(cmbSupplier, "Please Select Supplier");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbSupplier, "");
            }

            if (cmbWeighted.SelectedIndex == -1)
            {
                errItem.SetError(cmbWeighted, "Please Select Weighted");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbWeighted, "");
            }

            if (cmbMCategory.SelectedIndex == -1)
            {
                errItem.SetError(cmbMCategory, "Please Select Menu Category");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbMCategory, "");
            }

            if (cmbCapacityType.SelectedIndex == -1)
            {
                errItem.SetError(cmbCapacityType, "Please Select Capacity Type");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbCapacityType, "");
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                errItem.SetError(cmbStatus, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbStatus, "");
            }

            return isValidate;
        }
        #endregion

        #region InsertUpdate Item Data
        private int InsertUpdateData()
        {
            oItemMaster.LocationCode = cGlobleVariable.LocationCode.ToString();
            oItemMaster.ItemCode = this.txtItemCode.Text;
            oItemMaster.BarCode = this.txtBarCode.Text;
            oItemMaster.Description = this.txtDescription.Text;
            oItemMaster.Consignm = Convert.ToBoolean(cmbConsignm.SelectedItem.ToString());
            oItemMaster.Weighted = Convert.ToBoolean(cmbWeighted.SelectedItem.ToString());
            oItemMaster.Department = cmbDepartment["fldDepartmentCode"].ToString();
            oItemMaster.Category = cmbCategory["fldCategoryCode"].ToString();
            //oItemMaster.SubCategory = cmbSubCategory["fldSubCategoryCode"].ToString();
            oItemMaster.Supplier = cmbSupplier["fldSupplierCode"].ToString();
            oItemMaster.MenuCategory = cmbMCategory["fldMenuCategoryCode"].ToString();
            oItemMaster.Unit = Convert.ToInt32(this.txtUnit.Text);
            oItemMaster.MinimumGP = Convert.ToDouble(this.txtMinimumGP.Text);
            oItemMaster.PackageSize = Convert.ToDouble(this.txtPackageSize.Text);
            oItemMaster.Capacity = Convert.ToDouble(this.txtCapacity.Text);
            oItemMaster.CapacityType = cmbCapacityType["fldCapacityCode"].ToString();
            oItemMaster.CostPrice = Convert.ToDouble(this.txtCost.Text);
            oItemMaster.WholeSalePrice = Convert.ToDouble(this.txtWholeSale.Text);
            oItemMaster.SellingPrice = Convert.ToDouble(this.txtSelling.Text);
            oItemMaster.ReOrderLevel = Convert.ToDouble(this.txtROL.Text);
            oItemMaster.ReOrderQty = Convert.ToDouble(this.txtROQ.Text);
            oItemMaster.ReOrderMax = Convert.ToDouble(this.txtMax.Text);
            oItemMaster.Status = Convert.ToInt16(cmbStatus["fldStatusCode"]);
            return cItemMaster.InsertUpdateData(oItemMaster);
        }
        #endregion

        #region LoadSearch
        public void LoadSearch()
        {
            string[] strFieldList = new string[3];
            strFieldList[0] = "fldItemCode";
            strFieldList[1] = "fldBarCode";
            strFieldList[2] = "fldDescription";

            string[] strHeaderList = new string[3];
            strHeaderList[0] = "Item Code";
            strHeaderList[1] = "BarCode";
            strHeaderList[2] = "Description";

            int[] iHeaderWidth = new int[3];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 150;
            iHeaderWidth[2] = 250;

            string strReturnString = "Item Code";
            string strWhere = "fldStatus LIKE '1'";
            txtItemCode.Text = cCommonMethods.BrowsData("tbl_ItemMaster", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Item Code");
            if (txtItemCode.Text != "")
            {
                LoadItemDetails();
            }
        }
        #endregion

        #region Load Item Details
        private void LoadItemDetails()
        {
            oItemMaster = cItemMaster.GetItemData(txtItemCode.Text);

            txtBarCode.Text = oItemMaster.BarCode;
            txtUnit.Text = oItemMaster.Unit.ToString();
            txtPackageSize.Text = oItemMaster.PackageSize.ToString();
            txtDescription.Text = oItemMaster.Description;
            txtMinimumGP.Text = oItemMaster.MinimumGP.ToString();
            txtCapacity.Text = oItemMaster.Capacity.ToString();
            txtCost.Text = oItemMaster.CostPrice.ToString();
            txtWholeSale.Text = oItemMaster.WholeSalePrice.ToString();
            txtSelling.Text = oItemMaster.SellingPrice.ToString();
            txtROL.Text = oItemMaster.ReOrderLevel.ToString();
            txtROQ.Text = oItemMaster.ReOrderQty.ToString();
            txtMax.Text = oItemMaster.ReOrderMax.ToString();

            cmbConsignm.SelectedItem = oItemMaster.Consignm.ToString();
            cmbDepartment.SetText(cDepartment.GetDepartmentDataByCode(oItemMaster.Department));
            cmbCategory.SetText(cCategory.GetCategoryDataByDepartmentAndCategory(oItemMaster.Department, oItemMaster.Category));
            cmbSupplier.SetText(cSupplier.GetSupplierDataBySupplierCode(oItemMaster.LocationCode, oItemMaster.Supplier));
            cmbMCategory.SetText(cMenuCategory.GetMenuCategoryDataByCode(oItemMaster.LocationCode, oItemMaster.MenuCategory));
            cmbCapacityType.SetText(cCapacityType.GetCapacityDataByCode(oItemMaster.CapacityType));
            cmbWeighted.SelectedItem = oItemMaster.Weighted.ToString();
            cmbStatus.SetText(cStatusMaster.GetStatusByCode(oItemMaster.Status));

            this.txtBarCode.Select();
            this.txtItemCode.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnUpdate.Enabled = true;
        }
        #endregion

        #region LoadLocation
        public void LoadLocation()
        {
            string[] strFieldList = new string[2];
            strFieldList[0] = "fldSubLocationCode";
            strFieldList[1] = "fldSubLocationName";

            string[] strHeaderList = new string[2];
            strHeaderList[0] = "Location Code";
            strHeaderList[1] = "Location Name";

            int[] iHeaderWidth = new int[2];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 150;

            string strReturnString = "Location Code";
            string strWhere = "fldActiveStatus LIKE '1'";
            SubLocation = cCommonMethods.BrowsData("tbl_SubLocation", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "Location Code");
            if (SubLocation != "")
            {
                LoadLocationDetails();
            }
        }
        #endregion

        #region Load Location Details
        private void LoadLocationDetails()
        {
            oSubLocation = cSubLocation.GetSubLocationData(Location, SubLocation);

            int isExist = 0;
            for (int i = 0; i < dgvLocationData.Rows.Count; i++)
            {
                if (dgvLocationData.Rows[i].Cells[0].Value != null && SubLocation == dgvLocationData.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("The Selected Location already existed.");
                    isExist = -1;
                    break;
                }
                else
                {
                    isExist = 1;
                }
            }
            if (isExist == 1)
            {
                this.dgvLocationData.Rows.Add();
                this.dgvLocationData.Rows[this.dgvLocationData.CurrentCell.RowIndex - 1].Cells["clmLocationCode"].Value = oSubLocation.SubLocationCode;
                this.dgvLocationData.Rows[this.dgvLocationData.CurrentCell.RowIndex - 1].Cells["clmLocationName"].Value = oSubLocation.SubLocationName;
                this.dgvLocationData.Rows[this.dgvLocationData.CurrentCell.RowIndex - 1].Cells["clmShelfQty"].Value = "0.00";
                this.dgvLocationData.Rows[this.dgvLocationData.CurrentCell.RowIndex - 1].Cells["clmDamageQty"].Value = "0.00";
                this.dgvLocationData.Rows[this.dgvLocationData.CurrentCell.RowIndex - 1].Cells["clmMonthOpenQty"].Value = "0.00";
            }
        }
        #endregion

    }
}
