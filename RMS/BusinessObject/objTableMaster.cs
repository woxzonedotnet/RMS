using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objTableMaster
    {
        public string LocationCode { get; set; }
        public string TableCode { get; set; }
        public string TableCategoryCode { get; set; }
        public string SubLocationCode { get; set; }
        public int TableSeats { get; set; }
        public int TableStatus { get; set; }
        public bool IsExists { get; set; }
    }
}
