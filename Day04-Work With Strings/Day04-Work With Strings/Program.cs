using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_Work_With_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // \n换行符
            Console.WriteLine("Hello\nWorld");
            // 包含引号输出
            Console.WriteLine("What is \"means\" meaning?");
            // 直接输出变量对象
            string words = "This is a string object variable";
            Console.WriteLine(words);
            // 合并输出
            Console.WriteLine("Hey"+"you!");
            // 使用.Length属性获取目标字符串（数组或其他对象的长度）
            Console.WriteLine("The variable words length is "+words.Length);
            // 使用.ToUpper()或.ToLower()方法可以使目标字符串变成全大写或者全小写
            Console.WriteLine(words.ToUpper());
            Console.WriteLine(words.ToLower());
            // 使用contains方法可以检测源字符串中是否包含目标值，并返回布尔值结果
            Console.WriteLine(words.Contains("variable"));
            // 使用.Count()方法获取其数量，但是对与List对象而言.Count()的获取速度相较于.Length更快
            Console.WriteLine(words.Count());
            // 可以使用[]对字符串进行切片
            Console.WriteLine(words[0]);
            // 使用.IndexOf()获取目标对象在源字符串中的索引位置
            Console.WriteLine(words.IndexOf("This"));
            /* 使用.Substring()对源字符串进行截取，以指定字符所在的位置或指定位置向后输出指定长度的内容，
             * 当输出长度参数未被指定时，将以索引位向后指定长度的内容进行全部输出，反之将全部输出 */
            Console.WriteLine(words.Substring(words.IndexOf("object"),3));
            Console.ReadLine();
        }
    }
}
