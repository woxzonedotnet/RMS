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
  

    public class clsMenuDetails
    {
       #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objMenuDetails oMenuDetails = new objMenuDetails();
        #endregion

       #region Get Menu Data using MenuCode
        public objMenuDetails GetMenuData(string strLocationCode, string strMenuDetailsCode)
        {
            string strWhere1 = "fldMenuCode='" + strMenuDetailsCode + "' AND fldLocationCode='" + strLocationCode + "'";
            string strWhere2 = "fldMenuCode='" + strMenuDetailsCode + "'";

            DataTable dtMenuDetails = cDBConnection.SearchData("tbl_MenuDetails", strWhere1);
            DataTable dtMenuRecipe = cDBConnection.SearchData("tbl_MenuRecipe", strWhere2);
            DataTable dtMenuLocation = cDBConnection.SearchData("tbl_MenuLocation", strWhere2);

            if (dtMenuDetails.Rows.Count > 0)
            {
                oMenuDetails.LocationCode = dtMenuDetails.Rows[0]["fldLocationCode"].ToString();
                oMenuDetails.MenuCode = dtMenuDetails.Rows[0]["fldMenuCode"].ToString();
                oMenuDetails.FullDescription = dtMenuDetails.Rows[0]["fldDescription"].ToString();
                oMenuDetails.BillDescription = dtMenuDetails.Rows[0]["fldDescriptionBill"].ToString();
                oMenuDetails.SubLocationCode = dtMenuDetails.Rows[0]["fldSubLocationCode"].ToString();
                oMenuDetails.PrintLocationCode = dtMenuDetails.Rows[0]["fldPrintLocation"].ToString();
                oMenuDetails.MenuDepartmentCode = dtMenuDetails.Rows[0]["fldMenuDepartmentCode"].ToString();
                oMenuDetails.MenuCategoryCode = dtMenuDetails.Rows[0]["fldMenuCategoryCode"].ToString();
                oMenuDetails.SellingPrice = Convert.ToDouble(dtMenuDetails.Rows[0]["fldSellingPrice"].ToString());
                oMenuDetails.PackingCharges =  Convert.ToDouble(dtMenuDetails.Rows[0]["fldPackingCharge"].ToString());
                oMenuDetails.TimeToPrepare = Convert.ToInt32(dtMenuDetails.Rows[0]["fldTimeToPrepare"].ToString());
                oMenuDetails.ButtonBackground = dtMenuDetails.Rows[0]["fldBackgroundColor"].ToString();
                oMenuDetails.ButtonForground = dtMenuDetails.Rows[0]["fldForegroundColor"].ToString();
                oMenuDetails.photo_aray = Encoding.ASCII.GetBytes(dtMenuDetails.Rows[0]["fldImage"].ToString());
                oMenuDetails.FileName = dtMenuDetails.Rows[0]["fldFileName"].ToString();
                oMenuDetails.ButtonName = dtMenuDetails.Rows[0]["fldButtonName"].ToString();
                oMenuDetails.FontName = dtMenuDetails.Rows[0]["fldFontName"].ToString();
                oMenuDetails.FontSize = Convert.ToDouble(dtMenuDetails.Rows[0]["fldFontSize"].ToString());
                oMenuDetails.FontStyle = dtMenuDetails.Rows[0]["fldFontStyle"].ToString();
                oMenuDetails.ServiceCharge = Convert.ToBoolean(dtMenuDetails.Rows[0]["fldServiceCharge"].ToString());
                oMenuDetails.TotalCost= Convert.ToDouble(dtMenuDetails.Rows[0]["fldTotalMenuCost"].ToString());
                oMenuDetails.Status = Convert.ToInt32(dtMenuDetails.Rows[0]["fldStatus"].ToString());

                //Recipe Table
                oMenuDetails.dtRecipeDetails = dtMenuRecipe;

                //Location Table
                oMenuDetails.dtLocation = dtMenuLocation;

                oMenuDetails.IsExists = true;
            }
            else
            {
                oMenuDetails.IsExists = false;
            }
            return oMenuDetails;
        }
        #endregion

       #region InsertUpdateData
        public int InsertUpdateData(objMenuDetails oMenuDetails)
        {
            System.Object[,] arrParameter = new Object[24, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oMenuDetails.LocationCode;
            arrParameter[1, 0] = "@mfldMenuCode";
            arrParameter[1, 1] = oMenuDetails.MenuCode;
            arrParameter[2, 0] = "@mfldFullDescription";
            arrParameter[2, 1] = oMenuDetails.FullDescription;
            arrParameter[3, 0] = "@mfldBillDescription";
            arrParameter[3, 1] = oMenuDetails.BillDescription;
            arrParameter[4, 0] = "@mfldSubLocationCode";
            arrParameter[4, 1] = oMenuDetails.SubLocationCode;
            arrParameter[5, 0] = "@mfldPrintLocationCode";
            arrParameter[5, 1] = oMenuDetails.PrintLocationCode;
            arrParameter[6, 0] = "@mfldMenuDepartmentCode";
            arrParameter[6, 1] = oMenuDetails.MenuDepartmentCode;
            arrParameter[7, 0] = "@mfldMenuCategoryCode";
            arrParameter[7, 1] = oMenuDetails.MenuCategoryCode;
            arrParameter[8, 0] = "@mfldSellingPrice";
            arrParameter[8, 1] = oMenuDetails.SellingPrice;
            arrParameter[9, 0] = "@mfldPackingCharges";
            arrParameter[9, 1] = oMenuDetails.PackingCharges;
            arrParameter[10, 0] = "@mfldTimeToPrepare";
            arrParameter[10, 1] = oMenuDetails.TimeToPrepare;
            arrParameter[11, 0] = "@mfldButtonBackground";
            arrParameter[11, 1] = oMenuDetails.ButtonBackground;
            arrParameter[12, 0] = "@mfldButtonForground";
            arrParameter[12, 1] = oMenuDetails.ButtonForground;
            arrParameter[13, 0] = "@mfldImage";
            arrParameter[13, 1] = oMenuDetails.photo_aray;
            arrParameter[14, 0] = "@mfldFileName";
            arrParameter[14, 1] = oMenuDetails.FileName;
            arrParameter[15, 0] = "@mfldButtonName";
            arrParameter[15, 1] = oMenuDetails.ButtonName;
            arrParameter[16, 0] = "@mfldFontName";
            arrParameter[16, 1] = oMenuDetails.FontName;
            arrParameter[17, 0] = "@mfldFontSize";
            arrParameter[17, 1] = oMenuDetails.FontSize;
            arrParameter[18, 0] = "@mfldFontStyle";
            arrParameter[18, 1] = oMenuDetails.FontStyle;
            arrParameter[19, 0] = "@mfldServiceCharge";
            arrParameter[19, 1] = oMenuDetails.ServiceCharge;
            arrParameter[20, 0] = "@mfldTotalCost";
            arrParameter[20, 1] = oMenuDetails.TotalCost;
            arrParameter[21, 0] = "@mfldStatus";
            arrParameter[21, 1] = oMenuDetails.Status;
            arrParameter[22, 0] = "@mflddtRecipeDetails";
            arrParameter[22, 1] = oMenuDetails.dtRecipeDetails;
            arrParameter[23, 0] = "@mflddtLocation";
            arrParameter[23, 1] = oMenuDetails.dtLocation;
            
            
            return cDBConnection.Insert("sp_insert_update_MenuDetails", arrParameter);
        }
        #endregion
        
    }
}
