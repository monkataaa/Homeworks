using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {

            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double price = 0;

            string hall = "";

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                price = 2500;
            } else if (groupSize >50 && groupSize <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }
            

            //Console.WriteLine($"price is {price}");

            if (package == "Normal")
            {
                price += 500;
                price = (price - (price * 0.05))/ groupSize;
            } else if (package == "Gold")
            {
                price += 750;
                price = (price - (price * 0.1)) / groupSize;
            } else if (package == "Platinum")
            {
                price += 1000;
                price = (price - (price * 0.15)) / groupSize;
            }

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall."); 
            } else
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {price:F2}$");

            }

            
        }
    }
}
