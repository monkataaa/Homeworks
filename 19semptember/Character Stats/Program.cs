using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write($"Health: |{new string('|', health)}");
            Console.WriteLine($"{new string('.',healthMax-health)}|");
            Console.Write($"Energy: |{new string('|', energy)}");
            Console.WriteLine($"{new string('.', energyMax - energy)}|");

        }
    }
}
