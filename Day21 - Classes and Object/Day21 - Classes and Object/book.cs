using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21___Classes_and_Object
{
    public class book
    {
        // constructor的概念类似Python类中的初始化，即属性定义和内部方法定义的self
        public string Title;
        public string Author;
        public int pages;

        public book(string name)
        {
            Console.WriteLine("Creating Book {0} now...",name);
            Title = name;
            Console.WriteLine("Generate Process Finish");
        }
    }
}
