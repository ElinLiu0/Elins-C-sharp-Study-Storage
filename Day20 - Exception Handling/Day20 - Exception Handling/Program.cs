using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20___Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
                try
                {
                    Console.Write("Enter a number : ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter another number : ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(num1 / num2);

                    Console.ReadLine();
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You are tring divide zero!Please Retry");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Sure you are using correct C# support Num type?");
                }
                finally
                {
                    Console.WriteLine("Expression Call Error");
                }
            }
        }
}
