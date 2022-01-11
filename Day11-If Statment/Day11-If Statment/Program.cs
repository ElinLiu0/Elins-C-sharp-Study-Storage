using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_If_Statment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Is that you are a male?");
            bool isMale = Convert.ToBoolean(Console.ReadLine());
            Console.Write("input your age please ：");
            int age = Convert.ToInt32(Console.ReadLine());
            if (isMale && age <= 30)
            {
                Console.WriteLine("you are a young boy");
            }
            else if (isMale == false && age <= 30)
            {
               Console.WriteLine("you are a young girl");
            }
            else if (isMale && age >= 30 && age <= 70)
            {
                Console.WriteLine("you are a sir");
            }
            else if (!isMale && age <= 30 && age <= 70)
            {
                Console.WriteLine("Probably you are a Miss or a Mrs");
            }
            else if (isMale && age > 70)
            {
                Console.WriteLine("You are a old man");
            }
            else if (!isMale && age > 70)
            {
                Console.WriteLine("you are a old woman");
            }
            else
            {
                Console.WriteLine("You are not human beings!");
            }
            Console.ReadLine();
        }
    }
}
