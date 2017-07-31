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

        #region GetItemLocation Data 
        public objItemLocation GetItemLocationData(string strLocationCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "'";
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
                oItemLocation.Sup = Convert.ToChar(dtItemLocation.Rows[0]["fldSup"]);
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
