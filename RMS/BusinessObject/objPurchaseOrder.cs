using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objPurchaseOrder
    {
        public string LocationCode { get; set; }
        public string PurchaseOrderCode { get; set; }
        public string SubLocationCode { get; set; }
        public string SupplierCode { get; set; }
        public DateTime Date { get; set; }
        public double Purchase { get; set; }
        public double VAT { get; set; }
        public double NetAmount { get; set; }
        public string Remarks { get; set; }
        public DataTable dtItemList { get; set; }
        public int Status { get; set; }
        public bool IsExists { get; set; }
    }
}
