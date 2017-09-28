using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());
            int sum = 0;
            int combinations = 0;
            Boolean stillWorking = true;

            for (int i = num1; i >= 1 && stillWorking; i--)
            {
                
                for (int j = 1; j <= num2; j++)
                {
                    ++combinations;

                    if (control == sum)
                    {



                        Console.WriteLine($"{combinations - 1} combinations");
                        Console.WriteLine($"Sum: {sum} >= {control}");

                        stillWorking = false;
                        break;

                    } else if (control >=sum )
                    {   

                        
                        
                        Console.WriteLine($"{combinations-1} combinations");
                        Console.WriteLine($"Sum: {sum} >= {control}");
                        
                        stillWorking = false;
                        break;

                    } else if (i==1 && j == num2)
                    {
                        sum = sum + (3 * (i * j));
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {sum}");

                        stillWorking = false;
                        break;

                    }
                    sum = sum+ (3 * (i * j));
                    
                }
            }

        }
    }
}
