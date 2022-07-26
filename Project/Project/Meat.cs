using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Meat : Ingredient
    {
        public Meat(int id, string? name, int calories, double quantity, string? origin) :
            base(id, name, calories, quantity)
        {
            Origin = origin;
        }

        public string? Origin { get; set; }

        public override string GenerateIngredientCode()
        { 
            return base.GenerateIngredientCode() + Origin[..2];
        }
    }
}
