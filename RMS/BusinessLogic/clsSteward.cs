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
    public class clsSteward
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objSteward oSteward = new objSteward();
        #endregion



        #region GetDepartment Data Using DepartmentCode
        public objSteward GetStewardData(string strLocationCode, string strStewardCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' AND fldStewardCode='" + strStewardCode + "'";

            DataTable dtSteward = cDBConnection.SearchData("tbl_Steward", strWhere);

            if (dtSteward.Rows.Count > 0)
            {
                oSteward.LocationCode = dtSteward.Rows[0][0].ToString();
                oSteward.StewardCode = dtSteward.Rows[0][1].ToString();
                oSteward.StewardName = dtSteward.Rows[0][2].ToString();
                oSteward.Password = dtSteward.Rows[0][3].ToString();
                oSteward.Status = Convert.ToInt16(dtSteward.Rows[0][4]);

                oSteward.IsExits = true;
            }
            else
            {
                oSteward.IsExits = false;
            }

            return oSteward;
        }
        #endregion




        #region GetSteward Data
        public DataTable GetStewardData(string strLocationCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "'";
            DataTable dtSteward = cDBConnection.SearchData("tbl_Steward", strWhere);
            return dtSteward;
        }
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objSteward oSteward)
        {
            System.Object[,] arrParameter = new Object[5, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oSteward.LocationCode;
            arrParameter[1, 0] = "@mfldStewardCode";
            arrParameter[1, 1] = oSteward.StewardCode;
            arrParameter[2, 0] = "@mfldStewardName";
            arrParameter[2, 1] = oSteward.StewardName;
            arrParameter[4, 0] = "@mfldPassword";
            arrParameter[4, 1] = oSteward.Password;
            arrParameter[3, 0] = "@mfldStatus";
            arrParameter[3, 1] = oSteward.Status;

            return cDBConnection.Insert("SP_INSERT_UPDATE_STEWARD_MASTER", arrParameter);
        }
        #endregion
    }
}
