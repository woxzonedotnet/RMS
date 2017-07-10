﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinessObject;
using System.Data;

namespace BusinessLogic
{
    public class clsSupplierCategory
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objSupplierCategory oSupplierCategory = new objSupplierCategory();
        #endregion


        #region GetSupplierCategory Data Using SupplierCategoryCode
        public objSupplierCategory GetSupplierCategoryData(string strLocationCode, string strSupplierCategoryCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' AND fldSupplierCategoryCode='" + strSupplierCategoryCode + "'";

            DataTable dtSupplierCategory = cDBConnection.SearchData("tbl_SupplierCategory", strWhere);

            if (dtSupplierCategory.Rows.Count > 0)
            {
                oSupplierCategory.LocationCode = dtSupplierCategory.Rows[0][0].ToString();
                oSupplierCategory.SupplierCode = dtSupplierCategory.Rows[0][1].ToString();
                oSupplierCategory.Description = dtSupplierCategory.Rows[0][2].ToString();
                oSupplierCategory.Status = Convert.ToInt16(dtSupplierCategory.Rows[0][3]);
                oSupplierCategory.IsExists = true;
            }
            else
            {
                oSupplierCategory.IsExists = false;
            }
            return oSupplierCategory;
        }
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objSupplierCategory oSupplierCategory)
        {
            System.Object[,] arrParameter = new Object[4, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oSupplierCategory.LocationCode;
            arrParameter[1, 0] = "@mfldSupplierCategoryCode";
            arrParameter[1, 1] = oSupplierCategory.SupplierCode;
            arrParameter[2, 0] = "@mfldDescription";
            arrParameter[2, 1] = oSupplierCategory.Description;
            arrParameter[3, 0] = "@mfldStatus";
            arrParameter[3, 1] = oSupplierCategory.Status;

            return cDBConnection.Insert("SP_INSERT_UPDATE_SUPPLIER_CATEGORY", arrParameter);
        }
        #endregion
    }
}