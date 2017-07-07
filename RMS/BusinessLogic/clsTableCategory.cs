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
    public class clsTableCategory
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objTableCategory oTableCategory = new objTableCategory();
        #endregion

        #region GetTableCategory Data Using TableCategoryCode
        public objTableCategory GetTableCategoryData(string strLocationCode, string strTableCategoryCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' AND fldTableCategoryCode='" + strTableCategoryCode + "'";

            DataTable dtTableCategory = cDBConnection.SearchData("tbl_TableCategoryMaster", strWhere);

            if (dtTableCategory.Rows.Count > 0)
            {
                oTableCategory.LocationCode = dtTableCategory.Rows[0][0].ToString();
                oTableCategory.TableCategoryCode = dtTableCategory.Rows[0][1].ToString();
                oTableCategory.TableCategoryName = dtTableCategory.Rows[0][2].ToString();
                oTableCategory.Status = Convert.ToInt16(dtTableCategory.Rows[0][3]);

                oTableCategory.IsExists = true;
            }
            else
            {
                oTableCategory.IsExists = false;
            }

            return oTableCategory;
        }
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objTableCategory oTableCategory)
        {
            System.Object[,] arrParameter = new Object[4, 2];
                                                                                                                                                                                                                                                                                                                                                    
            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oTableCategory.LocationCode;
            arrParameter[1, 0] = "@mfldTableCategoryCode";
            arrParameter[1, 1] = oTableCategory.TableCategoryCode;
            arrParameter[2, 0] = "@mfldTableCategoryName";
            arrParameter[2, 1] = oTableCategory.TableCategoryName;
            arrParameter[3, 0] = "@mfldTableCategoryStatus";
            arrParameter[3, 1] = oTableCategory.Status;

            return cDBConnection.Insert("SP_INSERT_UPDATE_TABLE_CATEGORY", arrParameter);
        }
        #endregion
    }
}
