using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23___Getter_and_Setter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            movie avengers = new movie("The Aveners","Joss Whedon","adasjd");
            movie shrek = new movie("Shrek","Adam Adams","PG");
            // 常见电影评级：G,PG,PG-13,R,NR
            Console.WriteLine(avengers.rating);
            Console.ReadLine();
        }
    }
}
