using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Day___Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeSpecialDish();
            Italian Italian = new Italian();
            Italian.MakeSpecialDish();
            Console.ReadLine();
        }
    }
}
