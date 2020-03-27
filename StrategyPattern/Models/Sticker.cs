using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Models
{
    class Sticker : Product
    {
        public Sticker(int price)
        {
            this.Price = price;
        }
    }
}
