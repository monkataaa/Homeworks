using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22septConditionalStatments_AndLoops_EXERCISES
{
    class StartUp
    {
      public  static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            
           
            switch (drink)
            {
                case "Athlete":
                    Console.WriteLine( "Water" );
                    break;
                case "Businessman":                    
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default :
                    Console.WriteLine("Tea");
                    break;

            }




        }
    }
}
