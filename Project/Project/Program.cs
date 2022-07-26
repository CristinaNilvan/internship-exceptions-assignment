﻿using Project;

Ingredient ingredient01 = new Ingredient(1, "faina", 60, 40);
Ingredient ingredient02 = new Ingredient(2, "lapte", 55, 50);
Ingredient ingredient03 = new Ingredient(3, "zahar", 45, 70);
Ingredient ingredient04 = new Ingredient(4, "piersica", 30, 60);

var ingredientList = new List<Ingredient>();
ingredientList.Add(ingredient01);
ingredientList.Add(ingredient02);
ingredientList.Add(ingredient03);
ingredientList.Add(ingredient04);

var recipe = new Recipe(1, "Prajitura cu piersici", 190, ingredientList);
int number = 0;
bool foundException = false;

//Write Try-catch-Finally block with multiple catch statements
//Add conditional compilation symbols
#if DEBUG
try
{
    number = 6;
    var auxIngredient = recipe.GetAnIngredient(number);
    Console.WriteLine($"The ingredient with number {number} is: {auxIngredient.Name}");
}
catch (ArgumentOutOfRangeException)
{
    foundException = true;
    Console.WriteLine("The given number is invalid!");
}
finally
{
    number = 0;
}
#elif RELEASE
try
{
    number = 58;
    var auxIngredients = recipe.FindIngredientsLessThanCalories(number);

    Console.WriteLine($"The ingredients with calories less than {number} are:");
    foreach (var item in auxIngredients)
    {
        Console.WriteLine(item.Name);
    }
}
catch (NegativeCaloriesException e)
{
    foundException = true;
    Console.WriteLine(e.Message);
}
catch (NoMatchException e)
{
    foundException = true;
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("End of testing try-catch...");
}
#endif

//Use debug class to write debug information to output window
DebugOperation.Action(foundException);