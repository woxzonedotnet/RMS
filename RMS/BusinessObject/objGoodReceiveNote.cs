using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objGoodReceiveNote
    {

        string GRNNumber { get; set; }
        string Location { get; set; }
        string Supplier { get; set; }
        DateTime Date { get; set; }
        string InvoiceNo { get; set; }
        string GRNValue { get; set; }
        decimal VatAmount { get; set; }
        decimal Discount { get; set; }
        decimal VatPrecentage { get; set; }

    }
}
