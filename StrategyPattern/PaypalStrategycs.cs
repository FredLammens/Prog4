using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class PaypalStrategycs : IPaymentStrategy
    {
        public PaypalStrategycs()
        {
        }
        public void Pay()
        {
            Console.WriteLine("paid using Paypal.");
        }
    }
}
