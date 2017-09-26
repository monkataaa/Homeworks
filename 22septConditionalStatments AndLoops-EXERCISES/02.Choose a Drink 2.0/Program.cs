using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22septConditionalStatments_AndLoops_EXERCISES
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());



            switch (profession)
            {
                case "Athlete":
                    quantity *= 0.70;
                    Console.WriteLine($"The {profession} has to pay {quantity:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    
                    Console.WriteLine($"The {profession} has to pay {quantity:F2}.");
                   
                    break;
                case "SoftUni Student":
                    quantity *= 1.70;
                    Console.WriteLine($"The {profession} has to pay {quantity:F2}.");
                    
                    break;
                default:
                    quantity *= 1.20;
                    Console.WriteLine($"The {profession} has to pay {quantity:F2}.");
                    break;

            }




        }
    }
}
