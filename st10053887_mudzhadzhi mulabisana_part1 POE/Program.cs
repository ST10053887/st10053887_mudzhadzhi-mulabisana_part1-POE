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
        }
    }
}
