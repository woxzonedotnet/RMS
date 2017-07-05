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

        #region GetDepartment Data Using DepartmentCode
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
    }
}
