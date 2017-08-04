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
        objStockAdjustmentNote oStockAdjustmentNote = new objStockAdjustmentNote();
        clsDBConnection cDBConnection = new clsDBConnection();
        #endregion


        #region Get SAN Details using SAN No
        public objStockAdjustmentNote GetStockAdjustmentNoteData(string LocationCode,string strSANNo)
        {
            string strWhere1 = "fldLocationCode='" + LocationCode + "' and fldSANNo='" + strSANNo + "'";
            string strWhere2 = "fldSANNo='" + strSANNo + "'";

            DataTable dtSANHeader = cDBConnection.SearchData("tbl_SANHeader", strWhere1);
            DataTable dtSANDetails = cDBConnection.SearchData("tbl_SANDetails", strWhere2);

            if (dtSANHeader.Rows.Count > 0)
            {
                oStockAdjustmentNote.LocationCode = dtSANHeader.Rows[0]["fldLocationCode"].ToString();
                oStockAdjustmentNote.SANNumber = dtSANHeader.Rows[0]["fldSANNo"].ToString();
                oStockAdjustmentNote.SubLocation = dtSANHeader.Rows[0]["fldSubLocationCode"].ToString();
                oStockAdjustmentNote.Date = DateTime.Parse(dtSANHeader.Rows[0]["fldSANDate"].ToString());
                oStockAdjustmentNote.TotalCost = Convert.ToDouble(dtSANHeader.Rows[0]["fldSANTotalCost"].ToString());
                oStockAdjustmentNote.User = dtSANHeader.Rows[0]["fldUser"].ToString();
                oStockAdjustmentNote.dtItemData = dtSANDetails;
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
            System.Object[,] arrParameter = new Object[7, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oStockAdjustmentNote.LocationCode;
            arrParameter[1, 0] = "@mfldSANNo";
            arrParameter[1, 1] = oStockAdjustmentNote.SANNumber;
            arrParameter[2, 0] = "@mfldSubLocationCode";
            arrParameter[2, 1] = oStockAdjustmentNote.SubLocation;
            arrParameter[3, 0] = "@mfldSANDate";
            arrParameter[3, 1] = oStockAdjustmentNote.Date;
            arrParameter[4, 0] = "@mfldTotalCost";
            arrParameter[4, 1] = oStockAdjustmentNote.TotalCost;
            arrParameter[5, 0] = "@mfldUser";
            arrParameter[5, 1] = oStockAdjustmentNote.User;
            arrParameter[6, 0] = "@mflddtItemList";
            arrParameter[6, 1] = oStockAdjustmentNote.dtItemData;

            return cDBConnection.Insert("SP_INSERT_STOCK_AJUSTMENT_NOTE", arrParameter);
        }
        #endregion
    }
}
