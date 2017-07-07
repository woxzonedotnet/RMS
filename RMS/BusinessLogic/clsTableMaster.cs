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
    public class clsTableMaster
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objTableMaster oTableMaster = new objTableMaster();
        #endregion

        #region GetTableMaster Data Using TableCategoryCode and TableCode
        public objTableMaster GetTableMasterData(string strLocationCode, string strTableCategoryCode,string strTableCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' AND fldTableCategoryCode='" + strTableCategoryCode + "' and fldTableCode = '" + strTableCode + "'";

            DataTable dtTableMaster = cDBConnection.SearchData("tbl_TableMaster", strWhere);

            if (dtTableMaster.Rows.Count > 0)
            {
                oTableMaster.LocationCode = dtTableMaster.Rows[0][0].ToString();
                oTableMaster.TableCategoryCode = dtTableMaster.Rows[0][1].ToString();
                oTableMaster.TableCode = dtTableMaster.Rows[0][2].ToString();
                oTableMaster.SubLocationCode = dtTableMaster.Rows[0][3].ToString();
                oTableMaster.TableSeats=Convert.ToInt16(dtTableMaster.Rows[0][4]);
                oTableMaster.TableStatus = Convert.ToInt16(dtTableMaster.Rows[0][5]);

                oTableMaster.IsExists = true;
            }
            else
            {
                oTableMaster.IsExists = false;
            }

            return oTableMaster;
        }
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objTableMaster oTableMaster)
        {
            System.Object[,] arrParameter = new Object[6, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oTableMaster.LocationCode;
            arrParameter[1, 0] = "@mfldTableCategoryCode";
            arrParameter[1, 1] = oTableMaster.TableCategoryCode;
            arrParameter[2, 0] = "@mfldTableCode";
            arrParameter[2, 1] = oTableMaster.TableCode;
            arrParameter[3, 0] = "@mfldTableLocationCode";
            arrParameter[3, 1] = oTableMaster.SubLocationCode;
            arrParameter[4, 0] = "@mfldTableSeats";
            arrParameter[4, 1] = oTableMaster.TableSeats;
            arrParameter[5, 0] = "@mfldStatus";
            arrParameter[5, 1] = oTableMaster.TableStatus;

            return cDBConnection.Insert("SP_INSERT_UPDATE_TABLE_MASTER", arrParameter);
        }
        #endregion
    }
}
