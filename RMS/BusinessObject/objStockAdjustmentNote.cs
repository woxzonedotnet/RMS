using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
   public class objStockAdjustmentNote
    {
       public string SANNumber { get; set; }
       public string Location { get; set; }
       public DateTime Date { get; set; }
       public decimal TotalCost { get; set; }
       public bool IsExists { get; set; }
    }
}
