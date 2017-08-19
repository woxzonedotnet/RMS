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
    public class clsSupplierReturnNote
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objSupplierReturnNote oSupplierReturnNote = new objSupplierReturnNote();
        #endregion


        #region Variable

        #endregion


        #region InsertUpdateData
        public int InsertUpdateData(objSupplierReturnNote oSupplierReturnNote)
        {
            System.Object[,] arrParameter = new Object[13, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oSupplierReturnNote.LocationCode;
            arrParameter[1, 0] = "@mfldSRNCode";
            arrParameter[1, 1] = oSupplierReturnNote.SRNCode;
            arrParameter[2, 0] = "@mfldSubLocationCode";
            arrParameter[2, 1] = oSupplierReturnNote.SubLocationCode;
            arrParameter[3, 0] = "@mfldSupplierCode";
            arrParameter[3, 1] = oSupplierReturnNote.SupplierCode;
            arrParameter[4, 0] = "@mfldDate";
            arrParameter[4, 1] = oSupplierReturnNote.Date;
            arrParameter[5, 0] = "@mfldInvoiceNo";
            arrParameter[5, 1] = oSupplierReturnNote.InvoiceNo;
            arrParameter[6, 0] = "@mfldSRNValue";
            arrParameter[6, 1] = oSupplierReturnNote.SRNValue;
            arrParameter[7, 0] = "@mfldVatPrecentage";
            arrParameter[7, 1] = oSupplierReturnNote.VATPresentage;
            arrParameter[8, 0] = "@mfldVatAmount";
            arrParameter[8, 1] = oSupplierReturnNote.VATAmount;
            arrParameter[9, 0] = "@mfldDiscount";
            arrParameter[9, 1] = oSupplierReturnNote.Discount;
            arrParameter[10, 0] = "@mfldNetAmount";
            arrParameter[10, 1] = oSupplierReturnNote.NetAmount;
            arrParameter[11, 0] = "@mflddtItemList";
            arrParameter[11, 1] = oSupplierReturnNote.dtItemList;
            arrParameter[12, 0] = "@mfldGRNCode";
            arrParameter[12, 1] = oSupplierReturnNote.GRNCode;


            return cDBConnection.Insert("sp_insert_update_SupplierReturnNote", arrParameter);
        }
        #endregion

        #region Get Supplier Return Note Data using SRNCode
        public objSupplierReturnNote GetSupplierReturnNoteData(string strLocationCode, string strSupplierReturnNoteCode)
        {
            string strWhere1 = "fldSRNCode='" + strSupplierReturnNoteCode + "' AND fldLocationCode='" + strLocationCode + "'";
            string strWhere2 = "fldSRNCode='" + strSupplierReturnNoteCode + "'";

            DataTable dtSRNDetails = cDBConnection.SearchData("tbl_SRNDetails", strWhere1);
            DataTable dtSRNItemList = cDBConnection.SearchData("tbl_SRNItemList", strWhere2);

            if (dtSRNDetails.Rows.Count > 0)
            {

                oSupplierReturnNote.LocationCode = dtSRNDetails.Rows[0]["fldLocationCode"].ToString();
                oSupplierReturnNote.SRNCode = dtSRNDetails.Rows[0]["fldSRNCode"].ToString();
                oSupplierReturnNote.SubLocationCode = dtSRNDetails.Rows[0]["fldSubLocationCode"].ToString();
                oSupplierReturnNote.SupplierCode = dtSRNDetails.Rows[0]["fldSupplierCode"].ToString();
                oSupplierReturnNote.Date = Convert.ToDateTime(dtSRNDetails.Rows[0]["fldDate"].ToString());
                oSupplierReturnNote.InvoiceNo = dtSRNDetails.Rows[0]["fldInvoiceNo"].ToString();
                oSupplierReturnNote.SRNValue = Convert.ToDouble(dtSRNDetails.Rows[0]["fldSRNValue"].ToString());
                oSupplierReturnNote.VATPresentage = Convert.ToDouble(dtSRNDetails.Rows[0]["fldVatPrecentage"].ToString());
                oSupplierReturnNote.VATAmount = Convert.ToDouble(dtSRNDetails.Rows[0]["fldVatAmount"].ToString());
                oSupplierReturnNote.Discount = Convert.ToDouble(dtSRNDetails.Rows[0]["fldDiscount"].ToString());
                oSupplierReturnNote.NetAmount = Convert.ToDouble(dtSRNDetails.Rows[0]["fldNetAmount"].ToString());

                //Price Table
                oSupplierReturnNote.dtItemList = dtSRNItemList;

                oSupplierReturnNote.IsExists = true;
            }
            else
            {
                oSupplierReturnNote.IsExists = false;
            }


            return oSupplierReturnNote;
        }
        #endregion
    }
}
