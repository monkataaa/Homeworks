﻿using System;
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
            int multiplier = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
                multiplier++;
            } while (multiplier <= 10);
        }
    }
}
