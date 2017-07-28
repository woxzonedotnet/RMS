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


        #region Get Purchase Order Data using ItemCode
        public objRecipeDetails GetPurchaseOrderData(string strLocationCode, string strSubLocationCode, string strRecipeCode)
        {
            string strWhere1 = "fldLocationCode='" + strLocationCode + "' fldSubLocationCode='" + strSubLocationCode + "' AND fldRecipeCode='" + strRecipeCode + "'";
            string strWhere2 = "fldPOCode='" + strRecipeCode + "'";

            DataTable dtPODetails = cDBConnection.SearchData("tbl_RecipeHead", strWhere1);
            DataTable dtPOItemList = cDBConnection.SearchData("tbl_RecipeDetails", strWhere2);

            if (dtPODetails.Rows.Count > 0)
            {
                oRecipeDetails.LocationCode = dtPODetails.Rows[0]["fldLocationCode"].ToString();
                oRecipeDetails.SubLocationCode = dtPODetails.Rows[0]["fldSubLocationCode"].ToString();
                oRecipeDetails.RecipeCode = dtPODetails.Rows[0]["fldRecipeCode"].ToString();
                oRecipeDetails.RecipeName = dtPODetails.Rows[0]["fldRecipeName"].ToString();
                oRecipeDetails.OrderTypeCode = dtPODetails.Rows[0]["fldOrderTypeCode"].ToString();
                oRecipeDetails.RecipeCost = Convert.ToDouble(dtPODetails.Rows[0]["fldRecipeCost"]);

                oRecipeDetails.dtRecipeDetails = dtPOItemList;

                oRecipeDetails.IsExists = true;
            }
            else
            {
                oRecipeDetails.IsExists = false;
            }
            return oRecipeDetails;
        }
        #endregion

    }
}
