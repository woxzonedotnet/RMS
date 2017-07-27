using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;

namespace RMS.Forms.Inventory
{
    public partial class frmGoodsReceiveNote : Form
    {
        #region Objects
        clsCommonMethods cCommonMethods = new clsCommonMethods();
        clsSubLocation cSubLocation = new clsSubLocation();
        clsSupplierMaster cSupplierMaster = new clsSupplierMaster();
        #endregion

        public frmGoodsReceiveNote()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGoodsReceiveNote_Load(object sender, EventArgs e)
        {
            cCommonMethods.loadComboRMS(cSubLocation.GetSubLocationData(), cmbLocation, 2);
            cCommonMethods.loadComboRMS(cSupplierMaster.GetSupplierData(), cmbSupplier, 2);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        public void LoadSearch()
        {
            string[] strFieldList = new string[3];
            strFieldList[0] = "fldCardCode";
            strFieldList[1] = "fldBankCode";
            strFieldList[2] = "fldCardTypeCode";

            string[] strHeaderList = new string[3];
            strHeaderList[0] = "Card Code";
            strHeaderList[1] = "Bank Code";
            strHeaderList[2] = "Card Type Code";

            int[] iHeaderWidth = new int[3];
            iHeaderWidth[0] = 150;
            iHeaderWidth[1] = 150;
            iHeaderWidth[2] = 320;

            string strReturnString = "GRN Number";
            string strWhere = "fldStatus LIKE '%'";
            txtGRNNumber.Text = cCommonMethods.BrowsData("tbl_GRNDetails", strFieldList, strHeaderList, iHeaderWidth, strReturnString, strWhere, "fldGRNCode");
            if (txtGRNNumber.Text != "")
            {
               // LoadGRNNumber();
            }
        }
    }
}
