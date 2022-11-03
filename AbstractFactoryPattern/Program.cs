using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            Factory f = new Factory();
            IPerson p1 = f.GetPerson(PersonType.Rural);
            Console.WriteLine(p1.GetName());
            IPerson p2 = f.GetPerson(PersonType.Urban);
            Console.WriteLine(p2.GetName());

        }
    }
}
