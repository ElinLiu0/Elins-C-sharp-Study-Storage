using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24___Static_Method_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday","Green Day",200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);

            Console.ReadLine();
        }
    }
}
