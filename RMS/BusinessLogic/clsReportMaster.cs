using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using BusinessObject;

namespace BusinessLogic
{
    public class clsReportMaster
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        #endregion


        public DataTable GetReports()
        {

            string strSystem = "AS";
            string strWhereString = "fldSystem ='" + strSystem + "'";

            DataTable dtReports = cDBConnection.SearchData("tbl_ReportMaster");

            return dtReports;
        }

        public objReportMaster GetReports(int ReportID)
        {
            objReportMaster oReportMaster = new objReportMaster();

            string strWhereString = "fldReportID =" + ReportID;

            DataTable dtReports = cDBConnection.SearchData("tbl_ReportMaster", strWhereString);

            if (dtReports.Rows.Count > 0)
            {
                oReportMaster.ReportID = dtReports.Rows[0]["fldReportID"].ToString();
                oReportMaster.ReportName = dtReports.Rows[0]["fldReportName"].ToString();
                oReportMaster.ReportTitle = dtReports.Rows[0]["fldReportTitle"].ToString();
                oReportMaster.SelectionFormular = dtReports.Rows[0]["fldSelectionFormular"].ToString();
                oReportMaster.SelectedTable = dtReports.Rows[0]["fldSelectTable"].ToString();
            }
            return oReportMaster;

        }
    }
}
