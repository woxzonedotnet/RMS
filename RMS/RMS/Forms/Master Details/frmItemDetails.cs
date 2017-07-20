using System;
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
        //clsCapacityType cCapacityType = new clsCapacityType();
        #endregion

        #region Variables
        int result = -1;
        Point lastClick;
        string Location;
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
                //oItemMaster = cItemMaster.GetItemData(cGlobleVariable.LocationCode, this.txtItemCode.Text);

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
                errItem.SetError(txtItemCode, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtItemCode, "");

            }

            if (txtBarCode.Text == "")
            {
                errItem.SetError(txtBarCode, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtBarCode, "");

            }

            if (txtUnit.Text == "")
            {
                errItem.SetError(txtUnit, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtUnit, "");

            }

            if (txtPackageSize.Text == "")
            {
                errItem.SetError(txtPackageSize, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtPackageSize, "");
            }

            if (txtDescription.Text == "")
            {
                errItem.SetError(txtDescription, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtDescription, "");
            }

            if (txtMinimumGP.Text == "")
            {
                errItem.SetError(txtMinimumGP, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtMinimumGP, "");
            }

            if (txtCapacity.Text == "")
            {
                errItem.SetError(txtCapacity, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtCapacity, "");
            }

            if (txtCost.Text == "")
            {
                errItem.SetError(txtCost, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtCost, "");
            }

            if (txtWholeSale.Text == "")
            {
                errItem.SetError(txtWholeSale, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtWholeSale, "");
            }

            if (txtSelling.Text == "")
            {
                errItem.SetError(txtSelling, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtSelling, "");
            }

            if (txtROL.Text == "")
            {
                errItem.SetError(txtROL, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtROL, "");
            }

            if (txtROQ.Text == "")
            {
                errItem.SetError(txtROQ, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtROQ, "");
            }

            if (txtMax.Text == "")
            {
                errItem.SetError(txtMax, "Please Enter Customer Code");
                isValidate = false;
            }
            else
            {
                errItem.SetError(txtMax, "");
            }



            if (cmbConsignm.SelectedIndex == -1)
            {
                errItem.SetError(cmbConsignm, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbConsignm, "");
            }

            if (cmbDepartment.SelectedIndex == -1)
            {
                errItem.SetError(cmbDepartment, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbDepartment, "");
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                errItem.SetError(cmbCategory, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbCategory, "");
            }

            if (cmbSupplier.SelectedIndex == -1)
            {
                errItem.SetError(cmbSupplier, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbSupplier, "");
            }

            if (cmbWeighted.SelectedIndex == -1)
            {
                errItem.SetError(cmbWeighted, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbWeighted, "");
            }

            //if (cmbSubCategory.SelectedIndex == -1)
            //{
            //    errItem.SetError(cmbSubCategory, "Please Select Status");
            //    isValidate = false;
            //}
            //else
            //{
            //    errItem.SetError(cmbSubCategory, "");
            //}

            if (cmbMCategory.SelectedIndex == -1)
            {
                errItem.SetError(cmbMCategory, "Please Select Status");
                isValidate = false;
            }
            else
            {
                errItem.SetError(cmbMCategory, "");
            }

            //if (cmbCapacityType.SelectedIndex == -1)
            //{
            //    errItem.SetError(cmbCapacityType, "Please Select Status");
            //    isValidate = false;
            //}
            //else
            //{
            //    errItem.SetError(cmbCapacityType, "");
            //}

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
            oItemMaster.Consignm = Convert.ToBoolean(cmbConsignm["fldConsignm"].ToString());
            oItemMaster.Weighted = Convert.ToBoolean(cmbWeighted["fldWeighted"].ToString());
            oItemMaster.Department = cmbDepartment["fldDepartmentCode"].ToString();
            oItemMaster.Category = cmbCategory["fldCategoryCode"].ToString();
            oItemMaster.SubCategory = cmbSubCategory["fldSubCategoryCode"].ToString();
            oItemMaster.Supplier = cmbSupplier["fldSupplierCode"].ToString();
            oItemMaster.MenuCategory = cmbMCategory["fldMenuCategoryCode"].ToString();
            oItemMaster.Unit = Convert.ToInt16(this.txtUnit.Text);
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

        private void frmItemDetails_Load(object sender, EventArgs e)
        {
            
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
            cCommonMethods.loadComboRMS(cDepartment.GetDepartmentData(Location), cmbDepartment, 1);
            cCommonMethods.loadComboRMS(cCategory.GetCategoryData(Location), cmbCategory, 1);
            cCommonMethods.loadComboRMS(cSupplier.GetSupplierData(Location), cmbStatus, 1);
            cCommonMethods.loadComboRMS(cMenuCategory.GetMenuCategoryData(Location), cmbStatus, 1);
        }


    }
}
