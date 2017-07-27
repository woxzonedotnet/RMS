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
    public class clsStockAdjustmentNote
    {


        #region Objects
        clsStockAdjustmentNote cStockAdjustmentNote = new clsStockAdjustmentNote();
        objStockAdjustmentNote oStockAdjustmentNote = new objStockAdjustmentNote();
        clsDBConnection cDBConnection = new clsDBConnection();
         
        #endregion


        #region Get BankCard Data using Bank Code
        public objStockAdjustmentNote GetStockAdjustmentNote(string strCardCode)
        {
            string strWhere = "fldSANNumber='" + strCardCode + "'";

            DataTable dtStockAdjustmentNote = cDBConnection.SearchData("tbl_BankCardMaster", strWhere);

            if (dtStockAdjustmentNote.Rows.Count > 0)
            {
                oStockAdjustmentNote.SANNumber = dtStockAdjustmentNote.Rows[0][0].ToString();
                oStockAdjustmentNote.Location = dtStockAdjustmentNote.Rows[0][1].ToString();
                oStockAdjustmentNote.Date = DateTime.Parse(dtStockAdjustmentNote.Rows[0][2].ToString());
                oStockAdjustmentNote.TotalCost = decimal.Parse(dtStockAdjustmentNote.Rows[0][3].ToString());
                oStockAdjustmentNote.IsExists = true;
            }
            else
            {
                oStockAdjustmentNote.IsExists = false;
            }

            return oStockAdjustmentNote;

            }   
            
        #endregion


        #region InsertUpdate StockAjustmentNote
        public int InsertUpdateData(objStockAdjustmentNote oStockAdjustmentNote)
        {
            System.Object[,] arrParameter = new Object[6, 2];

            arrParameter[0, 0] = "@mfldSANNumber";
            arrParameter[0, 1] = oStockAdjustmentNote.SANNumber;
            arrParameter[1, 0] = "@mfldLocation";
            arrParameter[1, 1] = oStockAdjustmentNote.Location;
            arrParameter[2, 0] = "@mfldDate";
            arrParameter[2, 1] = oStockAdjustmentNote.Date;
            arrParameter[3, 0] = "@mfldTotalCost";
            arrParameter[3, 1] = oStockAdjustmentNote.TotalCost;
           

            return cDBConnection.Insert("sp_insert_update_StockAdjustmentNote", arrParameter);
        }
        #endregion

        public objStockAdjustmentNote GetStockAdjustmentNote()
        {
            throw new NotImplementedException();
        }
    }
}
