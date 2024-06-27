using System.Collections.Generic;
using System.Windows;

namespace ST10026525.PROG6221.POE
{
    public partial class MainWindow : Window
    {
        private List<recipeClass> recipes = new List<recipeClass>(); // List to store recipes
        private recipeClass selectedRecipe; // Track the currently selected recipe

        public MainWindow()
        {
            InitializeComponent();
        }

        // Option 1: Enter a new recipe
        private void EnterNewRecipe_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = PromptUserForInput("Enter the Name of your Recipe:");
            if (string.IsNullOrWhiteSpace(recipeName))
            {
                MessageBox.Show("Recipe name cannot be empty.");
                return;
            }

            int numIngredients = PromptUserForIntegerInput("How many Ingredients does this Recipe need?:");
            if (numIngredients <= 0)
            {
                MessageBox.Show("Please enter a valid number of ingredients.");
                return;
            }

            // Input values for ingredients
            ingredientClass[] ingredients = new ingredientClass[numIngredients];
            for (int i = 0; i < numIngredients; i++)
            {
                string ingredientName = PromptUserForInput($"Enter Ingredient #{i + 1} Name:");
                double quantity = PromptUserForDoubleInput($"Enter Quantity for {ingredientName}:");
                string unit = PromptUserForInput($"Enter Unit for {ingredientName}:");

                ingredients[i] = new ingredientClass(ingredientName, quantity, unit);
            }

            int numSteps = PromptUserForIntegerInput("How many steps does this recipe have?");
            if (numSteps <= 0)
            {
                MessageBox.Show("Please enter a valid number of steps.");
                return;
            }

            // Input values for steps
            string[] steps = new string[numSteps];
            for (int i = 0; i < numSteps; i++)
            {
                steps[i] = PromptUserForInput($"Enter step {i + 1}:");
            }

            // Create new recipe and add to list
            recipeClass newRecipe = new recipeClass(recipeName, ingredients, steps);
            recipes.Add(newRecipe);
            MessageBox.Show("Recipe added successfully.");
        }

        // Option 2: Display all recipes titles
        private void DisplayAllRecipes_Click(object sender, RoutedEventArgs e)
        {
            if (recipes.Count > 0)
            {
                string recipeList = "Recipes:\n";
                foreach (var recipe in recipes)
                {
                    recipeList += $"{recipe.recipeName}\n";
                }
                MessageBox.Show(recipeList);
            }
            else
            {
                MessageBox.Show("No recipes available.");
            }
        }

        // Option 3: Display a recipe with its ingredients and steps
        private void DisplayRecipeDetails_Click(object sender, RoutedEventArgs e)
        {
            if (selectedRecipe != null)
            {
                // Display detailed recipe information in a new window or message box
                string details = $"Recipe: {selectedRecipe.recipeName}\n\nIngredients:\n";
                foreach (var ingredient in selectedRecipe.Ingredient)
                {
                    details += $"{ingredient.Quantity} {ingredient.Unit} of {ingredient.ingredientName}\n";
                }
                details += "\nInstructions:\n";
                foreach (var step in selectedRecipe.steps)
                {
                    details += $"{step}\n";
                }

                MessageBox.Show(details, "Recipe Details");
            }
            else
            {
                MessageBox.Show("No recipe selected.");
            }
        }

        // Option 4: Enter to scale recipe
        private void ScaleRecipe_Click(object sender, RoutedEventArgs e)
        {
            if (selectedRecipe != null)
            {
                double factor = PromptUserForDoubleInput("Enter scaling factor (e.g., 0.5 for half, 2 for double):");
                if (factor <= 0)
                {
                    MessageBox.Show("Scaling factor must be greater than zero.");
                    return;
                }

                selectedRecipe.scaleCalculator(factor);
                MessageBox.Show("Recipe scaled successfully.");
            }
            else
            {
                MessageBox.Show("Please select a recipe first.");
            }
        }

        // Option 5: Reset the ingredients of a recipe
        private void ResetIngredients_Click(object sender, RoutedEventArgs e)
        {
            if (selectedRecipe != null)
            {
                selectedRecipe.scaleCalculator(1.0); // Reset to original
                MessageBox.Show("Ingredients reset to original quantities.");
            }
            else
            {
                MessageBox.Show("Please select a recipe first.");
            }
        }

        // Option 6: Filter all recipes
        private void FilterRecipes_Click(object sender, RoutedEventArgs e)
        {
            // Placeholder for filtering recipes based on criteria
            MessageBox.Show("Filtering recipes functionality not implemented.");
        }

        // Option 7: Clear data
        private void ClearData_Click(object sender, RoutedEventArgs e)
        {
            recipes.Clear();
            selectedRecipe = null;
            MessageBox.Show("All data cleared.");
        }

        // Option 8: Exit button
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close(); // Close the main window
        }

        // Helper method to prompt user for string input
        private string PromptUserForInput(string prompt)
        {
            // You should have TextBox controls in your MainWindow.xaml to get user input
            // This method is just a placeholder; actual implementation depends on your UI design
            return ""; // Placeholder return
        }

        // Helper method to prompt user for integer input
        private int PromptUserForIntegerInput(string prompt)
        {
            // You should have TextBox controls in your MainWindow.xaml to get user input
            // This method is just a placeholder; actual implementation depends on your UI design
            return 0; // Placeholder return
        }

        // Helper method to prompt user for double input
        private double PromptUserForDoubleInput(string prompt)
        {
            // You should have TextBox controls in your MainWindow.xaml to get user input
            // This method is just a placeholder; actual implementation depends on your UI design
            return 0.0; // Placeholder return
        }
    }
}

