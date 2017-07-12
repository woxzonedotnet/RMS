using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objCustomerMaster
    {
        public string LocationCode { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public double CreditLimit { get; set; }
        public double Discount { get; set; }
        public string VatNo { get; set; }
        public bool IsServiceCharge { get; set; }
        public bool IsCreditCustomer { get; set; }
        public bool IsComplementary { get; set; }
    }
}
