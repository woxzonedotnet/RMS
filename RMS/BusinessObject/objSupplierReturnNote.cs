using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objSupplierReturnNote
    {
        public string LocationCode { get; set; }
        public string SRNCode { get; set; }
        public string SubLocationCode { get; set; }
        public string SupplierCode { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNo { get; set; }
        public double SRNValue { get; set; }
        public double VATPresentage { get; set; }
        public double VATAmount { get; set; }
        public double Discount { get; set; }
        public double NetAmount { get; set; }

        public string GRNCode { get; set; }


        //public string ItemCode { get; set; }
        //public string ItemDescription { get; set; }
        //public double UnitPrice { get; set; }
        //public double Quantity { get; set; }
        //public double TaxAmount { get; set; }
        //public double TotalAmount { get; set; }
        public DataTable dtItemList { get; set; }

        public int Status { get; set; }
        public bool IsExists { get; set; }
    }
}
