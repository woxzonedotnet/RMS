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
    public class clsUserLevel
    {
        #region Object
        objUserLevel oUserLevel = new objUserLevel();
        clsDBConnection cDBConnection = new clsDBConnection();
        #endregion

        #region Variable

        #endregion

        #region DefaultRolls
        public DataTable getDefaultRolls()
        {
            DataTable dtDefaultRolls = cDBConnection.SearchData("tbl_UserDefaultRolls");
            return dtDefaultRolls;
        }
        #endregion

        #region Get User Level Data using Code
        public objUserLevel GetUserLevelData(string strLocationCode, string strUserLevelCode)
        {
            string strWhere1 = "fldUserLevelCode='" + strUserLevelCode + "' AND fldLocationCode='" + strLocationCode + "'";
            string strWhere2 = "fldUserLevelCode='" + strUserLevelCode + "'";

            DataTable dtULDetails = cDBConnection.SearchData("tbl_UserLevelHeader", strWhere1);
            DataTable dtULItemList = cDBConnection.SearchData("tbl_UserLevelDetails", strWhere2);

            if (dtULDetails.Rows.Count > 0)
            {

                oUserLevel.LocationCode = dtULDetails.Rows[0]["fldLocationCode"].ToString();
                oUserLevel.UserLevelCode = dtULDetails.Rows[0]["fldUserLevelCode"].ToString();
                oUserLevel.UserLevel = dtULDetails.Rows[0]["fldUserLevel"].ToString();
                oUserLevel.Status = Convert.ToInt16(dtULDetails.Rows[0]["fldStatus"]);
                oUserLevel.Changeable = Convert.ToBoolean(dtULDetails.Rows[0]["fldChangeable"]);

                //Access Roll Table
                oUserLevel.dtItemList = dtULItemList;

                oUserLevel.IsExists = true;
            }
            else
            {
                oUserLevel.IsExists = false;
            }


            return oUserLevel;
        }
        #endregion

        #region Get User Level Data
        public DataTable GetUserLevelData()
        {
            
            DataTable dtULDetails = cDBConnection.SearchData("tbl_UserLevelHeader");

            return dtULDetails;
        }
        #endregion

        #region Get User Level Data
        public DataTable GetActiveUserLevelData()
        {
            DataTable dtULDetails = cDBConnection.SearchData("tbl_UserLevelHeader", "fldStatus=1");
            return dtULDetails;
        }
        #endregion


        #region Get User Level Access
        public DataTable GetUserLevelData(string Level)
        {
            string where = "fldUserLevelCode='" + Level + "'";
            DataTable dtULItemList = cDBConnection.SearchData("tbl_UserLevelDetails", where);
            return dtULItemList;
        }
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objUserLevel oUserLevel)
        {
            System.Object[,] arrParameter = new Object[6, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oUserLevel.LocationCode;
            arrParameter[1, 0] = "@mfldUserLevelCode";
            arrParameter[1, 1] = oUserLevel.UserLevelCode;
            arrParameter[2, 0] = "@mfldUserLevel";
            arrParameter[2, 1] = oUserLevel.UserLevel;
            arrParameter[3, 0] = "@mfldStatus";
            arrParameter[3, 1] = oUserLevel.Status;
            arrParameter[4, 0] = "@mfldChangeable";
            arrParameter[4, 1] = oUserLevel.Changeable;
            arrParameter[5, 0] = "@mflddtItemList";
            arrParameter[5, 1] = oUserLevel.dtItemList;

            return cDBConnection.Insert("sp_insert_update_UserLevel", arrParameter);
        }
        #endregion
    }
}
