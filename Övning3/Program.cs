using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Pers = new Person();
            PersonHandler Per = new PersonHandler();       
            Pers = Per.CreatePerson(40, "Dany", "Kassdaoud", 182, 78);
            Per.PrintPerson(Pers);
        }
    }
}
