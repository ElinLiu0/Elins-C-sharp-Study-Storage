using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22___Object_Methods
{
    public class students
    {
        public string name;
        public string major;
        public double gpa;
        public students(string aName,string aMajor,double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }
        public bool isGoodStudent()
        {
            if(gpa >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
