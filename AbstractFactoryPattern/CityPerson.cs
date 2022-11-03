using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class CityPerson : IPerson
    {
        public string GetName()
        {
            return "City Person";
        }

    }
}
