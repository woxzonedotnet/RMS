using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objOrderType
    {
        public string LocationCode { get; set; }
        public string OrderTypeCode { get; set; }
        public string OrderTypeName { get; set; }
        public int Status { get; set; }
        public bool IsExists { get; set; }
    }
}
