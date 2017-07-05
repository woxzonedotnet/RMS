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
    public partial class frmCategoryMasterDetails : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsStatusMaster cStatusMaster = new clsStatusMaster();
        clsCategoryMaster cCategoryMaster = new clsCategoryMaster();
        clsDepartment cDepartment = new clsDepartment();
        clsGlobleVariable cGlobleVariable = new clsGlobleVariable();
        objCategoryMaster oCategoryMaster = new objCategoryMaster();
        #endregion

        #region variables
        int result = -1;
        #endregion

        public frmCategoryMasterDetails()
        {
            InitializeComponent();
        }

        private void frmCategoryMasterDetails_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cDepartment.GetDepartmentData(cGlobleVariable.LocationCode), cmbDepartmentName, 2);
            cCommonMethods.loadComboRMS(cStatusMaster.GetStatusDetails(), cmbStatus, 1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (ValidateData())
            //{
            //    oCategoryMaster = cCategoryMaster.GetCategoryData(cGlobleVariable.LocationCode, this.txtCategoryCode.Text);

            //    if (oCategoryMaster.IsExistCategory == false)
            //    {
            //        result = InsertUpdateData();
            //        if (result != -1)
            //        {
            //            MessageBox.Show("Successfully Saved...!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            clear();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Category Data Not Saved...!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Record already exist...!", "Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
        }
    }
}
