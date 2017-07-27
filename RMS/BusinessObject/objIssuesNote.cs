using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
   public class objIssuesNote
    {
        public string IssuesNumber { get; set; }
        public string LocationFrom { get; set; }
        public string Date { get; set; }
        public decimal Total { get; set; }
        public bool IsExists { get; set; }

    }
}
