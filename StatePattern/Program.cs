using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pkg = new Package(new OrderedState());
            pkg.printStatus();

            pkg.nextState();
            pkg.printStatus();

            pkg.nextState();
            pkg.printStatus();

            pkg.nextState();
        }
    }
}
