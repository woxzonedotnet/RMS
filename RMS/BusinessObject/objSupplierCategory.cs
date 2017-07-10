using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objSupplierCategory
    {
        public string LocationCode { get; set; }
        public string SupplierCode { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public bool IsExists { get; set; }
    }
}
