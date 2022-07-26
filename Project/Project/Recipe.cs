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
        public List<Ingredient> Ingredients { get; set; }

        //Create methods which checks input arguments and throws exceptions
        //Rethrow exception
        public Ingredient GetAnIngredient(int number)
        {
            try
            {
                return Ingredients.ElementAt(number);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw;
            }
        }

        //Create custom exceptions and throw them 
        public List<Ingredient> FindIngredientsLessThanCalories(int calories)
        {
            if (calories < 0)
                throw new NegativeCaloriesException("Not valid number of calories: negative number!");

            var auxIngredients = new List<Ingredient>();
            foreach (var item in Ingredients)
            {
                if (item.Calories < calories)
                {
                    auxIngredients.Add(item);
                }
            }

            if (auxIngredients.Count == 0)
                throw new NoMatchException("No elements were found!");

            return auxIngredients;
        }
    }
}
