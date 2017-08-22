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
    public class clsTransferNote
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objTransferNote oTransferNote = new objTransferNote();
        #endregion

        #region InsertUpdateData
        public int InsertUpdateData(objTransferNote oTransferNote)
        {
            System.Object[,] arrParameter = new Object[7, 2];

            arrParameter[0, 0] = "@mfldLocationCode";
            arrParameter[0, 1] = oTransferNote.LocationCode;
            arrParameter[1, 0] = "@mfldTransferNumber";
            arrParameter[1, 1] = oTransferNote.TransferNumber;
            arrParameter[2, 0] = "@mfldFromSubLocationCode";
            arrParameter[2, 1] = oTransferNote.FromSubLocation;
            arrParameter[3, 0] = "@mfldDate";
            arrParameter[3, 1] = oTransferNote.TransferDate;
            arrParameter[4, 0] = "@mfldTransferValue";
            arrParameter[4, 1] = oTransferNote.TransferValue;
            arrParameter[5, 0] = "@mfldIssueUser";
            arrParameter[5, 1] = oTransferNote.User;
            arrParameter[6, 0] = "@mflddtItemList";
            arrParameter[6, 1] = oTransferNote.dtTransferNote;

            return cDBConnection.Insert("sp_insert_Transfer_Note", arrParameter);
        }
        #endregion

        #region Get Transfer Note Data using IssueNumber
        public objTransferNote GetTransferNoteData(string strLocationCode, string strTransferNumber)
        {
            string strWhere1 = "fldLocationCode = '" + strLocationCode + "' and fldTransferNumber='" + strTransferNumber + "'";
            string strWhere2 = "fldTransferNumber='" + strTransferNumber + "'";

            DataTable dtTransferHeader = cDBConnection.SearchData("tbl_TransferHeader", strWhere1);
            DataTable dtTransferDetails = cDBConnection.SearchData("tbl_TransferDetails", strWhere2);

            if (dtTransferHeader.Rows.Count > 0)
            {
                oTransferNote.LocationCode = dtTransferHeader.Rows[0]["fldLocationCode"].ToString();
                oTransferNote.TransferNumber = dtTransferHeader.Rows[0]["fldTransferNumber"].ToString();
                oTransferNote.FromSubLocation = dtTransferHeader.Rows[0]["fldFromLocationCode"].ToString();
                oTransferNote.TransferDate = Convert.ToDateTime(dtTransferHeader.Rows[0]["fldTransferDate"].ToString());
                oTransferNote.TransferValue = Convert.ToDouble(dtTransferHeader.Rows[0]["fldTransferValue"].ToString());
                oTransferNote.User = dtTransferHeader.Rows[0]["fldTransferUser"].ToString();

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
