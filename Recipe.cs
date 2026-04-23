using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingRecipeManager
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public string ImagePath { get; set; }
        public override string ToString() => Name;
    }
}
