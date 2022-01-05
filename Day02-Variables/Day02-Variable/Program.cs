using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //变量声明
            string charaterName = "John";
            string charaterGender = "Men";
            int characterAge = 25;
            //使用+进行字符串（变量之间的连接）
            Console.WriteLine("This " + charaterGender + "called " + charaterName + " at " + characterAge + " years old.");
            Console.ReadLine();
        }
    }
}
