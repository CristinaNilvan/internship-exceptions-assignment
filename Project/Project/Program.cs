using Project;

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

var auxIngredient = recipe.GetAnIngredient(6);
Console.WriteLine(auxIngredient.ToString());