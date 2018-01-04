using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            if (age > 0)
            {
                pers.Age = age;
            }
            else
            {
                Console.WriteLine("You didn't enter a number");
            }

        }
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person Pers = new Person();            
            bool check = ValidateName(fname, lname);
            if (check == true)
            {
                Pers.FirstName = fname;
                Pers.LasName = lname;
            }
            else
            {
                Console.WriteLine("You didn't enter a correct name");
            }

            check = ValidateNumber(weight, height);
            if (check == true)
            {
                Pers.Height = height;
                Pers.Weight = weight;
            }
            else
            {
                Console.WriteLine("You entered negative value!");
            }           
            SetAge(Pers, age);
            return Pers;
        }
        public bool ValidateName(string Fname,String Lname)
        {
            if (Fname !="" && Lname !="" )
            {
                return true;
            }
            return false;
        }
        public bool ValidateNumber(double weight,double height)
        {
            if (weight > 0 && height >0)
            {
                return true;
            }
            return false;
        }
        public void PrintPerson(Person Pers)
        {
            if (ValidateName(Pers.FirstName,Pers.LasName) && ValidateNumber(Pers.Weight, Pers.Height))
            {
                Console.WriteLine("Fullname is : " + Pers.FirstName + " " + Pers.LasName);
                Console.WriteLine("His weight is: " + Pers.Weight);
                Console.WriteLine("His Length is " + Pers.Height);
                Console.WriteLine("His Age is : " + Pers.Age);
            }
            else
            {
                Console.WriteLine(" You entered wrong Values!");
            }
        }
         
    }
         
}
