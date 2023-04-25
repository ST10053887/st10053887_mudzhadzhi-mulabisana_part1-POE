using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st10053887_mudzhadzhi_mulabisana_part1_POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter recipe details:");

            Console.Write("Number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            Console.Write("Number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            Recipe recipe = new Recipe(numIngredients, numSteps);

            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write("Ingredient {0} name: ", i + 1);
                string name = Console.ReadLine();

                Console.Write("Ingredient {0} quantity: ", i + 1);
                decimal quantity = decimal.Parse(Console.ReadLine());

                Console.Write("Ingredient {0} unit: ", i + 1);
                string unit = Console.ReadLine();

                recipe.SetIngredient(i, name, quantity, unit);
            }
        }
    }
}
