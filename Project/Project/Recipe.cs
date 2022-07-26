using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Recipe
    {
        public Recipe(int id, string? name, int calories, List<Ingredient>? ingredients)
        {
            Id = id;
            Name = name;
            Calories = calories;
            Ingredients = ingredients;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Calories { get; set; }
        public List<Ingredient>? Ingredients { get; set; }

        //Create methods which checks input arguments and throws exceptions
        public Ingredient GetAnIngredient(int number)
        {
            if (number > Ingredients.Count)
                throw new ArgumentOutOfRangeException();

            return Ingredients.ElementAt(number);
        }
    }
}
