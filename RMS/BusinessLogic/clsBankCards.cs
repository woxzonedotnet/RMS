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
    public class clsBankCards
    {
        #region Object
        objBankCards oBankCards = new objBankCards();
        clsDBConnection cDBConnection = new clsDBConnection();
        #endregion

        #region Variable

        #endregion

        #region Function
        
        #region InsertUpdate Bank Cards
        public int InsertUpdateData(objBankCards oBankCards)
        {
            System.Object[,] arrParameter = new Object[6, 2];

            arrParameter[0, 0] = "@mfldCardCode";
            arrParameter[0, 1] = oBankCards.CardCode;
            arrParameter[1, 0] = "@mfldBankCode";
            arrParameter[1, 1] = oBankCards.BankCode;
            arrParameter[2, 0] = "@mfldCardTypeCode";
            arrParameter[2, 1] = oBankCards.CardType;
            arrParameter[3, 0] = "@mfldCurrencyCode";
            arrParameter[3, 1] = oBankCards.Currency;
            arrParameter[4, 0] = "@mfldCommision";
            arrParameter[4, 1] = oBankCards.Commision;
            arrParameter[5, 0] = "@mfldCardStatus";
            arrParameter[5, 1] = oBankCards.Status;

            return cDBConnection.Insert("sp_insert_update_bankcard", arrParameter);
        }
        #endregion

        #region Get BankCard Data using Bank Code
        public objBankCards GetBankCardData(string strCardCode)
        {
            string strWhere = "fldCardCode='" + strCardCode + "'";

            DataTable dtBank = cDBConnection.SearchData("tbl_BankCardMaster", strWhere);

            if (dtBank.Rows.Count > 0)
            {
                oBankCards.CardCode = dtBank.Rows[0][0].ToString();
                oBankCards.BankCode = dtBank.Rows[0][1].ToString();
                oBankCards.CardType = dtBank.Rows[0][2].ToString();
                oBankCards.Currency = dtBank.Rows[0][3].ToString();
                oBankCards.Commision = Convert.ToDouble(dtBank.Rows[0][4]);
                oBankCards.Status = Convert.ToInt16(dtBank.Rows[0][5]);

                oBankCards.IsExists = true;
            }
            else
            {
                oBankCards.IsExists = false;
            }

            return oBankCards;
        }
        #endregion


        #endregion
    }
}
