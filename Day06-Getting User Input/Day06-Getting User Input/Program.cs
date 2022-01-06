using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_Getting_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用Console.Write() + Console.ReadLine()进行用户输入获取，并使用变量进行存储
            Console.Write("Who are you?");
            Console.O
            string name = Console.ReadLine();
            Console.WriteLine("Greetings " + name + " and welecome you are trying to learn C#.");
            Console.ReadLine();
        }
    }
}
