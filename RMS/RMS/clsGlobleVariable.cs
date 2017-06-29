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

        public string LocationCode
        {
            get { return _LocationCode; }
            set { _LocationCode = value; }
        }
    }


}
