using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Models
{
    class ChickenBurger : Burger
    {
        public override string Name => "ChickenBurger";

        public override float Price => 2.50f;
    }
}
