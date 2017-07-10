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
    public class clsBankCardType
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objBankCardType oBankCardType = new objBankCardType();
        #endregion

        #region GetBankCardType
        public DataTable GetBankCardType()
        {
            DataTable dtBankCardType = cDBConnection.SearchData("tbl_BankCardType");
            return dtBankCardType;
        }
        #endregion

        #region GetBankCardType using TypeCode
        public string GetBankCardTypeByCode(string strTypeCode)
        {
            string strWhereString = "fldCardTypeCode ='" + strTypeCode + "'";

            DataTable dtBankCardType = cDBConnection.SearchData("tbl_BankCardType", strWhereString);

            if (dtBankCardType.Rows.Count > 0)
            {
                oBankCardType.TypeCode = dtBankCardType.Rows[0][0].ToString();
                oBankCardType.TypeName = dtBankCardType.Rows[0][1].ToString();
                oBankCardType.IsExists = true;
            }
            else
            {
                oBankCardType.IsExists = false;
            }
            return oBankCardType.TypeName;
        }
        #endregion
    }
}
