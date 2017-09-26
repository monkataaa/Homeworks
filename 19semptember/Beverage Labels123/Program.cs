using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels123
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Double volume = double.Parse(Console.ReadLine());
            Double energyContent = Double.Parse(Console.ReadLine());
            energyContent = energyContent * (volume / 100);
            Double sugarContent = double.Parse(Console.ReadLine());
            sugarContent = sugarContent * (volume / 100);

            Console.WriteLine($"{volume}ml {name}: ");
            Console.WriteLine($"{ energyContent}kcal, {sugarContent}g sugars");


        }
    }
}
