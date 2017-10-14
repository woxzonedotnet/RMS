using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objMenuDetails
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string FullDescription { get; set; }
        public string BillDescription { get; set; }
        public string SubLocationCode { get; set; }
        public string PrintLocationCode { get; set; }
        public string MenuDepartmentCode { get; set; }
        public string MenuCategoryCode { get; set; }
        public double SellingPrice { get; set; }
        public double PackingCharges { get; set; }
        public double TimeToPrepare { get; set; }
        public string ButtonBackground { get; set; }
        public string ButtonForground { get; set; }
        public byte[] photo_aray { get; set; }
        public string FileName { get; set; }
        public string ButtonName { get; set; }
        public string FontName { get; set; }
        public double FontSize { get; set; }
        public string FontStyle { get; set; }
        public bool ServiceCharge { get; set; }
        public double TotalCost { get; set; }
        public int Status { get; set; }
        public bool IsExists { get; set; }
        public DataTable dtRecipeDetails { get; set; }
        public DataTable dtLocation { get; set; }
        
    }
}
