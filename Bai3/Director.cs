using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Director :Worker
    {
        private string name;
        private long wkId;
        private int workingDay;
        private int salaryPerDay;
        private double bonus; // từ 0 đến 1

        public Director(long wkId, string name, int workingDay, int salaryPerDay, double bonus)
        {
            this.wkId = wkId;
            this.name = name;
            this.workingDay = workingDay;
            this.salaryPerDay = salaryPerDay;
            this.bonus = bonus;
        }
        public void showDetails()
        {
            Console.WriteLine(wkId + " " + name + " " + workingDay + " " + salaryPerDay + " " + bonus);
        }
    }
}
