using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09taskMultiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {


            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter <= 10)
            {
                Console.WriteLine($"{number} X {counter} = {number*counter}");
                counter++;
            }
        }
    }
}
