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
    public class clsSubLocation
    {
        #region Objects
        objSubLocation oSubLocation = new objSubLocation();
        clsDBConnection cDBConnection = new clsDBConnection(); 
        #endregion

        #region Variables

        #endregion

        public int InsertUpdateData(objSubLocation oSubLocation)
        {
            System.Object[,] arrParameter = new Object[6, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oSubLocation.LocationCode;
            arrParameter[1, 0] = "@mfldSubLocationCode";
            arrParameter[1, 1] = oSubLocation.SubLocationCode;
            arrParameter[2, 0] = "@mfldSubLocationName";
            arrParameter[2, 1] = oSubLocation.SubLocationName;
            arrParameter[3, 0] = "@mfldShowInFrontEnd";
            arrParameter[3, 1] = oSubLocation.ShowInFrontEnd;
            arrParameter[4, 0] = "@mfldIsOrderLocation";
            arrParameter[4, 1] = oSubLocation.IsOrderLocation;
            arrParameter[5, 0] = "@mfldStatus";
            arrParameter[5, 1] = oSubLocation.Status;

            return cDBConnection.Insert("SP_INSERT_UPDATE_SUBLOCATION_MASTER", arrParameter);
        }

        #region GetSubLocation Data Using LocationCode and SubLocationCode
        public objSubLocation GetSubLocationData(string strLocationCode, string strSubLocationCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' AND fldSubLocationCode ='" + strSubLocationCode + "'";

            DataTable dtSubLocation = cDBConnection.SearchData("tbl_SubLocation", strWhere);

            if (dtSubLocation.Rows.Count > 0)
            {
                oSubLocation.LocationCode = dtSubLocation.Rows[0][0].ToString();
                oSubLocation.SubLocationCode = dtSubLocation.Rows[0][1].ToString();
                oSubLocation.SubLocationName = dtSubLocation.Rows[0][2].ToString();
                oSubLocation.ShowInFrontEnd = Convert.ToBoolean(dtSubLocation.Rows[0][3]);
                oSubLocation.IsOrderLocation = Convert.ToBoolean(dtSubLocation.Rows[0][4]);
                oSubLocation.Status=Convert.ToInt16(dtSubLocation.Rows[0][5]);

                oSubLocation.IsExists = true;
            }
            else
            {
                oSubLocation.IsExists = false;
            }

            return oSubLocation;
        }
        #endregion

        #region GetSubLocation Data using LocationCode
        public DataTable GetSubLocationData(string strLocationCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' and fldActiveStatus=1";
            DataTable dtSubLocation = cDBConnection.SearchData("tbl_SubLocation", strWhere);
            return dtSubLocation;
        }
        #endregion

        #region GetSubLocation
        public DataTable GetSubLocationData()
        {
            DataTable dtSubLocation = cDBConnection.SearchData("tbl_SubLocation");
            return dtSubLocation;
        }
        #endregion

        #region Delete Location details By Category Code
        public int DeleteLocationData(string SearchValue)
        {
            string strWhereString = "fldSubLocationCode='" + SearchValue + "'";
            return cDBConnection.DeleteData("tbl_SubLocation", strWhereString);
        }
        # endregion
    }
}
