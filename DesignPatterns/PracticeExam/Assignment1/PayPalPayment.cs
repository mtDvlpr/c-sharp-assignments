﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class PayPalPayment : Payment
    {
        protected override void ProcessPayment()
        {
            Console.WriteLine("Processing CreditCard payment...");
        }
    }
}
