using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10026525.PROG6221.POE
{
    public class recipeManager
    {
        private List<recipeClass> recipes = new List<recipeClass>();
        private recipeClass selectedRecipe = null;
        private bool scaled = false;
        private double originalFactor = 1.0;

        public List<recipeClass> GetRecipes()
        {
            return recipes;
        }

        public void AddRecipe(recipeClass newRecipe)
        {
            recipes.Add(newRecipe);
        }

        public recipeClass GetRecipe(int index)
        {
            if (index >= 0 && index < recipes.Count)
            {
                return recipes[index];
            }
            return null;
        }

        public void SelectRecipe(int index)
        {
            if (index >= 0 && index < recipes.Count)
            {
                selectedRecipe = recipes[index];
            }
        }

        public void ScaleSelectedRecipe(double factor)
        {
            if (selectedRecipe != null && !scaled)
            {
                selectedRecipe.scaleCalculator(factor);
                originalFactor = factor;
                scaled = true;
            }
        }

        public void ResetSelectedRecipe()
        {
            if (selectedRecipe != null && scaled)
            {
                selectedRecipe.scaleCalculator(1.0 / originalFactor);
                scaled = false;
            }
        }

        public void ClearAllRecipes()
        {
            recipes.Clear();
            selectedRecipe = null;
            scaled = false;
        }
    }
}



