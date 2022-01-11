using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14___Switch_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Input the daynumber:");
            int dayIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetDay(dayIndex));
            Console.ReadLine();
        }
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 1:
                    dayName = "Monday";
                    break ;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wensday";
                    break;
                case 4:
                    dayName = "ThursDay";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sonday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }
            return dayName;
        }
    }
}
