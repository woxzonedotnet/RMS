using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objCategoryMaster
    {
        public string LocationCode { get; set; }
        public string DepartmentCode { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public int Status { get; set; }
        public bool IsExistCategory { get; set; }
    }
}
