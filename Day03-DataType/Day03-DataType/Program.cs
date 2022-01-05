using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = "Hello World";
            /* char字符型数据与string不同之处在于：char仅可以保存一个字符，而string是由多个char构成的数组
             * 因此，string和char在变量保存时，一个使用双引号，一个使用单引号 */
            char bools = 'T';
            /* 在C#中，一共有三种数据类型可以存放小数点数据，分别是float（单精度），double（双精度）和 decimal（十进制）
               在通常情况下，double足可以满足日常的编程需要，除非有对精度极高的要求时才使用decimal（节省内存开支）*/
            double doubles = 2.0;
            int ints = 2;
            bool male = true;
        }
    }
}
