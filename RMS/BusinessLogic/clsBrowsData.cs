using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class clsBrowsData
    {
        #region Objects
        clsDBConnection DbConn = new clsDBConnection();
        #endregion

        #region BrowsData using TableName and FieldList
        public DataTable BrowsData(string strTableName, string[] strFieldList)
        {
            string strSQL = "";
            DataTable dtBrowsData;

            for (int i = 0; i < strFieldList.Length; i++)
            {
                strSQL += strFieldList[i].ToString();

                if (i < strFieldList.Length - 1)
                {
                    strSQL += ",";
                }
            }

            System.Object[,] arrParameter = new Object[2, 2];

            arrParameter[0, 0] = "tblName";
            arrParameter[0, 1] = strTableName;
            arrParameter[1, 0] = "FieldList";
            arrParameter[1, 1] = strSQL;

            return dtBrowsData = DbConn.Execute("sp_BrowsData", arrParameter);
        }
        #endregion

        #region BrowsData using TableName,FieldList and WhereClause
        public DataTable BrowsData(string strTableName, string[] strFieldList, string where_clause)
        {
            string strSQL = "";
            DataTable dtBrowsData;

            for (int i = 0; i < strFieldList.Length; i++)
            {
                strSQL += strFieldList[i].ToString();

                if (i < strFieldList.Length - 1)
                {
                    strSQL += ",";
                }
            }

            System.Object[,] arrParameter = new Object[3, 2];

            arrParameter[0, 0] = "tblName";
            arrParameter[0, 1] = strTableName;
            arrParameter[1, 0] = "FieldList";
            arrParameter[1, 1] = strSQL;
            arrParameter[2, 0] = "where_clause";
            arrParameter[2, 1] = where_clause;


            return dtBrowsData = DbConn.Execute("sp_BrowsDataUsingWhere", arrParameter);
        }
        #endregion
    }
}
