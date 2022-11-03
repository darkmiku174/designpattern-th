﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class HappyHourStrategy : IBillingStrategy
    {
        public double GetActPrice(double rawPrice) => rawPrice * 0.5;
    }
}
