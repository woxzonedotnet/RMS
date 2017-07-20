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
    public class clsCategoryMaster
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objCategoryMaster oCategoryMaster = new objCategoryMaster();
        #endregion

        #region GetCategory Data Using CategoryCode
        public objCategoryMaster GetCategoryData(string strLocationCode, string strCategoryCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' AND fldCategoryCode='" + strCategoryCode + "'";

            DataTable dtDepartment = cDBConnection.SearchData("tbl_CategoryMaster", strWhere);

            if (dtDepartment.Rows.Count > 0)
            {
                oCategoryMaster.LocationCode = dtDepartment.Rows[0][0].ToString();
                oCategoryMaster.DepartmentCode = dtDepartment.Rows[0][1].ToString();
                oCategoryMaster.CategoryCode = dtDepartment.Rows[0][2].ToString();
                oCategoryMaster.CategoryName = dtDepartment.Rows[0][3].ToString();
                oCategoryMaster.Status = Convert.ToInt16(dtDepartment.Rows[0][4]);

                oCategoryMaster.IsExistCategory = true;
            }
            else
            {
                oCategoryMaster.IsExistCategory = false;
            }

            return oCategoryMaster;
        }
        #endregion

        #region GetCategory Data
        public DataTable GetCategoryDataByDepartment(string strLocationCode, string strDepartmentCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' and fldDepartmentCode='" + strDepartmentCode + "' and fldStatus=1";
            DataTable dtCategory = cDBConnection.SearchData("tbl_CategoryMaster", strWhere);
            return dtCategory;
        }
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objCategoryMaster oCategoryMaster)
        {
            System.Object[,] arrParameter = new Object[5, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oCategoryMaster.LocationCode;
            arrParameter[1, 0] = "@mfldDepartmentCode";
            arrParameter[1, 1] = oCategoryMaster.DepartmentCode;
            arrParameter[2, 0] = "@mfldCategoryCode";
            arrParameter[2, 1] = oCategoryMaster.CategoryCode;
            arrParameter[3, 0] = "@mfldCategoryName";
            arrParameter[3, 1] = oCategoryMaster.CategoryName;
            arrParameter[4, 0] = "@mfldStatus";
            arrParameter[4, 1] = oCategoryMaster.Status;

            return cDBConnection.Insert("SP_INSERT_UPDATE_CATEGORY_MASTER", arrParameter);
        }
        #endregion
    }
}
