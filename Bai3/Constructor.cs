using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Constructor : Worker
    {
        private string name;
        private long wkId;
        private int workingDay;
        private int salaryPerDay;
        private double baseSalary;
        public Constructor(long wkId, string name, int workingDay, int salaryPerDay, int baseSalary)
        {
            this.wkId = wkId;
            this.name = name;
            this.workingDay = workingDay;
            this.salaryPerDay = salaryPerDay;
            this.baseSalary = baseSalary;
        }

        public void showDetails()
        {
            Console.WriteLine(wkId + " " + name + " " + workingDay + " " + salaryPerDay + " " + baseSalary);
        }
    }
}
