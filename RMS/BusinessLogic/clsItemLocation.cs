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
    public class clsItemLocation
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objItemLocation oItemLocation = new objItemLocation();
        #endregion


        #region InsertUpdateData
        public int InsertUpdateData(objItemLocation oItemLocation)
        {
            System.Object[,] arrParameter = new Object[12, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oItemLocation.LocationCode;
            arrParameter[1, 0] = "@mfldSubLocationCode";
            arrParameter[1, 1] = oItemLocation.SubLocationCode;
            arrParameter[2, 0] = "@mfldItemCode";
            arrParameter[2, 1] = oItemLocation.ItemCode;
            arrParameter[3, 0] = "@mfldShelfStock";
            arrParameter[3, 1] = oItemLocation.ShelfStock;
            arrParameter[4, 0] = "@mfldDamageStoc";
            arrParameter[4, 1] = oItemLocation.DamageStock;
            arrParameter[5, 0] = "@mfldMonthlyOpenQty";
            arrParameter[5, 1] = oItemLocation.MonthlyOpenQty;
            arrParameter[6, 0] = "@mfldOldStock";
            arrParameter[6, 1] = oItemLocation.OldStock;
            arrParameter[7, 0] = "@mfldInitialized";
            arrParameter[7, 1] = oItemLocation.Initialized;
            arrParameter[8, 0] = "@mfldDataTransfer";
            arrParameter[8, 1] = oItemLocation.DataTransfer;
            //arrParameter[9, 0] = "@mfldSup";
            //arrParameter[9, 1] = oItemLocation.Sup;
            arrParameter[9, 0] = "@mfldPendingInvoice";
            arrParameter[9, 1] = oItemLocation.PendingInvoice;
            arrParameter[10, 0] = "@mfldDamageReturn";
            arrParameter[10, 1] = oItemLocation.DamageReturn;
            arrParameter[11, 0] = "@mfldInvoiced";
            arrParameter[11, 1] = oItemLocation.Invoiced;

            return cDBConnection.Insert("SP_INSERT_UPDATE_ITEM_LOCATION", arrParameter);
        }
        #endregion



        #region GetItemLocation Data 
        public objItemLocation GetItemLocationData(string strLocationCode,string strItemCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' and fldItemCode='"+ strItemCode +"'";
            DataTable dtItemLocation = cDBConnection.SearchData("tbl_ItemLocation", strWhere);

            if (dtItemLocation.Rows.Count > 0)
            {
                oItemLocation.LocationCode = dtItemLocation.Rows[0]["fldLocationCode"].ToString();
                oItemLocation.SubLocationCode = dtItemLocation.Rows[0]["fldSubLocationCode"].ToString();
                oItemLocation.ItemCode = dtItemLocation.Rows[0]["fldItemCode"].ToString();
                oItemLocation.ShelfStock = Convert.ToDouble(dtItemLocation.Rows[0]["fldShelfStock"]);
                oItemLocation.DamageStock = Convert.ToDouble(dtItemLocation.Rows[0]["fldDamageStock"]);
                oItemLocation.MonthlyOpenQty = Convert.ToDouble(dtItemLocation.Rows[0]["fldMonthlyOpenQty"]);
                oItemLocation.OldStock = Convert.ToDouble(dtItemLocation.Rows[0]["fldOldStock"]);
                oItemLocation.Initialized = Convert.ToBoolean(dtItemLocation.Rows[0]["fldInitialized"]);
                oItemLocation.DataTransfer = Convert.ToBoolean(dtItemLocation.Rows[0]["fldDataTransfer"]);
                //oItemLocation.Sup = Convert.ToChar(dtItemLocation.Rows[0]["fldSup"]);
                oItemLocation.PendingInvoice = Convert.ToDouble(dtItemLocation.Rows[0]["fldPendingInvoice"]);
                oItemLocation.DamageReturn = Convert.ToDouble(dtItemLocation.Rows[0]["fldDamageReturn"]);
                oItemLocation.Invoiced = Convert.ToBoolean(dtItemLocation.Rows[0]["fldInvoiced"]);

                oItemLocation.IsExists = true;
            }
            else
            {
                oItemLocation.IsExists = false;
            }

            return oItemLocation;
        }

        public objItemLocation GetItemLocationData(string strLocationCode,string strSubLocationCode ,string strItemCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' and fldSubLocationCode='" + strSubLocationCode + "' and fldItemCode='" + strItemCode + "'";
            DataTable dtItemLocation = cDBConnection.SearchData("tbl_ItemLocation", strWhere);

            if (dtItemLocation.Rows.Count > 0)
            {
                oItemLocation.LocationCode = dtItemLocation.Rows[0]["fldLocationCode"].ToString();
                oItemLocation.SubLocationCode = dtItemLocation.Rows[0]["fldSubLocationCode"].ToString();
                oItemLocation.ItemCode = dtItemLocation.Rows[0]["fldItemCode"].ToString();
                oItemLocation.ShelfStock = Convert.ToDouble(dtItemLocation.Rows[0]["fldShelfStock"]);
                oItemLocation.DamageStock = Convert.ToDouble(dtItemLocation.Rows[0]["fldDamageStock"]);
                oItemLocation.MonthlyOpenQty = Convert.ToDouble(dtItemLocation.Rows[0]["fldMonthlyOpenQty"]);
                oItemLocation.OldStock = Convert.ToDouble(dtItemLocation.Rows[0]["fldOldStock"]);
                oItemLocation.Initialized = Convert.ToBoolean(dtItemLocation.Rows[0]["fldInitialized"]);
                oItemLocation.DataTransfer = Convert.ToBoolean(dtItemLocation.Rows[0]["fldDataTransfer"]);
                //oItemLocation.Sup = Convert.ToChar(dtItemLocation.Rows[0]["fldSup"]);
                oItemLocation.PendingInvoice = Convert.ToDouble(dtItemLocation.Rows[0]["fldPendingInvoice"]);
                oItemLocation.DamageReturn = Convert.ToDouble(dtItemLocation.Rows[0]["fldDamageReturn"]);
                oItemLocation.Invoiced = Convert.ToBoolean(dtItemLocation.Rows[0]["fldInvoiced"]);

                oItemLocation.IsExists = true;
            }
            else
            {
                oItemLocation.IsExists = false;
            }

            return oItemLocation;
        }
        #endregion
    }
}
