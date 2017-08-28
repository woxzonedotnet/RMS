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
    public class clsUserMaster
    {
        #region Object
        objUserMaster oUserMaster = new objUserMaster();
        clsDBConnection cDBConnection = new clsDBConnection();
        #endregion

        #region Variable

        #endregion

        #region Get User Data using Code
        public objUserMaster GetUserData(string strLocationCode, string strUserCode)
        {
            string strWhere1 = "fldUserCode='" + strUserCode + "' AND fldLocationCode='" + strLocationCode + "'";
            string strWhere2 = "fldUserCode='" + strUserCode + "'";

            DataTable dtUDetails = cDBConnection.SearchData("tbl_UserMaster", strWhere2);

            if (dtUDetails.Rows.Count > 0)
            {

                oUserMaster.LocationCode = dtUDetails.Rows[0]["fldLocationCode"].ToString();
                oUserMaster.UserCode = dtUDetails.Rows[0]["fldUserCode"].ToString();
                oUserMaster.UserName = dtUDetails.Rows[0]["fldUserName"].ToString();
                oUserMaster.Password = dtUDetails.Rows[0]["fldPassword"].ToString();
                oUserMaster.UserLevel = dtUDetails.Rows[0]["fldUserLevelCode"].ToString();
                oUserMaster.Status = Convert.ToInt16(dtUDetails.Rows[0]["fldStatus"]);
                oUserMaster.Changeable = Convert.ToBoolean(dtUDetails.Rows[0]["fldChangeable"]);


                oUserMaster.IsExists = true;
            }
            else
            {
                oUserMaster.IsExists = false;
            }


            return oUserMaster;
        }
        #endregion

        #region Get User Data
        public DataTable GetUserData()
        {

            DataTable dtUDetails = cDBConnection.SearchData("tbl_UserMaster");

            return dtUDetails;
        }
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objUserMaster oUserMaster)
        {
            System.Object[,] arrParameter = new Object[7, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oUserMaster.LocationCode;
            arrParameter[1, 0] = "@mfldUserCode";
            arrParameter[1, 1] = oUserMaster.UserCode;
            arrParameter[2, 0] = "@mfldUserName";
            arrParameter[2, 1] = oUserMaster.UserName;
            arrParameter[3, 0] = "@mfldPassword";
            arrParameter[3, 1] = oUserMaster.Password;
            arrParameter[4, 0] = "@mfldUserLevelCode";
            arrParameter[4, 1] = oUserMaster.UserLevel;
            arrParameter[5, 0] = "@mfldStatus";
            arrParameter[5, 1] = oUserMaster.Status;
            arrParameter[6, 0] = "@mfldChangeable";
            arrParameter[6, 1] = oUserMaster.Changeable;

            return cDBConnection.Insert("sp_insert_update_UserMaster", arrParameter);
        }
        #endregion
    }
}
