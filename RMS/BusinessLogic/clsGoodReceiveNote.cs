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
    public class clsGoodReceiveNote
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objGoodReceiveNote oGoodReceiveNote = new objGoodReceiveNote();
        #endregion


        #region Variable

        #endregion


        #region InsertUpdateData
        public int InsertUpdateGRNCancel(objGoodReceiveNote oGoodReceiveNote)
        {
            System.Object[,] arrParameter = new Object[4, 2];

            arrParameter[0, 0] = "@mfldGRNCancelCode";
            arrParameter[0, 1] = oGoodReceiveNote.GRNCancelCode;
            arrParameter[1, 0] = "@mfldGRNCode";
            arrParameter[1, 1] = oGoodReceiveNote.GRNCode;
            arrParameter[2, 0] = "@mflddtItemList";
            arrParameter[2, 1] = oGoodReceiveNote.dtItemList;
            arrParameter[3, 0] = "@mfldSubLocationCode";
            arrParameter[3, 1] = oGoodReceiveNote.SubLocationCode;


            return cDBConnection.Insert("SP_INSERT_GRN_CANCEL", arrParameter);
        }
        #endregion


        #region InsertUpdateData
        public int InsertUpdateData(objGoodReceiveNote oGoodReceiveNote)
        {
            System.Object[,] arrParameter = new Object[13, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oGoodReceiveNote.LocationCode;
            arrParameter[1, 0] = "@mfldGRNCode";
            arrParameter[1, 1] = oGoodReceiveNote.GRNCode;
            arrParameter[2, 0] = "@mfldSubLocationCode";
            arrParameter[2, 1] = oGoodReceiveNote.SubLocationCode;
            arrParameter[3, 0] = "@mfldSupplierCode";
            arrParameter[3, 1] = oGoodReceiveNote.SupplierCode;
            arrParameter[4, 0] = "@mfldDate";
            arrParameter[4, 1] = oGoodReceiveNote.Date;
            arrParameter[5, 0] = "@mfldInvoiceNo";
            arrParameter[5, 1] = oGoodReceiveNote.InvoiceNo;
            arrParameter[6, 0] = "@mfldGRNValue";
            arrParameter[6, 1] = oGoodReceiveNote.GRNValue;
            arrParameter[7, 0] = "@mfldVatPrecentage";
            arrParameter[7, 1] = oGoodReceiveNote.VATPresentage;
            arrParameter[8, 0] = "@mfldVatAmount";
            arrParameter[8, 1] = oGoodReceiveNote.VATAmount;
            arrParameter[9, 0] = "@mfldDiscount";
            arrParameter[9, 1] = oGoodReceiveNote.Discount;
            arrParameter[10, 0] = "@mfldNetAmount";
            arrParameter[10, 1] = oGoodReceiveNote.NetAmount;
            arrParameter[11, 0] = "@mflddtItemList";
            arrParameter[11, 1] = oGoodReceiveNote.dtItemList;
            arrParameter[12, 0] = "@mfldPOCode";
            arrParameter[12, 1] = oGoodReceiveNote.POCode;
            
            
            return cDBConnection.Insert("sp_insert_update_GoodReceiveNote", arrParameter);
        }
        #endregion

        #region Get Good Receive Note Data using GRNCode
        public objGoodReceiveNote GetGoodReceiveNoteData(string strLocationCode, string strGoodReceiveNoteCode)
        {
            string strWhere1 = "fldGRNCode='" + strGoodReceiveNoteCode + "' AND fldLocationCode='" + strLocationCode + "'";
            string strWhere2 = "fldGRNCode='" + strGoodReceiveNoteCode + "'";

            DataTable dtGRNDetails = cDBConnection.SearchData("tbl_GRNDetails", strWhere1);
            DataTable dtGRNItemList = cDBConnection.SearchData("tbl_GRNItemList", strWhere2);

            if (dtGRNDetails.Rows.Count > 0)
            {

                oGoodReceiveNote.LocationCode = dtGRNDetails.Rows[0]["fldLocationCode"].ToString();
                oGoodReceiveNote.GRNCode = dtGRNDetails.Rows[0]["fldGRNCode"].ToString();
                oGoodReceiveNote.SubLocationCode = dtGRNDetails.Rows[0]["fldSubLocationCode"].ToString();
                oGoodReceiveNote.SupplierCode = dtGRNDetails.Rows[0]["fldSupplierCode"].ToString();
                oGoodReceiveNote.Date = Convert.ToDateTime(dtGRNDetails.Rows[0]["fldDate"].ToString());
                oGoodReceiveNote.InvoiceNo = dtGRNDetails.Rows[0]["fldInvoiceNo"].ToString();
                oGoodReceiveNote.GRNValue = Convert.ToDouble(dtGRNDetails.Rows[0]["fldGRNValue"].ToString());
                oGoodReceiveNote.VATPresentage = Convert.ToDouble(dtGRNDetails.Rows[0]["fldVatPrecentage"].ToString());
                oGoodReceiveNote.VATAmount = Convert.ToDouble(dtGRNDetails.Rows[0]["fldVatAmount"].ToString());
                oGoodReceiveNote.Discount = Convert.ToDouble(dtGRNDetails.Rows[0]["fldDiscount"].ToString());
                oGoodReceiveNote.NetAmount = Convert.ToDouble(dtGRNDetails.Rows[0]["fldNetAmount"].ToString());

                //Price Table
                oGoodReceiveNote.dtItemList = dtGRNItemList;

                oGoodReceiveNote.IsExists = true;
            }
            else
            {
                oGoodReceiveNote.IsExists = false;
            }


            return oGoodReceiveNote;
        }
        #endregion
    }
}
