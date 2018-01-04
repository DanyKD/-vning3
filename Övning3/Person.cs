using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    class Person
    {
        private string fName="";
        private string lName="";
        private double height;
        private double weight;
        private  int age;
        public string FirstName
        {
            get{ return fName; }
            set{ fName = value; }
        }
        public string LasName
        {
            get{return lName;}
            set{lName = value;}
        }
        public double Height
        {
            get{return height;}
            set{height = value;}
        }
        public double Weight
        {
            get{return weight;}
            set{weight = value;}
        }
        public int Age
        {
            get{return age;}
            set{age=value;}
        }
       
    }
}
