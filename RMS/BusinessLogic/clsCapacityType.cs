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

        #region GetDepartment Data
        public DataTable GetCapacityData()
        {
            DataTable dtCapacity = cDBConnection.SearchData("tbl_Capacity");
            return dtCapacity;
        }
        #endregion
    }
}
