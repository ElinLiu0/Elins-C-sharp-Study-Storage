using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 使用[]来声明一个数组
            int[] luckynumber = {4,8,15,16,23,42};
            for(int i = 0; i < luckynumber.Length; i++)
            {
                Console.WriteLine(luckynumber[i]);
            }
            // 创建一个空的矩阵进行备用，在new string[]中的[]可以指定这个矩阵允许承载的最大元素数量
            string[] luckname = new string[5];
            // 可以使用数组的索引对其进行值插入或者重新更改
            luckname[0] = "Mike";
            luckname[1] = "John";
            // 数组内的所有数据类型需均保持一致
            Console.WriteLine(luckname[1]);
            Console.ReadLine();
        }
    }
}
