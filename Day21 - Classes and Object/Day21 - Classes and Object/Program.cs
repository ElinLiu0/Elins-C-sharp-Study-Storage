using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21___Classes_and_Object
{
    // internal关键字是类型和类型成员的访问修饰符。只有在同一个程序集的文件中，内部类型或者是成员才可以访问
    // 当class前的修饰为public时，则可被外部cs源文件进行调用
    internal class Program
    {
        static void Main(string[] args)
        {

            book book1= new book("Harry Porter");
            book1.Author = "J.K.Rowling";
            book1.pages = 128;
            Console.WriteLine(book1);
            Console.WriteLine("The Information of {0} are list :\nPages : {1}\nAuthor by : {2}",book1.Title,book1.pages,book1.Author);
            Console.ReadLine();
        }
    }
}
