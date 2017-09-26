using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int count=0;


            while (true)
            {
                string ingredients = Console.ReadLine();
                if (ingredients != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredients}");
                    count++;
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    break;
                }
            }
          

            
        }

    }
}
