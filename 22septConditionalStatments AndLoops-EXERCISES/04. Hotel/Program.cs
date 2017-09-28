using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            double nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double doubleRoom = 0;
            double suite = 0;

            switch (month)
            {
                case "May":
                case "October":
                    

                    studio = nights * 50;
                    doubleRoom = nights * 65;
                    suite = nights * 75;
                    if ((month == "October") && nights > 7)
                    {

                        studio -= 50;
                        break;
                    }

                    if (nights > 7)
                    {
                        studio = studio - ( studio * 0.05);
                    }

                    break;
                case "June":
                case "September":
                    studio = nights * 60;
                    doubleRoom = nights * 72;
                    suite = nights * 82;

                    if ((month == "September") && nights > 7)
                    {
                        studio -= 60;
                        break;
                    }

                    if (nights > 14)
                    {
                        doubleRoom = doubleRoom - (doubleRoom * 0.1);
                    }

                    break;
                case "July":
                case "August":
                case "December":
                    studio = nights * 68;
                    doubleRoom = nights * 77;
                    suite = nights * 89;

                    if (nights > 14)
                    {

                        suite = suite - (suite * 0.15);
                    }


                    break;
            }

           // if (( month=="October") && nights > 7)
            //{
              //  
              //  studio -= 50;
            //}
//
  //          if ((month == "September") && nights > 7)
    //        {
      //          studio -= 60;
        //    }
            Console.WriteLine($"Studio: {studio:F2} lv.");
            Console.WriteLine($"Double: {doubleRoom:F2} lv.");
            Console.WriteLine($"Suite: {suite:F2} lv.");



        }
    }
}
