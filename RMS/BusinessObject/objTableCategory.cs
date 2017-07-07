using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objTableCategory
    {
        public string LocationCode { get; set; }
        public string TableCategoryCode { get; set; }
        public string TableCategoryName { get; set; }
        public int Status { get; set; }
        public bool IsExists { get; set; }
    }
}
