using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05taskForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string leanguage = Console.ReadLine();

            switch (leanguage)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;

                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
