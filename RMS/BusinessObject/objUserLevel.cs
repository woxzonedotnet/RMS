using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objUserLevel
    {
        public string LocationCode { get; set; }
        public string UserLevelCode { get; set; }
        public string UserLevel { get; set; }
        public bool Changeable { get; set; }
        public DataTable dtItemList { get; set; } 
        public int Status { get; set; }
        public bool IsExists { get; set; }
    }
}
