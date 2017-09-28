using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            int calories = 0;

            while (count > 0)
            {
                string ingredients= Console.ReadLine().ToLower();
                

                if(ingredients== "cheese")
                {
                    calories += 500;
                } else if (ingredients == "tomato sauce")
                {
                    calories += 150;
                }
                else if (ingredients == "salami")
                {
                    calories += 600;
                }
                else if (ingredients == "pepper")
                {
                    calories += 50;
                }


                count--;
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
