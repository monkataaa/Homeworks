using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {


            int start = 40;
            int end = 50;
            int change;

            Boolean goFurther = true;

            if (start > end)
            {
                change = start;
                start = end;
                end = change;
            }

            if ((end - start) < 5)
            {
                Console.WriteLine("No");
            } else if (goFurther)
            {
                int num1=start;
                int num2=0;
                int num3 = 0;
                int num4 = 0;
                int num5 = 0;



                for (int i = num1; i < end; i++)
                {
                    for (int u = 0; u < end; u++)
                    {
                        for (int y = 0; y < end; y++)
                        {
                            for (int t = 0; t < end; t++)
                                for (int r = 0; r <= end; r++)
                                {
                                    if ((i < u) && (u < y) && (y < t) && (t < r))
                                    {
                                        Console.WriteLine($"{i} {u} {y} {t} {r}");
                                        
                                    } else if (
                                        num5-num1==4 &&
                                        num5-num2==3 &&
                                        num5-num3==2 &&
                                        num5-num4==1

                                        )
                                    {
                                        Console.WriteLine("stop");
                                        goFurther = false;
                                        break;
                                    }

                                }
                            {

                            }

                        }


                    }

                }

            }

            


            
        }
    }
}
