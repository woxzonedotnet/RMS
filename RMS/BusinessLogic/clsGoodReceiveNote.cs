using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess;

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
        public int InsertUpdateData(objGoodReceiveNote oGoodReceiveNote)
        {
            System.Object[,] arrParameter = new Object[12, 2];

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
            
            
            return cDBConnection.Insert("sp_insert_update_GoodReceiveNote", arrParameter);
        }
        #endregion

        //#region Get Purchase Order Data using ItemCode
        //public objPurchaseOrder GetItemData(string strLocationCode, string strPurchaseOrderCode)
        //{
        //    string strWhere1 = "fldPOCode='" + strPurchaseOrderCode + "' AND fldLocationCode='" + strLocationCode + "'";
        //    string strWhere2 = "fldPOCode='" + strPurchaseOrderCode + "'";

        //    DataTable dtPODetails = cDBConnection.SearchData("tbl_PODetails", strWhere2);
        //    DataTable dtPOItemList = cDBConnection.SearchData("tbl_POItemList", strWhere1);

        //    if (dtPODetails.Rows.Count > 0)
        //    {
        //        oPurchaseOrder.LocationCode = dtPODetails.Rows[0][0].ToString();
        //        oPurchaseOrder.PurchaseOrderCode = dtPODetails.Rows[0][1].ToString();
        //        oPurchaseOrder.SubLocationCode = dtPODetails.Rows[0][2].ToString();
        //        oPurchaseOrder.SupplierCode = dtPODetails.Rows[0][3].ToString();
        //        oPurchaseOrder.Date = Convert.ToDateTime(dtPODetails.Rows[0][4].ToString());
        //        oPurchaseOrder.VAT = Convert.ToDouble(dtPODetails.Rows[0][5].ToString());
        //        oPurchaseOrder.NetAmount = Convert.ToDouble(dtPODetails.Rows[0][6].ToString());
        //        oPurchaseOrder.Remarks = dtPODetails.Rows[0][7].ToString();

        //        //Price Table
        //        oPurchaseOrder.dtItemList = dtPOItemList;

        //        oPurchaseOrder.IsExists = true;
        //    }
        //    else
        //    {
        //        oPurchaseOrder.IsExists = false;
        //    }


        //    return oPurchaseOrder;
        //}
        //#endregion
    }
}
