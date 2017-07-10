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
    public class clsBankDetails
    {
        #region Object
        objBankDetails oBankDetails = new objBankDetails();
        clsDBConnection cDBConnection = new clsDBConnection();
        #endregion

        #region Variable

        #endregion

        #region Function

        #region InsertUpdate Bank Details
        public int InsertUpdateData(objBankDetails oBankDetails)
        {
            System.Object[,] arrParameter = new Object[3, 2];

            arrParameter[0, 0] = "@mfldBankCode";
            arrParameter[0, 1] = oBankDetails.BankCode;
            arrParameter[1, 0] = "@mfldBankName";
            arrParameter[1, 1] = oBankDetails.BankName;
            arrParameter[2, 0] = "@mfldBankStatus";
            arrParameter[2, 1] = oBankDetails.Status;

            return cDBConnection.Insert("sp_insert_update_bank", arrParameter);
        }
        #endregion

        #region GetBankDetails
        public DataTable GetBankData()
        {
            DataTable dtBankMaster = cDBConnection.SearchData("tbl_BankMaster");
            return dtBankMaster;
        }
        #endregion

        #region Get Bank Data using Bank Code
        public objBankDetails GetBankData(string strBankCode)
        {
            string strWhere = "fldBankCode='" + strBankCode + "'";

            DataTable dtBank = cDBConnection.SearchData("tbl_BankMaster", strWhere);

            if (dtBank.Rows.Count > 0)
            {
                oBankDetails.BankCode = dtBank.Rows[0][0].ToString();
                oBankDetails.BankName = dtBank.Rows[0][1].ToString();
                oBankDetails.Status = Convert.ToInt16(dtBank.Rows[0][2]);

                oBankDetails.IsExists = true;
            }
            else
            {
                oBankDetails.IsExists = false;
            }

            return oBankDetails;
        }
        #endregion

        #region Get Bank Name using Bank Code
        public string GetBankName(string strBankCode)
        {
            string strWhere = "fldBankCode='" + strBankCode + "'";

            DataTable dtBank = cDBConnection.SearchData("tbl_BankMaster", strWhere);

            if (dtBank.Rows.Count > 0)
            {
                oBankDetails.BankCode = dtBank.Rows[0][0].ToString();
                oBankDetails.BankName = dtBank.Rows[0][1].ToString();
                oBankDetails.Status = Convert.ToInt16(dtBank.Rows[0][2]);

                oBankDetails.IsExists = true;
            }
            else
            {
                oBankDetails.IsExists = false;
            }

            return oBankDetails.BankName;
        }
        #endregion

        #endregion
    }
}
