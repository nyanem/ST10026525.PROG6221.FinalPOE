using System;
using System.Collections.Generic;

namespace ST10026525.PROG6221.POE
{
    public class recipeClass
    {
        public string recipeName { get; set; }
        public ingredientClass[] Ingredient { get; set; }
        public string[] steps { get; set; }

        // Constructor
        public recipeClass(string recipeName, ingredientClass[] ingredients, string[] steps)
        {
            this.recipeName = recipeName;
            this.Ingredient = ingredients;
            this.steps = steps;
        }

        // Display Recipe Details
        public void displayRecipe()
        {
            Console.WriteLine($"Recipe: {recipeName}");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredient)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.ingredientName}");
            }
            Console.WriteLine("Steps:");
            foreach (var step in steps)
            {
                Console.WriteLine(step);
            }
        }

        // Scale Calculator
        public void scaleCalculator(double factor)
        {
            foreach (var ingredient in Ingredient)
            {
                ingredient.Quantity *= factor;
            }
        }
    }
}
