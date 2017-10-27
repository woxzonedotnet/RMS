using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objFoodOrder
    {
        public string LocationCode { get; set; }
        public string SubLocationCode { get; set; }
        public string OrderNo { get; set; }
        public string StewardCode { get; set; }
        public string TableCode { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public double SubTotal { get; set; }
        public double Discount { get; set; }
        public double Tax { get; set; }
        public int OrderState { get; set; }
        public DataTable Items { get; set; }
        public bool IsExists { get; set; }
    }
}
