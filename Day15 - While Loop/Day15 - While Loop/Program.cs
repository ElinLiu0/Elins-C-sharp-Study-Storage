using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15___While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            int count = 0;
            while(index > 0)
            {
                Console.WriteLine(count);
                count++;
                if (count == 10)
                {
                    break;
                }
            }
            /*
             do while循环：
                当while关键字前出现do关键字时
                C#将会优先处理do中的代码进而再去执行while
                例如：
                    do
                    {
                        Console.WriteLine(1);    
                    } while (index=5);
             */
            Console.ReadLine();
        }
    }
}
