using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class OrderedState : IPackageState
    {
        public void next(Package pkg)
        {
            pkg.State = new DeliveredState();
        }
        public void prev(Package pkg)
        {
            Console.WriteLine("The package is in its root state.");
        }
        public void printStatus()
        {
            Console.WriteLine("Package ordered, not delivered to the office yet.");
        }
    }
}
