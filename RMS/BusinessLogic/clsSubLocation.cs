using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess;


namespace BusinessLogic
{
    public class clsSubLocation
    {
        #region Objects
        //objSubLocation oSubLocation = new objSubLocation();
        clsDBConnection cDBConnection = new clsDBConnection(); 
        #endregion

        #region Variables

        #endregion

        public int InsertUpdateData(objSubLocation oSubLocation)
        {
            System.Object[,] arrParameter = new Object[5, 2];

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

            return cDBConnection.Insert("sp_insert_update_sublocation", arrParameter);
        }
    }
}
