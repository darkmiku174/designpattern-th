using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class ReceivedState : IPackageState
    {
        public void next(Package pkg)
        {
            Console.WriteLine("This package is already received by a client.");
        }

        public void prev(Package pkg)
        {
            pkg.State = new DeliveredState();
        }
        public void printStatus()
        {
            Console.WriteLine("Done");
        }
    }
}
