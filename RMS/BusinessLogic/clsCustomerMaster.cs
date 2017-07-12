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
                oCustomerMaster.VatNo = dtCustomer.Rows[0][8].ToString();
                oCustomerMaster.IsServiceCharge = Convert.ToBoolean(dtCustomer.Rows[0][9]);
                oCustomerMaster.IsCreditCustomer = Convert.ToBoolean(dtCustomer.Rows[0][10]);
                oCustomerMaster.IsComplementary = Convert.ToBoolean(dtCustomer.Rows[0][11]);

                oCustomerMaster.IsExists = true;
            }
            else
            {
                oCustomerMaster.IsExists = false;
            }

            return oCustomerMaster;
        }
        #endregion
    }
}
