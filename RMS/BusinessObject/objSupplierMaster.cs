using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objSupplierMaster
    {
        public string LocationCode { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string TellephoneNo { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string SupplierCategoryCode { get; set; }
        public double Discount { get; set; }
        public bool Consignment { get; set; }
        public DateTime EnterdDate { get; set; }
        public DateTime CancelDate { get; set; }
        public int Status { get; set; }
        public bool RelesePendingPO { get; set; }
        public bool IsExists { get; set; }
    }
}
