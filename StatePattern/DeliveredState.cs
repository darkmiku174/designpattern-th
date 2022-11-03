using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class DeliveredState : IPackageState
    {
        public void next(Package pkg)
        {
            pkg.State = new ReceivedState();
        }
        public void prev(Package pkg)
        {
            pkg.State = new OrderedState();
        }
        public void printStatus()
        {
            Console.WriteLine("Package delivered to post office, not received yet.");
        }
    }
}
