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
    public class clsOrderType
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objOrderType oOrderType = new objOrderType();
        #endregion

        #region GetOrderType Using OrderType Code
        public DataTable GetOrderType(string strLocationCode)
        {
            string strWhere = "fldLocationCode ='" + strLocationCode + "'";

            DataTable dtOrderType = cDBConnection.SearchData("tbl_OrderType", strWhere);

            
            return dtOrderType;
        }
        #endregion

        public objOrderType GetOrderTypeByCode(string strOrderTypeCode)
        {
            string strWhere = "fldOrderTypeCode ='" + strOrderTypeCode + "'";

            DataTable dtOrderType = cDBConnection.SearchData("tbl_OrderType", strWhere);

            if (dtOrderType.Rows.Count > 0)
            {
                oOrderType.LocationCode = dtOrderType.Rows[0]["fldLocationCode"].ToString();
                oOrderType.OrderTypeCode = dtOrderType.Rows[0]["fldOrderTypeCode"].ToString();
                oOrderType.OrderTypeName = dtOrderType.Rows[0]["fldOrderTypeName"].ToString();
                oOrderType.Status = Convert.ToInt16(dtOrderType.Rows[0]["fldStatus"]);

                oOrderType.IsExists = true;
            }
            else
            {
                oOrderType.IsExists = false;
            }
            return oOrderType;
        }
    }
}
