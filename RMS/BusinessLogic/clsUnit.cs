using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class clsUnit
    {
        #region Object
        objUnit oCapacityType = new objUnit();
        clsDBConnection cDBConnection = new clsDBConnection();
        #endregion

        #region GetCapacity Data
        public DataTable GetUnitData()
        {
            DataTable dtCapacity = cDBConnection.SearchData("tbl_Unit");
            return dtCapacity;
        }
        #endregion

        public DataTable GetUnitSize()
        {
            DataTable dtCapacitySize = cDBConnection.SearchData("tbl_UnitSize");
            return dtCapacitySize;
        }



        #region GetUnit Data By Code
        public objUnit GetUnitDataByCode(string strUnitSymbol)
        {
            string strWhere = "fldUnitSymbol='" + strUnitSymbol + "'";
            DataTable dtUnit = cDBConnection.SearchData("tbl_Unit", strWhere);

            if (dtUnit.Rows.Count > 0)
            {
                oCapacityType.UnitCode = dtUnit.Rows[0]["fldUnitCode"].ToString();
                oCapacityType.UnitName = dtUnit.Rows[0]["fldUnitName"].ToString();
                oCapacityType.UnitSymbol = dtUnit.Rows[0]["fldUnitSymbol"].ToString();

                oCapacityType.IsExists = true;
            }
            else
            {
                oCapacityType.IsExists = false;
            }
            return oCapacityType;
        }
        #endregion
    }
}
