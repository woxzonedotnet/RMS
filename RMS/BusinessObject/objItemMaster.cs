using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objItemMaster
    {

        public string LocationCode { get; set; }
        public string ItemCode { get; set; }
        public string BarCode { get; set; }
        public bool Consignm { get; set; }
        public string Department { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
        //public int Unit { get; set; }
        public double PackageSize { get; set; }
        public string Description { get; set; }
        public bool Weighted { get; set; }
        public string SubCategory { get; set; }
        public string MenuCategory { get; set; }
        public double MinimumGP { get; set; }
        public double Capacity { get; set; }
        public string CapacityType { get; set; }
        public double CostPrice { get; set; }
        public double WholeSalePrice { get; set; }
        public double SellingPrice { get; set; }
        public double ReOrderLevel { get; set; }
        public double ReOrderQty { get; set; }
        public double ReOrderMax { get; set; }
        public int Status { get; set; }
        public bool IsExists { get; set; }

    }
}
