using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS
{
    class clsGlobleVariable
    {
        private static string _LocationCode = "LOC01";
        private static string _User = "USER01";
        private static string _CompanyName = "WOXZONE (PVT) LTD";
        private static string _Address_1 = "21/5 PAGODA ROAD";
        private static string _Address_2 = "NUGEGODA";
        private static string _Address_3 = "COLOMBO";
        private static string _BrowsDataValue = "";
        private static string _UniqID;
        private static string _DateYear;
        private static string _CopyRight = "Copyright © 2008 WOXZONE (PVT) LTD";
        private static string _CustomerWeb = "www.woxzone.com";
        private static string _CustomerTel = "+9411254853";
        private static string _CustomerFAX = "+9411254853";
        private static string _CustomerEmail = "info@woxzone.com";
        private static string _ReportLocation = "";

        public string strServerName { get; set; }
        public string strDatabaseName { get; set; }
        public string strUsername { get; set; }
        public string strPassword { get; set; }
        public string strSecurity { get; set; }

        public string User
        {
            get { return _User; }
            set { _User = value; }
        }
        public string ReportLocation
        {
            get { return _ReportLocation; }
            set { _ReportLocation = value; }
        }
        public string CustomerTel
        {
            get { return _CustomerTel; }
            set { _CustomerTel = value; }
        }
        public string CustomerFAX
        {
            get { return _CustomerFAX; }
            set { _CustomerFAX = value; }
        }
        public string CustomerEmail
        {
            get { return _CustomerEmail; }
            set { _CustomerEmail = value; }
        }

        public string CustomerWeb
        {
            get { return _CustomerWeb; }
            set { _CustomerWeb = value; }
        }
        public string CopyRight
        {
            get { return _CopyRight; }
            set { _CopyRight = value; }
        }
        public string Address_1
        {
            get { return _Address_1; }
            set { _Address_1 = value; }
        }
        public string Address_2
        {
            get { return _Address_2; }
            set { _Address_2 = value; }
        }
        public string Address_3
        {
            get { return _Address_3; }
            set { _Address_3 = value; }
        }

        public string CompanyName
        {
            get { return _CompanyName; }
            set { _CompanyName = value; }
        }
        public string DateYear
        {
            get { return _DateYear; }
            set { _DateYear = value; }
        }

        public string UniqID
        {
            get { return _UniqID; }
            set { _UniqID = value; }
        }


        public string BrowsDataValue
        {
            get { return _BrowsDataValue; }
            set { _BrowsDataValue = value; }
        }

        public string LocationCode
        {
            get { return _LocationCode; }
            set { _LocationCode = value; }
        }
    }


}
