using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objRecipeDetails
    {
        public string LocationCode { get; set; }
        public string SubLocationCode { get; set; }
        public string RecipeCode { get; set; }
        public string RecipeName { get; set; }
        public string OrderTypeCode { get; set; }
        public double RecipeCost { get; set; }
        public DataTable dtRecipeDetails { get; set; }
        public bool IsExists { get; set; }
    }
}
