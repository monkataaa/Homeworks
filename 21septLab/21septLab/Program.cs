﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21septLab
{
    class Program
    {
      public  static void Main(string[] args)
        {

            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (day == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("12$");
                } else if (age > 18 && age <= 64)
                {
                    Console.WriteLine("18$");

                } else if (age > 64  && age <= 122)
                {
                    Console.WriteLine("12$");
                } else if (age<0 && age < 122)
                {
                    Console.WriteLine("Error");
                }
            }
            else if (day == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("15$");
                }
                else if (age > 18 && age <= 64)
                {
                    Console.WriteLine("20$");

                }
                else if (age > 64 && age <= 122)
                {
                    Console.WriteLine("15$");
                }
                else if (age < 0 && age < 122)
                {
                    Console.WriteLine("Error");
                }
            }
            else if (day == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (age > 18 && age <= 64)
                {
                    Console.WriteLine("12$");

                }
                else if (age > 64 && age <= 122)
                {
                    Console.WriteLine("10$");
                }
                else if (age < 0 && age < 122)
                {
                    Console.WriteLine("Error!");
                }
            }

        }
    }
}