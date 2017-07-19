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
    public class clsSetupSetting
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objSetupSetting oSetupSetting = new objSetupSetting();
        #endregion

        #region Get SetupSetting Data
        public objSetupSetting GetSetupSettingData(string strLocationCode)
        {
            string where = "fldLocationCode='" + strLocationCode + "'";

            DataTable dtSetupSetting = cDBConnection.SearchData("tbl_SetupSetting",where);

            if (dtSetupSetting.Rows.Count > 0)
            {
                oSetupSetting.LocationCode = dtSetupSetting.Rows[0][0].ToString();
                oSetupSetting.ServiceCharge = Convert.ToDecimal(dtSetupSetting.Rows[0][1]);
                oSetupSetting.VAT = Convert.ToDecimal(dtSetupSetting.Rows[0][2]);
                oSetupSetting.GuidCharge = Convert.ToDecimal(dtSetupSetting.Rows[0][3]);

                oSetupSetting.IsExists = true;
            }
            else
            {
                oSetupSetting.IsExists = false;
            }

            return oSetupSetting;
        }
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objSetupSetting oSetupSetting)
        {
            System.Object[,] arrParameter = new Object[4, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oSetupSetting.LocationCode;
            arrParameter[1, 0] = "@mfldServiceCharge";
            arrParameter[1, 1] = oSetupSetting.ServiceCharge;
            arrParameter[2, 0] = "@mfldVAT";
            arrParameter[2, 1] = oSetupSetting.VAT;
            arrParameter[3, 0] = "@mfldGuidCharge";
            arrParameter[3, 1] = oSetupSetting.GuidCharge;

            return cDBConnection.Insert("SP_INSERT_UPDATE_SETUP_SETTING", arrParameter);
        }
        #endregion
    }
}
