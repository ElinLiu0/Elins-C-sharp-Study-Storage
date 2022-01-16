using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22___Object_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            students student1 = new students("Jim", "Bussiness", 2.6);
            students student2 = new students("Pam", "Art", 3.6);
            Console.WriteLine(student1.isGoodStudent());
            Console.ReadLine();
        }
    }
}
