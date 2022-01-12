using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19___2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] numGrid = {
                {1,2},
                {3,4},
                {5,6},
            };
            int[,] myArray = new int[2,3];
            Console.WriteLine(myArray.Length);
            // myArray.Length = 2 * 3 = 6
            Console.WriteLine(numGrid[1,1]);

            Console.ReadLine();
        }
    }
}
