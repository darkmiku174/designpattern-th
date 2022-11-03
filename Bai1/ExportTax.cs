using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class ExportTax : ITax
    {
        public double GetTax()
        {
            return 1.05;
        }
    }
}
