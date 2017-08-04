using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
   public class objStockAdjustmentNote
    {
       public string LocationCode { get; set; }
       public string SANNumber { get; set; }
       public string SubLocation { get; set; }
       public DateTime Date { get; set; }
       public double TotalCost { get; set; }
       public string User { get; set; }
       public DataTable dtItemData { get; set; }
       
       public bool IsExists { get; set; }
    }
}
