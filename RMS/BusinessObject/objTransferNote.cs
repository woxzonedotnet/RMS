using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objTransferNote
    {
        public string LocationCode { get; set; }
        public string IssueNumber { get; set; }
        public string FromSubLocation { get; set; }
        public string ToSubLocation { get; set; }
        public DateTime IssueDate { get; set; }
        public double IssueValue { get; set; }
        public string User { get; set; }
        public DataTable dtTransferNote { get; set; }
        public bool IsExists { get; set; }
    }
}
