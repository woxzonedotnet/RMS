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
    public class clsDepartment
    {
        #region Object
        objDepartment oDepartment = new objDepartment();
        clsDBConnection cDBConnection = new clsDBConnection();
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objDepartment oDepartment)
        {
            System.Object[,] arrParameter = new Object[4, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oDepartment.LocationCode;
            arrParameter[1, 0] = "@mfldDepartmentCode";
            arrParameter[1, 1] = oDepartment.DepartmentCode;
            arrParameter[2, 0] = "@mfldDepartmentName";
            arrParameter[2, 1] = oDepartment.DepartmentName;
            arrParameter[3, 0] = "@mfldDepartmentStatus";
            arrParameter[3, 1] = oDepartment.Status;

            return cDBConnection.Insert("SP_INSERT_UPDATE_DEPARTMENT_MASTER", arrParameter);
        }
        #endregion

        #region GetDepartment Data Using DepartmentCode
        public objDepartment GetDepartmentData(string strLocationCode,string strDepartmentCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' AND fldDepartmentCode='" + strDepartmentCode + "'";

            DataTable dtDepartment = cDBConnection.SearchData("tbl_DepartmentMaster", strWhere);

            if (dtDepartment.Rows.Count > 0)
            {
                oDepartment.LocationCode = dtDepartment.Rows[0][0].ToString();
                oDepartment.DepartmentCode = dtDepartment.Rows[0][1].ToString();
                oDepartment.DepartmentName = dtDepartment.Rows[0][2].ToString();
                oDepartment.Status=Convert.ToInt16(dtDepartment.Rows[0][3]);

                oDepartment.IsExists = true;
            }
            else
            {
                oDepartment.IsExists = false;
            }

            return oDepartment;
        }

        public string GetDepartmentDataByCode(string strDepartmentCode)
        {
            string strWhere = "fldDepartmentCode='" + strDepartmentCode + "'";

            DataTable dtDepartment = cDBConnection.SearchData("tbl_DepartmentMaster", strWhere);

            if (dtDepartment.Rows.Count > 0)
            {
                oDepartment.LocationCode = dtDepartment.Rows[0][0].ToString();
                oDepartment.DepartmentCode = dtDepartment.Rows[0][1].ToString();
                oDepartment.DepartmentName = dtDepartment.Rows[0][2].ToString();
                oDepartment.Status = Convert.ToInt16(dtDepartment.Rows[0][3]);

                oDepartment.IsExists = true;
            }
            else
            {
                oDepartment.IsExists = false;
            }

            return oDepartment.DepartmentName;
        }
        #endregion

        #region GetDepartment Data
        public DataTable GetDepartmentData(string strLocationCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' and fldStatus=1";
            DataTable dtDepartment = cDBConnection.SearchData("tbl_DepartmentMaster", strWhere);
            return dtDepartment;
        }
        #endregion

        #region  GetDepartment
        public DataTable GetDepartment()
        {
            DataTable dtDepartment = cDBConnection.SearchData("tbl_DepartmentMaster");
            return dtDepartment;
        }
        #endregion


        public DataTable GetDepartmentData(global::System.Drawing.Point Location)
        {
            throw new NotImplementedException();
        }

        
    }
}
