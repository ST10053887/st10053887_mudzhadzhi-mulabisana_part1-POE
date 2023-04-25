using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st10053887_mudzhadzhi_mulabisana_part1_POE
{
    internal class Recipe
    {
        private Ingredient[] ingredients;
        private Step[] steps;

        public Recipe(int numIngredients, int numSteps)
        {
            ingredients = new Ingredient[numIngredients];
            steps = new Step[numSteps];
        }

        public void SetIngredient(int index, string name, decimal quantity, string unit)
        {
            ingredients[index] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
        }

        public void SetStep(int index, string description)
        {
            steps[index] = new Step { Description = description };
        }
        public void PrintRecipe()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine("{0} {1} {2}", ingredient.Quantity, ingredient.Unit, ingredient.Name);
            }

            Console.WriteLine("Steps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, steps[i].Description);
            }
        }

        public void ScaleRecipe(decimal factor)
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity /= 2;
            }
        }

        public void ClearRecipe()
        {
            Array.Clear(ingredients, 0, ingredients.Length);
            Array.Clear(steps, 0, steps.Length);
        }
    }
}
