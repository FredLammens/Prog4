using StrategyPattern.Interfaces;
using StrategyPattern.Models;
using System;

namespace StrategyPattern
{
    class WalletStrategy : IPaymentStrategy
    {
        public decimal budget { get; private set; }
        public WalletStrategy(decimal budget)
        {
            this.budget = budget;
        }

        public bool Pay(Product product)
        {
            if (product.GetPrice() >= budget)
            {
                budget -= product.GetPrice();
                Console.WriteLine("paid using In-Game Wallet.");
                return true;
            }
            else
            {
                Console.WriteLine("Budget is niet genoeg voor deze product te kunnen kopen.");
                return false;
            }
        }

        public bool Pay(int totaalprijs)
        {
            if (totaalprijs >= budget)
            {
                budget -= totaalprijs;
                Console.WriteLine("paid using In-Game Wallet.");
                return true;
            }
            else
            {
                Console.WriteLine("Budget is niet genoeg voor deze product te kunnen kopen.");
                return false;
            }

        }

        public decimal GetBudget()
        {
            return budget;
        }
    }
}
