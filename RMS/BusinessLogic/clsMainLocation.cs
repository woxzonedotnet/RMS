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
    public class clsMainLocation
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objMainLocation oMainLocation = new objMainLocation();
        #endregion

        #region Get Main Location Data Using Main LocationCode
        public objMainLocation GetMainLocationData()
        {
            string strWhere = "fldLocationStatus='1'";

            DataTable dtMainLocation = cDBConnection.SearchData("tbl_LocationMaster", strWhere);

            if (dtMainLocation.Rows.Count > 0)
            {
                oMainLocation.MainLocationCode = dtMainLocation.Rows[0][0].ToString();
                oMainLocation.MainLocationName = dtMainLocation.Rows[0][1].ToString();
                oMainLocation.AddressLine1 = dtMainLocation.Rows[0][2].ToString();
                oMainLocation.AddressLine2 = dtMainLocation.Rows[0][3].ToString();
                oMainLocation.AddressLine3 = dtMainLocation.Rows[0][4].ToString();
                oMainLocation.TelephoneNo = dtMainLocation.Rows[0][5].ToString();
                oMainLocation.FaxNo = dtMainLocation.Rows[0][6].ToString();
                oMainLocation.Email = dtMainLocation.Rows[0][7].ToString();
                oMainLocation.Status = Convert.ToInt16(dtMainLocation.Rows[0][8]);

                oMainLocation.IsExists = true;
            }
            else
            {
                oMainLocation.IsExists = false;
            }

            return oMainLocation;
        }
        #endregion

        #region Get Main Location Details
        public DataTable GetMainLocationDetails()
        {
            DataTable dtMainLocation = cDBConnection.SearchData("tbl_LocationMaster");
            return dtMainLocation;
        }
        #endregion
    }
}
