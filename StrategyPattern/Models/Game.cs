using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Models
{
    public class Game : Product
    {
        public Game(int price) 
        {
            this.Price = price;
        }
    }
}
