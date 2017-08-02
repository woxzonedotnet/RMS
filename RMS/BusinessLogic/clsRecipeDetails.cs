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


        #region Get Recipe Data using RecipeCode
        public objRecipeDetails GetRecipeData(string strLocationCode, string strRecipeCode)
        {
            string strWhere1 = "fldLocationCode='" + strLocationCode + "' AND fldRecipeCode='" + strRecipeCode + "'";
            string strWhere2 = "fldRecipeCode='" + strRecipeCode + "'";

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

        public objRecipeDetails GetRecipeData(string strLocationCode, string strSubLocationCode, string strRecipeCode)
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


        #region InsertUpdateData
        public int InsertUpdateData(objRecipeDetails oRecipeDetails)
        {
            System.Object[,] arrParameter = new Object[7, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oRecipeDetails.LocationCode;
            arrParameter[1, 0] = "@mfldSubLocationCode";
            arrParameter[1, 1] = oRecipeDetails.SubLocationCode;
            arrParameter[2, 0] = "@mfldRecipeCode";
            arrParameter[2, 1] = oRecipeDetails.RecipeCode;
            arrParameter[3, 0] = "@mfldRecipeName";
            arrParameter[3, 1] = oRecipeDetails.RecipeName;
            arrParameter[4, 0] = "@mfldOrderTypeCode";
            arrParameter[4, 1] = oRecipeDetails.OrderTypeCode;
            arrParameter[5, 0] = "@mfldRecipeCost";
            arrParameter[5, 1] = oRecipeDetails.RecipeCost;
            arrParameter[6, 0] = "@mflddtItemList";
            arrParameter[6, 1] = oRecipeDetails.dtRecipeDetails;
            

            return cDBConnection.Insert("sp_insert_update_Recipe", arrParameter);
        }
        #endregion

    }
}
