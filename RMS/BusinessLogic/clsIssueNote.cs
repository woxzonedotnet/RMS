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
    public class clsIssueNote
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objIssueNote oTransferNote = new objIssueNote();
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objIssueNote oTransferNote)
        {
            System.Object[,] arrParameter = new Object[8, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oTransferNote.LocationCode;
            arrParameter[1, 0] = "@mfldIssueNumber";
            arrParameter[1, 1] = oTransferNote.IssueNumber;
            arrParameter[2, 0] = "@mfldFromSubLocationCode";
            arrParameter[2, 1] = oTransferNote.FromSubLocation;
            arrParameter[3, 0] = "@mfldToSubLocationCode";
            arrParameter[3, 1] = oTransferNote.ToSubLocation;
            arrParameter[4, 0] = "@mfldIssueDate";
            arrParameter[4, 1] = oTransferNote.IssueDate;
            arrParameter[5, 0] = "@mfldIssueValue";
            arrParameter[5, 1] = oTransferNote.IssueValue;
            arrParameter[6, 0] = "@mfldIssueUser";
            arrParameter[6, 1] = oTransferNote.User;
            arrParameter[7, 0] = "@mflddtItemList";
            arrParameter[7, 1] = oTransferNote.dtTransferNote;

            return cDBConnection.Insert("SP_INSERT_ISSUE_NOTE", arrParameter);
        }
        #endregion

        #region Get Transfer Note Data using IssueNumber
        public objIssueNote GetTransferNoteData(string strLocationCode, string strIssueNumber)
        {
            string strWhere1 = "fldLocationCode = '" + strLocationCode + "' and fldIssueNumber='" + strIssueNumber + "'";
            string strWhere2 = "fldIssueNumber='" + strIssueNumber + "'";

            DataTable dtTransferHeader = cDBConnection.SearchData("tbl_IssueHeader", strWhere1);
            DataTable dtTransferDetails = cDBConnection.SearchData("tbl_IssueDetails", strWhere2);

            if (dtTransferHeader.Rows.Count > 0)
            {
                oTransferNote.LocationCode = dtTransferHeader.Rows[0]["fldLocationCode"].ToString();
                oTransferNote.IssueNumber = dtTransferHeader.Rows[0]["fldIssueNumber"].ToString();
                oTransferNote.FromSubLocation = dtTransferHeader.Rows[0]["fldFromLocationCode"].ToString();
                oTransferNote.ToSubLocation = dtTransferHeader.Rows[0]["fldToLocationCode"].ToString();
                oTransferNote.IssueDate = Convert.ToDateTime(dtTransferHeader.Rows[0]["fldIssueDate"].ToString());
                oTransferNote.IssueValue = Convert.ToDouble(dtTransferHeader.Rows[0]["fldIssueValue"].ToString());
                oTransferNote.User = dtTransferHeader.Rows[0]["fldIssueUser"].ToString();
               
                //Details
                oTransferNote.dtTransferNote = dtTransferDetails;

                oTransferNote.IsExists = true;
            }
            else
            {
                oTransferNote.IsExists = false;
            }
            return oTransferNote;
        }
        #endregion
    }
}
