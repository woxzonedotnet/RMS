using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objMenuCategory
    {
        public string LocationCode { get; set; }
        public string MenuDepartmentCode { get; set; }
        public string MenuCategoryCode { get; set; }
        public string MenuCategoryName { get; set; }
        public int Status { get; set; }
        public bool IsExists { get; set; }
    }
}
