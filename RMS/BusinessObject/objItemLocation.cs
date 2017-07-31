using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objItemLocation
    {
        public string LocationCode { get; set; }
        public string SubLocationCode { get; set; }
        public string ItemCode { get; set; }
        public double ShelfStock { get; set; }
        public double DamageStock { get; set; }
        public double MonthlyOpenQty { get; set; }
        public double OldStock { get; set; }
        public bool Initialized { get; set; }
        public bool DataTransfer { get; set; }
        public char Sup { get; set; }
        public double PendingInvoice { get; set; }
        public double DamageReturn { get; set; }
        public bool Invoiced { get; set; }
        public bool IsExists { get; set; }
    }
}
