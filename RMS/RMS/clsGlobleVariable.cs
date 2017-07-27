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
        private static string _BrowsDataValue = "";
        private static string _UniqID;
        private static string _DateYear;

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
