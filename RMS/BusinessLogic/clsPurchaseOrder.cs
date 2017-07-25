using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using BusinessLogic;
using DataAccess;

namespace BusinessLogic
{

    public class clsPurchaseOrder
    {

        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
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
    }
}
