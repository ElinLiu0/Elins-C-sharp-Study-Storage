using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 在C#中，方法可以同Python一样直接调用，当方法存在返回值，则需要变量对其进行承接
            SayHi("John",12);
            Console.ReadLine();
        }
        // static表示该方法是一个静态方法，void表示无返回值方法
        // 通过在()中指定有效参数
        static void SayHi(string name,int age)
        {
            Console.WriteLine("Hi " + name + " and you are age : " + age);
        }
    }
}
