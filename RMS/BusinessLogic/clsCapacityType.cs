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
    public class clsCapacityType
    {
        #region Object
        objCapacityType oCapacityType = new objCapacityType();
        clsDBConnection cDBConnection = new clsDBConnection();
        #endregion

        #region GetCapacity Data
        public DataTable GetCapacityData()
        {
            DataTable dtCapacity = cDBConnection.SearchData("tbl_Capacity");
            return dtCapacity;
        }
        #endregion

        #region GetCapacity Data By Code
        public string GetCapacityDataByCode(string strCapacityCode)
        {
            string strWhere = "fldCapacityCode='" + strCapacityCode + "'";
            DataTable dtCapacity = cDBConnection.SearchData("tbl_Capacity",strWhere);
            if (dtCapacity.Rows.Count > 0)
            {
                oCapacityType.CapacityCode = dtCapacity.Rows[0][0].ToString();
                oCapacityType.CapacityName = dtCapacity.Rows[0][1].ToString();
                oCapacityType.CapacitySymbol = dtCapacity.Rows[0][2].ToString();

                //oMenuCategory.IsExists = true;
            }
            else
            {
                //oMenuCategory.IsExists = false;
            }

            return oCapacityType.CapacityName;
        }
        #endregion
    }
}
