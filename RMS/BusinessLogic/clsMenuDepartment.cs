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
    public class clsMenuDepartment
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objMenuDepartment oMenuDepartment = new objMenuDepartment();
        #endregion

        #region GetMenuDepartment Data Using MenuDepartmentCode
        public objMenuDepartment GetMenuDepartmentData(string strLocationCode, string strMenuDepartmentCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' AND fldMenuDepartmentCode='" + strMenuDepartmentCode + "'";

            DataTable dtMenuDepartment = cDBConnection.SearchData("tbl_MenuDepartment", strWhere);

            if (dtMenuDepartment.Rows.Count > 0)
            {
                oMenuDepartment.LocationCode = dtMenuDepartment.Rows[0][0].ToString();
                oMenuDepartment.MenuDepartmentCode = dtMenuDepartment.Rows[0][1].ToString();
                oMenuDepartment.MenuDepartmentName = dtMenuDepartment.Rows[0][2].ToString();
                oMenuDepartment.Status = Convert.ToInt16(dtMenuDepartment.Rows[0][3]);

                oMenuDepartment.IsExists = true;
            }
            else
            {
                oMenuDepartment.IsExists = false;
            }

            return oMenuDepartment;
        }
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objMenuDepartment oMenuDepartment)
        {
            System.Object[,] arrParameter = new Object[4, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oMenuDepartment.LocationCode;
            arrParameter[1, 0] = "@mfldMenuDepartmentCode";
            arrParameter[1, 1] = oMenuDepartment.MenuDepartmentCode;
            arrParameter[2, 0] = "@mfldMenuDepartmentName";
            arrParameter[2, 1] = oMenuDepartment.MenuDepartmentName;
            arrParameter[3, 0] = "@mfldMenuDepartmentStatus";
            arrParameter[3, 1] = oMenuDepartment.Status;

            return cDBConnection.Insert("SP_INSERT_UPDATE_MENU_DEPARTMENT_MASTER", arrParameter);
        }
        #endregion
    }
}
