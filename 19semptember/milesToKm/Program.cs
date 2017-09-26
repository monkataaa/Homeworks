using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milesToKm
{
    class Program
    {
        static void Main(string[] args)
        {

            double miles = Double.Parse(Console.ReadLine());

            double km = miles * 1.60934;

            Console.WriteLine($"{km:F2}");
        }
    }
}
