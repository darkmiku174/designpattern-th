using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Driver
    {
        private int age;

        public int Age { get => age; set => age = value; }

        public Driver (int age)
        {
            Age = age;
        }
    }
}
