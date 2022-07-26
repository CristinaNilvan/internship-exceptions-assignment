using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Dairy : Ingredient
    {
        public Dairy(int id, string? name, int calories, double quantity, double lactose) : 
            base(id, name, calories, quantity)
        {
            Lactose = lactose;
        }

        public double Lactose { get; set; }

        public override string GenerateIngredientCode()
        {
            return base.GenerateIngredientCode() + Lactose.ToString();
        }
    }
}
