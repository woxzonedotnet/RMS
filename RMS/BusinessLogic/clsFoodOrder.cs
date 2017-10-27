using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class clsFoodOrder
    {
        #region Object
        objFoodOrder oFoodOrder = new objFoodOrder();
        clsSubLocation cSubLocation = new clsSubLocation();
        clsDBConnection cDBConnection = new clsDBConnection();

        #endregion

        #region Variable

        #endregion

        #region Function

        #region InsertUpdate Food Orders
        public int InsertUpdateData(objFoodOrder oFoodOrder)
        {
            System.Object[,] arrParameter = new Object[12, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oFoodOrder.LocationCode;
            arrParameter[1, 0] = "@mfldSubLocationCode";
            arrParameter[1, 1] = oFoodOrder.SubLocationCode;
            arrParameter[2, 0] = "@mfldOrderNo";
            arrParameter[2, 1] = oFoodOrder.OrderNo;
            arrParameter[3, 0] = "@mfldStewardCode";
            arrParameter[3, 1] = oFoodOrder.StewardCode;
            arrParameter[4, 0] = "@mfldTableCode";
            arrParameter[4, 1] = oFoodOrder.TableCode;
            arrParameter[5, 0] = "@mfldDate";
            arrParameter[5, 1] = oFoodOrder.Date;
            arrParameter[6, 0] = "@mfldTime";
            arrParameter[6, 1] = oFoodOrder.Time;
            arrParameter[7, 0] = "@mfldSubTotal";
            arrParameter[7, 1] = oFoodOrder.SubTotal;
            arrParameter[8, 0] = "@mfldDiscount";
            arrParameter[8, 1] = oFoodOrder.Discount;
            arrParameter[9, 0] = "@mfldTax";
            arrParameter[9, 1] = oFoodOrder.Tax;
            arrParameter[10, 0] = "@mfldOrderState";
            arrParameter[10, 1] = oFoodOrder.OrderState;
            arrParameter[11, 0] = "@mfldItems";
            arrParameter[11, 1] = oFoodOrder.Items;

            return cDBConnection.Insert("sp_insert_update_food_order", arrParameter);
        }
        #endregion

        #region Get Food Order Data using Order Code
        public objFoodOrder GetFoodOrderData(string strOrderCode)
        {
            string strWhere = "fldOrderNo='" + strOrderCode + "'";

            DataTable dtOrder = cDBConnection.SearchData("tbl_FoodOrder", strWhere);
            DataTable dtOrderItems = cDBConnection.SearchData("tbl_FoodOrderItems", strWhere);

            if (dtOrder.Rows.Count > 0)
            {
                oFoodOrder.LocationCode = dtOrder.Rows[0]["fldLocationCode"].ToString();
                oFoodOrder.SubLocationCode = dtOrder.Rows[0]["fldLocationCode"].ToString();
                oFoodOrder.OrderNo = dtOrder.Rows[0]["fldLocationCode"].ToString();
                oFoodOrder.StewardCode = dtOrder.Rows[0]["fldLocationCode"].ToString();
                oFoodOrder.TableCode = dtOrder.Rows[0]["fldLocationCode"].ToString();
                oFoodOrder.Date = Convert.ToDateTime(dtOrder.Rows[0]["fldLocationCode"].ToString());
                oFoodOrder.Time = Convert.ToDateTime(dtOrder.Rows[0]["fldLocationCode"].ToString());
                oFoodOrder.SubTotal = Convert.ToDouble(dtOrder.Rows[0]["fldLocationCode"].ToString());
                oFoodOrder.Discount = Convert.ToDouble(dtOrder.Rows[0]["fldLocationCode"].ToString());
                oFoodOrder.Tax = Convert.ToDouble(dtOrder.Rows[0]["fldLocationCode"].ToString());
                oFoodOrder.OrderState = Convert.ToInt16(dtOrder.Rows[0]["fldLocationCode"].ToString());

                oFoodOrder.Items = dtOrderItems;

                oFoodOrder.IsExists = true;
            }
            else
            {
                oFoodOrder.IsExists = false;
            }

            return oFoodOrder;
        }
        #endregion


        #endregion
    }
}
