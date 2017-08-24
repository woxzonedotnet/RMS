using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objGoodReceiveNote
    {
        public string LocationCode { get; set; }
        public string GRNCode { get; set; }
        public string SubLocationCode { get; set; }
        public string SupplierCode { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNo { get; set; }
        public double GRNValue { get; set; }
        public double VATPresentage { get; set; }
        public double VATAmount { get; set; }
        public double Discount { get; set; }
        public double NetAmount { get; set; }
        public string POCode { get; set; }
        public string GRNCancelCode { get; set; }
        public bool IsGRNCancel { get; set; }
        public string User { get; set; }
        public string Reason { get; set; }
        public DataTable dtItemList { get; set; }
        public int Status { get; set; }
        public bool IsExists { get; set; }
    }
}
