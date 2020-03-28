using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Models
{
    public class Cola : Drink
    {
        public override string Name => "Coca Cola";

        public override float Price => 1.50f;
    }
}
