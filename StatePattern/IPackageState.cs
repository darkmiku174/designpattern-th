using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    interface IPackageState
    {
        void next(Package pkg);
        void prev(Package pkg);
        void printStatus();
    }
}
