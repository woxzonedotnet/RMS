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
    public class clsMenuCategory
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objMenuCategory oMenuCategory = new objMenuCategory(); 
        #endregion

        #region GetMenuCategory Data Using MenuDepartmentCode & MenuCategoryCode
        public objMenuCategory GetMenuCategoryData(string strLocationCode, string strMenuDepartmentCode,string strMenuCategoryCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' AND fldMenuDepartmentCode='" + strMenuDepartmentCode + "' and fldMenuCategoryCode='"+ strMenuCategoryCode +"'";

            DataTable dtMenuCategory = cDBConnection.SearchData("tbl_MenuCategory", strWhere);

            if (dtMenuCategory.Rows.Count > 0)
            {
                oMenuCategory.LocationCode = dtMenuCategory.Rows[0][0].ToString();
                oMenuCategory.MenuDepartmentCode = dtMenuCategory.Rows[0][1].ToString();
                oMenuCategory.MenuCategoryCode = dtMenuCategory.Rows[0][2].ToString();
                oMenuCategory.MenuCategoryName = dtMenuCategory.Rows[0][3].ToString();
                oMenuCategory.Status = Convert.ToInt16(dtMenuCategory.Rows[0][4]);

                oMenuCategory.IsExists = true;
            }
            else
            {
                oMenuCategory.IsExists = false;
            }

            return oMenuCategory;
        }
        #endregion

        #region GetMenuCategory Data
        public DataTable GetMenuCategoryData(string strLocationCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' and fldStatus=1";
            DataTable dtMenuCategory = cDBConnection.SearchData("tbl_MenuCategory", strWhere);
            return dtMenuCategory;
        }
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objMenuCategory oMenuCategory)
        {
            System.Object[,] arrParameter = new Object[5, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oMenuCategory.LocationCode;
            arrParameter[1, 0] = "@mfldMenuDepartmentCode";
            arrParameter[1, 1] = oMenuCategory.MenuDepartmentCode;
            arrParameter[2, 0] = "@mfldMenuCategoryCode";
            arrParameter[2, 1] = oMenuCategory.MenuCategoryCode;
            arrParameter[3, 0] = "@mfldMenuCategoryName";
            arrParameter[3, 1] = oMenuCategory.MenuCategoryName;
            arrParameter[4, 0] = "@mfldMenuCategoryStatus";
            arrParameter[4, 1] = oMenuCategory.Status;

            return cDBConnection.Insert("SP_INSERT_UPDATE_MENU_CATEGORY_MASTER", arrParameter);
        }
        #endregion
    }
}
