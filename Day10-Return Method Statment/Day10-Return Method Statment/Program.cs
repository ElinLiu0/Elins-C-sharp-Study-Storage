using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Return_Method_Statment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入计算边长：");
            int side_len = Convert.ToInt32(Console.ReadLine());
            string volume = Cubenum(side_len);
            Console.WriteLine(volume);
            Console.ReadLine();
        }
        static dynamic Cubenum(int side_len)
        {
            int volume = (int)Math.Pow(side_len, 3);
            string result = "这个正方体的体积为 ：" + volume;
            return result;
        }
    }
}
