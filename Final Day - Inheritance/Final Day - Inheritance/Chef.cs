using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Day___Inheritance
{
    public class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chicken makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef make salad");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
