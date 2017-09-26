using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int count = 1;

            for (int i = 1; i < num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
