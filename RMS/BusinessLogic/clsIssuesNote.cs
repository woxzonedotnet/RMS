using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using BusinessObject;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogic
{
   public  class clsIssuesNote
    {
        #region Object
        objIssuesNote oIssuesNote = new objIssuesNote();
        clsDBConnection cDBConnection = new clsDBConnection();
        #endregion


        #region InsertUpdate IssuesNote
        public int InsertUpdateData(objBankCards oBankCards)
        {
            System.Object[,] arrParameter = new Object[6, 2];

            arrParameter[0, 0] = "@mfldCardCode";
            arrParameter[0, 1] = oIssuesNote.IssuesNumber;
            arrParameter[1, 0] = "@mfldBankCode";
            arrParameter[1, 1] = oIssuesNote.LocationFrom;
            arrParameter[2, 0] = "@mfldCardTypeCode";
            arrParameter[2, 1] = oIssuesNote.Date;
            arrParameter[3, 0] = "@mfldCurrencyCode";
            arrParameter[3, 1] = oIssuesNote.Total;
           

            return cDBConnection.Insert("sp_insert_update_IssuesNote", arrParameter);
        }
        #endregion


        #region Get issuesNote Data using Issue Number
        public objIssuesNote GetissuesNoteData(string strIssueNumber)
        {
            string strWhere = "fldIssuesNumber='" + strIssueNumber + "'";

            DataTable dtIssues = cDBConnection.SearchData("tbl_BankCardMaster", strWhere);

            if (dtIssues.Rows.Count > 0)
            {
                oIssuesNote.IssuesNumber = dtIssues.Rows[0][0].ToString();
                oIssuesNote.LocationFrom = dtIssues.Rows[0][1].ToString();
                oIssuesNote.Date = dtIssues.Rows[0][2].ToString();
                oIssuesNote.Total = Convert.ToDecimal(dtIssues.Rows[0][3].ToString());
                oIssuesNote.IsExists = true;
            }
            else
            {
                oIssuesNote.IsExists = false;
            }

            return oIssuesNote;
        }
        #endregion




        public int InsertUpdateData(objIssuesNote oIssuesNote)
        {
            throw new NotImplementedException();
        }
    }
}
