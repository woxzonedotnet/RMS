using BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class clsSupplierMaster
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objSupplierMaster oSupplierMaster = new objSupplierMaster();
        #endregion

        #region GetSupplierMaster Data Using SupplierCode
        public objSupplierMaster GetSupplierData(string strLocationCode, string strSupplierCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' AND fldSupplierCode='" + strSupplierCode + "'";

            DataTable dtSupplier = cDBConnection.SearchData("tbl_SupplierMaster", strWhere);

            if (dtSupplier.Rows.Count > 0)
            {
                oSupplierMaster.LocationCode = dtSupplier.Rows[0][0].ToString();
                oSupplierMaster.SupplierCode = dtSupplier.Rows[0][1].ToString();
                oSupplierMaster.SupplierName = dtSupplier.Rows[0][2].ToString();
                oSupplierMaster.ContactPerson = dtSupplier.Rows[0][3].ToString();
                oSupplierMaster.Address = dtSupplier.Rows[0][4].ToString();
                oSupplierMaster.TellephoneNo = dtSupplier.Rows[0][5].ToString();
                oSupplierMaster.Fax = dtSupplier.Rows[0][6].ToString();
                oSupplierMaster.Email = dtSupplier.Rows[0][7].ToString();
                oSupplierMaster.SupplierCategoryCode = dtSupplier.Rows[0][8].ToString();
                oSupplierMaster.Discount = Convert.ToDouble(dtSupplier.Rows[0][9]);
                oSupplierMaster.Consignment = Convert.ToBoolean(dtSupplier.Rows[0][10]);
                oSupplierMaster.EnterdDate = Convert.ToDateTime(dtSupplier.Rows[0][11]);
                oSupplierMaster.CancelDate = Convert.ToDateTime(dtSupplier.Rows[0][12]);
                oSupplierMaster.Status = Convert.ToInt16(dtSupplier.Rows[0][13]);
                oSupplierMaster.RelesePendingPO = Convert.ToBoolean(dtSupplier.Rows[0][14]);
                oSupplierMaster.IsExists = true;
            }
            else
            {
                oSupplierMaster.IsExists = false;
            }
            return oSupplierMaster;
        }
        #endregion

        #region GetSupplierData using Location Code
        public DataTable GetSupplierData(string strLocationCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' and fldStatus=1";
            DataTable dtSupplier = cDBConnection.SearchData("tbl_SupplierMaster", strWhere);
            return dtSupplier;
        }
        #endregion

        #region GetSupplierMaster Data Using SupplierCode
        public string GetSupplierDataBySupplierCode(string strLocationCode, string strSupplierCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' AND fldSupplierCode='" + strSupplierCode + "'";

            DataTable dtSupplier = cDBConnection.SearchData("tbl_SupplierMaster", strWhere);

            if (dtSupplier.Rows.Count > 0)
            {
                oSupplierMaster.LocationCode = dtSupplier.Rows[0][0].ToString();
                oSupplierMaster.SupplierCode = dtSupplier.Rows[0][1].ToString();
                oSupplierMaster.SupplierName = dtSupplier.Rows[0][2].ToString();
                oSupplierMaster.ContactPerson = dtSupplier.Rows[0][3].ToString();
                oSupplierMaster.Address = dtSupplier.Rows[0][4].ToString();
                oSupplierMaster.TellephoneNo = dtSupplier.Rows[0][5].ToString();
                oSupplierMaster.Fax = dtSupplier.Rows[0][6].ToString();
                oSupplierMaster.Email = dtSupplier.Rows[0][7].ToString();
                oSupplierMaster.SupplierCategoryCode = dtSupplier.Rows[0][8].ToString();
                oSupplierMaster.Discount = Convert.ToDouble(dtSupplier.Rows[0][9]);
                oSupplierMaster.Consignment = Convert.ToBoolean(dtSupplier.Rows[0][10]);
                oSupplierMaster.EnterdDate = Convert.ToDateTime(dtSupplier.Rows[0][11]);
                oSupplierMaster.CancelDate = Convert.ToDateTime(dtSupplier.Rows[0][12]);
                oSupplierMaster.Status = Convert.ToInt16(dtSupplier.Rows[0][13]);
                oSupplierMaster.RelesePendingPO = Convert.ToBoolean(dtSupplier.Rows[0][14]);
                oSupplierMaster.IsExists = true;
            }
            else
            {
                oSupplierMaster.IsExists = false;
            }
            return oSupplierMaster.SupplierName;
        }
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objSupplierMaster oSupplierMaster)
        {
            System.Object[,] arrParameter = new Object[15, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oSupplierMaster.LocationCode;
            arrParameter[1, 0] = "@mfldSupplierCode";
            arrParameter[1, 1] = oSupplierMaster.SupplierCode;
            arrParameter[2, 0] = "@mfldSupplierName";
            arrParameter[2, 1] = oSupplierMaster.SupplierName;
            arrParameter[3, 0] = "@mfldContactPerson";
            arrParameter[3, 1] = oSupplierMaster.ContactPerson;
            arrParameter[4, 0] = "@mfldAddress";
            arrParameter[4, 1] = oSupplierMaster.Address;
            arrParameter[5, 0] = "@mfldTellephoneNo";
            arrParameter[5, 1] = oSupplierMaster.TellephoneNo;
            arrParameter[6, 0] = "@mfldFaxNo";
            arrParameter[6, 1] = oSupplierMaster.Fax;
            arrParameter[7, 0] = "@mfldEmail";
            arrParameter[7, 1] = oSupplierMaster.Email;
            arrParameter[8, 0] = "@mfldSupplierCategoryCode";
            arrParameter[8, 1] = oSupplierMaster.SupplierCategoryCode;
            arrParameter[9, 0] = "@mfldDiscount";
            arrParameter[9, 1] = oSupplierMaster.Discount;
            arrParameter[10, 0] = "@mfldConsignment";
            arrParameter[10, 1] = oSupplierMaster.Consignment;
            arrParameter[11, 0] = "@mfldEnterdDate";
            arrParameter[11, 1] = oSupplierMaster.EnterdDate;
            arrParameter[12, 0] = "@mfldCancelDate";
            arrParameter[12, 1] = oSupplierMaster.CancelDate;
            arrParameter[13, 0] = "@mfldStatus";
            arrParameter[13, 1] = oSupplierMaster.Status;
            arrParameter[14, 0] = "@mfldRelesePendingPO";
            arrParameter[14, 1] = oSupplierMaster.RelesePendingPO;

            return cDBConnection.Insert("SP_INSERT_UPDATE_SUPPLIER_MASTER", arrParameter);
        }
        #endregion


        #region  GetSupplierData
        public DataTable GetSupplierData()
        {
            DataTable dtSupplierData = cDBConnection.SearchData("tbl_SupplierMaster");
            return dtSupplierData;
        }
        #endregion
    }
}
