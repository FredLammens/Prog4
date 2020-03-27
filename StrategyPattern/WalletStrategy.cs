using StrategyPattern.Interfaces;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class WalletStrategy : IPaymentStrategy,IBudget
    {
        decimal budget;
        public WalletStrategy(decimal budget)
        {
            this.budget = budget;
        }

        public decimal GetBudget()
        {
            return budget;
        }

        public void Pay(Product product)
        {
            if(product.GetPrice() >= GetBudget() )
            Console.WriteLine("paid using In-Game Wallet.");
            else
                Console.WriteLine("Budget is niet genoeg voor deze product te kunnen kopen.");
        }
    }
}
