using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonAPrototypePattern
{
    public abstract class Prototype
    {
        // normal implementation
        public abstract Prototype Clone();
    }
}
