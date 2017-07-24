using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objRecipeDetails
    {
        public string RecipeCode { get; set;}
        public string OrderType { get; set; }

        public string Location { get; set; }

        public string FullDescription { get; set; }

        public string RecipeCost { get; set; }

        public bool IsExists { get; set; }
    }
}
