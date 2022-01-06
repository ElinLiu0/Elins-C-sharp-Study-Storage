using System;

namespace Day07_Build_Basic_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用Convert类下的方法实现字符串向数字（反之）的转换
            Console.Write("Input the first value : ");
            dynamic number1 = 0;
            dynamic number2 = 0;
            string get_uservalue1 = Console.ReadLine();
            try
            {
                number1 = Convert.ToInt32(get_uservalue1);
            }
            catch(Exception ex)
            {
                number1 = Convert.ToDouble(get_uservalue1);
            }
            Console.Write("Input the second value : ");
            string get_uservalue2 = Console.ReadLine();
            try
            {
                number2 = Convert.ToInt32(get_uservalue2);
            }
            catch (Exception ex)
            {
                number2 = Convert.ToDouble(get_uservalue2);
            }
            Console.Write("Input the method : ");
            string method = Console.ReadLine();
            if (method == "+")
            {
                Console.WriteLine("Result is {0}", (number1 + number2));
            }
            else if (method == "-")
            {
                Console.WriteLine("Result is {0}", (number1 - number2));
            }
            else if (method == "*")
            {
                Console.WriteLine("Result is {0}", (number1 * number2));
            }
            else if (method == "/")
            {
                Console.WriteLine("Result is {0}", (number1 / number2));
            }
            else if (method == "%")
            {
                Console.WriteLine("Result is {0}", (number1 % number2));
            }
            Console.ReadLine();
        }
    }
}
