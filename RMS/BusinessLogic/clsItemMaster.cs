using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinessObject;

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
            System.Object[,] arrParameter = new Object[23, 2];

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
            arrParameter[8, 0] = "@mfldSubCategoryCode";
            arrParameter[8, 1] = oItemMaster.SubCategory;
            arrParameter[9, 0] = "@mfldSupplierCode";
            arrParameter[9, 1] = oItemMaster.Supplier;
            arrParameter[10, 0] = "@mfldMenuCategoryCode";
            arrParameter[10, 1] = oItemMaster.MenuCategory;
            arrParameter[11, 0] = "@mfldUnit";
            arrParameter[11, 1] = oItemMaster.Unit;
            arrParameter[12, 0] = "@mfldMinimumGP";
            arrParameter[12, 1] = oItemMaster.MinimumGP;
            arrParameter[13, 0] = "@mfldPackageSize";
            arrParameter[13, 1] = oItemMaster.PackageSize;
            arrParameter[14, 0] = "@mfldCapacity";
            arrParameter[14, 1] = oItemMaster.Capacity;
            arrParameter[15, 0] = "@mfldCapacityCode";
            arrParameter[15, 1] = oItemMaster.CapacityType;
            arrParameter[16, 0] = "@mfldCostPrice";
            arrParameter[16, 1] = oItemMaster.CostPrice;
            arrParameter[17, 0] = "@mfldWholeSalePrice";
            arrParameter[17, 1] = oItemMaster.WholeSalePrice;
            arrParameter[18, 0] = "@mfldSellingPrice";
            arrParameter[18, 1] = oItemMaster.SellingPrice;
            arrParameter[19, 0] = "@mfldReOrderLevel";
            arrParameter[19, 1] = oItemMaster.ReOrderLevel;
            arrParameter[20, 0] = "@mfldReOrderQty";
            arrParameter[20, 1] = oItemMaster.ReOrderQty;
            arrParameter[21, 0] = "@mfldReOrderMax";
            arrParameter[21, 1] = oItemMaster.ReOrderMax;
            arrParameter[22, 0] = "@mfldStatus";
            arrParameter[22, 1] = oItemMaster.Status;

            return cDBConnection.Insert("sp_insert_update_itemMaster", arrParameter);
        }
        #endregion


    }
}
