using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objSubLocation
    {
        public string LocationCode { get; set; }
        public string SubLocationCode { get; set; }
        public string SubLocationName { get; set; }
        public bool ShowInFrontEnd { get; set; }
        public bool IsOrderLocation { get; set; }
    }
}
