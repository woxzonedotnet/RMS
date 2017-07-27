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
    public class clsDocumentNumber
    {
        #region Objects
        clsDBConnection cDBConnection = new clsDBConnection();
        objDocumentNumber oDocumentNumber=new objDocumentNumber();
        #endregion

        #region Variables

        #endregion

        public objDocumentNumber GetDocumentNumberData(string strUniqID, string strDocumentCode)
        {
            string strWhere = "fldPCID='" + strUniqID + "' AND fldDocumentCode='" + strDocumentCode + "'";

            DataTable dtDocumentNumber = cDBConnection.SearchData("tbl_DocumentNumber_Temp", strWhere);

            if (dtDocumentNumber.Rows.Count > 0)
            {
                oDocumentNumber.PCID = dtDocumentNumber.Rows[0][0].ToString();
                oDocumentNumber.DocumentCode = dtDocumentNumber.Rows[0][1].ToString();
                oDocumentNumber.DocumentNo = dtDocumentNumber.Rows[0][2].ToString();

                oDocumentNumber.IsExists = true;
            }
            else
            {
                oDocumentNumber.IsExists = false;
            }

            return oDocumentNumber;
        }

        public string DocumentNo(string strDocumentCode, string strLocationCode, string FinYear) 
        {
            string str = "";
            string str2 = "";

            DataTable dt = InsertUpdate(strDocumentCode, strLocationCode, FinYear);

            for (int i = 0; i < 4; i++)
            {
                str2 = dt.Rows[0][i].ToString().Trim();
                if (i == 3)
                {
                    for (int j = str2.Length; j < 4; j = str2.Length)
                    {
                        str2 = "0" + str2;
                    }
                }
                str = str + str2;
            }
            return str;
        }


        public DataTable InsertUpdate(string strDocumentCode, string strLocationCode, string FinYear) 
        {
            System.Object[,] arrParameter = new Object[3, 2];

            arrParameter[0, 0] = "@DocumentCode";
            arrParameter[0, 1] = strDocumentCode;
            arrParameter[1, 0] = "@LocationCode";
            arrParameter[1, 1] = strLocationCode;
            arrParameter[2, 0] = "@FinYear";
            arrParameter[2, 1] = FinYear;
            return cDBConnection.Execute("SP_GET_DOCUMENT_NUMBER", arrParameter);
        }

        public string LoadDocNumber(string strUniqID,string strDocumentCode, string strLocationCode, string FinYear)
        {
            string numFromTempTbl = this.GetDocumentNumberData(strUniqID, strDocumentCode).DocumentNo;
            if ((numFromTempTbl == null) || numFromTempTbl.Equals(""))
            {
                string docNo = this.DocumentNo(strDocumentCode, strLocationCode, FinYear);
                this.InsertDocumentNumberTempTbl(strUniqID, strDocumentCode, docNo);
                return docNo;
            }
            return numFromTempTbl;
        }

        private int InsertDocumentNumberTempTbl(string strUniqID,string strDocumentCode, string strDocumentNo)
        {
            System.Object[,] arrParameter = new Object[3, 2];

            arrParameter[0, 0] = "@mfldPCID";
            arrParameter[0, 1] = strUniqID;
            arrParameter[1, 0] = "@mfldDocumentCode";
            arrParameter[1, 1] = strDocumentCode;
            arrParameter[2, 0] = "@mfldDocumentNo";
            arrParameter[2, 1] = strDocumentNo;

            return cDBConnection.Insert("SP_INSERT_TEMP_DOCUMENT_NUMBER", arrParameter);
        }

        public int DeleteDocumentNumber(string strUniqID,string strDocumentCode,string strDocumentNumber) 
        {
            string strWhere = "fldPCID='" + strUniqID + "' and fldDocumentCode='" + strDocumentCode + "' and fldDocumentNo='"+strDocumentNumber+"'";
            return cDBConnection.DeleteData("tbl_DocumentNumber_Temp",strWhere);
        }
    }
}
