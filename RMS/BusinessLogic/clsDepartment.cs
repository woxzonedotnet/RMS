﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class clsDepartment
    {
        #region Object
        objDepartment oDepartment = new objDepartment();
        clsDBConnection cDBConnection = new clsDBConnection();
        #endregion

        #region Variable


        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objDepartment oDepartment)
        {
            System.Object[,] arrParameter = new Object[3, 2];

            arrParameter[0, 0] = "@mfldMainLocation";
            arrParameter[0, 1] = oDepartment.LocationCode;
            arrParameter[1, 0] = "@mfldDepartmentCode";
            arrParameter[1, 1] = oDepartment.DepartmentCode;
            arrParameter[2, 0] = "@mfldDepartmentName";
            arrParameter[2, 1] = oDepartment.DepartmentName;

            return cDBConnection.Insert("sp_insert_update_department", arrParameter);
        }
        #endregion

        #region GetDepartment Data Using DepartmentCode
        public objDepartment GetDepartmentData(string strLocationCode,string strDepartmentCode)
        {
            string strWhere = "fldMainLocation='" + strLocationCode + "' AND fldDepartmentCode='" + strDepartmentCode + "'";

            DataTable dtDepartment = cDBConnection.SearchData("tbl_DepartmentMaster", strWhere);

            if (dtDepartment.Rows.Count > 0)
            {
                oDepartment.LocationCode = dtDepartment.Rows[0][1].ToString();
                oDepartment.DepartmentCode = dtDepartment.Rows[0][2].ToString();
                oDepartment.DepartmentName = dtDepartment.Rows[0][3].ToString();

                oDepartment.IsExists = true;
            }
            else
            {
                oDepartment.IsExists = false;
            }

            return oDepartment;
        }
        #endregion
    }
}