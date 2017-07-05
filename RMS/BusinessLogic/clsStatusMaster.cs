using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using BusinessObject;

namespace BusinessLogic
{
    public class clsStatusMaster
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objStatusMaster oStatusMaster=new objStatusMaster();
        #endregion

        #region GetStatusDetails
        public DataTable GetStatusDetails()
        {
            DataTable dtStatusMaster = cDBConnection.SearchData("tbl_StatusMaster");
            return dtStatusMaster;
        }
        #endregion

        #region GetStatusDetails using StatusCode
        public string GetStatusByCode(int strStatusCode)
        {
            string strWhereString = "fldStatusCode ='" + strStatusCode + "'";

            DataTable dtStatusMaster = cDBConnection.SearchData("tbl_StatusMaster", strWhereString);

            if (dtStatusMaster.Rows.Count > 0)
            {
                oStatusMaster.StatusCode = Convert.ToInt16(dtStatusMaster.Rows[0][0]);
                oStatusMaster.StatusName = dtStatusMaster.Rows[0][1].ToString();
                oStatusMaster.IsExistStatus = true;
            }
            else
            {
                oStatusMaster.IsExistStatus = false;
            }
            return oStatusMaster.StatusName;
        }
        #endregion
    }
}
