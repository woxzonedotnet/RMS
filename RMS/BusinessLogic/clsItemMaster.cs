using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinessObject;
using System.Data;

namespace BusinessLogic
{
    public class clsItemMaster
    {

        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objItemMaster oItemMaster = new objItemMaster();
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objItemMaster oItemMaster)
        {
            System.Object[,] arrParameter = new Object[22, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oItemMaster.LocationCode;
            arrParameter[1, 0] = "@mfldItemCode";
            arrParameter[1, 1] = oItemMaster.ItemCode;
            arrParameter[2, 0] = "@mfldBarcode";
            arrParameter[2, 1] = oItemMaster.BarCode;
            arrParameter[3, 0] = "@mfldDescription";
            arrParameter[3, 1] = oItemMaster.Description;
            arrParameter[4, 0] = "@mfldConsignm";
            arrParameter[4, 1] = oItemMaster.Consignm;
            arrParameter[5, 0] = "@mfldWeighted";
            arrParameter[5, 1] = oItemMaster.Weighted;
            arrParameter[6, 0] = "@mfldDepartmentCode";
            arrParameter[6, 1] = oItemMaster.Department;
            arrParameter[7, 0] = "@mfldCategoryCode";
            arrParameter[7, 1] = oItemMaster.Category;
            //arrParameter[8, 0] = "@mfldSubCategoryCode";
            //arrParameter[8, 1] = oItemMaster.SubCategory;
            arrParameter[8, 0] = "@mfldSupplierCode";
            arrParameter[8, 1] = oItemMaster.Supplier;
            arrParameter[9, 0] = "@mfldMenuCategoryCode";
            arrParameter[9, 1] = oItemMaster.MenuCategory;
            arrParameter[10, 0] = "@mfldUnit";
            arrParameter[10, 1] = oItemMaster.Unit;
            arrParameter[11, 0] = "@mfldMinimumGP";
            arrParameter[11, 1] = oItemMaster.MinimumGP;
            arrParameter[12, 0] = "@mfldPackageSize";
            arrParameter[12, 1] = oItemMaster.PackageSize;
            arrParameter[13, 0] = "@mfldCapacity";
            arrParameter[13, 1] = oItemMaster.Capacity;
            arrParameter[14, 0] = "@mfldCapacityCode";
            arrParameter[14, 1] = oItemMaster.CapacityType;
            arrParameter[15, 0] = "@mfldCostPrice";
            arrParameter[15, 1] = oItemMaster.CostPrice;
            arrParameter[16, 0] = "@mfldWholeSalePrice";
            arrParameter[16, 1] = oItemMaster.WholeSalePrice;
            arrParameter[17, 0] = "@mfldSellingPrice";
            arrParameter[17, 1] = oItemMaster.SellingPrice;
            arrParameter[18, 0] = "@mfldReOrderLevel";
            arrParameter[18, 1] = oItemMaster.ReOrderLevel;
            arrParameter[19, 0] = "@mfldReOrderQty";
            arrParameter[19, 1] = oItemMaster.ReOrderQty;
            arrParameter[20, 0] = "@mfldReOrderMax";
            arrParameter[20, 1] = oItemMaster.ReOrderMax;
            arrParameter[21, 0] = "@mfldStatus";
            arrParameter[21, 1] = oItemMaster.Status;

            return cDBConnection.Insert("sp_insert_update_itemMaster", arrParameter);
        }
        #endregion

        #region GetItemDetails
        public DataTable GetItemData()
        {
            DataTable dtItemAll=null;
            DataTable dtItemMaster = cDBConnection.SearchData("tbl_ItemMaster");
            DataTable dtItemPrice = cDBConnection.SearchData("tbl_ItemPrice");
            DataTable dtItemReOrder = cDBConnection.SearchData("tbl_ItemReOrder");

            dtItemAll.Merge(dtItemMaster);
            dtItemAll.Merge(dtItemPrice);
            dtItemAll.Merge(dtItemReOrder);

            return dtItemAll;
        }
        #endregion

        #region Get ItemData using ItemCode
        public objItemMaster GetItemData(string strItemCode)
        {
            string strWhere = "fldItemCode='" + strItemCode + "'";

            DataTable dtItemMaster = cDBConnection.SearchData("tbl_ItemMaster",strWhere);
            DataTable dtItemPrice = cDBConnection.SearchData("tbl_ItemPrice", strWhere);
            DataTable dtItemReOrder = cDBConnection.SearchData("tbl_ItemReOrder", strWhere);

            if (dtItemMaster.Rows.Count > 0)
            {
                oItemMaster.LocationCode = dtItemMaster.Rows[0][0].ToString();
                oItemMaster.ItemCode = dtItemMaster.Rows[0][1].ToString();
                oItemMaster.BarCode = dtItemMaster.Rows[0][2].ToString();
                oItemMaster.Description = dtItemMaster.Rows[0][3].ToString();
                oItemMaster.Consignm = Convert.ToBoolean(dtItemMaster.Rows[0][4].ToString());
                oItemMaster.Weighted = Convert.ToBoolean(dtItemMaster.Rows[0][5].ToString());
                oItemMaster.Department = dtItemMaster.Rows[0][6].ToString();
                oItemMaster.Category = dtItemMaster.Rows[0][7].ToString();
                oItemMaster.Supplier = dtItemMaster.Rows[0][8].ToString();
                oItemMaster.MenuCategory = dtItemMaster.Rows[0][9].ToString();
                oItemMaster.Unit = Convert.ToInt32(dtItemMaster.Rows[0][10].ToString());
                oItemMaster.MinimumGP = Convert.ToDouble(dtItemMaster.Rows[0][11].ToString());
                oItemMaster.PackageSize = Convert.ToDouble(dtItemMaster.Rows[0][12].ToString());
                oItemMaster.Capacity = Convert.ToDouble(dtItemMaster.Rows[0][13].ToString());
                oItemMaster.CapacityType = dtItemMaster.Rows[0][14].ToString();
                oItemMaster.Status = Convert.ToInt16(dtItemMaster.Rows[0][15]);

                //Price Table
                oItemMaster.CostPrice = Convert.ToDouble(dtItemPrice.Rows[0][1].ToString());
                oItemMaster.WholeSalePrice = Convert.ToDouble(dtItemPrice.Rows[0][2].ToString());
                oItemMaster.SellingPrice = Convert.ToDouble(dtItemPrice.Rows[0][3].ToString());

                //ReOrder Table
                oItemMaster.ReOrderLevel = Convert.ToDouble(dtItemReOrder.Rows[0][1].ToString());
                oItemMaster.ReOrderQty = Convert.ToDouble(dtItemReOrder.Rows[0][2].ToString());
                oItemMaster.ReOrderMax = Convert.ToDouble(dtItemReOrder.Rows[0][3].ToString());


                oItemMaster.IsExists = true;
            }
            else
            {
                oItemMaster.IsExists = false;
            }


            return oItemMaster;
        }
        #endregion

        #region Get ItemData using ItemCode
        public objItemMaster GetItemData(string strLocationCode,string strItemCode)
        {
            string strWhere1 = "fldItemCode='" + strItemCode + "' AND fldLocationCode='"+strLocationCode+"'";
            string strWhere2 = "fldItemCode='" + strItemCode + "'";

            DataTable dtItemMaster = cDBConnection.SearchData("tbl_ItemMaster", strWhere1);
            DataTable dtItemPrice = cDBConnection.SearchData("tbl_ItemPrice", strWhere2);
            DataTable dtItemReOrder = cDBConnection.SearchData("tbl_ItemReOrder", strWhere2);

            if (dtItemMaster.Rows.Count > 0)
            {
                oItemMaster.LocationCode = dtItemMaster.Rows[0][0].ToString();
                oItemMaster.ItemCode = dtItemMaster.Rows[0][1].ToString();
                oItemMaster.BarCode = dtItemMaster.Rows[0][2].ToString();
                oItemMaster.Description = dtItemMaster.Rows[0][3].ToString();
                oItemMaster.Consignm = Convert.ToBoolean(dtItemMaster.Rows[0][4].ToString());
                oItemMaster.Weighted = Convert.ToBoolean(dtItemMaster.Rows[0][5].ToString());
                oItemMaster.Department = dtItemMaster.Rows[0][6].ToString();
                oItemMaster.Category = dtItemMaster.Rows[0][7].ToString();
                oItemMaster.Supplier = dtItemMaster.Rows[0][8].ToString();
                oItemMaster.MenuCategory = dtItemMaster.Rows[0][9].ToString();
                oItemMaster.Unit = Convert.ToInt32(dtItemMaster.Rows[0][10].ToString());
                oItemMaster.MinimumGP = Convert.ToDouble(dtItemMaster.Rows[0][11].ToString());
                oItemMaster.PackageSize = Convert.ToDouble(dtItemMaster.Rows[0][12].ToString());
                oItemMaster.Capacity = Convert.ToDouble(dtItemMaster.Rows[0][13].ToString());
                oItemMaster.CapacityType = dtItemMaster.Rows[0][14].ToString();
                oItemMaster.Status = Convert.ToInt16(dtItemMaster.Rows[0][15]);

                //Price Table
                oItemMaster.CostPrice = Convert.ToDouble(dtItemPrice.Rows[0][1].ToString());
                oItemMaster.WholeSalePrice = Convert.ToDouble(dtItemPrice.Rows[0][2].ToString());
                oItemMaster.SellingPrice = Convert.ToDouble(dtItemPrice.Rows[0][3].ToString());

                //ReOrder Table
                oItemMaster.ReOrderLevel = Convert.ToDouble(dtItemReOrder.Rows[0][1].ToString());
                oItemMaster.ReOrderQty = Convert.ToDouble(dtItemReOrder.Rows[0][2].ToString());
                oItemMaster.ReOrderMax = Convert.ToDouble(dtItemReOrder.Rows[0][3].ToString());


                oItemMaster.IsExists = true;
            }
            else
            {
                oItemMaster.IsExists = false;
            }


            return oItemMaster;
        }
        #endregion

    }
}
