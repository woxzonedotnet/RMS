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
    public class clsRecipeDetails
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objRecipeDetails oRecipeDetails = new objRecipeDetails();
        #endregion

        #region GetOrderType Data
        public DataTable GetOrderTypeData()
        {
            
            DataTable dtOrderType = cDBConnection.SearchData("tbl_OrderType");
            return dtOrderType;
        }
        #endregion
        

       
       



    }
}
