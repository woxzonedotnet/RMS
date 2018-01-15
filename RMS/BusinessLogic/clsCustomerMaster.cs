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
    public class clsCustomerMaster
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objCustomerMaster oCustomerMaster = new objCustomerMaster();
        #endregion

        #region GetCustomer Data Using CustomerCode
        public objCustomerMaster GetCustomerData(string strLocationCode, string strCustomerCode)
        {
            string strWhere = "fldLocationCode='" + strLocationCode + "' AND fldCustomerCode='" + strCustomerCode + "'";

            DataTable dtCustomer = cDBConnection.SearchData("tbl_CustomerMaster", strWhere);

            if (dtCustomer.Rows.Count > 0)
            {
                oCustomerMaster.LocationCode = dtCustomer.Rows[0][0].ToString();
                oCustomerMaster.CustomerCode = dtCustomer.Rows[0][1].ToString();
                oCustomerMaster.CustomerName = dtCustomer.Rows[0][2].ToString();
                oCustomerMaster.CustomerAddress = dtCustomer.Rows[0][3].ToString();
                oCustomerMaster.ContactNo = dtCustomer.Rows[0][4].ToString();
                oCustomerMaster.Email = dtCustomer.Rows[0][5].ToString();
                oCustomerMaster.CreditLimit = Convert.ToDouble(dtCustomer.Rows[0][6]);
                oCustomerMaster.Discount = Convert.ToDouble(dtCustomer.Rows[0][7]);
                oCustomerMaster.IsServiceCharge = Convert.ToBoolean(dtCustomer.Rows[0][8]);
                oCustomerMaster.IsCreditCustomer = Convert.ToBoolean(dtCustomer.Rows[0][9]);
                oCustomerMaster.IsComplementary = Convert.ToBoolean(dtCustomer.Rows[0][10]);
                oCustomerMaster.VatNo = dtCustomer.Rows[0][11].ToString();
                oCustomerMaster.IsExists = true;
                //what will be the help that they need to be pf that i
            }
            else
            {
                oCustomerMaster.IsExists = false;
            }

            return oCustomerMaster;
        }
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objCustomerMaster oCustomerMaster)
        {
            System.Object[,] arrParameter = new Object[12, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oCustomerMaster.LocationCode;
            arrParameter[1, 0] = "@mfldCustomerCode";
            arrParameter[1, 1] = oCustomerMaster.CustomerCode;
            arrParameter[2, 0] = "@mfldCustomerName";
            arrParameter[2, 1] = oCustomerMaster.CustomerName;
            arrParameter[3, 0] = "@mfldCustomerAddress";
            arrParameter[3, 1] = oCustomerMaster.CustomerAddress;
            arrParameter[4, 0] ="@mfldContactNo";
            arrParameter[4, 1] =oCustomerMaster.ContactNo;
            arrParameter[5, 0] ="@mfldEmail";
            arrParameter[5, 1] =oCustomerMaster.Email;
            arrParameter[6, 0] ="@mfldCreditLimit";
            arrParameter[6, 1] =oCustomerMaster.CreditLimit;
            arrParameter[7, 0] ="@mfldDiscount";
            arrParameter[7, 1] =oCustomerMaster.Discount;
            arrParameter[8, 0] ="@mfldVatNo";
            arrParameter[8, 1] =oCustomerMaster.VatNo;
            arrParameter[9, 0] ="@mfldIsServiceCharge";
            arrParameter[9, 1] =oCustomerMaster.IsServiceCharge;
            arrParameter[10, 0] ="@mfldIsCreditCustomer";
            arrParameter[10, 1] =oCustomerMaster.IsCreditCustomer;
            arrParameter[11, 0] ="@mfldIsComplementary";
            arrParameter[11, 1] = oCustomerMaster.IsComplementary;

            return cDBConnection.Insert("SP_INSERT_UPDATE_CUSTOMER_MASTER", arrParameter);
        }
        #endregion
    }
}
