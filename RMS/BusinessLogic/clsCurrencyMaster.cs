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
    public class clsCurrencyMaster
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objCurrencyMaster oCurrencyMaster = new objCurrencyMaster();
        #endregion

        #region GetCurrencyDetails
        public DataTable GetCurrencyDetails()
        {
            DataTable dtCurrencyMaster = cDBConnection.SearchData("tbl_CurrencyMaster");
            return dtCurrencyMaster;
        }
        #endregion

        #region GetCurrencyDetails using CurrencyCode
        public string GetCurrencyByCode(string strCurrencyCode)
        {
            string strWhereString = "fldCurrencyCode ='" + strCurrencyCode + "'";

            DataTable dtCurrencyMaster = cDBConnection.SearchData("tbl_CurrencyMaster", strWhereString);

            if (dtCurrencyMaster.Rows.Count > 0)
            {
                oCurrencyMaster.CurrencyCode = dtCurrencyMaster.Rows[0][0].ToString();
                oCurrencyMaster.CurrencyName = dtCurrencyMaster.Rows[0][1].ToString();
                oCurrencyMaster.Symbol = dtCurrencyMaster.Rows[0][2].ToString();
                oCurrencyMaster.IsExistStatus = true;
            }
            else
            {
                oCurrencyMaster.IsExistStatus = false;
            }
            return oCurrencyMaster.CurrencyName;
        }
        #endregion
    }
}
