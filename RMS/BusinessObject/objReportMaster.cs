using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objReportMaster
    {
        public string LocationCode{get;set;}
        public string ReportID { get; set; }
        public string ReportName { get; set; }
        public string ReportTitle { get; set; }
        public string SelectionFormular { get; set; }
        public string SelectedTable { get; set; }
    }
}
