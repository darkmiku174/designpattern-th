using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    abstract class Vegetable
    {
        private double weight;
        private int quantity;
        private int price;
        private string status;

        public abstract void print();
        public abstract double harvest();
        public abstract double total(ITax strategy);
        
        public virtual void infor(ITax strategy)
        {
            print();
            Console.WriteLine("Tong khoi luong thu hoach: " + harvest());
            Console.WriteLine("Gia tong cong: " + total(strategy));
        }
    }
}
