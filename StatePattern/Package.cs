using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Package
    {
        private IPackageState state;

        public IPackageState State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State: " + state.GetType().Name);
            }
        }

        public Package(IPackageState pkg)
        {
            State = pkg;
        }


        public void previousState()
        {
            state.prev(this);
        }
        public void nextState()
        {
            state.next(this);
        }
        public void printStatus()
        {
            state.printStatus();
        }
    }
}
