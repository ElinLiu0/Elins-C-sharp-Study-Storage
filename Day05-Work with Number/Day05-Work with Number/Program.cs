using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Work_with_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 在C#中，为了保证数据结构的一致性，当你使用两个整数之间进行相除操作时，如下：5 / 2
             * 则会返回结果为整数型的：2 */
            Console.WriteLine( 5 / 2);
            // 当对象中存在小数时，将以小数形式进行值返回
            Console.WriteLine(5 / 2.0);
            // 调用Math依赖实现对数字对象的数学计算操作
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Max(1, 2));
            Console.ReadLine();
        }
    }
}
