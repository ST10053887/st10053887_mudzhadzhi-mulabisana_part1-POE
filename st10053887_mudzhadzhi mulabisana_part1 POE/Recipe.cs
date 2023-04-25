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

    }
}
