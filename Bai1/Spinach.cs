using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Spinach :Vegetable
    {
        private double weight = 14.01;
        private int quantity = 6;
        private int price = 1260;
        private string status = "droopy";

        public double Weight { get => weight; set => weight = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public string Status { get => status; set => status = value; }

        public override void print()
        {
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Status: " + Status);
        }
        public override double harvest()
        {
            return Weight * Quantity;
        }

        public override double total(ITax strategy)
        {
            return Weight * Quantity * Price * strategy.GetTax();
        }
    }
}
