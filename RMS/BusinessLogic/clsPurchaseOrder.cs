using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using BusinessLogic;
using DataAccess;
using System.Data;

namespace BusinessLogic
{

    public class clsPurchaseOrder
    {

        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objPurchaseOrder oPurchaseOrder = new objPurchaseOrder();
        #endregion


        #region Variable

        #endregion


        #region InsertUpdateData
        public int InsertUpdateData(objPurchaseOrder oPurchaseOrder)
        {
            System.Object[,] arrParameter = new Object[9, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oPurchaseOrder.LocationCode;
            arrParameter[1, 0] = "@mfldPurchaseOrderCode";
            arrParameter[1, 1] = oPurchaseOrder.PurchaseOrderCode;
            arrParameter[2, 0] = "@mfldSubLocationCode";
            arrParameter[2, 1] = oPurchaseOrder.SubLocationCode;
            arrParameter[3, 0] = "@mfldSupplierCode";
            arrParameter[3, 1] = oPurchaseOrder.SupplierCode;
            arrParameter[4, 0] = "@mfldDate";
            arrParameter[4, 1] = oPurchaseOrder.Date;
            arrParameter[5, 0] = "@mfldVat";
            arrParameter[5, 1] = oPurchaseOrder.VAT;
            arrParameter[6, 0] = "@mfldNetAmount";
            arrParameter[6, 1] = oPurchaseOrder.NetAmount;
            arrParameter[7, 0] = "@mfldRemarks";
            arrParameter[7, 1] = oPurchaseOrder.Remarks;
            arrParameter[8, 0] = "@mflddtItemList";
            arrParameter[8, 1] = oPurchaseOrder.dtItemList;

            return cDBConnection.Insert("sp_insert_update_PurchaseOrder", arrParameter);
        }
        #endregion

        #region Get Purchase Order Data using ItemCode
        public objPurchaseOrder GetPurchaseOrderData(string strLocationCode, string strPurchaseOrderCode)
        {
            string strWhere1 = "fldPOCode='" + strPurchaseOrderCode + "' AND fldLocationCode='" + strLocationCode + "'";
            string strWhere2 = "fldPOCode='" + strPurchaseOrderCode + "'";

            DataTable dtPODetails = cDBConnection.SearchData("tbl_PODetails", strWhere1);
            DataTable dtPOItemList = cDBConnection.SearchData("tbl_POItemList", strWhere2);

            if (dtPODetails.Rows.Count > 0)
            {
                oPurchaseOrder.LocationCode = dtPODetails.Rows[0]["fldLocationCode"].ToString();
                oPurchaseOrder.PurchaseOrderCode = dtPODetails.Rows[0]["fldPOCode"].ToString();
                oPurchaseOrder.SubLocationCode = dtPODetails.Rows[0]["fldSubLocationCode"].ToString();
                oPurchaseOrder.SupplierCode = dtPODetails.Rows[0]["fldSupplierCode"].ToString();
                oPurchaseOrder.Date = Convert.ToDateTime(dtPODetails.Rows[0]["fldDate"].ToString());
                oPurchaseOrder.VAT = Convert.ToDouble(dtPODetails.Rows[0]["fldVatAmount"].ToString());
                oPurchaseOrder.NetAmount = Convert.ToDouble(dtPODetails.Rows[0]["fldPONetAmount"].ToString());
                oPurchaseOrder.Remarks = dtPODetails.Rows[0]["fldRemarks"].ToString();

                //Price Table
                oPurchaseOrder.dtItemList = dtPOItemList;

                oPurchaseOrder.IsExists = true;
            }
            else
            {
                oPurchaseOrder.IsExists = false;
            }
            return oPurchaseOrder;
        }
        #endregion

    }
}
