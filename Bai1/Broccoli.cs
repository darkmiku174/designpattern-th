﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Mangon : Vegetable
    {
        private double weight = 6.7;
        private int quantity = 2;
        private int price = 3500;
        private string status = "fresh";

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
