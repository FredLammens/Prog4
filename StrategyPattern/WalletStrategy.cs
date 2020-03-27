using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class WalletStrategy : IPaymentStrategy
    {
        public WalletStrategy()
        {
        }
        public void Pay()
        {
            Console.WriteLine("paid using In-Game Wallet.");
        }
    }
}
