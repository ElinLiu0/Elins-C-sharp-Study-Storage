using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18___Building_An_Exponent_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(GetPow(4,3));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not do the math Expression cause by {0}", ex);
                Console.ReadLine();
            }
            
        }
        static int GetPow(int baseNum,int PowNum)
        {
            int result = 1;

            for (int i = 0;i < PowNum;i++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}
