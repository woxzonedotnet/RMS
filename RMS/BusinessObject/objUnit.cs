using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objUnit
    {
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string UnitSymbol { get; set; }
        public double CapacitySize { get; set; }
        public int Status { get; set; }
        public bool IsExists { get; set; }
    }
}
