using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objUserMaster
    {
        public string LocationCode { get; set; }
        public string UserCode { get; set; }
        public string FromSubLocation { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Changeable { get; set; }
        public string UserLevel { get; set; }
        public int Status { get; set; }
        public bool IsExists { get; set; }
    }
}
