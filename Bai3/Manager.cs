using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Manager : Worker
    {
        private string name;
        private long wkId;
        private int workingDay;
        private int salaryPerDay;

        public Manager(long wkId, string name, int workingDay, int salaryPerDay)
        {
            this.wkId = wkId;
            this.name = name;
            this.workingDay = workingDay;
            this.salaryPerDay = salaryPerDay;
        }

        public void showDetails()
        {
            Console.WriteLine(wkId + " " + name + " " + workingDay + " " + salaryPerDay);
        }
    }
}
